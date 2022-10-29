//функция создания двумерного целочисленного массива и заполнение его рандомными числами
int [,] create_array_int (int count_line, int count_column)
{
    int[,] A = new int[count_line,count_column];
    Random random = new Random();
    for (int i = 0; i < count_line; i++)
    {
        for (int j = 0; j < count_column; j++)
        {
            A[i, j] = (int)random.Next(-10, 10);
        }
    }
    return A;
}

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

//функция умножения 2х массивов
int [,] multiplication_array (int count_line_a1, int count_column_a1,int [,]A1,int count_line_a2, int count_column_a2,int [,]A2)
{
    int[,] C = new int[count_line_a1,count_column_a2];

    for (int i = 0; i < count_line_a1; i++)
    {
        for (int j = 0; j < count_column_a2; j++)
        {
            C[i, j] = 0;
            for (int k=0;k<count_column_a1;k++)
            {
                C[i,j]+=A1[i,k]*A2[k,j];
            }
        }
    }
    return C;
}



   

    /*
    Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
    Например, даны 2 матрицы:
    2 4 | 3 4
    3 2 | 3 3
    Результирующая матрица будет:
    18 20
    15 18
    */  
    
    int count_line_a1;
    int count_column_a1;
    int count_line_a2;
    int count_column_a2;
    Console.WriteLine("Укажите параметры для первой матрицы");
    Console.WriteLine("Введите количество строк");
    count_line_a1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов");
    count_column_a1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Укажите параметры для второй матрицы");
    Console.WriteLine("Введите количество строк");
    count_line_a2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов");
    count_column_a2 = Convert.ToInt32(Console.ReadLine());
    if (count_column_a1==count_line_a2)
    {
        //создаем массивы
        int[,] A1 = create_array_int(count_line_a1,count_column_a1);
        Console.WriteLine("Первая матрица такая:");
        print_array_int (count_line_a1,count_column_a1,A1);
        int[,] A2 = create_array_int(count_line_a2,count_column_a2);
        Console.WriteLine("Первая матрица такая:");
        print_array_int (count_line_a2,count_column_a2,A2);
        int[,] C = multiplication_array(count_line_a1,count_column_a1,A1,count_line_a2,count_column_a2,A2);
        Console.WriteLine("Результат умножения матрица такая:");
        print_array_int (count_line_a1,count_column_a2,C);
    }
    else 
    Console.WriteLine("Умножение не возможно");
    
    