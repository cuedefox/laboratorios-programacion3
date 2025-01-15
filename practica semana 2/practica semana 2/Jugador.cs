namespace SquidGames;

public class Jugador : Persona
{
    public int Numero {  get; set; }
    public string Estado { get; set; } = "Participando";
    public bool Vivo {  get; set; } = true;

    public override void RealizarAccion()
    {
        throw new NotImplementedException();
    }
}