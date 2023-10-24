public class InicializadorBD {
    public static void Inicializar(ContextoDatos contexto) {
    if(contexto.Jugadores.Any()) {
        return;
    }
    var jugadores = new Jugador[] {
    new Jugador {Nombre="Juan de la Fuente",FechaNac=DateTime.Parse("20/02/2002"),NoPlayera=1,Posicion="Medio",Apariciones=1,Goles=0},
    new Jugador {Nombre="Santiago Jimenez",FechaNac=DateTime.Parse("20/02/2002"),NoPlayera=2,Posicion="Defensa",Apariciones=1,Goles=0},
    new Jugador {Nombre="Lucia Rodriguez",FechaNac=DateTime.Parse("20/02/2002"),NoPlayera=3,Posicion="Delantero",Apariciones=2,Goles=0},
    new Jugador {Nombre="Roberto Arellano",FechaNac=DateTime.Parse("20/02/2002"),NoPlayera=4,Posicion="Lateral",Apariciones=3,Goles=0},
    new Jugador {Nombre="Ana Montoya",FechaNac=DateTime.Parse("20/02/2002"),NoPlayera=5,Posicion="Portero",Apariciones=0,Goles=0}
    };
    contexto.Jugadores.AddRange(jugadores);
    contexto.SaveChanges();
    }
}