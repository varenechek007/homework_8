

//метод вывода двумерного целочисленного массива
void print_array_int (int count_line, int count_column, int [,]A)
{
    for (int i = 0; i < count_line; i++)
    {
        for (int j = 0; j < count_column; j++)
        {
            Console.Write(A[i, j] + " ");
        }
    Console.WriteLine();
    }
}

//функция создания и заполнения квадратной матрицы спирально
int [,] create_array_spiral(int count)
{
    int[,] A = new int[count,count];
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= count * count)
    {
        A[i, j] = temp;
        temp++;
        //определяем куда идти
        if (i <= j + 1 && i + j < count - 1)
            j++;
        else if (i < j && i + j >= count - 1)
            i++;
        else if (i >= j && i + j > count - 1)
            j--;
        else
            i--;
    }

    return A;
}


    /*
    Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
    Например, на выходе получается вот такой массив:
    01 02 03 04
    12 13 14 05
    11 16 15 06
    10 09 08 07
    */
    int count;
    Console.WriteLine("Введите количество строк в квадратной матрице");
    count = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Матрица 4х4 заполенная спирально");
    int[,] A = create_array_spiral(count);
    print_array_int(count,count,A);
