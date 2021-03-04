# Polimorfismo e Herança
Utilizando recurso da POO, Polimorfismo e Herança com classe abstract e métodos (abstract e virtual), e classe Derivada sealed sobrescrevendo o método virtual e o abstract.

Neste cenário, temos:
1-Classe BASE (abstract class VeiculoBase) que não pode ser instanciada com suas propriedades(Ano,Cor,Modelo,Km) e o metodo "virtual void Revisao()" que as classes derivadas podem alterar o comportamento e metodo "abstract int CalcularNumeroRevisao(int i)" que as classes derivadas devem alterar o comportamento. 

2-Classe DERIVADA (sealed class Carro : VeiculoBase), que herda todos os métodos e propriedades a classe BASE(VeiculoBase) e altera o comportamento de método virtual, e também altera o comportamento do método abstract, e ninguém poderá derivar dela.

3-Classe DERIVADA (sealed class Caminhao : VeiculoBase), que herda todos os métodos e propriedades a classe BASE(VeiculoBase) e altera o comportamento de método virtual, e também altera o comportamento do método abstract, e ninguém poderá derivar dela.

4-Classe DERIVADA (sealed class Bicicleta : VeiculoBase), que herda todos os métodos e propriedades a classe BASE(VeiculoBase) e não altera o comportamento de método virtual, e também altera o comportamento do método abstract, e ninguém poderá derivar dela.
