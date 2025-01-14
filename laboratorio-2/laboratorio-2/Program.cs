using System.Drawing;

namespace pooPilars;

class Esfera
{
    private double radio;

    public double Radio
    {
        get { return radio; }
        set { radio = value; }
    }

    public virtual void Rodar() //Usado para polimorfismo
    {

    }
}

//abstraccion al tomar el objeto esfera y pelota y descomponerlos en sus propiedades y metodos
class Pelota : Esfera //herencia
{
    private string color;
    private int volumen;
    private int peso;
    private int dureza;

    public string Color //encapsulamiento estableciendo getters y setters para propiedades privadas
    {
        get { return color; }
        set { color = value; }
    }
    public int Volumen
    {
        get { return volumen; }
        set { volumen = value; }
    }
    public int Peso
    {
        get { return peso; }
        set { peso = value; }
    }
    public int Dureza
    {
        get { return dureza; }
        set { dureza = value; }
    }

    public override void Rodar() //Polimorfismo
    {
        System.Console.WriteLine($"La pelota color {color} esta rodando");
    }

    public void Rebotar()
    {
        System.Console.WriteLine($"La pelota color {color} esta rebotando");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Esfera miEsfera = new Esfera { Radio = 5.0 };
        miEsfera.Rodar();

        Pelota miPelota = new Pelota { Color = "rojo", Volumen = 10, Peso = 2, Dureza = 5 };
        miPelota.Rodar();
        miPelota.Rebotar();
    }
}