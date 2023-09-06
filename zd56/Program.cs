Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");


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
int SumStrMin=10*matrix.GetLength(1);
int StrNumMin=0;
for(i=0; i<matrix.GetLength(0); i++)
{
  int SumStr=0;
    for(j=0; j<matrix.GetLength(1); j++)
    {
      SumStr=SumStr+matrix[i,j];
    }
  if (SumStr<SumStrMin)
  {
    SumStrMin=SumStr;
    StrNumMin=i;
  }
}

Console.WriteLine($" Строка № {StrNumMin+1} имеет наименьшую сумму элементов");

