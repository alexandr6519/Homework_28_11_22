try
{
    Console.WriteLine("Input the integer positive number");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write($"The list of cubes of numbers from 1 to {n} is: (");
    for (int i = 1; i <= n; i++)
    {
        if (i == n) Console.Write($" {Math.Pow(i, 3)})");
        else Console.Write($" {Math.Pow(i, 3)},");
    }
}
catch
{
    Console.WriteLine("You should input the integer positive number only!!!");
}