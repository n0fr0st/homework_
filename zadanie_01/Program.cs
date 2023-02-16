void PrintNumber(int n)
{
    if(n != 1)
    {
        Console.Write($"{n}, ");
                PrintNumber(n-1);
    }
    else
    {
        Console.WriteLine($"{n}");
    }
}
Console.WriteLine("Задайте число и программа выведет все число в промежутке от вашего числа до 1.");
int num = Convert.ToInt32(Console.ReadLine());
PrintNumber(num);