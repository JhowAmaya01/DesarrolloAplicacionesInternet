public class Estudiante{
    public string Matricula {get; set;}
    public string Nombre {get; set;}
    public string Domicilio {get; set;}
    public string Municipio {get; set;}
    public char Sexo {get; set;}
    public int Edad {get; set;}
    public bool Becado {get; set;}
    public List<float> Califs {get; set;}
    public Estudiante(){}
    public Estudiante(string matricula, string nombre, string domicilio, string municipio, char sexo, int edad, bool becado, List<float> califs) => (Matricula, Nombre, Domicilio, Municipio, Sexo, Edad, Becado, Califs) = (matricula, nombre, domicilio, municipio, sexo, edad, becado, califs);
    public override string ToString() => $"Matricula: {Matricula}\t Nombre: {Nombre}\t Domicilio: {Domicilio} \t Municipio: {Municipio} \nSexo: {(Sexo=='H'?"Hombre":"Mujer")}\t Edad: {Edad} \tBecado: {(Becado?"Becado":"No becado")} \tCalifs: {string.Join(",",Califs)}";
}