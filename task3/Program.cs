// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

int GetNumberFromConsole(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5);
        }
    }
}

void PrintArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine(" ");
    }
}

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int product = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                product = firstMartrix[i, j] * secomdMartrix[i, j];
            }
            resultMatrix[i, j] = product;
        }
    }
}


int m = GetNumberFromConsole("Введите размерность массивов. Количество строк: ");
int n = GetNumberFromConsole("Введите размерность массивов. Количество столбцов: ");
int[,] firstMartrix = new int[m, n];
int[,] secondMartrix = new int[m, n];
int[,] resultMatrix = new int[m, n];
FillArrayRandomNumbers(firstMartrix); /// заполняем массив определенного размера
PrintArrayRandomNumbers(firstMartrix); /// выводим на экран  массив случайных чисел
FillArrayRandomNumbers(secondMartrix); /// заполняем массив определенного размера
Console.WriteLine("умножить");
PrintArrayRandomNumbers(secondMartrix); /// выводим на экран  массив случайных чисел
MultiplyMatrix(firstMartrix, secondMartrix, resultMatrix); /// выводим на экран произведение двух массивов
Console.WriteLine("их произведение будет равно следующему массиву:");
PrintArrayRandomNumbers(resultMatrix);