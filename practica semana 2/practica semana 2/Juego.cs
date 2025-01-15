using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquidGames;

public abstract class Juego
{
    public string Nombre { get; set; } = string.Empty;
    public int NumeroDeJugadores { get; set; }
    public string Estado {  get; set; }
    public List<Jugador> Jugadores { get; set; } = new List<Jugador>();

    public abstract void Iniciar();

    public abstract void Terminar();

    public abstract void EvaluarResultado();
}