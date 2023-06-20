﻿/*Задача 45: Напишите программу,
которая будет создавать копию заданного массива 
с помощью поэлементного копирования.*/

Console.Clear();
int [] array = GetRandomArray(4, -9, 9);
Console.WriteLine("Generated array: ");
Console.WriteLine(String.Join(", ", array));

int [] copy = copyArray(array);
Console.WriteLine("Array copy: ");
Console.WriteLine(String.Join(", ", copy));


int [] GetRandomArray (int size, int minValue, int maxValue) {
    int [] result = new int [size];
    for (int i = 0; i < size; i++) {
        result[i] = new Random().Next(minValue, maxValue+1);
    }
    return result;
}

int [] copyArray (int [] arr) {
 int[] copy = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++) {
            copy[i] = arr[i];
        }
    return copy;
}