public class Cliente {
    public string Nombre {get; set;}
    public string RFC {get; set;}
    public string Domicilio {get; set;}
    public string Correo {get; set;}
    public List<Venta> Venta {get; set;}
    public Cliente (string nombre, string rfc, string domicilio, string correo, List<Venta> venta) => 
    (Nombre, RFC, Domicilio, Correo, Venta) = (nombre, rfc, domicilio, correo, venta);
    public void AgregarVenta(Venta venta) => Venta.Add(venta);
    public override string ToString() => $"Nombre: {Nombre}, RFC: {RFC}, domicilio: {Domicilio} correo: {Correo}";
}