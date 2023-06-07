// Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.

// Если N = 5-> 0 1 1 2 3

// Если N = 3 -> 0 1 1

// Если N = 7 -> 0 1 1 2 3 5 8

Console.Clear();
Console.WriteLine("Введите число операций");
int N = int.Parse(Console.ReadLine());

int a = 0;
int b = 1;
int c = 0;

for (int i = 0; i < N - 2; i++)
    {
        c = a + b;
        a = b; 
        b = c;
        {
            Console.WriteLine(c);
        }

    } 


