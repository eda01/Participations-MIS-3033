using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONPokemon
{
    public class PokeAPI
    {
        public string height { get; set; }
        public string weight { get; set; }
        public Image image { get; set; }

    }

    public class Image
    {
        public string front { get; set; }
        public string back { get; set; }

    }
}
