using System;

public class Program
{
    public static void Main()
    {
        //Console.WriteLine("Hello World");
        int rows, columns;
        Random r = new Random();
        double p=0.2;
        char[,] A;
        Console.WriteLine("введите количество строк");
        rows= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите количество столбцов");
        columns = Convert.ToInt32(Console.ReadLine());
        A= new char[rows,columns];
        for(int i=0; i<rows;i++)
        {
            for(int j=0; j<columns; j++)
            {
                if(r.Next(0,5)==2)
                A[i,j]='*';
                else
                A[i,j]=' ';
            }
        }
        VisualiseArray(A);
        FF(A, ' ','x', 1,2);
        Console.WriteLine();
        VisualiseArray(A);
    }

    public static void FF(char[,] array, char coin, char cout, int x, int y)
    {
        if(x >= 0 && x < array.GetLength(0) && y>=0 && y< array.GetLength(1) && array[x,y] == coin)
        {
            array[x,y] = cout;
            FF(array, coin, cout, x-1, y);
            FF(array, coin, cout, x+1, y);
            FF(array, coin, cout, x, y-1);
            FF(array, coin, cout, x, y+1);
        }
    }

    public static void VisualiseArray(char[,] array){
            for(int i=0; i<array.GetLength(0); i++){
                for(int j=0; j<array.GetLength(1);j++)
                {
                    Console.Write(array[i,j]);
                }
                Console.WriteLine();
            }
    }
}