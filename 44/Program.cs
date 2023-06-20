// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.

// Если N = 5-> 0 1 1 2 3

// Если N = 3 -> 0 1 1

// Если N = 7 -> 0 1 1 2 3 5 8

// <aside>
// ❗️ Числа Фибоначчи — числовая ****последовательность,
// каждый элемент которой равен сумме двух предыдущих.

Console.Clear();
Console.WriteLine("Enter your number ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"Your number is {num}");

int [] result = fib(num);
Console.WriteLine("Fibonnaci sequence: ");
Console.WriteLine(String.Join(", ", result));

int [] fib (int num) {
    int [] fib = new int [num];
    fib[0] = 0;
    fib[1] = 1;
    for (int i=2; i < fib.Length; i++) {
        fib[i] = fib[i - 1] + fib [i - 2];
    }
    return fib;
}