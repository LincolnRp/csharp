<h2>Resumo .NET e Compilação</h2>

```
SDK = Kit de desenvolvimento de software

.NET Framework = .NET legado versão Windows

.NET CORE = .NET atual, multiplataforma (que diz respeito agora somente ao .NET sem a nomenclatura de CORE)

Fluxos da compilação: primeira compilação acontece no seu código C#, com o próprio compilador do C#, é gerado o código intermediário (código universal que não diz respeito a nenhuma máquina em arquitetura em específico), que será outra vez compilado para linguagem de máquina (21 0a 00 00..) por meio do JIT compiler (nesse momento, sendo compilado de uma forma diferente pra cada máquina/arquitetura)

Program.CS = (Program é uma class) programa executável do C#.

csproj = Informações descritivas para o projeto (metadados na linguaguem XML)

obj = arquivos de debug

bin = binários (compilação do código e transformado para código-fonte)
```



<h2>Arquivos</h2>





<h2>Comandos utilizados</h2>

```
dotnet --info: imprimi as informações do .NET instalado.
dotnet new console: o dotnet cria um novo projeto de console.
donet run: compila o executa o programa C#.
dotnet build: faz a build do projeto (saída da compilação do projeto)
```

