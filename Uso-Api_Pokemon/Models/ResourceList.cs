using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uso_Api_Pokemon.Models
{
    public class ResourceList
    {
        public int Count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<PokemonInfo> result { get; set; }

    }
}
