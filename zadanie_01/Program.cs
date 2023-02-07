int[] GenArray(int coll)
{
    int[] arr = new int[coll];
    int result;
    for(int index = 0; index < arr.Length; index++)
    {
        Console.WriteLine($"Введите {index+1} число.");
        while (!int.TryParse(Console.ReadLine(), out result))
        {
                Console.WriteLine(" error try again");
        }
        arr[index] = result;
    }
    return arr;
}
int num(int[] coll)
{
    int result = 0;
    for(int i = 0; i < coll.Length; i++)
    {
        if(coll[i] > 0)
            result++;
    }
    Console.WriteLine($"Чисел которые больше 0 - {result}");
    return result;
}
void printArray(int[] array)
{
    Console.WriteLine($"Ваши числа - {string.Join(", ", array)}");
}
Console.WriteLine("Введите количество чисел, которые вы хотите проверить, что они больше 0, а так же введите каждое число, чтобы его проверить.");
int[] array = GenArray(Convert.ToInt32(Console.ReadLine()));
printArray(array);
num(array);