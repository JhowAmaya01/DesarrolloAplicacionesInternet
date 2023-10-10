// Programa que hace consultas a traves de linq en un programa que contiene clases

List<Estudiante> estudiantes = new List<Estudiante>();
estudiantes.Add(new Estudiante("1234", "Juan Perez", "Principal 123","Zacatecas",'H',21, true, new List<float>{97,92,81,60}));
estudiantes.Add(new Estudiante("2345", "Maria Lopez", "Principal 126","Fresnillo",'M',21, true, new List<float>{97,92,81,60}));
estudiantes.Add(new Estudiante("3456", "Rodrigo Mata", "Av Mexico 114","Rio Grande",'H',21, true, new List<float>{97,92,81,60}));
estudiantes.Add(new Estudiante("4567", "Miguel Mejia", "La loma 666","Fresnillo",'H',21, true, new List<float>{97,92,81,60}));
estudiantes.Add(new Estudiante("5678", "Pepe Pecas", "5 de mayo 23","Rio Grande",'H',21, true, new List<float>{97,92,81,60}));
estudiantes.Add(new Estudiante("6789", "Brenda Giron", "Av Rayon 12","Zacatecas",'M',21, true, new List<float>{97,92,81,60}));
estudiantes.Add(new Estudiante("7890", "Lili Morones", "Sierra Madre 12","Rio Grande",'M',21, true, new List<float>{97,92,81,60}));
estudiantes.Add(new Estudiante("8901", "Bere Diaz", "Sierra Mezquite 34","Fresnillo",'M',21, true, new List<float>{97,92,81,60}));
estudiantes.Add(new Estudiante("9012", "Rocio Bernal", "Amargura 66","Fresnillo",'M',21, true, new List<float>{97,92,81,60}));

Console.WriteLine("\nTodos los estudiantes del grupo");
estudiantes.ForEach(e=>Console.WriteLine(">>" + e));

string mun = "Zacatecas";
var estmun = estudiantes.Where(e=>e.Municipio==mun).ToList();
Console.WriteLine($"\n\nEstudiantes que son de {mun} --{estmun.Count()}");
estmun.ForEach(e=>Console.WriteLine(">>" + e.ToString()));

float prom = 65f;
var estprom = estudiantes.Where(e=>e.Califs.Average()>=prom).ToList();
Console.WriteLine($"\n\nEstudiantes con promedio >= {prom} --{estprom.Count()}");
estprom.ForEach(e=>Console.WriteLine(">>" + e));

var estprom1 = estudiantes.Select(e => new { Nombre=e.Nombre, Promedio=e.Califs.Average() }).ToList();
Console.WriteLine($"\n\nLista de alumnos y promedios: ");
estprom1.ForEach(e=>Console.WriteLine(">>" + e));

Console.WriteLine("\n\nSubtotales:");
var promedades = estudiantes.Average(e=>e.Edad);
Console.WriteLine($"Promedio de edades: {promedades:n2}");
var promprom = estudiantes.Average(e=>e.Califs.Average());
Console.WriteLine($"Promedio grupal de calificacion: {promprom:n2}");
var totm = estudiantes.Count(e=>e.Sexo=='M');
Console.WriteLine($"Total de mujeres: {totm:n2}");
var toth = estudiantes.Count(e=>e.Sexo=='H');
Console.WriteLine($"Total de hombres: {toth:n2}");
var tb = estudiantes.Count(e=>e.Becado);
Console.WriteLine($"Total de becados: {tb:n2}");
var tnb = estudiantes.Count(e=>!e.Becado);
Console.WriteLine($"Total de no becados: {tnb:n2}");
var tmb = (from e in estudiantes where e.Becado && e.Sexo == 'M' select e).Count();
Console.WriteLine($"Total de mujeres becadas: {tmb:n2}");

var gpoest = estudiantes.GroupBy(e=>e.Municipio);
Console.WriteLine("\nEstudiantes agrupados por municipios");
foreach (var gpo in gpoest){
    Console.WriteLine($"\n{gpo.Key} : {gpo.Count()}");
    foreach (var est in gpo){
        Console.WriteLine(">>" + est);
    }
}