
Console.WriteLine("Введите размеры двух матриц и диапазон случайных значений:");
Console.Write ("Введите число строк матриц: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов матриц: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите диапозон случайных чисел от 1 до ");
int num = Convert.ToInt32(Console.ReadLine());

int[,] array1 = new int[m, n];
Console.WriteLine("Это первая матрица");
for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array1.GetLength(1); j++)
    {
        array1[i, j] = new Random().Next(1, num);

        Console.Write($"{array1[i, j]} ");
       

    }
    Console.WriteLine();
}
Console.WriteLine();
int a =m;
int b = n;
int[,] array2 = new int[a, b];
Console.WriteLine("Это вторая матрица");
for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        array2[i, j] = new Random().Next(1, num);

        Console.Write($"{array2[i, j]} ");
       

    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Это произведение двух матриц: ");

int r = m;
int t = b; 
int[,] result =  new int[r,t];


for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < array1.GetLength(1); k++)
      {
        sum += array1[i,k] * array2[k,j];
        
      }
      result[i,j] = sum;
    Console.Write($"{sum} ");
    }
    Console.WriteLine();
  }


