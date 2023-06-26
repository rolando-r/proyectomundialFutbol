using diccionarios_csharp;
internal class Program
{
    private static void Main(string[] args)
    {
        Equipo equipo = new Equipo();
        DiccDemo dicc = new DiccDemo();
        bool isAddEquipo = true;
        int opc=0;
        while (isAddEquipo){
            Console.Clear();
            Console.WriteLine("Ingrese el nombre del equipo :");
            equipo.Nombre = Console.ReadLine();
            Console.WriteLine("1.Agregar jugadoras\n2.Agregar persona del panel tecnico\n3.Agregar persona del panel medico\n4.Salir");
            switch(opc){
                case 1:
                    Console.WriteLine("Nombre jugadora:");
                    string nombreJugadora = Console.ReadLine() ?? String.Empty;
                    Console.WriteLine("Numero de dorsal");
                    string dorsalJugadora = Console.ReadLine() ?? String.Empty;
                    Console.WriteLine("Posicion de juego");
                    string posicionJugadora = Console.ReadLine() ?? String.Empty;
                    Console.WriteLine("Edad");
                    string edadJugadora = Console.ReadLine() ?? String.Empty;
                    break;
                case 2:
                    Console.WriteLine("Nombre persona:");
                    string nombrePerCTec = Console.ReadLine() ?? String.Empty;
                    Console.WriteLine("Cargo");
                    string cargoPerCTec = Console.ReadLine() ?? String.Empty;
                    Console.WriteLine("Edad");
                    string edadPerCTec = Console.ReadLine() ?? String.Empty;
                    break;
                case 3:
                    Console.WriteLine("Nombre persona:");
                    string nombrePerCMed = Console.ReadLine() ?? String.Empty;
                    Console.WriteLine("Especialidad");
                    string especialidadPerCMed = Console.ReadLine() ?? String.Empty;
                    Console.WriteLine("Edad");
                    string edadPerCMed = Console.ReadLine() ?? String.Empty;
                    break;
                case 4:
                    isAddEquipo=false;
                    break;
            }
        }
    }
}