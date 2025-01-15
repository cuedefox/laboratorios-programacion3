using SquidGames;

public class Guardia : Persona
{
    public string Arma { get; set; }
    public string Rango { get; set; }

    public override void RealizarAccion()
    {
        Console.WriteLine($"El guardia {Nombre} vigila a los jugadores con el arma {Arma}");
    }

    public void EliminarJugador(Jugador jugador)
    {
        jugador.Estado = "Eliminado";
        jugador.Vivo = false;
        Console.WriteLine($"El guardia {Nombre} ha eliminado al jugador numero {jugador.Numero}");
    }
}