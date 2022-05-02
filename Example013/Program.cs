
/*
string [,] table = new string[2, 5]; 
table[1,2]="слово";

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.Write($"-{table[rows, columns]}-");
    }
}
*/

/*
void PrintArray(int [,] matr )
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            Console.Write($"{matr[rows, columns]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
        matr[rows, columns] = new Random().Next(1,10);
        }
    
    }
}

int[,] matrix = new int[3, 4];
PrintArray (matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray (matrix);

*/



//////////
/*
int[,] pic = new int[23, 25];


void PrintImage(int[,] image)
{
    for (int rows = 0; rows < image.GetLength(0); rows++)
    {
        for (int columns = 0; columns < image.GetLength(1); columns++)
        {
            //Console.Write($"{image[rows, columns]} ");
            if (image[rows, columns] == 0) Console.Write(" ");
            else Console.Write("+");
        }
        Console.WriteLine();
    }
}

void FillImage(int row, int col)
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}




PrintImage(pic);
FillImage (13,13);
PrintImage(pic);

*/

/*
 double Factorial(int n)
{
    //1!=1
    //0!=!
    if (n == 1) return 1;
    else return n* Factorial(n-1);

}

Console.WriteLine(Factorial(40));

*/


// f(1)=1
// f(2)=1
// f(n-1) + f(n-2)

/*
double Fibonacci(int n)
{
    if (n==1 || n==2) return 1;
    else 
        return Fibonacci(n-1) + Fibonacci(n-2);
}
int i = 30;
 Console.WriteLine($"f{i}  " + Fibonacci(i));

for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f{i}  " + Fibonacci(i));
}

*/



