public class Categoria {
    public string Nombre {get; set;}
    public string Rango {get; set;}
    public double Costo {get; set;}
    public List<Jugador> Jugadores {get; set;}
    public Categoria() => Jugadores = new List<Jugador>();
    public Categoria(string nombre, string rango, double costo) : this() => (Nombre, Rango, Costo) = (nombre, rango, costo);
    public void AgregarJugador(Jugador jugador) => Jugadores.Add(jugador);
    
   public double subtotalh{
        get {return Jugadores.Count(x => x.Sexo == 'H');}
    }
    public double subtotalm{
        get {return Jugadores.Count(x => x.Sexo == 'M');}
    }
    public double subtotal{
        get{return Jugadores.Where(j => !j.Becado).Sum(j => Costo);}
    }
    public override string ToString() => $"Nombre: {Nombre,-8} Rango: {Rango,-12} costo: {Costo,-15:c2}";
}