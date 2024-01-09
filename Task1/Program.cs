// Создание массива из 5
int[] arr = new int[5];
arr[0] = 5;
arr[1] = 7;
arr[2] = 5;
arr[3] = 4;
arr[4] = 3;
Console.WriteLine(arr[0]);
Console.WriteLine(arr[1]);
Console.WriteLine(arr[2]);
Console.WriteLine(arr[3]);
Console.WriteLine(arr[4]);

// Недопустимое обращение, индекс выходит за границы массива
// Console.WriteLine(arr[5]);

// Создание массива без отдельного ввода каждого его элемента
int[] arr2 = new int[5] { 1, 2, 3, 4, 5 };

// Упрощенное создание массива (выделение памяти под массив без new int[5])
int[] arr3 = { 1, 2, 3, 4, 5 };

// Создание массива на pyhton 
// arr = [1,2,3,4,5]