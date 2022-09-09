// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите число: ");
 int N = Convert.ToInt32(Console.ReadLine());
 for (int i=1; 1<=10; i++)
 {
    for (int j =1; j <= N; j++)
    {
        Console.WriteLine($"{Math.Pow(j,3)}, "); 
    }
   
     Console.WriteLine(" ");
 break;
  }   




