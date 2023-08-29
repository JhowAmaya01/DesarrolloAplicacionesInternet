//Programa que muestra las estadisticas de un arreglo
const int max=100;
int n = 0;

double [] calif = null;
double mayor = 0, menor = 0, promedio = 0, var = 0, desv = 0;

Console.Clear();
Console.Write("Cuantos elementos ? ");
n = int.Parse(Console.ReadLine());

if(n>max){
    Console.WriteLine("El maximo de elementos es {0}",max);
    return 1;
}

calif = new double[n];
for(int i = 0; i < calif.Length; i++){
    Console.Write($"Calif[{i}]= ");
    calif[i] = double.Parse(Console.ReadLine());
}

est.Imprime(calif);
mayor = est.Mayor(calif);
menor = est.Menor(calif);
promedio = est.Promedio(calif);
var = est.Var(calif, promedio);
desv = Math.Sqrt(var);

Console.WriteLine("\nResumen de estadisticas:");
Console.WriteLine($"Cantidad de calificaciones {calif.Length}");
Console.WriteLine($"El mayor es: {mayor:f2}");
Console.WriteLine($"El menor es: {menor:f2}");
Console.WriteLine($"El promedio es: {promedio:f2}");
Console.WriteLine($"La varianza es: {var:f2}");
Console.WriteLine($"La desviacion es: {desv:f2}");

return 0;