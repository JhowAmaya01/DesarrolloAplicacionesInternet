// Data/Cliente.cs
using System.ComponentModel.DataAnnotations;
public class Cliente {
    DateTime fechaActual = DateTime.Today;
    public int Id { get; set; }
    [Required, StringLength(30)]
    public string Nombre { get; set; }
    [Required, StringLength(30)]
    public string Apellido { get; set; }
    public char Genero {get; set;}
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
    public DateTime FechaCumple { get; set; }
    [EmailAddress]
    public string Correo { get; set; }
    [StringLength(10)]
    public string Telefono { get; set; }
    [Display(Name = "Nombre Completo")]
    public string NombreCompleto {
    get { return Nombre + " " + Apellido; }
    }
    public TimeSpan Edad{
        get{return fechaActual - FechaCumple;}
    }
    public double Edad2{
        get{return Edad.TotalDays;}
    }
    public double Edad3{
        get{return Edad2/365;}
    }
    public double Edad4{
        get{return Math.Floor(Edad3);}
    }
    public ICollection<Reserva> Reservas { get; set; }
}