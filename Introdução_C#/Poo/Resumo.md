<h1>Programação Orientada a Objetos</h1>



<b>Classe:</b> Representação de um objeto da vida real; (como se fosse a planta de uma casa);

<b>Objeto:</b> É a instância da classe; (a casa de fato);

<b>get:</b> Pega alguma propriedade.;

<b>set:</b> Seta, alguma propriedade.;

<b>namespace:</b> Organização de classe. (caminho até a classe);

<b>@class:</b> O arroba, permite usar palavras reservadas.;



<h2>Comandos</h2>

```
New C# > Class > Pessoa
prop > Criação de propriedade

public class Pessoa { (classe)
	    public string Nome { get; set; } (propriedades)
        public int Idade { get; set; }
        
		public void Apresentar() (metódos)
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");
       
        }
}

```

