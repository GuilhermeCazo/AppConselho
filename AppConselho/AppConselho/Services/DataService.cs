using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using AppConselho.Model;

namespace AppConselho.Services
{
     class DataService
    {
        //public
        public static async Task<Conselho> GetConselho()
        {

            string queryString = "https://api.adviceslip.com/advice";

            Console.WriteLine(queryString);

            dynamic resultado = await getDataFromService(queryString).ConfigureAwait(false);

            Console.WriteLine(resultado);



            if (resultado != null)
            {
                Conselho aaa = new Conselho();

                aaa.Id = (string)resultado["id"];
                aaa.Mensagem = (string)resultado["advice"];

                return aaa;

            } 
            else
            {
                return null;
            }
        }

        
        public static async Task<dynamic> getDataFromService(string queryString)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(queryString);
            dynamic data = null;
            if (response != null)
            {

                string json = response.Content.ReadAsStringAsync().Result;
                data = JsonConvert.DeserializeObject(json);

            }
            return data;
        }
    }
}
