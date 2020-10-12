using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using poundBustersCoreV1.Models;
using http = System.Net.Http;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace poundBustersCoreV1.Controllers
{
    public class PetFinderController : Controller
    {
        string token = string.Empty;
        string petFinderSearchURL = "https://api.petfinder.com/v2/animals";
        //Token
        [HttpPost]
        public async Task<IActionResult> GetToken()
        {
            var petFinderApiUrl = "https://api.petfinder.com/v2/oauth2/token";
            
            var clientId = "gAR4IK6gN1eUxuzBO4Kw7Cw4VApFAC5XLrKKyjM41yrNUoamCP";
            var clientSecret = "qOVO7iz7SVFTwyh6U2UMUxpeHwHQtfmxXNs0EUrn";
            var grantType = "client_credentials";
            var body = new Dictionary<string, string>();
            body.Add("Content-Type", "application/x-www-form-urlencoded");
            body.Add("grant_type", grantType);
            body.Add("client_id", clientId);
            body.Add("client_secret", clientSecret);

            using (var httpClient = new http.HttpClient())
            {
                //httpClient.DefaultRequestHeaders.Authorization = new http.Headers.AuthenticationHeaderValue();
                httpClient.DefaultRequestHeaders.Accept.Add(new http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                http.HttpResponseMessage response = httpClient.PostAsync(petFinderApiUrl, new http.FormUrlEncodedContent(body)).Result;
                if (response != null)
                {
                    Console.WriteLine(response.Content);

                    var stringJwt = response.Content.ReadAsStringAsync().Result;
                    var obj = JsonConvert.DeserializeObject<Token>(stringJwt);
                    token = obj.access_token;


                    //Newtonsoft.Json.JsonObjectAttribute 
                    //JObject json = response.Content.ReadAsAsync<JObject>().Result;

                    //var json = await httpClient.GetStringAsync(petFinderApiUrl+"?"+body);
                    //await GetPets();
                }

            };
            return null;
        }


        // GET: /<controller>/
        [Route("PetFinderController/GetPets")]
        [HttpGet]
        public async Task<IActionResult> GetPets()
        {


            GetToken();
            //var client = new http.HttpClient();
            //var request = new http.HttpRequestMessage()
            //{
            //    RequestUri = new Uri(petFinderSearchURL),
            //    Method = http.HttpMethod.Get,
            //};


            using (var httpClient = new http.HttpClient())
            {


                //httpClient.DefaultRequestHeaders.Add("Bearer", token);
                httpClient.DefaultRequestHeaders.Authorization = new http.Headers.AuthenticationHeaderValue("Bearer", token);

                var response = httpClient.GetAsync(petFinderSearchURL).Result;
                if (response != null)
                {
                    var jsonString = response.Content.ReadAsStringAsync().Result;
                    //var pfr = JsonConvert.DeserializeObject<PetFinderResponse>(jsonString);

                    return Ok(jsonString);

                    //if (pfr.pagination != null)
                    //{
                    //    var pagination = pfr.pagination;
                    //}
                    //if (pfr.animals != null)
                    //{
                    //    var animals = pfr.animals;
                    //}

                    //var pets = pfo.animals;
                    //var pagination = pfo.pagination;

                    //var pets = JsonConvert.DeserializeObject<Pet>(response);
                }


                //rq.Headers.Add("Authorization", $"Bearer {token}");


                //using (var requestMessage = new http.HttpRequestMessage(http.HttpMethod.Get, petFinderSearchURL))
                //{
                //    requestMessage.Headers.Authorization = new http.Headers.AuthenticationHeaderValue("Bearer", token);
                //    var response = await httpClient.SendAsync(requestMessage);
                //
                //    if (response !=null)
                //    {
                //        var json = response.Content.ReadAsStringAsync().Result;
                //        var pets = JsonConvert.DeserializeObject<Pet>(json);
                //
                //       Console.WriteLine(pets);
                //    }
                //}


                //http.DefaultRequestHeaders = new AuthenticationHeaderValue()

                //var task = httpClient.GetAsync(petFinderSearchURL)
                //.ContinueWith((rq) =>
                //{
                //var response = rq.Result;
                //if (response != null)
                //{
                //var json = response.Content.ReadAsStringAsync().Result;
                //var pets = JsonConvert.DeserializeObject<Pet>(json);
                //}
                //});


                //http.HttpResponseMessage response = await httpClient.GetAsync(petFinderSearchURL);

            }
            return Ok();

        }
    }
}
