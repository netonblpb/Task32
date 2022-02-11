// Задайте массив из восьми элементов, заполненных нулями и единицами. Выведите их на экран

Console.Clear();
int[] array = new int[8];
Random random = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(0, 2);
    Console.Write(array[i] + "     ");
}