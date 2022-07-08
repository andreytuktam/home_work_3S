/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да


int numberA = new Random().Next(10000, 99999);
//int numberA = 12321;
Console.WriteLine(numberA);
string numberB = numberA.ToString();
int dlina = numberB.Length;
int n = 0;
if (dlina == 5)
{
    int A1 = numberA / 10000;
    n = numberA % 10000;
    int A2 = n / 1000;
    n = n % 1000;
    int A3 = n / 100;
    n = n % 100;
    int A4 = n / 10;
    int A5 = n % 10;
    
    if (A1 == A5 && A2 == A4)
    {
        Console.WriteLine(numberA + " - является палиндромом");    
    }
    else
    {
        Console.WriteLine(numberA + " - не является палиндромом");   
    }       
}
else
{
    Console.WriteLine(numberA + " - число не пятизначное");
}

Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53



double dlinaAB (double X1, double Y1, double Z1, double X2, double Y2, double Z2)
{   
    double result = 0;
    if (X1 == X2 && Y1 == Y2 && Z1 == Z2)
    {
        return result;
    }
    else
    {
        result = Math.Sqrt((Math.Pow(X2 - X1, 2)) + (Math.Pow(Y2 - Y1, 2)) + (Math.Pow(Z2 - Z1, 2)));
        return result;
    }
}
double AB = dlinaAB (3, 6, 8, 2, 1, -7);
Console.WriteLine(AB);


Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int[] kub(int N)
{   
    int[] A = new int[N];
    for (int i = 1; i <= N; i++)
    {
        A[i - 1] = i * i * i;
        Console.WriteLine(A[i - 1]);
              
    }
    return A; 
}

int[] result = kub (5);


