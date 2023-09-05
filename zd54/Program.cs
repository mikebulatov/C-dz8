Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");


Console.Write("Введите первую размерность массива:");
int i=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую размерность массива:");
int j=Convert.ToInt32(Console.ReadLine());

int [,] matrix=new int [i,j];

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

float summ;
Console.Write("Среднее арифметическое каждого столбца:");
for(i=0; i<matrix.GetLength(1); i++)
{
  summ=0;
    for(j=0; j<matrix.GetLength(0); j++)
    {
    summ=summ+matrix[j,i];
    
    }
   Console.Write("{0:f1} ", summ/matrix.GetLength(1));
}
Console.WriteLine();
