// Data/InicializadorBD.cs
public class InicializadorBD {
    public static void Inicializar(ContextoDatos contexto) {
        if(contexto.Clientes.Any()) {
            return;
        }
        var clientes = new List<Cliente> {
            new Cliente { Nombre = "Juan", Apellido = "Lopez", Genero = 'H',FechaCumple = DateTime.Parse("1990-02-26"), Correo = "jl@mail.com", Telefono = "4921569354"},
            new Cliente { Nombre = "Manuel", Apellido = "Perez", Genero = 'H',FechaCumple = DateTime.Parse("1985-05-16"), Correo = "mp@mail.com", Telefono = "4926589310"},
            new Cliente { Nombre = "Perla", Apellido = "Carrillo", Genero = 'M',FechaCumple = DateTime.Parse("1979-12-12"), Correo = "pc@mail.com", Telefono = "4923610280"},
            new Cliente { Nombre = "Maria", Apellido = "Anaya", Genero = 'M',FechaCumple = DateTime.Parse("2000-01-06"), Correo = "ma@mail.com", Telefono = "4925601587"},
            new Cliente { Nombre = "Eugenia", Apellido = "Gonzales", Genero = 'M',FechaCumple = DateTime.Parse("1999-03-01"), Correo = "eg@mail.com", Telefono = "4926871036"},
            new Cliente { Nombre = "Marco", Apellido = "Del Rio", Genero = 'H',FechaCumple = DateTime.Parse("1953-11-10"), Correo = "mdr@mail.com", Telefono = "4921369850"},
            new Cliente { Nombre = "Laura", Apellido = "Valle", Genero = 'M',FechaCumple = DateTime.Parse("1966-04-25"), Correo = "lv@mail.com", Telefono = "4920136987"},
            new Cliente { Nombre = "Jose", Apellido = "Lechuga", Genero = 'H',FechaCumple = DateTime.Parse("1987-12-31"), Correo = "jol@mail.com", Telefono = "4920698030"}
        };
        contexto.Clientes.AddRange(clientes);
        contexto.SaveChanges();
        var habitaciones = new List<Habitacion> {
            new Habitacion {Id = 1, NoHabitacion = 1, Tipo = "Individual", Piso = 1, Costo = 750},
            new Habitacion {Id = 4, NoHabitacion = 4, Tipo = "Individual", Piso = 2, Costo = 850},
            new Habitacion {Id = 7, NoHabitacion = 7, Tipo = "Individual", Piso = 3, Costo = 900},
            new Habitacion {Id = 10, NoHabitacion = 10, Tipo = "Individual", Piso = 4, Costo = 950},
            new Habitacion {Id = 2, NoHabitacion = 2, Tipo = "Doble", Piso = 1, Costo = 1000},
            new Habitacion {Id = 5, NoHabitacion = 5, Tipo = "Doble", Piso = 2, Costo = 1100},
            new Habitacion {Id = 8, NoHabitacion = 8, Tipo = "Doble", Piso = 3, Costo = 1200},
            new Habitacion {Id = 11, NoHabitacion = 11, Tipo = "Doble", Piso = 4, Costo = 1300},
            new Habitacion {Id = 3, NoHabitacion = 3, Tipo = "Triple", Piso = 1, Costo = 1500},
            new Habitacion {Id = 6, NoHabitacion = 6, Tipo = "Triple", Piso = 2, Costo = 1750},
            new Habitacion {Id = 9, NoHabitacion = 9, Tipo = "Triple", Piso = 3, Costo = 2000},
            new Habitacion {Id = 12, NoHabitacion = 12, Tipo = "Triple", Piso = 4, Costo = 2250}
        };
        contexto.Habitaciones.AddRange(habitaciones);
        contexto.SaveChanges();
        var reservas = new List<Reserva> {
            new Reserva {HabitacionID = 1, ClienteID = 1, InicioReserva = DateTime.Parse("2023-11-10"), FinReserva = DateTime.Parse("2023-11-20")}
        };
        contexto.Reservas.AddRange(reservas);
        contexto.SaveChanges();
    }
}