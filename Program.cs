﻿using Newtonsoft.Json;
using System;
//using System.Web.Script.Serialization;

namespace Polimorfismo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo();
            veiculo.Revisao();
            Console.WriteLine(JsonConvert.SerializeObject(veiculo));
            Console.WriteLine("-------------------------------------------------------");

            Carro carro = new Carro();
            carro.Ano = 2019;
            carro.Modelo = "Passat";
            carro.Cor = "Branca";
            carro.Km = 100000;
            carro.QuatidadePorta = 5;
            carro.Revisao();
            Console.WriteLine(JsonConvert.SerializeObject(carro));
            Console.WriteLine("-------------------------------------------------------");

            Caminhao caminhao = new Caminhao();
            caminhao.Ano = 2000;
            caminhao.Modelo = "Mercedez";
            caminhao.Cor = "Azul";
            caminhao.Km = 170000;
            caminhao.CapacidadeCarga = 10;
            caminhao.Revisao();
            Console.WriteLine(JsonConvert.SerializeObject(caminhao));
        }
    }

    //Classe BASE, onde todos veiculos possuem (ano,cor e modelo)
    public class Veiculo 
    { 
        public int Ano { get; set; }
        public string Cor { get; set; }
        public string Modelo { get; set; }
        public int Km { get; set; }

        //Metodo vitual que pode ser substituído dentro da classe derivada.
        public virtual void Revisao() 
        {
            Console.WriteLine("Veiculo Não faz Revisão");            
        }
    }

    /*
     * Classe DERIVADA, herda todos os métodos, campos, propriedades e eventos da classe base. 
     * Mas pode alterar o comportamento de métodos virtuais.
    */
    public class Carro : Veiculo
    { 
        public int QuatidadePorta { get; set; }


        /*Substituindo o metodo da classe BASE*/
        public override void Revisao()
        {           
            Console.WriteLine("Carro faz Revisão");
        }
    }

    /*
     * Classe DERIVADA, herda todos os métodos, campos, propriedades e eventos da classe base. 
     * -----------------Mas pode alterar o comportamento de métodos virtuais.-----------------
    */
    public class Caminhao : Veiculo 
    { 
        public int CapacidadeCarga { get; set; }

        /*Substituindo o metodo da classe BASE*/
        public override void Revisao()
        {
            Console.WriteLine("Carro faz Revisão");
        }
    }
}
