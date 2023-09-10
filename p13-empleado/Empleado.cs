//codigo de clase
public class Empleado{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public char Sexo { get; set; }
    public bool EstadoCivil { get; set; }

    public Empleado() {}
    public Empleado(string nombre) => Nombre = nombre;
    public Empleado(string nombre, int edad, char sexo, bool estadocivil) => (Nombre, Edad, Sexo, EstadoCivil) = (nombre, edad, sexo, estadocivil);
    public void Imprimir(){
        Console.WriteLine($"Nombre: {Nombre} \nEdad: {Edad}");
        Console.WriteLine($"Sexo: {(Sexo == 'M' ? "Mujer":"Hombre")} \nEstado civil: {(EstadoCivil ? "Casado":"No casado")}\n");
    }
}