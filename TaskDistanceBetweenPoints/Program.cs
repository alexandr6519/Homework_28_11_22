try
{
    Console.WriteLine("Input the size of space");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] point1 = new int[n];
    int[] point2 = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Input {i + 1} coordinate of first point");
        point1[i] = Convert.ToInt32(Console.ReadLine());
    }
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Input {i + 1} coordinate of second point");
        point2[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write("The distance beetween points ");
     PrintArray(point1);
     Console.Write(" and ");
      PrintArray(point2);
     Console.Write(" is : {0:f4}", GetDistance(point1, point2));
}
catch
{
    Console.WriteLine("You must input integer numbers only!!!");
}

double GetDistance(int[] array1, int[] array2)
{
    double sumSquares = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        sumSquares += Math.Pow(array1[i] - array2[i], 2);
    }
    return Math.Sqrt(sumSquares);
}

void PrintArray(int[] array)
{
    Console.Write("(");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($" {array[i]},");
        else Console.Write($" {array[i]})");
    }
}