﻿// Calcula factorial de n numeros
int n,f;

Console.Clear();
Console.WriteLine("Calculo del factorial de N numeros");
Console.WriteLine("Hasta que numero deseas el factorial");
n = int.Parse(Console.ReadLine());
for(int i = 1; i <= n; i++){
    Console.Write($"{i} !=");
    f = 1;
    for(int j = 1; j <= i; j++)
        f *=j;
    Console.Write($"{f} \n");
}
