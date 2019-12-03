using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsWPFMvvm.Models
{
    public class CharacterAPIResult
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public List<Character> Results { get; set; }
    }
    public class Character
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
