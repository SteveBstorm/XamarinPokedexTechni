using System;
using System.Collections.Generic;
using System.Text;

namespace PokedexDal.Models
{
    public class Pokedex
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public IEnumerable<Result> Results { get; set; }
    }

    public class Result
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class Pokemon {
        public string Name { get; set; }
        public string Height { get; set; }
        public Sprites Sprites{ get; set; }
    }

    public class Sprites
    {
        public string Front_default { get; set; }
        public string Back_default { get; set; }
    }
}
