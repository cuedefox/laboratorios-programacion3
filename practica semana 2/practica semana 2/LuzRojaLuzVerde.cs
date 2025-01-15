namespace SquidGames;

public class LuzRojaLuzVerde : Juego
{
    private Random random = new Random();

    public override void Iniciar()
    {
        Estado = "En curso";
        Console.WriteLine($"{Nombre} ha comenzado. Luz Roja Luz Verde");
    }

    public override void Terminar()
    {
        Estado = "Finalizado";
        Console.WriteLine($"{Nombre} ha terminado");
    }

    public override void EvaluarResultado()
    {
        Console.WriteLine("Evaluando resultado de Luz Roja Luz Verde");

        foreach (var jugador in Jugadores)
        {
            if (random.Next(0, 2) == 0)
            {
                jugador.Estado = "Eliminado";
                jugador.Vivo = false;
                Console.WriteLine($"El jugador numero {jugador.Numero} ha sido eliminado");
            }
            else
            {
                Console.WriteLine($"El jugador numero {jugador.Numero} ha ganado {Nombre}");
            }
        }
    }
}