Console.WriteLine("Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.");

int [,] matrixA=new int [4,4];
//формируем матрицы
int k=0;
for(int i=0; i<matrixA.GetLength(0); i++)
{
    k=k+1;
    matrixA[0,i]=k;
}
for(int i=1; i<matrixA.GetLength(1); i++)
{
    k=k+1;
    matrixA[i,3]=k;
}

for(int i=2; i>=0; i--)
{
    k=k+1;
    matrixA[3,i]=k;
}
for(int i=matrixA.GetLength(1)-1; i>0; i--)
{
    k=k+1;
    matrixA[i,0]=k;
}
for(int i=1; i<matrixA.GetLength(0)-1; i++)
{
    k=k+1;
    matrixA[1,i]=k;
}
for(int i=matrixA.GetLength(0)-2; i>0; i--)
{
    k=k+1;
    matrixA[2,i]=k;
}


Console.WriteLine("Сформированна матрица:");
for(int i=0; i<matrixA.GetLength(0); i++)
{
    for(int j=0; j<matrixA.GetLength(1); j++)
    {

     Console.Write("{0:D2} ", matrixA[i,j]);
    
    }
    Console.WriteLine();
}



