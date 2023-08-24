// imprime una tabla de conversion de peso a otras monedas
int ini, fin, c;
float tcd = 17.70f, tcl =  21.21f, tce = 18.19f;

Console.Clear();
Console.WriteLine("Imprime tabla de conversion de monedas \n");

do{
    Console.WriteLine("Valor inicial: ");ini = int.Parse(Console.ReadLine());
    Console.WriteLine("Valor final:   ");fin = int.Parse(Console.ReadLine());
}while(fin<ini); //valida que ini sea menor que fin
c= ini;
Console.WriteLine("Peso\tDolar\tLibra E\tEuro");
while(c<=fin){
    Console.WriteLine($"{c:f2}\t{c/tcd:f2}\t{c/tcl:f2}\t{c/tce:f2}");
    c++;
}
