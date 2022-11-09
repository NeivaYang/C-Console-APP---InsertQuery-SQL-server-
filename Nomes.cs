using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace koniaE1.services
{
    class Nomes
    {
        public static List<listaNomes> GetlistaNomes()
        {
            var lista = new List<listaNomes>()
            {
                new listaNomes {Id=1,Nome="NOME P1"},
                new listaNomes {Id=2,Nome="NOME P2"},
                new listaNomes {Id=3,Nome="NOME P3"},
                new listaNomes {Id=4,Nome="NOME P4"},
                new listaNomes {Id=5,Nome="NOME P5"},
                new listaNomes {Id=6,Nome="NOME P6"},
                new listaNomes {Id=7,Nome="NOME P7"},
                new listaNomes {Id=8,Nome="NOME P8"},
                new listaNomes {Id=9,Nome="NOME P9"},
                new listaNomes {Id=10,Nome="NOME P10"},
            };
            return lista;
        }
    }
}