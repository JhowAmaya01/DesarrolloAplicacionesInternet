// Programa que mide la distancia de dos puntos
double ax = 0.0, ay = 0.0, bx = 0.0, by = 0.0, d = 0.0;
Console.WriteLine("Dame las coordenadas del primer punto separadas por un salto de linea: ");
ax = double.Parse(Console.ReadLine());
ay = double.Parse(Console.ReadLine());
Console.WriteLine("Dame las coordenadas del segundo punto separadas por un salto de linea: ");
bx = double.Parse(Console.ReadLine());
by = double.Parse(Console.ReadLine());
d = Math.Sqrt(Math.Pow(ax-bx,2) + Math.Pow(ay-by,2));

Console.WriteLine("Las coordenadas son:");
Console.WriteLine($"a: {ax:f2},{ay:f2}\nb: {bx:f2},{by:f2}");
Console.WriteLine("La distancia entre estos puntos es: ");
Console.WriteLine($"{d:f2}");



