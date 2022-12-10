using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP._02___Pilares_OOP
{
    public class Pessoa
    {
        //Estado: Propriedades da classe. Precisam estar em um Estado, armazenando informações,
        //possuindo um estado definido
        public string Nome { get; set;}
        public DateTime DataNascimento { get; set;}

        //Comportamento: Métodos que geram informação e devolvem outras.
        //Processamento, transformação das informações. Modificam valores
        public int CalcularIdade()
        {
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - DataNascimento.Year;

            if (dataAtual < DataNascimento.AddYears(idade)) idade--;

            return idade;
        }
    }
}
