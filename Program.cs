// Семинар 6 Двумерные массивы и Рекурсия
// Задача 1: напишите программу, которая перевернет одномерный массив (порследний элемент будет первый, 
//а первый на последнем месте и тд)
// int[] CreateRandomArray(int size, int minValue, int maxValue) // размер массива, максимальное значение и минимальное
// {
//     int[] array = new int[size]; // выделяем память под массив- надо запомнить, имя массива (array), тип массива int, размер массива size
    
//     for(int i = 0; i < size; i++) //  при работе с массивом, это всегда цикл, i- индекс
//         array[i] = new Random().Next(minValue, maxValue + 1);

//     return array; // возвращаем массив, пишем только его имя!
// }
 void ShowArray(int[] array) // войтовский метод будем вызывать массив
 {
    Console.Write("Array is: "); // красивая финтифлюшка для вывода массива
    
    for (int i =0; i < array.Length; i++) // обращаемся к длине массива
        Console.Write(array[i] + " ");

    Console.WriteLine(" ;) \n"); // \n  переход на новую строку

 }
 
//  void ReverseArray(int[] array)
//  {
    
//     // for (int i = 0; i < array.Length / 2; i++ ) // блок инициализации рабочей переменной, блок условий и блок перехода, он может усложняться
//     // {
//     //     int temp = array[i]; // решение первым способом
//     //     array[i] = array[array.Length -1 -i]; // сводим массив  друг к дружке 
//     //     array[array.Length -1 -i] = temp;
//     //}
//     for (int i =0, j = array.Length -1; i < j; i++, j--) // второй вариант записи и решения, более понятный и расписанный
//     {
//         int temp = array[i];
//         array[i] = array [j];
//         array[j] = temp;
//     }
//  }
 
// Console.Write("Input a number of elements: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(n, min, max);
// ShowArray(myArray);
// ReverseArray(myArray); // метод работает с первоисточником массивом
// ShowArray(myArray);

// Задача 2 Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые 2 числа Фибоначчи a и b. 
int[] Fibonacci(int N, int a, int b)
{
    int[]array = new int[N]; //создаем массив, куда будем помещать все числа фибоначчи
    array[0]= a;
    array[1] = b;
    for(int i = 2; i < N; i++) 
    {
      array[i] = array[i-1]+array[i-2]; //формула фибоначчи
    } 
    return array;
}
 Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b: ");
int b = Convert.ToInt32(Console.ReadLine());  
ShowArray(Fibonacci(n, a, b)); 


//Задача 3 Напишите программу, которая будет  создавать копию заданного массива с помощью поэлементного копирования

// Напишите программу, которая принимает на вход 3 числа и проверяет, может ли существовать треугольник со сторонами такой длины
//int --bool