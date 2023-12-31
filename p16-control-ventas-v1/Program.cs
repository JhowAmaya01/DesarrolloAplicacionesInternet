﻿//programa que genera un reporte de ventas diarias

//creamos una tienda
Tienda mitienda = new Tienda("Mari's","Jhohana Amaya","Mi casita");

//agregamos clientes
mitienda.AgregarCliente(new Cliente("Carlos Robles", "CRG240698ML4", "Rosas 15", "crobles@gmail.com", new List<Venta>{new Venta("Jabon",3, 24.5)}));
mitienda.AgregarCliente(new Cliente("Maria Hernandez", "MHJ125436KL5", "Claveles 5", "mariher@gmail.com", new List<Venta>()));
mitienda.Cliente[1].AgregarVenta(new Venta("Yogurth", 5, 12.5));
mitienda.Cliente[1].AgregarVenta(new Venta("Coca Cola", 2, 18));
//imprimimos los datos
Console.WriteLine($"Reporte de ventas de la tienda: \n{mitienda.ToString()}");
Console.WriteLine($"Clientes: {mitienda.Cliente.Count}");
Console.WriteLine($"Total de ventas: \n");

//Imprimir los clientes y sus respectivos datos
foreach(Cliente cte in mitienda.Cliente){
    Console.Write($"\nCliente:\n{cte.ToString()}, total de ventas: {cte.Venta.Count}\n");
    foreach(Venta venta in cte.Venta){
        Console.WriteLine($"Ventas: {venta.ToString()}");
    }
}