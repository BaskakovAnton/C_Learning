using System;
int[] Array = { 1, 12, 31, 4, 15, 16, 4, 18 };

int n = Array.Length;
int find = 4;

int index = 0;

while (index < n)
{
    if (Array[index] == find)
    {
        System.Console.WriteLine(index);
        System.Console.WriteLine(Array[index]);
        break;
    }
    index++;
}