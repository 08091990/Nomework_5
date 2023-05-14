// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


int[] EvenNumber(int[] massive)
{ 
    int max = massive[0];
    int quantity = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] > 0)
        {
            quantity++;
        }
    }
    Console.WriteLine(" Количество чисел больше 0 -> {0} ", quantity);
    return massive;
}

int[] MakeRandomArray(int size)
{
    int[] massive = new int [size];
    for (int i = 0; i < size; i++)
    {
        massive[i] = new Random().Next(-100, 100);
    }
    return massive;
}

int[] array = MakeRandomArray(5);
Console.Write($"{String.Join(", ",array)}");
int[] massive = EvenNumber(array);

