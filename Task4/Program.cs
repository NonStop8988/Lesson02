int[] arr = { 0, 45, 5, -234, 64, 56, 5 };
int i = 0;
int max = arr[0];

while (i < arr.Length)
{
    if (max < arr[i])
    {
        max = arr[i];
    }
    i += 1;
}
Console.WriteLine(max);

max = arr[0];
for (int j = 0; j < arr.Length; j++)
{
    if (max < arr[j])
    {
        max = arr[j];
    }
}
Console.WriteLine(max);

max = arr[0];
foreach (int e in arr)
{
    if (max < e)
    {
        max = e;
    }
}
Console.WriteLine(max);