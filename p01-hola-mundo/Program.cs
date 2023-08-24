// Programa que manda saludos a la pantalla
string amigo = "Juan";
string hermano = "Maria";
Console.WriteLine("Hola " + amigo);
Console.WriteLine($"Hola {amigo} bienvenido a C#");
Console.WriteLine($"\nMi amigo es {amigo}, mi hermana es {hermano}");
Console.WriteLine("Nombre en mayusculas:");
Console.WriteLine($"{amigo.ToUpper()} {hermano.ToUpper()}");