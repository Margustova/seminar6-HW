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
//  void ShowArray(int[] array) // войтовский метод будем вызывать массив
//  {
//     Console.Write("Array is: "); // красивая финтифлюшка для вывода массива
    
//     for (int i =0; i < array.Length; i++) // обращаемся к длине массива
//         Console.Write(array[i] + " ");

//     Console.WriteLine(" ;) \n"); // \n  переход на новую строку

//  }
 
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
// int[] Fibonacci(int N, int a, int b)
// {
//     int[]array = new int[N]; //создаем массив, куда будем помещать все числа фибоначчи
//     array[0]= a;
//     array[1] = b;
//     for(int i = 2; i < N; i++) 
//     {
//       array[i] = array[i-1]+array[i-2]; //формула фибоначчи
//     } 
//     return array;
// }
//  Console.Write("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a : ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input b: ");
// int b = Convert.ToInt32(Console.ReadLine());  
// ShowArray(Fibonacci(n, a, b)); 


//Задача 3 Напишите программу, которая будет  создавать копию заданного массива с помощью поэлементного копирования

// int[] Copy(int[] array)
// {   
//     int[] CopyArray = new int[array.Length];
//     for( int i=0; i < array.Length; i++)
//     {
//         CopyArray[i] = array[i];

//     }
//     return CopyArray; 

// }
// Console.Write("Input a number of elements: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(n, min, max);
// ShowArray(myArray);
// ShowArray(Copy(myArray));

// // Напишите программу, которая принимает на вход 3 числа и проверяет, может ли существовать треугольник со сторонами такой длины
// bool Triangle(int a, int b, int c)
// {
//     int sumab = a+b;
//     int sumbc = b+c;
//     int sumca = c+a;
//     // if ( sumab> c && sumbc > a && sumca > b)
//     // {
//     //     return true;
//     // }
//     // else return false;
//     return sumab> c && sumbc > a && sumca > b; // будет тоже самое, что if
 
// }
// Console.Write("Input a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input c: ");
// int c = Convert.ToInt32(Console.ReadLine());
// bool x= a>b; //булевую величину можно отправлять без if и тд
// if(x)
// {
//     Console.WriteLine();
// }
// Console.WriteLine(Triangle(a , b, c));
 
//  Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// решаем без массивов через счетчик, проверяя, что число больше 0

// int PositiveDigit(int m)
// {
//     int count =0; //счетчик положительных чисел
//     int num; // числа, которые вводит пользователь
//     for (int dig=0; dig <m; dig++) //считаем сколько чисел до m
//     {
//         Console.Write("Введите число: ");
//         num = Convert.ToInt32(Console.ReadLine());
//         if(num > 0)
//         count++;
//     }
//     return count;
// }
// Console.Write("Сколько чисел: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write(PositiveDigit(m));


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int PointIntersectionX(int b1, int b2, int k1, int k2)
{
    int x;
   
    //y = k1 * x + b1; //прямая 1
    //y = k2 * x + b2; // прямая 2
    
//Если M0 является точкой пересечения прямых a и b, то по определению она принадлежит и прямой a и прямой b,
// то есть, ее координаты должны удовлетворять одновременно и уравнению формула и уравнению формула. 
//Следовательно, нам нужно подставить координаты точки М0 в уравнения заданных прямых и посмотреть, 
//получаются ли при этом два верных равенства. Если координаты точки М0 удовлетворяют обоим уравнениям формула и формула,
// то формула – точка пересечения прямых a и b, в противном случае М0 не является точкой пересечения прямых.
    x = (b2-b1) / (k1-k2);
     return x; //находим координату x
} 

int PointIntersectionY(int x, int b1, int k1)
{
    int y;     
    y = k1 *x + b1; // находим координату y
    return y;
}
Console.WriteLine("Input b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
int x = PointIntersectionX(b1, b2, k1, k2);
Console.WriteLine(x+" "+PointIntersectionY(x, b1,k1));