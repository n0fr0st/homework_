int akkFunc(int m, int n)
{
    if(m > 0 && n > 0) return akkFunc(m - 1, akkFunc(m, n - 1));
    else if( m != 0 && n == 0) return akkFunc(m - 1, 1);
    else if ( m == 0) return n + 1;
    return akkFunc(m, n);
}


int natureNum(string pic)
{
    int m;
    Console.Write($"Введите число {pic} - ");
    while(!int.TryParse(Console.ReadLine(), out  m))
    {
        Console.WriteLine("error");
    } 
    if (m < 0) 
    {
        Console.WriteLine("Введите положительное число ");   
        return natureNum(pic);
    }
return m;
}


int m = natureNum("m");
int n = natureNum("n");
Console.WriteLine($" функция Аккермана при значениях m - {m}, и n - {n}, равна - {akkFunc(m, n)}");