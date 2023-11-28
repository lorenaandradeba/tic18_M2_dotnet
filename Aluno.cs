using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraticaSala
{
    public class Aluno
    {
        public Aluno() 
        {
            this.Nome = "";
            this.Idade = 0;
        }
        public string Nome { get; set;}
        public int Idade { get;  set;}
     
    }
}