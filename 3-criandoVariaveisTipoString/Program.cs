using System;

class Programa
{
    static void Main(string[] args)
    {
        char letra = 'a';
        char letra2 = 'b';
        char letra3 = (char)99;

        Console.WriteLine(letra);
        Console.WriteLine(letra2);
        Console.WriteLine(letra3);

        string nome = "jonas ";
        string nomeDoMeio = "ramos ";
        string juncao = "do ";
        string ultimoNome = "santos";
        
        Console.WriteLine();
        Console.WriteLine(nome + nomeDoMeio + juncao + ultimoNome);

        string nomeCompletoPulaLinha = @"jonas
ramos
dos
santos";
        Console.WriteLine();
        Console.WriteLine(nomeCompletoPulaLinha);
    }
}