public class Banco {
    public string Nombre { get; private set; }
    public string Direccion { get; private set; }
    public List<Cliente> Clientes { get; private set;}
    public Banco() => Clientes = new List<Cliente>();
    public Banco(string nombre,string direccion) : this() => (Nombre, Direccion) = (nombre, direccion);
    public void AgregarCliente(Cliente cliente) => Clientes.Add(cliente);
    public override string ToString() => $"Nombre: {Nombre}, domicilio: {Direccion}";

}