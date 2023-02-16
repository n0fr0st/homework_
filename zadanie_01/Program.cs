int getSumm(int m, int n, int summ)
{
    if (m <= n)
    {
        summ = summ + m;
        m++;
        return getSumm(m,n,summ);
    }
    return summ;
}
System.Console.WriteLine("Введите число M - ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N - ");
int n = Convert.ToInt32(Console.ReadLine());
int summ = 0;
Console.WriteLine($"Сумма всех чисел от M до N - {getSumm(m, n, summ)}");
