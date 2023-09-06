Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");


Console.Write("Введите первую размерность массива:");
int i=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую размерность массива:");
int j=Convert.ToInt32(Console.ReadLine());

int [,] matrix=new int [i,j];
//формируем массиы
Console.WriteLine("Сформированный массив:");
for(i=0; i<matrix.GetLength(0); i++)
{
    for(j=0; j<matrix.GetLength(1); j++)
    {
    matrix[i,j]= new Random().Next(0,10);
     Console.Write("{0:D2} ", matrix[i,j]);
    
    }
    Console.WriteLine();
}

//сортируем строки массива
for(i=0; i<matrix.GetLength(0); i++)
{
  
    for(j=0; j<matrix.GetLength(1); j++)
    {
      for(int k=j+1; k<matrix.GetLength(1); k++)
      if(matrix[i,k]>matrix[i,j])
      {
       matrix[i,j]=matrix[i,j]+matrix[i,k];
       matrix[i,k]=matrix[i,j]-matrix[i,k];
       matrix[i,j]=matrix[i,j]-matrix[i,k];
      }
    
    
    }
   
}
//Выводим упорядоченный массив
Console.WriteLine("Упорядоченный массив:");
for(i=0; i<matrix.GetLength(0); i++)
{
  for(j=0; j<matrix.GetLength(1); j++)
    {
     Console.Write("{0:D2} ", matrix[i,j]);
    }
    Console.WriteLine();
}

Console.WriteLine();
