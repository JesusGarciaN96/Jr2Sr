void mostrarMenu()
{
    try
    {
        Console.WriteLine("Hello!");
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("[S]ee all TODOs");
        Console.WriteLine("[A]dd a TODO");
        Console.WriteLine("[R]emove a TODO");
        Console.WriteLine("[E]xit");
        string opcion = Console.ReadLine();
        Console.WriteLine();
        if (opcion != null || opcion != "")
        {
            char opcionMenu = Convert.ToChar(opcion.Length > 0 ? opcion[0] : "");
            seleccionarOpcion(opcionMenu);
        }
    }
    catch
    {
        seleccionarOpcion('.');
    }
}

void seleccionarOpcion(char opcion)
{
    switch (opcion)
    {
        case 's':
        case 'S':
            Console.WriteLine("Mostramos la lista");
            Console.WriteLine();
            mostrarMenu();
            break;
        case 'a':
        case 'A':
            Console.WriteLine("Agregamos elemento");
            Console.WriteLine();
            mostrarMenu();
            break;
        case 'r':
        case 'R':
            Console.WriteLine("Eliminamos elemento");
            Console.WriteLine();
            mostrarMenu();
            break;
        case 'e':
        case 'E':
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opción equivocada, intente de nuevo");
            Console.WriteLine();
            mostrarMenu();
            break;
    }
}

mostrarMenu();
