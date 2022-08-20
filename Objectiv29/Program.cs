int[] array = new int[8];
for (int index = 0; index < array.Length; index++)
{
    array[index] = new Random().Next(-10, 10);  
}
Console.Write($"Вывод массива: [{String.Join(", ", array)}]");