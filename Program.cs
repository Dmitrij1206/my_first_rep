// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы

// Console.Write("Введите число М: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// void ShowNumbersFromMtoN(int m, int n)
// {
//     if (m == n)
//     {
//        Console.Write (n);
//        return;
//     }
//     Console.Write(m + " ");
//     ShowNumbersFromMtoN( m + 1, n);
// }
// Console.Write("Числа от M до N : ");
// ShowNumbersFromMtoN(m,n);


// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

// int[] array = {1,2,5,10,34};
// int arrayNumber = array.Length-1;
// void ShowArrayBacktoFront(int arrayNumber)
// {
// if (arrayNumber == 0)
// {
//     Console.Write(array[0]);
//     return;
// }
// Console.Write(array[arrayNumber] + " ");
// ShowArrayBacktoFront(arrayNumber-1);
// }
// ShowArrayBacktoFront(arrayNumber);

// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 

 int Akkermanfunc (int m, int n)
{
if (m == 0 && n != 0)
{
    return n+1;
} 
else 
if ( m > 0 && n == 0)
{
  return
   Akkermanfunc (m-1, 1);
} 
else
{
  return
    Akkermanfunc(m-1, Akkermanfunc(m,n-1));
}
}
int res = Akkermanfunc(3,4);
Console.Write(res);
