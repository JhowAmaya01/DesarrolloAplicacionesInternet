// Procesa n calificaciones introducidas por el usuario, calcula suma y promedio
char resp;
int cont = 0, numEst = 0;
float calificaciones = 0, suma = 0, promedio = 0, promgen = 0;
string status = "";
do{
    promedio = suma = cont = 0;
Console.Clear();
Console.WriteLine("Procesa calificaciones, introduce 666 para terminar");
do{
    Console.Write("Calificacion :");
    calificaciones = float.Parse(Console.ReadLine());
    if (calificaciones != 666){
        suma += calificaciones;
        cont++;
    }
}while(calificaciones != 666);
promedio = suma/cont;
status = promedio >= 6 ? "Aprobado" : "No Aprobado";
promgen +=promedio;
Console.WriteLine($"Capturaste: {cont} calificaciones");
Console.WriteLine($"La suma de las calificaciones es: {suma}");
Console.WriteLine($"El promedio es {promedio:f2}");
Console.WriteLine($"Tu status es: {status}");
numEst++;
Console.WriteLine("\n Deseas capturar las calificaciones de otro estudiante? (S/N)");
resp = char.ToUpper(Console.ReadLine()[0]);
} while(resp != 'N');
promgen/= numEst;
Console.WriteLine($"Se procesaron las calificaciones de {numEst} estudiantes");
Console.WriteLine($"El promedio general es: {promgen}");