//Calcula la paga de un trabajador considerando la horas extra
string nombre = "";
int  horas = 0, horasextra = 0;
float paga = 0, pagaextra = 0, pagabruta = 0, paganeta = 0, impuesto = 0, tasa = 0;
Console.Clear();
Console.Write("Nombre ?"); nombre = Console.ReadLine();
Console.Write("Horas ?"); horas = int.Parse(Console.ReadLine());
Console.Write("Paga ?"); paga = float.Parse(Console.ReadLine());

tasa = 0.03f;

if(horas > 40){
    horasextra = horas - 40;
    pagaextra = 2 * paga * horasextra;
    pagabruta = 40 * paga + pagaextra;
} else 
    pagabruta = horas * paga;
impuesto = pagabruta * tasa;
paganeta = pagabruta - impuesto;

Console.WriteLine($"\nResumen de pagos del trabajador {nombre} \n");
Console.WriteLine($"{horas} horas trabajadas, {horasextra} extra, paga {paga}, tasa de impuesto {tasa:p2} ");
Console.WriteLine($"Paga bruta : {pagabruta,12:c2}");
Console.WriteLine($"Paga extra : {pagaextra,12:c2}");
Console.WriteLine($"Impuesto : {impuesto,12:c2}");
Console.WriteLine($"Paga neta : {paganeta,12:c2}");