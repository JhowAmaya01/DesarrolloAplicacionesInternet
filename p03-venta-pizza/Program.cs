// Programa que procesa el pedido de una pizzade acuerdo a LA ELECCION DEL USUARIO
char tamaño, cubierta, lugar;
string[] ingredientes;
string Tamaño = "", Ingredientes ="", Cubierta, Lugar; 
int Cantidad = 0;
float total = 0;

if(args.Length == 0){
    Menu();
    return 1;
}

//tamaño
tamaño = char.Parse(args[0].ToUpper());
if(tamaño == 'P'){ Tamaño = "Pequeña"; total += 10;}
else if(tamaño == 'M'){Tamaño = "Mediana"; total += 20;}
else{ Tamaño = "Grande"; total += 30;}

//Ingredientes
ingredientes = args[1].Split("+");
foreach(string i in ingredientes){
    total +=5;
    switch(char.Parse(i.ToUpper())){
        case 'E' : Ingredientes += "Extra queso "; break;
        case 'C' : Ingredientes += "Champiñones "; break;
        case 'P' : Ingredientes += "Piña "; break;
    }
}

//Cubierta
cubierta = char.Parse(args[2].ToUpper());
Cubierta = (cubierta == 'D' ?  "Delgada" : "Gruesa");

//Lugar de consumo
lugar = char.Parse(args[3].ToUpper());
Lugar = (lugar == 'A' ? "Aqui" : "Llevar");

//Cantidad
Cantidad = int.Parse(args[4]);
total *= Cantidad;

//Pedido final
Console.WriteLine("Tu pedido es el siguiente: \n");
Console.WriteLine("Tamaño: {0}", Tamaño);
Console.WriteLine("Ingredientes: {0}", Ingredientes);
Console.WriteLine("Cubierta: {0}", Cubierta);
Console.WriteLine("Lugar de consumo: {0}", Lugar);
Console.WriteLine("Cantidad: {0}", Cantidad);
Console.WriteLine("Total: {0}", total);



return 0;
static void Menu(){
Console.Clear();
Console.WriteLine("Tamaño : [P]equeña-$10 [M]ediana-$20 [G]rande-$30");
Console.WriteLine("Ingredientes : [E]xtra queso [C]hampiñoness [P]iña , unidos por un + ($5)");
Console.WriteLine("Cubierta : [D]elgada [G]ruesa");
Console.WriteLine("Donde la consumes : [A]qui [L]levar");
Console.WriteLine("Cantidad ¿?");
}