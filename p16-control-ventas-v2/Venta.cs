public class Venta{
    public string Articulo {get; set;}
    public int Cantidad {get; set;}
    public double Precio {get; set;}
    public double Total{
        get {return Cantidad * Precio;}
    }
    public Venta(){}
    public Venta(string articulo, int cantidad, double precio) => (Articulo, Cantidad, Precio) = (articulo, cantidad, precio);
    public override string ToString() => $"Articulo: {Articulo,-15} Cantidad: {Cantidad,5} Precio: {Precio,12:c2}{Total,12:c2}";
    
}