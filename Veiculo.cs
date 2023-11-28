using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace PraticaSala
{
    public class Veiculo
    {
        public int Ano { get; set;}
        public string Modelo { get; set;}
        public string Cor { get; set;}
        public int IdadeVeiculo => (DateTime.Now.Year) - Ano;

    }
}