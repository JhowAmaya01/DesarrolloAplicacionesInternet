public class Tienda {
    public string Nombre {get; private set;}
    public string Propietario {get; private set;}
    public string Domicilio {get; private set;}
    public List<Cliente> Cliente {get; private set;}
    public Tienda() => Cliente = new List<Cliente>();
    public Tienda(string nombre, string propietario, string domicilio) : this() => (Nombre,Propietario,Domicilio) = (nombre, propietario,domicilio);
     public void AgregarCliente(Cliente cliente) => Cliente.Add(cliente);
     public override string ToString() => $"Nombre: {Nombre} \nPropietario: {Propietario}\nDomicilio: {Domicilio}";
}