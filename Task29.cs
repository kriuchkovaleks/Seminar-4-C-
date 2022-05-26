/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
6, 1, 33 -> [6, 1, 33]
*/


void FillArray(int[] collection)
{
    Random randomaizer = new Random();
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        collection[i] = randomaizer.Next(0,1000);
    }
}

int [] array = new int[8];
FillArray(array);

for (int i = 0; i <= array.Length; i++)
{
    Console.Write(array[i] + " ");
}