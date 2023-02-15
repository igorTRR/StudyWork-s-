// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
Console.Write("Введите числа через запятую: ");
int[] NumArray = InNum(Console.ReadLine()!);
PrintArray(NumArray);
int sum = 0;
for (int i = 0; i < NumArray.Length; i++)
{
    if (NumArray[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($"количество значений больше 0 = {sum}");

int[] InNum(string ar)
{
    int count = 1;
    for (int i = 0; i < ar.Length; i++)
    {
        if (ar[i] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int [count];
    int index = 0;

    for (int i = 0; i < ar.Length; i++)
    {
        string temp = "";

        while (ar[i] != ',')
        {
        if(i != ar.Length - 1)
        {
            temp += ar[i].ToString();
            i++;
        }
        else
        {
            temp += ar[i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}