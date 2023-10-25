//int[,] arr = {  { 1, 2, 3, 4, 5 },
//                            { 6, 7, 8, 9, 10 },
//                            { 11, 12, 13, 14, 15 },
//                            { 16, 17, 18, 19, 20 },
//                            { 21, 22, 23, 24, 25 }
//            };

//int maxUpper = 0, minUnder = int.MaxValue;
//int iMax = 0, jMax = 0, iMin = 0, jMin = 0;

//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for (int j = 0; j < arr.GetLength(1); j++)
//    {
//        Console.Write($"{arr[i, j]}\t");
//        if (j > i && arr[i, j] > maxUpper)
//        {
//            maxUpper = arr[i, j];
//            iMax = i;
//            jMax = j;
//        }
//        else if (j < i && arr[i, j] < minUnder)
//        {
//            minUnder = arr[i, j];
//            iMin = i;
//            jMin = j;
//        }
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
//Console.WriteLine("\nМассив после замены:\n");

//(arr[iMax, jMax], arr[iMin, jMin]) = (arr[iMin, jMin], arr[iMax, jMax]);

//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for (int j = 0; j < arr.GetLength(1); j++)
//    {
//        Console.Write($"{arr[i, j]}\t");
//    }
//    Console.WriteLine();
//}





using System.Runtime.InteropServices;
int i, j, k, n, m, itmp;
double tmp;
Console.WriteLine("Введите число строк матрицы: ");
n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов матрицы: ");
m = Convert.ToInt32(Console.ReadLine());
int[] imin = new int[n];            
double[,] arr = new double[n, m];      
Console.WriteLine("элементы: ");
for (i = 0; i < n; ++i)
{
    for (j = 0; j < m; ++j)         //вводим строку
    {
        Console.WriteLine("arr[" + i + "][" + j + "] = ");
        arr[i, j] = Convert.ToDouble(Console.ReadLine());
    }
}
Console.WriteLine("");
Console.WriteLine("исходная матрица: ");
for (i = 0; i < n; ++i)
{
    for (j = 0; j < m; ++j)
        Console.Write(arr[i, j] + "\t");
    Console.WriteLine("");
}
for (i = 0; i < n; ++i)             
{
    imin[i] = 0;                    
    for (j = 1; j < m; ++j)        
    {
        if (arr[i, j] < arr[i, imin[i]])
            imin[i] = j;            
    }
}

for (i = 0; i < n - 1; ++i)         
{
    for (j = i + 1; j < n; ++j)
    {
        if (arr[i, imin[i]] > arr[j, imin[j]])  
        {
            for (k = 0; k < m; ++k)             
            {
                tmp = arr[i, k];
                arr[i, k] = arr[j, k];
                arr[j, k] = tmp;
            }
            itmp = imin[i];                 
            imin[i] = imin[j];
            imin[j] = itmp;
        }
    }
}
Console.WriteLine("конечная матрица:");
for (i = 0; i < n; ++i)
{
    for (j = 0; j < m; ++j)
        Console.Write(arr[i, j] + "\t");
    Console.WriteLine("");
}
namespace GitApp
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Wtriteline('Hello');
        }
    }
}