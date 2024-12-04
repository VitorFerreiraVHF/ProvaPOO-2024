using System;

class CalcularIdade
{
    static void Main()
    {
        Console.Write("Digite sua idade em dias: ");
        int idadeEmDias = int.Parse(Console.ReadLine());
        int anos = idadeEmDias / 365;
        idadeEmDias %= 365;
        int meses = idadeEmDias / 30;
        idadeEmDias %= 30;
        int dias = idadeEmDias;
        Console.WriteLine($"Você tem {anos} anos, {meses} meses e {dias} dias.");
    }
}