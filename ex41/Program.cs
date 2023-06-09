//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

void FillArray(int[] array, int M)
{
    for (int i = 0; i < M; i++)
    {
        Console.WriteLine("Введите элемент массива под номером: " + (i+1));
        array[i] = int.Parse(Console.ReadLine());
    }
}

void PositiveNumCounter(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count += 1;
        } 
    }
    Console.WriteLine("Колличество элементов массива, которые больше 0: " + count);

}

Console.WriteLine("Введите колличество элементов массива");
int N = int.Parse(Console.ReadLine());
int[] massiv = new int[N];
FillArray(massiv, N);
PositiveNumCounter(massiv);