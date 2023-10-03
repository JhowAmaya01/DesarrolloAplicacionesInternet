// Consultas LINQ
List<int> numeros = new() {5, 4, 1, 3, 9, 8, 6, 7, 2, 8};

/*foreach (int n in numeros){
    Console.WriteLine(n);
}*/
//Consulta LINQ usando la sintaxis integrada
Console.WriteLine("\nNumeros pares:");
var pares = from num in numeros where num%2==0select num;
foreach (int n in pares){
    Console.WriteLine(n);
}

//Consulta LINQ usando los metodos de extension
Console.WriteLine("\nNumeros impares:");
var impares = numeros.Where(num => num%2!=0);
foreach (int n in impares){
    Console.WriteLine(n);
}

//Consulta LINQ, sintaxis integrada, convertir a lista
Console.WriteLine("\nNumeros entre 5 y 9");
var rango1 = (from num in numeros where num>=5 && num<=9 select num).ToList();
rango1.ForEach(num=>Console.WriteLine(num));

//Consulta LINQ, metodos de extension, convertir a lista
Console.WriteLine("\nNumeros entre 1 y 4");
var rango2 = numeros.Where(num=> num>=1 && num<=4).ToList();
rango2.ForEach(num=>Console.WriteLine(num));