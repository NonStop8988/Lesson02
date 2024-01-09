int[] arr = { 1, 4, 6, 7, 2, 5, 8, 9, 4, 6 };
int i = 0;

while (i < arr.Length)
{
    if (arr[i] % 2 == 0)
    {
        Console.Write($"{arr[i]}; ");
    }
    i += 1;
}
    