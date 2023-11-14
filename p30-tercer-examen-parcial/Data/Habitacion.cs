// Data/Habitacion.cs
using System.ComponentModel.DataAnnotations;
public class Habitacion {
    public int Id { get; set; }
    [Required, Range(1, 30)]
    public int NoHabitacion { get; set; }
    [Required, StringLength(10)]
    public string Tipo { get; set; }
    [Range(1, 4)]
    public int Piso { get; set; }
    [Required,Range(1, 5000)]
    public double Costo { get; set; }
    public ICollection<Reserva> Reservas { get; set; }
    [Display(Name = "Hab")]
    public string Hab {
    get { return "Tipo:" +Tipo + " -No. habitacion" + NoHabitacion + " -Piso:" + Piso + " -Costo: $" + Costo; }
    }
}