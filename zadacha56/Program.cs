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

//функция поиска строки в массиве с минимальной суммой элементов в строке
int stroka_s_min_sum (int count_line, int count_column,int [,]A)
{
    int index_str_min=0;
    int sum_str_min=0;
    int temp_sum=0;
    for(int i=0;i<count_line;i++)
    {
        for (int j = 0; j < count_column; j++)
        {
            temp_sum = +A[i,j];
        }
        //Console.WriteLine("temp_sum=="+temp_sum);
        if (temp_sum<sum_str_min)
        {
            index_str_min=i;
            sum_str_min=temp_sum;
        }
        temp_sum=0;
    }
    return index_str_min;
}

 

    /*
    Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
    которая будет находить строку с наименьшей суммой элементов.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    5 2 6 7
    Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
    int result = stroka_s_min_sum(count_line,count_column,A);
    Console.WriteLine("Индекс строки с наименьшей суммой элементов по строке: "+result);


   
    
   
   
