// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

int idade = 24; // valor inteiro sem casas decimais, pode assubir 2 bilhoes
string name = "lincoln";  //cadeia de caracters
bool maioridade = true; //valor booleano
double idade2 = 24.2D; //valor numerico flutuante + utilizado
float idade3 = 20.2F;
decimal salario = 20.5M; //valor decimal geralmente usado para valores monetários

DateTime dataAtual = DateTime.Now.AddDays(5);

Console.WriteLine(dataAtual);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

Console.WriteLine(idade);
Console.WriteLine(name);
Console.WriteLine(maioridade);
Console.WriteLine(idade2);
Console.WriteLine(idade3);
Console.WriteLine(salario);

double altura = 1.80;

Console.WriteLine(altura.ToString("0.00")); //mexendo na casa decimal

