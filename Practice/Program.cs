int[] elements = new int[] { 12, 24, -5, 45, -4, -35 };
List<int> resultPositives = getOnlyPositiveValues(elements);

List<int> getOnlyPositiveValues(int[] numbers)
{
    List<int> positives = new List<int>();
    foreach (int number in numbers)
    {
        if (number > 0)
            positives.Add(number);
    }
    return positives;
}

foreach (int positive in resultPositives)
    Console.WriteLine(positive);
