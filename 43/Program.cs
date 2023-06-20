/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.Clear();
Console.WriteLine("Enter b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = findX(b1, b2, k1, k2);
double y = findY(b1, b2, k1, k2);
Console.WriteLine($"Intersection in X: {x}, Y: {y}");

double findX (double b1, double b2, double k1, double k2) {
double x = (-b2 + b1)/(-k1 + k2);
return x;
}

double findY (double b1, double b2, double k1, double k2) {
double y = k2 * x + b2;
return y;
}