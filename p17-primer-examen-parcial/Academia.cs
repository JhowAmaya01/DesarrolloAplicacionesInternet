public class Academia{
    public string Nombre {get; set;}
    public string Propietario {get; set;}
    public string Domicilio {get; set;}
    public List<Categoria> Categorias {get;  set;}
    public Academia() => Categorias = new List<Categoria>();
    public Academia(string nombre, string propietario, string domicilio) : this() => (Nombre,Propietario,Domicilio) = (nombre, propietario,domicilio);
    public void AgregarCategoria(Categoria categoria) => Categorias.Add(categoria);
    public override string ToString() => $"Nombre: {Nombre} \nPropietario: {Propietario}\nDomicilio: {Domicilio}";
    public  double totalh(){
         double total=0;
        foreach (Categoria categoria in Categorias)
            total = total + categoria.subtotalh;
        return total;
    }
    public  double totalm(){
         double total=0;
        foreach (Categoria categoria in Categorias)
            total = total + categoria.subtotalm;
        return total;
    }
    public double total(){
         double total=0;
        foreach (Categoria categoria in Categorias)
            total = total + categoria.subtotal;
        return total;
    }
}