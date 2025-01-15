namespace SquidGames;

public abstract class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Rol { get; set; }

    public abstract void RealizarAccion();
}