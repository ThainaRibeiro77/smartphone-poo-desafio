using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smartphone_poo_desafio.models
{
    public abstract class Smartphone
    {
        public string Numero {get; set;}
        private string Modelo {get; set;}
        private string IMEI {get; set;}
        private string Memoria {get; set;}
        public Smartphone (string numero, string modelo, string imei, string memoria)
        {
            this.Numero = numero;
            this.Modelo = modelo;
            this.IMEI = imei;
            this.Memoria = memoria;
        }
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }
        public abstract void InstalarApp(string nomeApp);
        
    }
}