/*
 * Dado un número "limite" se deben sumar los valores divisibles entre 3 y 5
 * si el número es divisible entre 3 y 5 entonces solo se debe sumar una vez
 * por ejemplo: 15 es divisible entre 3 y 5 y debe sumarse 15 una sola vez.
 * 
 * En caso de que el resultado sea negativo el resultado debe ser 0.
 */
static int sumaMultiplosTresCinco(int limite)
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

Console.WriteLine(sumaMultiplosTresCinco(16));
