using System;

class CalcularDias
{
    static void Main()
    {
        Console.Write("Primeira data (dd/MM/yyyy): ");
        string data1String = Console.ReadLine();
        Console.Write("Segunda data (dd/MM/yyyy): ");
        string data2String = Console.ReadLine();
        DateTime data1 = DateTime.ParseExact(data1String, "dd/MM/yyyy", null);
        DateTime data2 = DateTime.ParseExact(data2String, "dd/MM/yyyy", null);
        TimeSpan diferenca = data2 - data1;
        int dias = diferenca.Days;
        Console.WriteLine($"A diferença entre as datas é de {dias} dias.");
    }
}