// Programa que imprime articulos para su venta y la cantidad de ellos que se van a vender y el total de pago.

string articulo, lista;
double precio = 0, cantidad = 0, total = 0, totalfin = 0, artcompr = 0;
int n = 0;
char resp;
do{
    precio = cantidad = total = totalfin = artcompr = 0;
    Console.Write("Cuantos articulos distintos deseas ingresar?: ");
    n = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++){
        Console.Write("Dame el nombre del articulo: ");
        articulo = Console.ReadLine();
        Console.Write("Dame el precio de este articulo: $");
        precio = double.Parse(Console.ReadLine());
        Console.Write("Dame la cantidad: ");
        cantidad = double.Parse(Console.ReadLine());
        total = cantidad * precio;
        Console.WriteLine($"Subtotal: ${total}");
        totalfin += total;
        artcompr += cantidad;
    }
    if(totalfin <= 1200){
        Console.Write($"\n\nEl total sin IVA es: ${totalfin:f2}\n");
        totalfin = totalfin + totalfin*0.16;
        Console.Write($"El total con IVA es: ${totalfin:f2}\nSus articulos totales son {artcompr} de {n} articulos diferentes");
    }
    else
        Console.Write($"\n\nEl total es: ${totalfin:f2}\nSus articulos totales son {artcompr} de {n} articulos diferentes");
    Console.Write("\nQuiere seguir de compras?: S/N ");
    resp = char.ToUpper(Console.ReadLine()[0]);
}while(resp != 'N');