/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
Console.Clear();
Console.Write("Введите числа через пробел: ");
string [] arr = Console.ReadLine().Split(' ');

int [] nums = getArr(arr);
Console.WriteLine("You entered: ");
Console.WriteLine(String.Join(", ", nums));

int result = counter(nums);
Console.WriteLine($"You entered {result} numbers > 0 ");



int [] getArr (string [] arr) {
int [] nums = new int [arr.Length];
for (int i = 0; i < arr.Length; i++) {
    nums[i] = int.Parse(arr[i]);
}
return nums;
}

int counter (int [] nums) {
    int counter = 0;
    for (int i = 0; i < nums.Length; i++) {
        if (nums[i] > 0) {
            counter++;
        }
    }
    return counter;
}