List<string> TODOList = new List<string>();

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
            mostrarItems();
            Console.WriteLine();
            mostrarMenu();
            break;
        case 'a':
        case 'A':
            agregarItem();
            Console.WriteLine();
            mostrarMenu();
            break;
        case 'r':
        case 'R':
            eliminarItem();
            Console.WriteLine();
            mostrarMenu();
            break;
        case 'e':
        case 'E':
            break;
        default:
            Console.WriteLine("Opción equivocada, intente de nuevo");
            Console.WriteLine();
            mostrarMenu();
            break;
    }
}

void mostrarItems()
{
    if (TODOList.Count() > 0)
    {

        foreach (string item in TODOList)
        {
            int index = TODOList.IndexOf(item);
            Console.WriteLine($"{index + 1}.- {item}");
        }
    }
    else
    {
        Console.WriteLine("No hay items registrados.");
    }
}

void agregarItem()
{
    Console.Write("Ingresa el item: ");
    string item = Console.ReadLine();

    if (item != null && item != "")
    {
        TODOList.Add(item);
    }
    else
    {
        Console.WriteLine("El item no puede ser vacio.");
    }
}

void eliminarItem()
{
    Console.Write("Ingresa el indice del item: ");
    int indiceItem = Convert.ToInt32(Console.ReadLine());
    if (indiceItem > 0)
    {
        string itemEncontrado = TODOList.ElementAt(indiceItem - 1);
        Console.WriteLine($"Item eliminado: {itemEncontrado}");
        TODOList.RemoveAt(indiceItem - 1);
    }
    else
    {
        Console.WriteLine("El indice no corresponde a un item registrado.");
    }
}

mostrarMenu();
