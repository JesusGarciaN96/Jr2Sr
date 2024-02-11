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

Console.WriteLine(sumaEnteros(-1, 0));
