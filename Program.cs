using Newtonsoft.Json;
using System;

namespace Polimorfismo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Carro carro = new Carro();
            carro.Ano = 2019;
            carro.Modelo = "Passat";
            carro.Cor = "Branca";
            carro.Km = 100000;
            carro.CapacidadePassageiro = 5;
            carro.Revisao();
            Console.WriteLine(JsonConvert.SerializeObject(carro));
            Console.WriteLine($"Revisão de Número :{carro.CalcularNumeroRevisao(carro.Km)}");
            Console.WriteLine("-------------------------------------------------------");

            Caminhao caminhao = new Caminhao();
            caminhao.Ano = 2000;
            caminhao.Modelo = "Mercedez";
            caminhao.Cor = "Azul";
            caminhao.Km = 170000;
            caminhao.CapacidadeCarga = 10;
            caminhao.Revisao();
            Console.WriteLine(JsonConvert.SerializeObject(caminhao));
            Console.WriteLine($"Revisão de Número :{caminhao.CalcularNumeroRevisao(carro.Km)}");
            Console.WriteLine("-------------------------------------------------------");

            Bicicleta bicicleta = new Bicicleta();
            bicicleta.Ano = 2019;
            bicicleta.Modelo = "Caloi";
            bicicleta.Cor = "Branca";
            Console.WriteLine(JsonConvert.SerializeObject(bicicleta));
            Console.WriteLine("-------------------------------------------------------");
        }
    }

    /*
     Classe BASE Abstract(Não podem ser instanciadas), permite que você crie classes e membros de classe que estão incompletos e 
    ***********************devem ser implementados em uma classe derivada**************************
    * Neste caso, temos as propriedades (ano,cor, km e modelo) que as classes derivadas vão herdar 
    * e os métodos Revisao('Não obrigatório implementar') e CalcularNumeroRevisao(É obrigatório implementar)
    * 
    *///
    public abstract class VeiculoBase 
    { 
        public int Ano { get; set; }
        public string Cor { get; set; }
        public string Modelo { get; set; }
        public int Km { get; set; }

        //Metodo vitual que pode ser substituído dentro das classes derivadas.
        public virtual void Revisao() 
        {
            Console.WriteLine("Veiculo Não faz Revisão");            
        }

        //Metodo abstract de implementação obrigatório dentro das classes derivadas.
        public abstract int CalcularNumeroRevisao(int i);
    }

    /*
     * Classe DERIVADA, herda todos os métodos e propriedades a classe base. 
     * Pode alterar o comportamento de métodos virtuais, e devem implementar comportamento para os métodos abstract.
     * Classe SEALED ninguém poderá derivar dela.
    */
    public sealed class Carro : VeiculoBase
    {
        public int CapacidadePassageiro { get; set; }
        
        /*Substituindo o metodo da classe BASE*/

        public override void Revisao()
        {
            Console.WriteLine("Carro faz Revisão");
        }

        public override int CalcularNumeroRevisao(int i)
        {
            return i / 10000;
        }
    }

    /*
     * Classe DERIVADA, herda todos os métodos e propriedades a classe base. 
     * Pode alterar o comportamento de métodos virtuais, e devem implementar comportamento para os métodos abstract.
     * classe SEALED ninguém poderá derivar dela.
    */
    public sealed class Caminhao : VeiculoBase 
    { 
        public int CapacidadeCarga { get; set; }

        /*Substituindo o metodo da classe BASE*/
        public override void Revisao()
        {
            Console.WriteLine("Caminhao faz Revisão");
        }

        /**/
        public override int CalcularNumeroRevisao(int i)
        {
            return i / 15000;
        }
    }

    /*
     * Classe DERIVADA, herda todos os métodos e propriedades a classe base. 
     * Pode alterar o comportamento de métodos virtuais, e devem implementar comportamento para os métodos abstract.
     * classe SEALED ninguém poderá derivar dela.
    */
    public sealed class Bicicleta : VeiculoBase
    {
        public override int CalcularNumeroRevisao(int i)
        {
            throw new NotImplementedException();
        }
    }
}
