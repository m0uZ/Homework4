// Написать программу, которая сортирует массив от большего к меньшему и находит медианное значение. 
// Массив заполняется случайными целыми числами от 1 до 100, а его размерность вводится с клавиатуры.

int[] returnArray(int finalNumb)
{
    int[] array = new int[finalNumb];
    for (int i = 0; i < finalNumb; i++)
    {
        array[i] = new Random().Next(0, 100);
        Console.WriteLine(array[i] + " ");
    }
    return array;
}

Console.Write("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] rndArray = returnArray(N);

int temp;
for (int i = 0; i < rndArray.Length - 1; i++)
{
    for (int j = i + 1; j < rndArray.Length; j++)
    {
        if (rndArray[i] > rndArray[j])
        {
            temp = rndArray[i];
            rndArray[i] = rndArray[j];
            rndArray[j] = temp;
        }
    }
}
Console.WriteLine("Вывод отсортированного массива");
for (int i = 0; i < rndArray.Length; i++)
{
    Console.WriteLine(rndArray[i]);
}
int len = rndArray.Length;

if ((len - 1) % 2 == 0)
{
    Console.WriteLine("Медианное значение: " + rndArray[(len - 1) / 2]);
}
else
{
    Console.WriteLine("Медианное значение: " + (rndArray[len / 2] + rndArray[(len / 2) - 1]) / 2);
}




