using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using AppConselho.Model;

namespace AppConselho.Services
{
     public class DataService
    {
        //public
        public static async Task<Conselho> GetConselho()
        {

            string queryString = "https://api.adviceslip.com/advice";            

            dynamic resultado = await getDataFromService(queryString).ConfigureAwait(false);

            Console.WriteLine(resultado);



            if (resultado["slip"] != null)
            {
                Conselho aaa = new Conselho();

                aaa.Id = (string)resultado["slip"]["id"];
                aaa.Mensagem = (string)resultado["slip"]["advice"];

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
