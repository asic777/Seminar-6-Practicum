// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Task_41();

void Task_41()
{
    Console.WriteLine("Задача 41. Ввод массива и подсчет чисел больше 0.");

    Console.Write("Введите длину массива: ");
    int SizeArray = int.Parse(Console.ReadLine()!);

    int[] array = FillArray(SizeArray);
    PrintArray(array);
    Console.WriteLine(" -> " + CountingPositiveNumbers(array));
}

void PrintArray(int[] tempArray)
{
    Console.Write("[{0}", tempArray[0]);

    for (int i = 1; i < tempArray.Length; i++)
    {
        Console.Write(", {0}", tempArray[i]);
    }

    Console.Write("]");
}

int CountingPositiveNumbers(int[] checkArray)
{
    int result = 0;

    foreach (var item in checkArray)
    {
        result += item > 0 ? 1 : 0;
    }

    return result;
}

int[] FillArray(int lengthArray)
{
    int[] resultArray = new int[lengthArray];

    for (int i = 0; i < lengthArray; i++)
    {
        Console.Write($"Введите значение элемента [{i}] массива: ");
        resultArray[i] = int.Parse(Console.ReadLine()!);
    }

    return resultArray;
}