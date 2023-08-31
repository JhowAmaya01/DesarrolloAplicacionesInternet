// Programa que muestra un arreglo con funciones desde una clase
double [] num = {100, 123, 456, 222, 999, 895, 325, 234, 322, 988};
double suma = 0, suma2 = 0;

biblio.Imprime(num);
suma = biblio.Suma(num);
suma2 = biblio.Suma2(num);
Console.WriteLine($"\nLa suma de estos numeros es: {suma:f2}");
Console.WriteLine($"\nLa division entre 2 de estos numeros y su suma despues de esto es: {suma2:f2}");
biblio.Imprime2(num);