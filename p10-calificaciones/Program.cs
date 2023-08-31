// Programa que muestra el promedio de un alumno y le manda un mensaje de acuerdo al promedio
string nombre, mensaje;
double cal = 0, prom = 0, suma = 0;
int num = 0;
char resp;

Console.WriteLine("Escribe tu nombre: ");
nombre = Console.ReadLine();
do{
    Console.Write("Calificacion: ");
    cal = double.Parse(Console.ReadLine());
    if (cal > 10){
        cal = 0;
        Console.WriteLine("Ingrese una calificacion valida en el rango de 0 a 10");
    }
    else{
        suma += cal;
        num++;
    }
    Console.Write("Desea ingresar otra calificacion S/N: ");
    resp = char.ToUpper(Console.ReadLine()[0]);
}while(resp != 'N');
if(num>0){
    prom = suma / num;
    Console.WriteLine($"\n{nombre} tu status es el siguiente:");
    Console.WriteLine($"Reportaste {num} calificaciones");
    if(prom >= 0 && prom <= 5.9) 
        Console.Write($"Tu calificacion global es D ({prom}): Andas mal");
    else if(prom >= 6 && prom <= 7.5) 
        Console.Write($"Tu calificacion global es C ({prom}): Mucho mejor");
    else if(prom >= 7.6 && prom <= 8.5) 
        Console.Write($"Tu calificacion global es B ({prom}): Muy bien");
    else
        Console.Write($"Tu calificacion global es A ({prom}): Excelente");
}
else
    Console.WriteLine($"{nombre} reporta alguna calificacion por favor");



