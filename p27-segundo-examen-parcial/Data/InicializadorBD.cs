public class InicializadorBD {
    public static void Inicializar(ContextoDatos contexto) {
    if(contexto.Articulos.Any()) {
        return;
    }
    var articulos = new Articulo[] {
    new Articulo {Descripcion="Jabon zote",FechaAlta=DateTime.Parse("20/02/2023"),Cantidad=1,Precio=16.5,UdeMedida="Pieza"},
    new Articulo {Descripcion="Huevo",FechaAlta=DateTime.Parse("20/02/2023"),Cantidad=2,Precio=38,UdeMedida="Kilo"},
    new Articulo {Descripcion="Azucar",FechaAlta=DateTime.Parse("20/02/2023"),Cantidad=3,Precio=42,UdeMedida="Kilo"},
    new Articulo {Descripcion="Galletas Marias",FechaAlta=DateTime.Parse("20/02/2023"),Cantidad=4,Precio=18,UdeMedida="Caja"},
    new Articulo {Descripcion="Leche San Marcos",FechaAlta=DateTime.Parse("20/02/2023"),Cantidad=5,Precio=38.5,UdeMedida="Litro"}
    };
    contexto.Articulos.AddRange(articulos);
    contexto.SaveChanges();
    }
}