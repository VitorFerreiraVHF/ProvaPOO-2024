using System;

class IdentificaAnimal
{
    static void Main()
    {
        Console.Write("Seu Animal é vertebrado? (sim/não): ");
        string vertebrado = Console.ReadLine().ToLower();
        Console.Write("Se sim, é ave ou mamífero? (ave/mamifero): ");
        string classe = Console.ReadLine().ToLower();
        Console.Write("Qual o tipo de dieta dele? (carnivoro/onivoro/herbivoro/hematofago): ");
        string dieta = Console.ReadLine().ToLower();
        string animal = "";
        if (vertebrado == "sim")
        {
            if (classe == "ave")
            {
                animal = dieta == "carnivoro" ? "águia" : "pombo";
            }
            else if (classe == "mamifero")
            {
                animal = dieta == "onivoro" ? "homem" : "vaca";
            }
        }
        else
        {
            if (classe == "inseto")
            {
                animal = dieta == "hematofago" ? "pulga" : "lagarta";
            }
            else if (classe == "anelideo")
            {
                animal = dieta == "hematofago" ? "sanguessuga" : "minhoca";
            }
        }
        Console.WriteLine($"O animal seria: {animal}");
    }
}