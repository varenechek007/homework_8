
//функция создания 3х мерного массива целочисленного и заполнение случайными значениями
int [,,] create_3_array (int x, int y, int z)
{
    int [,,]A = new int [x,y,z];
    Random random = new Random();
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for(int k=0; k < z; k++)
            {
                A[i,j,k] = (int)random.Next(-10, 10);
            }
        }
    }

    return A;
}
//метод вывода трехмерного целочисленного массива
void print_array_3 (int x, int y, int z, int [,,]A)
{
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                Console.Write("Элемент на позиции i:" +i);
                Console.Write(" j:" +j);
                Console.Write(" k:" +k);
                Console.Write(" Значение: ");
                Console.Write(A[i, j,k] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
            
        }
    Console.WriteLine();
    }
}


 
    /*
    Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
    Массив размером 2 x 2 x 2
    66(0,0,0) 25(0,1,0)
    34(1,0,0) 41(1,1,0)
    27(0,0,1) 90(0,1,1)
    26(1,0,1) 55(1,1,1)
    */

    int x;
    int y;
    int z;
    Console.WriteLine("Укажите параметры для 3x мерной матрицы");
    Console.WriteLine("Введите количество x");
    x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество y");
    y = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество z");
    z = Convert.ToInt32(Console.ReadLine());
    int [,,]A=create_3_array(x,y,z);
    print_array_3(x,y,z,A);


   