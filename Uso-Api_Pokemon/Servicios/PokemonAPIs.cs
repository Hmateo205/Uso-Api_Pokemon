using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uso_Api_Pokemon.Models;

namespace Uso_Api_Pokemon.Servicios
{
    public class PokemonAPIs
    {
        public HttpClient _httpClient;
        public PokemonAPIs() 
        {
            _httpClient = new HttpClient();
        }
        public async Task< List<PokemonInfo>> DevuelveListadoPokemones()
        {
            string url = "https://pokeapi.co/api/v2/ability/?limit=40&offset=0";
            string json = await _httpClient.GetStringAsync(url);

            ResourceList Resourcelist_pokemon = JsonConvert.DeserializeObject<ResourceList>(json); 
            return Resourcelist_pokemon.result;
        }
    }
}
