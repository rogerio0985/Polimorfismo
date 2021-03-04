# Polimorfismo
Utilizando recurso da POO, Polimorfismo e Herança. Classe abstract com métodos abstract e virtual, e classe Derivada sealed sobrescrevendo o método virtual e o abstract.
Polimorfismo e Herança, com classe abstract e metodos abstract e virtual

Neste cenário, temos:
-Classe BASE(abstract) porque não pode ser instanciada, permite que você crie métodos que estão incompletos e devem ser implementados em uma classe derivada.
-As propriedades (ano,cor, km e modelo) que as classes derivadas vão herdar e os métodos virtual "Revisao" porque não obrigatório implementar, e abstract "CalcularNumeroRevisao" porque é obrigatório implementar.

/*Nosso clase base(VeiculoBase), com as propriedades e os metodos virtual e abstract*/
public abstract class VeiculoBase 
{ 
   public int Ano { get; set; }
   public string Cor { get; set; }
   public string Modelo { get; set; }
   public int Km { get; set; }

   public virtual void Revisao() 
   {
      Console.WriteLine("Veiculo Não faz Revisão");            
   }

   public abstract int CalcularNumeroRevisao(int i);
}

/*Nossa clase derivada(Carro), herda todos os métodos e propriedades a classe BASE(VeiculoBase) e pode alterar o comportamento de métodos virtuais, e deve implementar os comportamentos para os métodos abstract.
Classe SEALED ninguém poderá derivar dela.*/
public sealed class Carro : VeiculoBase
{
   public int CapacidadePassageiro { get; set; }
        
   public override void Revisao()
   {
       Console.WriteLine("Carro faz Revisão");
   }

   public override int CalcularNumeroRevisao(int i)
   {
       return i / 10000;
   }
}

/*Nossa clase derivada(Caminhao), herda todos os métodos e propriedades a classe BASE(VeiculoBase) e pode alterar o comportamento de métodos virtuais, e deve implementar os comportamentos para os métodos abstract.
Classe SEALED ninguém poderá derivar dela.*/
public sealed class Caminhao : VeiculoBase 
{ 
    public int CapacidadeCarga { get; set; }

    public override void Revisao()
    {
       Console.WriteLine("Caminhao faz Revisão");
    }

    public override int CalcularNumeroRevisao(int i)
    {
       return i / 15000;
    }
}

/*Nossa clase derivada(Bicicleta), herda todos os métodos e propriedades a classe BASE(VeiculoBase) e pode alterar o comportamento de métodos virtuais, e deve implementar os comportamentos para os métodos abstract.
Classe SEALED ninguém poderá derivar dela.*/
public sealed class Bicicleta : VeiculoBase
{
    public override int CalcularNumeroRevisao(int i)
    {
       throw new NotImplementedException();
    }
}
