public class Venta{
    public string Articulo {get; set;}
    public int Cantidad {get; set;}
    public double Precio {get; set;}
    public Venta(string articulo, int cantidad, double precio) => (Articulo, Cantidad, Precio) = (articulo, cantidad, precio);
    public override string ToString() => $"Articulo: {Articulo}, Cantidad: {Cantidad}, Precio: {Precio}";
    
}