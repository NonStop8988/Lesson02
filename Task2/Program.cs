// Создание массива от 1 до заданного числа n
int n = 10;
int[] arr = new int[n]; // new int[n] - выделение памяти под новый массив
int i = 0;

while (i < arr.Length) // arr.Length - длина массива
{
    arr[i] = i + 1;
    Console.Write(arr[i]);
    i += 1;

    if (i < arr.Length)
    {
        Console.Write($"; ");
    }
}