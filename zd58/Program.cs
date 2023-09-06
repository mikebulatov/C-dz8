Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");


Console.Write("Введите первую размерность превой матрицы:");
int i=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую размерность превой матрицы и первую второй:");
int j=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую размерность второй матрицы :");
int k=Convert.ToInt32(Console.ReadLine());


int [,] matrixA=new int [i,j];
int [,] matrixB=new int [j,k];
//формируем матрицы
Console.WriteLine("Сформированна матрица А:");
for(i=0; i<matrixA.GetLength(0); i++)
{
    for(j=0; j<matrixA.GetLength(1); j++)
    {
    matrixA[i,j]= new Random().Next(0,10);
     Console.Write("{0:D2} ", matrixA[i,j]);
    
    }
    Console.WriteLine();
}
Console.WriteLine("Сформированна матрица В:");
for(i=0; i<matrixB.GetLength(0); i++)
{
    for(j=0; j<matrixB.GetLength(1); j++)
    {
    matrixB[i,j]= new Random().Next(0,10);
     Console.Write("{0:D2} ", matrixB[i,j]);
    
    }
    Console.WriteLine();
}
//считаем матриц С (Произведение матриц А и В) и вывыодим её содержимое
Console.WriteLine("Произведение матриц А и В:");
int [,] matrixC=new int [matrixA.GetLength(0),matrixB.GetLength(1)];;
for(i=0; i<matrixC.GetLength(0); i++)
{
    for(j=0; j<matrixC.GetLength(1); j++)
    {
      for(k=0; k<matrixA.GetLength(1); k++)
      {
      matrixC[i,j]=matrixC[i,j]+matrixA[i,k]*matrixB[k,j];  
      }
  
      Console.Write("{0:D3} ", matrixC[i,j]);
    }
   Console.WriteLine();
}



