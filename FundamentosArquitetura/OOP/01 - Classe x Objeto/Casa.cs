using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP._01___Classe_x_Objeto
{
    public class Casa
    {
        //Definição de Classe: Mapeia um objeto do mundo real, possuindo propriedades
        public int TamanhoM2 { get; set; }
        public int Andares { get; set; }
        public decimal Valor { get; set; }
        public int NumeroVagas { get; set; }
    }

    public class Objeto
    {
        //Definição de Objeto: Classe sendo instanciada, representada na memória como um Objeto. Possui valores.
        public Objeto()
        {
            _ = new Casa
            {
                TamanhoM2 = 100,
                Andares = 2,
                Valor = 100000,
                NumeroVagas = 3
            };
        }
    }
}