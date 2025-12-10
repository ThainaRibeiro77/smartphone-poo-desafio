using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smartphone_poo_desafio.models
{
    public class Iphone : Smartphone
    {
       public Iphone (string numeroIphone, string modeloIphone, string imeiIphone, string memoriaIphone) 
       : base (numeroIphone, modeloIphone, imeiIphone, memoriaIphone)
        {}
        public override void InstalarApp(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp}...");
        }
    }
}