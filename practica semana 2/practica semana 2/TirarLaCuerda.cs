using System;

namespace SquidGames;

public class TirarLaCuerda : Juego
{
    public List<Jugador> EquipoA {  get; set; } = new List<Jugador>();
    public List<Jugador> EquipoB { get; set; } = new List<Jugador>();


    public override void Iniciar()
    {
        Estado = "En curso";
        Console.WriteLine($"{Nombre} ha comenzado. A tirar de la cuerda");
    }

    public override void Terminar()
    {
        Estado = "Finalizado";
        Console.WriteLine($"{Nombre} ha terminado");
    }

    public override void EvaluarResultado()
    {
        Console.WriteLine("Evaluando resultado de tirar la cuerda");
        var fuerzaEquipoA = EquipoA.Count * random.Next(1, 10);
        var fuerzaEquipoB = EquipoB.Count * random.Next(1, 10);

        if (fuerzaEquipoA > fuerzaEquipoB) { Console.WriteLine
    }
}