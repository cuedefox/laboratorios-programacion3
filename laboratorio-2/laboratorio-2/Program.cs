namespace Registro;

class Persona
{
    //campos privados
    private int id;
    private string name;
    private int age;

    public string Name //propiedad publica
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0)
                age = value;
            else
                Console.WriteLine("Value is under 0");
        }
    }

    public int Id { get { return id; } }

    private int GenerateId()//Metodo privado
    {
        Random random = new Random();
        return random.Next(1000000, 10000000);
    }

    public Persona(string name, int age) //constructor con parametros pasados y default
    {
        this.id = GenerateId();
        this.name = name;
        this.age = age;
        Console.WriteLine($"The persona {name} was created with {age} years");
    }

    ~Persona()//destructor
    {
        Console.WriteLine($"Se ha destruido a {name} con id {id}");
    }

    public char[] StringToCharArray(string input)//String a array de caracteres
    {
        return input.ToCharArray();
    }

    public string CharArrayToString(char[] input)//array de caracteres a string
    {
        return new string(input);
    }

    public string GetSubstring(string input, int startIndex, int length)//obtener substrings a partir de un string dado
    {
        if (startIndex >= 0 && startIndex + length <= input.Length)
            return input.Substring(startIndex, length);
        else
            return "Index out of range";
    }

    public bool CompareStrings(string str1, string str2)//comparar strings
    {
        return str1.Equals(str2);
    }

    public int SearchString(string input, string search)//buscar string dentro de otro
    {
        return input.IndexOf(search);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Persona persona1 = new Persona("Rodrigo", 23);
        Console.WriteLine(persona1.Name + " " + persona1.Age + " " + persona1.Id);
        //quise llamar al destructor pero investigando encontre de que el garbage collector es el que se encarga de esto en c#

        string example = "Hola, mundo!";
        Console.WriteLine("\n--- Operaciones con cadenas ---");

        char[] charArray = persona1.StringToCharArray(example);
        Console.WriteLine("Array de caracteres: " + string.Join(", ", charArray));

        string reunitedString = persona1.CharArrayToString(charArray);
        Console.WriteLine("String reunido: " + reunitedString);

        string substring = persona1.GetSubstring(example, 0, 4);
        Console.WriteLine("Substring: " + substring);

        bool comparison = persona1.CompareStrings("Hola", "Hola");
        Console.WriteLine("Comparación de cadenas: " + (comparison ? "Iguales" : "Diferentes"));

        int position = persona1.SearchString(example, "mundo");
        Console.WriteLine("Posición de 'mundo': " + position);

        Console.WriteLine("Fin del programa.");
    }
}