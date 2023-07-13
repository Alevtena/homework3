// Task1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool Palindrom(int n)
{
    int num = n;
    int rezult = 0;
    while ( n > 0 )
    {
        int dig = n % 10;
        rezult = rezult*10 + dig;
        n = n / 10;
    }
    if (num == rezult) return true;
    else return false;
}
Console.Write("Input number:" + " ");
int number  = Convert.ToInt32(Console.ReadLine()); 
if (Palindrom(number) == true) Console.WriteLine(number +" " + "Yes, this is palindrom");
else Console.WriteLine($"{number}  No, this is not palindrom");


// Task2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

/* double Distans (int x1, int x2, int y1, int y2, int z1, int z2)
{
    int x = (x2-x1)*(x2-x1);
    int y = (y2 -y1)*(y2-y1);
    int z = (z2 - z1)*(z2-z1);
    double result = Math.Round(Math.Sqrt(x+y+z),2);
    return result;

}

Console.Write ("Input x1 "+" ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input y1 "+" ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input z1 "+" ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input x2 "+" ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input y2 "+" ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input z2 "+" ");
int z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Distans(x1,x2,y1,y2,z1,z2));


// Task3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/* void TablCub(int N)
{
    int count = 1;
    while( count <= N)
    {
        Console.WriteLine($"{count} - {count*count*count}");
        count++;
    }
}
Console.Write("Input number:" + " ");
int N = Convert.ToInt32(Console.ReadLine());
TablCub(N);
*/