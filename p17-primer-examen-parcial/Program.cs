// Programa que lleva el control en una academia de futbol

//Crear academia
Academia miacademia = new Academia("Academia Santos Laguna", "Francisco Nava", "Agua Naval 123, Hidraulica");

//Agregar categorias
miacademia.AgregarCategoria(new Categoria("Junior A", "2006/2007/2008", 1250));
miacademia.AgregarCategoria(new Categoria("Junior B", "2009/2010/2011", 850));
miacademia.AgregarCategoria(new Categoria("Junior C", "2012/2013/2014", 700));

//Agregar jugadores a las categorias
//Junior A
miacademia.Categorias[0].AgregarJugador(new Jugador("Alexander Lopez", 2006, 'H', false));
miacademia.Categorias[0].AgregarJugador(new Jugador("Amanda Chavez", 2007, 'M', true));
miacademia.Categorias[0].AgregarJugador(new Jugador("Alexander Lopez", 2008, 'M', false));
//Junior B
miacademia.Categorias[1].AgregarJugador(new Jugador("Armando Santana", 2009, 'H', false));
miacademia.Categorias[1].AgregarJugador(new Jugador("Daniel Mijares", 2010, 'H', false));
miacademia.Categorias[1].AgregarJugador(new Jugador("Antonia Hernandez", 2011, 'M', true));
//Junior C
miacademia.Categorias[2].AgregarJugador(new Jugador("Andrea Solis", 2012, 'M', true));
miacademia.Categorias[2].AgregarJugador(new Jugador("Mario Benedetti", 2013, 'H', true));
miacademia.Categorias[2].AgregarJugador(new Jugador("Diana Soto", 2014, 'M', false));

//Reporte de la academia
Console.WriteLine($">> Datos generales de la academia");
Console.WriteLine(miacademia.ToString());
Console.WriteLine($"\nTotal de categorias: {miacademia.Categorias.Count()}");
/*if(miacademia.Categorias.Jugadores.Sexo == 'H'){
    int totalh;
    
}*/

Console.WriteLine($"Total de Hombres: {miacademia.totalh()}");
Console.WriteLine($"Total de Mujeres: {miacademia.totalm()}\n");
//Datos generales de las categorias
Console.WriteLine($">> Datos generales de las categorias");
foreach (Categoria categoria in miacademia.Categorias)
{
    Console.WriteLine(categoria.ToString());
}
//datos de los jugadores por categoria

Console.WriteLine("\n>>Datos de los jugadores:");
foreach (Categoria categoria in miacademia.Categorias)
{
    Console.WriteLine($"> {categoria.Nombre}  -{categoria.Rango}- ({categoria.Jugadores.Count()})");
    foreach (Jugador jugador in categoria.Jugadores){
        Console.WriteLine($"{jugador.ToString()} sexo: " +(jugador.Sexo is 'H' ? "Hombre": "Mujer ")+ " becado: " + (jugador.Becado ? "Becado":"Sin beca"));

    }
    Console.Write($"Subtotal: {categoria.subtotal:c2}\n\n");
}
Console.Write($"\n\nTotal: {miacademia.total:c2}\n");

