string[] InputArray(string[] newArray)
{
    Console.WriteLine("Введите количество элементов массива:");
    int elementsCount = int.Parse(Console.ReadLine());
    string[] createArray = new string[elementsCount];
    for (int i = 0; i < createArray.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        createArray[i] = Console.ReadLine();
    }
    return createArray;
}

string PrintArray(string[] array)
{
    string res = String.Empty;
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        res += $"{array[i]} ";
    }
    return res;
}

string[] OutputArray(string[] inputArray)
{
    Console.WriteLine("Введите максимальное число символов элементов массива, которые будут отображаться:");
    int limit = int.Parse(Console.ReadLine());
    int newLen = 0;
    for (int k = 0; k < inputArray.Length; k++)
    {
        if (inputArray[k].Length <= limit) newLen++;
    }

    string[] outputArray = new string[newLen];
    int i, index;
    index = i = 0;

    while (i < inputArray.Length)
    {
        if (inputArray[i].Length <= limit)
        {
            outputArray[index] = inputArray[i];
            index++;
        }
        i++;
    }

    return outputArray;
}

string[] emptyArray = new string[0];
var inArray = InputArray(emptyArray);
Console.WriteLine();
Console.WriteLine($"Исходный массив, созданный Вами:  {PrintArray(inArray)}");
var outArray = OutputArray(inArray);
Console.WriteLine($"Отформатированный массив:  {PrintArray(outArray)}");
