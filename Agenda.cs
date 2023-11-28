using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraticaSala
{
    public class Agenda
    {
        List<Contato> contatos = new List<Contato>();
        public void AdicionarContato(Contato contato){
            foreach (var c in contatos)
            {
                if (c.CPF == contato.CPF)
                {
                   throw  new ArgumentException("Já existe um CPF na base de dados.");
                }
            }
            ]contatos.Add(contato);
        }
    }
    public class Contato{
        public string Nome { get; set; }
        public string CPF { get; set;}
    } 
}