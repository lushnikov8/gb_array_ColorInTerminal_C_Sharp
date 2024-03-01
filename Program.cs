//Инфу по изменению вида символов в терминале взял тут:
//https://habr.com/ru/articles/94647/
//Console.WriteLine("\x1b[31mTest\x1b[0m");
//отмена форматирования ключ \x1b[0m

int[,] Array2merRandomInput (int m, int n)
{
    int[,] arr = new int[m,n];
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++) arr[i,j] = new Random().Next(10,100);
    }

    return arr;
}

void PrintMainDiagonal(int[,] arryPrintMainDiagonal, String FormatStr)
{
  for (int i = 0; i < arryPrintMainDiagonal.GetLength(0); i++)
  {
    for (int j = 0; j < arryPrintMainDiagonal.GetLength(1); j++)
    {
        if (i == j) Console.Write($"{FormatStr}{arryPrintMainDiagonal[i,j]}\x1b[0m \t");
        else Console.Write($"\x1b[30m{arryPrintMainDiagonal[i,j]}\x1b[0m\t");
    }
    Console.WriteLine();
  }
}


// Console.Write("Введите размерность м:");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите размерность м:");
// int n = Convert.ToInt32(Console.ReadLine());

//int[,] arr = Array2merRandomInput(m,n);

int[,] arr = Array2merRandomInput(7,7);

int[] ColorTextFont = {1,4,5,7,8,30,31,32,33,34,35,36,37,41,42,43,44,45,46,47};


foreach (var item in ColorTextFont)
{
    Console.WriteLine();
    Console.WriteLine($"-----\x1b[{item}m-------------параметр: {item} '\\x1b[{item}m' -----------------\x1b[0m-----");
    PrintMainDiagonal(arr, $"\x1b[{item}m");
}

// Console.WriteLine($"------------------параметр: {47}-----------------------");
// PrintMainDiagonal(arr, $"\x1b[{47}m");
