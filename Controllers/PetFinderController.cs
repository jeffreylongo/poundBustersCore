using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using http = System.Net.Http;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace poundBustersCoreV1.Controllers
{
    public class PetFinderController : Controller
    {
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

            var token = string.Empty;
            using (var httpClient = new http.HttpClient())
            {
                //httpClient.DefaultRequestHeaders.Authorization = new http.Headers.AuthenticationHeaderValue();
                httpClient.DefaultRequestHeaders.Accept.Add(new http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                http.HttpResponseMessage response = httpClient.PostAsync(petFinderApiUrl, new http.FormUrlEncodedContent(body)).Result;
                if (response != null)
                {
                    Console.WriteLine(response.Content);

                    var stringJwt = response.Content.ReadAsStringAsync().Result;

                    

                    var json = JsonConvert.DeserializeObject<object>(stringJwt);

                    var nextLine = "";

                    //Newtonsoft.Json.JsonObjectAttribute 
                    //JObject json = response.Content.ReadAsAsync<JObject>().Result;

                    //var json = await httpClient.GetStringAsync(petFinderApiUrl+"?"+body);
                }

            }
            return null;
        }


        // GET: /<controller>/
        [HttpGet]
        public async Task<IActionResult> GetPets()
        {
            return View();
        }
    }
}
