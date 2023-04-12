using da;

Console.WriteLine("Введите размер массива:");
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
Random rnd = new Random();
for (int i = 0; i < n; i++)
{
    arr[i] = rnd.Next(1000);
}
Task task1 = Task.Run(() => Sort.InsertionSort(arr));
Task task2 = Task.Run(() => Sort.SelectionSort(arr));
Task task3 = Task.Run(() => Sort.BubbleSort(arr));
Task.WaitAll(task1, task2, task3);
Console.WriteLine("Отсортированный массив:");
for (int i = 0; i < n; i++)
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine();