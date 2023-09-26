public class Jugador{
    public string Nombre {get; set;}
    public int AnoNac {get; set;}
    public char Sexo {get; set;}
    public bool Becado {get; set;}
    public Jugador(string nombre, int anoNac, char sexo, bool becado) => (Nombre, AnoNac, Sexo, Becado) = (nombre,anoNac, sexo, becado);
    //Console.Write((cta is CuentaDeCheques)?"Cuenta de cheques":"Cuenta de ahorro");
    public override string ToString() => $"Nombre: {Nombre,-20} año de nacimiento: {AnoNac,4}";
    
    //public int totalnb()
    
}