//Пример решения 1

// int n = 10;
// int[] array = { 2, 5, 38, 46, 82, 3, 4, 8, 6, 9 };
// int i = 0;

// while(i < n)
// {
//     if(array[i] % 2 == 0)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     i = i + 1;
// }


//Пример решения 2

//int n = 10;
int[] array = { 2, 5, 38, 46, 82, 3, 4, 8, 6, 9 };
int i = 0;

while(i < array.Length)
{
    if(array[i] % 2 == 0)
    {
        Console.Write(array[i]);
        Console.Write(' ');
    }
    i = i + 1;
}