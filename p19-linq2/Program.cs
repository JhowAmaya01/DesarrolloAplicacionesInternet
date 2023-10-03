// Programa que...
List<double> calif = new() {9.5, 8.5, 10.0, 7.4, 6.5, 8.2, 9.7, 5.0, 2.0, 0.0, 3.5};
Console.WriteLine("Las calificaciones son: " + calif.Count());
calif.ForEach(cal=>Console.Write(cal+ " "));
//Consulta de aprobados y no aprobados
var apr = calif.Where(cal=> cal>=6.5);
Console.WriteLine("\n\nAprobados: " + apr.Count());
var noapr = from cal in calif where cal<= 6.4 select cal;
Console.WriteLine("No aprobados: "+ noapr.Count());

Console.WriteLine($"La suma es : {calif.Sum():f2}\nElpromedio es: {calif.Average():f2}");
Console.WriteLine($"El mayor es: {calif.Max():f2}\nEl menor es: {calif.Min():f2}");

var mayp = (from cal in calif where cal > calif.Average() select cal).ToList();
Console.WriteLine("\nMayores al promedio son: "+ mayp.Count());
mayp.ForEach(cal=>Console.WriteLine(cal));

var menp = calif.Where(cal=> cal < calif.Average()).ToList();
Console.WriteLine("\nMenores al promedio son: "+ menp.Count());
menp.ForEach(cal=>Console.WriteLine(cal));

//Ordenar de mayor a menor y de menor a mayor
Console.WriteLine("\nOrdenar lista de manera ascendente");
var ord1 = (from cal in calif orderby cal ascending select cal).ToList();
ord1.ForEach(cal=>Console.WriteLine(cal));
Console.WriteLine("\nOrdenar lista de manera descendente");
var ord2 = (from cal in calif orderby cal descending select cal).ToList();
ord2.ForEach(cal=>Console.WriteLine(cal));
Console.WriteLine("\nOrdenar lista de manera ascendente");
var ord3 = calif.OrderBy(c=>c).ToList();
ord3.ForEach(cal=>Console.WriteLine(cal));
Console.WriteLine("\nOrdenar lista de manera descendente");
var ord4 = calif.OrderByDescending(c=>c).ToList();
ord4.ForEach(cal=>Console.WriteLine(cal));