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
//функция сортировки двумерного массива по строкам
int[,] sort_array_int (int count_line, int count_column, int [,]A)
{
    int temp;
    for (int s=0; s<count_line;s++)
    {
        //сортируем пузырьком по каждой строке
        for (int i=0;i<count_column-1;i++)
        {
            for (int j=0;j<count_column-i-1;j++)
            {
                if(A[s,j] < A[s,j+1])
                {
                    temp=A[s,j];
                    A[s,j] = A[s,j+1];
                    A[s,j+1] = temp;
                }
            }
        }

    }
    return A;
}



    /*
    Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    В итоге получается вот такой массив:
    7 4 2 1
    9 5 3 2
    8 4 4 2
    */
    
    int count_line;
    int count_column;
  
    Console.WriteLine("Введите количество строк");
    count_line = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов");
    count_column = Convert.ToInt32(Console.ReadLine());
    int[,] A = create_array_int(count_line,count_column);
    Console.WriteLine("Исходный массив:");
    print_array_int (count_line,count_column,A);
    A = sort_array_int(count_line, count_column,A);
    Console.WriteLine("Отсортированный массив:");
    print_array_int (count_line,count_column,A);
    


   