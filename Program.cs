// See https://aka.ms/new-console-template for more information
Console.WriteLine("Meu primeiro codigo em csharp!");


Console.Write("Digite o seu nome: ");
string name = Console.ReadLine();
Console.WriteLine("Digite o ano do seu Nascimaneto:");
int year = int.Parse(Console.ReadLine());
int age = 2022 - year;
Console.WriteLine($"você tem {age} anos ");