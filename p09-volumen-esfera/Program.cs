//Programa que calcula el volumen de una esfera
double r = 0, v = 0, pi = 3.1416;  
Console.WriteLine("Dame el radio de la esfera: ");
r = double.Parse(Console.ReadLine());
v = Math.Pow(r,3) * pi * 4 / 3;
Console.WriteLine($"El volumen de la esfera es: {v:f2}");