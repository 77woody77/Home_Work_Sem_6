// Напишите программу,
// которая будет создавать копию заданного массива с помощью поэлементного копирования./

int[] array = Creatingrandomarray(5,-10,10);

PrintArray(array, Copy(array));



int[] Creatingrandomarray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue+1);
    }
    return result;
}

int[] Copy(int [] array)
{
    int [] resault = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
        resault[i] = array[i];
    return resault;

}

void PrintArray(int[] array1, int[] array2)
    {
         for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array1[i]} \t {array2[i]}");
            }
    }