
class Sistema_Regis_Jugadores
{
    static void Main(string[] args)
    {
        // Crear un mapa para almacenar los deportistas y sus premios
        Dictionary<string, HashSet<string>> deportistasPremios = new Dictionary<string, HashSet<string>>();

        // Agregar algunos deportistas y sus premios
        AgregarPremio(deportistasPremios, "Usain Bolt", "Oro en 100m");
        AgregarPremio(deportistasPremios, "Simone Biles", "Oro en Gimnasia");
        AgregarPremio(deportistasPremios, "Michael Phelps", "Oro en 200m mariposa");
        AgregarPremio(deportistasPremios, "Usain Bolt", "Oro en 200m");

        // Mostrar los premios de cada deportista
        MostrarPremios(deportistasPremios);
    }

    // Método para agregar un premio a un deportista
    static void AgregarPremio(Dictionary<string, HashSet<string>> deportistasPremios, string deportista, string premio)
    {
        // Si el deportista no existe en el mapa, lo agregamos
        if (!deportistasPremios.ContainsKey(deportista))
        {
            deportistasPremios[deportista] = new HashSet<string>();
        }

        // Agregamos el premio al conjunto de premios del deportista
        deportistasPremios[deportista].Add(premio);
    }

    // Método para mostrar los premios de cada deportista
    static void MostrarPremios(Dictionary<string, HashSet<string>> deportistasPremios)
    {
        foreach (var deportista in deportistasPremios)
        {
            Console.WriteLine($"Deportista: {deportista.Key}");
            Console.WriteLine("Premios:");
            foreach (var premio in deportista.Value)
            {
                Console.WriteLine($"- {premio}");
            }
            Console.WriteLine();
        }
    }
}
