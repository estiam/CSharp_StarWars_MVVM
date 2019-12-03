using Newtonsoft.Json;
using StarWarsWPFMvvm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsWPFMvvm.DAL
{
    public static class StarWarsAPIDAL
    {
        const string LOADALL_URL = "https://swapi.co/api/people/?limit=100";
        //Chercher la donnée
        public static async Task<List<Character>> LoadCharacters()
        {
            WebClient wc = new WebClient();
            byte[] data = await wc.DownloadDataTaskAsync(new Uri(LOADALL_URL));
            string json = Encoding.UTF8.GetString(data);
            CharacterAPIResult result = JsonConvert.DeserializeObject<CharacterAPIResult>(json);

            return result.Results;
;        }
    }
}
