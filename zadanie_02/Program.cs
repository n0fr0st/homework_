float[] GenArray1(int coll)
{
    float[] arr = new float[coll];
    float result;
    for(int index = 0; index < arr.Length; index++)
    {
        string coord;
        if(index == 0)
            coord = "b";
        else
            coord = "k";
        Console.WriteLine($"Введите {coord}{1}.");
        while (!float.TryParse(Console.ReadLine(), out result))
        {
                Console.WriteLine(" error try again");
        }
        arr[index] = result;
    }
    return arr;
}
float[] GenArray2(int coll)
{
    float[] arr = new float[coll];
    float result;
    for(int index = 0; index < arr.Length; index++)
    {
        string coord;
        if(index == 0)
            coord = "b";
        else
            coord = "k";
        Console.WriteLine($"Введите {coord}{2}.");
        while (!float.TryParse(Console.ReadLine(), out result))
        {
                Console.WriteLine(" error try again");
        }
        arr[index] = result;
    }
    return arr;
}
float[] resultDot(float[] first, float[] second)
{
    float[] arr = new float[2];
    arr[0]= (second[0] - first[0])/(first[1] - second[1]);
    
    arr[1]= ((first[1]*second[0] - first[0]*second[1])/(first[1] - second[1]));
    return arr;
}
void printArray1(float[] array)
{
    Console.WriteLine($"Точка пересечения - ({string.Join("; ", array)})");
}
Console.WriteLine("Программа найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
float[] dotCoord1 = GenArray1(2);   
float[] dotCoord2 = GenArray2(2);
printArray1(resultDot(dotCoord1, dotCoord2));



