using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace koniaE1
{
    public class listaNomes
    {
        public string? Nome { get; set; }
        public int? Id { get; set;}

        public listaNomes()
        { }

        public listaNomes(int id, string nomes)
        {
            Id = id;
            Nome = nomes;
        }
    }
}