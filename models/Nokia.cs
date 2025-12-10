using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smartphone_poo_desafio.models
{
    public class Nokia : Smartphone
    {
        public Nokia (string numeroNokia, string modeloNokia, string imeiNokia, string memoriaNokia) 
       : base (numeroNokia, modeloNokia, imeiNokia, memoriaNokia){}
       public override void InstalarApp(string nomeApp)
        {
            Console.WriteLine($"Estamos instalando o aplicativo {nomeApp}... Aguarde :)");
        }
    }
}