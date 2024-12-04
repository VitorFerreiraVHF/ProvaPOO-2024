using System;

class ContadorPalavras
{
    static void Main()
    {
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();
        string[] palavras = frase.Split(' ');
        int numeroDePalavras = palavras.Length;
        Console.WriteLine($"A frase possui {numeroDePalavras} palavras.");
    }
}