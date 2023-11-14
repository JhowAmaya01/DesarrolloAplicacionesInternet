// Data/Inscripcion.cs
using System.ComponentModel.DataAnnotations;
public class Reserva{
    public int ReservaID { get; set; }
    public int HabitacionID { get; set; }
    public int ClienteID { get; set; }
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
    public DateTime InicioReserva { get; set; }
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
    public DateTime FinReserva { get; set; }
    public Habitacion Habitacion { get; set; }
    public Cliente Cliente { get; set; }

    public TimeSpan DiasReservados{
        get{return FinReserva-InicioReserva;}
    }
    public double Total{
        get{return Habitacion.Costo*DiasReservados.TotalDays;}
    }
    public double TotDiasRes{
        get{return DiasReservados.TotalDays;}
    }
    [Display(Name = "Hab")]
    public string Hab {
    get { return Habitacion.Tipo + " - " + Habitacion.NoHabitacion + " - " + Habitacion.Piso + " - " + Habitacion.Costo; }
    }
    [Display(Name = "Nombre Completo 2")]
    public string NombreCompleto2 {
    get { return Cliente.Nombre + " " + Cliente.Apellido; }
    }
    //public override string cad() => $"{Habitacion.Tipo}-{Habitacion.NoHabitacion}-{Habitacion.Piso}-{Habitacion.Costo}";

}

