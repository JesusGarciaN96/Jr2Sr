/*
 * Dado un número "limite" se deben sumar los valores divisibles entre 3 y 5
 * si el número es divisible entre 3 y 5 entonces solo se debe sumar una vez
 * por ejemplo: 15 es divisible entre 3 y 5 y debe sumarse 15 una sola vez.
 * 
 * En caso de que el resultado sea negativo el resultado debe ser 0.
 */
int sumaMultiplosTresCinco(int limite)
{
    int resultado = 0;
    for (int indice = 1; indice < limite; indice++)
    {
        bool unResiduo = indice % 3 == 0 || indice % 5 == 0;
        if (unResiduo)
        {
            resultado += indice;
        }
    }
    return resultado < 0 ? 0 : resultado;
}

/*
 * Dado dos números enteros (pueden ser positivos o negativos)
 * se debe encontra la suma de todos los enteros. 
 * 
 * Si los dos números son iguales, se debe retornar uno de los
 * dos valores.
 */
int sumaEnteros(int primero, int segundo)
{
    if (primero == segundo)
        return primero;
    else
    {
        int resultado = 0;
        int inicio = primero < segundo ? primero : segundo;
        int limite = segundo > primero ? segundo : primero;
        for (int indice = inicio; indice <= limite; indice++)
        {
            resultado += indice;
        }
        return resultado;
    }
}

/*
 * Dada una lista de object donde esta contendrá elementos de tipo
 * string e int (positivos) se deben filtrar solo los valores de tipo int.
 */
List<object> genericos = new List<object>() { 1, 2, "a", "b" };

IEnumerable<int> soloEnterosPositivos(List<object> listaGenerica)
{
    List<int> enteros = new List<int>();
    foreach (var elemento in listaGenerica)
    {
        if(elemento.GetType() == typeof(int))
        {
            int entero = (int)elemento;
            if(entero >= 0)
            {
                enteros.Add(entero);
            }
        }
    }
    return enteros;
}

/*
 * Dado un array de int retornar la suma de valores positivos
 */
int sumaSoloeEnteros(int[] enteros)
{
    int resultado = 0;
    foreach(int numero in enteros)
        resultado += numero > 0 ? numero : 0;
    return resultado;
}

Console.WriteLine(sumaSoloeEnteros([12, 34, -3, 5, -6]));
