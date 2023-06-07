// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.WriteLine("Введите числа: ");
string numbers = Console.ReadLine()!;
string [] array = numbers.Split(',');
Console.WriteLine($"{Numofnum(array)}");


int Numofnum (string[] array)
{
   int count = 0;
   for(int i = 0; i < array.Length; i++)
   {
        if (Convert.ToInt32(array[i]) > 0)
           count++;
   }
   return count;
}   