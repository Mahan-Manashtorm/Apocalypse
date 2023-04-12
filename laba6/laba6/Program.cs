using da;

SetAdapter<int> adapter = new SetAdapter<int>(); 
int[] array = { 1, 2, 3, 4, 5 };

ISet<int> set = adapter.ToSet(array);
Console.WriteLine("Множество: ");
foreach (int item in set)
{
    Console.Write(item + " ");
}

Console.WriteLine();
set.Add(6);
set.Add(7);

int[] newArray = adapter.ToArray(set);
Console.WriteLine("Массив: ");
foreach (int item in newArray)
{
    Console.Write(item + " ");

}
Console.WriteLine();