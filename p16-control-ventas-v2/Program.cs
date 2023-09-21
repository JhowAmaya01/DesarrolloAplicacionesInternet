//programa que genera un reporte de ventas diarias
//Agregar una tienda
Tienda mitienda = new Tienda{Nombre = "Panaderia El panadero con el pan", Domicilio = "Mi casa", Propietario = "Jhohana Amaya"};

//Agregar clientes a la tienda
mitienda.AgregarCliente(new Cliente("Carlos Robles", "CRG240698ML4", "Rosas 15", "crobles@gmail.com"));
mitienda.AgregarCliente(new Cliente("Maria Hernandez", "MHJ125436KL5", "Claveles 5", "mariher@gmail.com"));
mitienda.AgregarCliente(new Cliente("Lorena Guerrero", "LORE121620M2", "Azucenas 12", "lguerr@gmail.com"));
mitienda.AgregarCliente(new Cliente("Beto Arellano", "BAR080462MJ2", "Girasoles 20", "beare@gmail.com"));

//Agregar ventas a los clientes
mitienda.Clientes[0].AgregarVenta(new Venta {Articulo = "Bollillo", Cantidad = 5, Precio = 7.5});
mitienda.Clientes[1].AgregarVenta(new Venta {Articulo = "Bollillo", Cantidad = 4, Precio = 7.5});
mitienda.Clientes[2].AgregarVenta(new Venta {Articulo = "Bollillo", Cantidad = 1, Precio = 7.5});
mitienda.Clientes[3].AgregarVenta(new Venta {Articulo = "Bollillo", Cantidad = 52, Precio = 7.5});
mitienda.Clientes[0].AgregarVenta(new Venta {Articulo = "Cuernitos", Cantidad = 6, Precio = 10});

//Reporte de ventas
Console.WriteLine("Reporte de ventas\n");
Console.WriteLine(mitienda.ToString());
Console.WriteLine($"Total de clientes: {mitienda.Clientes.Count()}");
Console.WriteLine($"Total de ventas: {mitienda.totalventas()}");
Console.WriteLine("\n\nDatos generales de los clientes");
foreach (Cliente cliente in mitienda.Clientes)
{
    Console.WriteLine(cliente.ToString());
}
Console.WriteLine("\nVentas de los clientes:");
foreach (Cliente cliente in mitienda.Clientes)
{
    Console.WriteLine(cliente.Nombre);
    foreach (Venta venta in cliente.Ventas)
        Console.WriteLine(venta.ToString());
    Console.WriteLine($"Subtotal : {cliente.subtotal(),63:c2}");
}
Console.WriteLine($"\n\nGanancia total de la tienda: {mitienda.total(),45:c2}");