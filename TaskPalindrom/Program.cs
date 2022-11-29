try
{
    Console.WriteLine("Input any integer number");
    int number = Convert.ToInt32(Console.ReadLine());
    if (IsPalindrom(number))
        Console.WriteLine($"The number {number} is palindrom!");
    else Console.WriteLine($"The number {number} is NOT palindrom!");
}
catch
{
    Console.WriteLine("You should enter the integer number only!");
}

bool IsPalindrom(int a)
{
    int digitNumber = (int)Math.Log10(Math.Abs(a)) + 1;
    if (digitNumber == 1) return true;
    int[] digitArray = new int[digitNumber];
    for (int i = 0; i < digitNumber; i++)
    {
        digitArray[i] = a % 10;
        a /= 10;
    }
    for (int i = 0; i < digitNumber / 2; i++)
    {
        if (digitArray[i] != digitArray[digitNumber - i - 1])
            return false;
    }
    return true;
}