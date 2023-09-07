Console.WriteLine("Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");


Console.Write("Введите первую размерность массива:");
int i=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую размерность массива:");
int j=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третью размерность массива:");
int k=Convert.ToInt32(Console.ReadLine());

int [,,] matrix=new int [i,j,k];
//формируем массив
int num=10;
for(i=0; i<matrix.GetLength(0); i++)
for(j=0; j<matrix.GetLength(1); j++)
for(k=0; k<matrix.GetLength(2); k++)
{
matrix[i,j,k]=num;
num=num+1;
Console.WriteLine("{0:D2}({1:D},{2:D},{3:D}) ", matrix[i,j,k],i,j,k);
}
//Console.WriteLine();


