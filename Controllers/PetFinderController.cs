using System;
using System.Web;
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

            using (var httpClient = new http.HttpClient())
            {


                //httpClient.DefaultRequestHeaders.Add("Bearer", token);
                httpClient.DefaultRequestHeaders.Authorization = new http.Headers.AuthenticationHeaderValue("Bearer", token);

                var response = httpClient.GetAsync(petFinderSearchURL).Result;
                if (response != null)
                {
                    var jsonString = response.Content.ReadAsStringAsync().Result;

                    var pfr = JsonConvert.DeserializeObject<PetFinderResponse>(jsonString);
                    if (pfr != null)
                    {

                    }
                    //var pets = JsonConvert.DeserializeObject<Pet>(pfr);

                    //var obj = JsonSerializer.Deserialize<PetFinderResponse>(jsonString);
                    

                    
                    return Ok(jsonString);

                }

            }
            return Ok();

        }
    }
}
