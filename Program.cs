// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void sravn (int num)
{
if (((num / 10000) == (num % 10)) && ((num/1000)%10) == ((num%100)/10))
    Console.WriteLine($"Число {num} полиндром");    
else Console.WriteLine($"Число {num} не полиндром");
}

Console.Write("Введите число: ");
int user_number = Convert.ToInt32(Console.ReadLine());
sravn(user_number);



// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


double LongLineAB (int xA, int xB, int yA, int yB, int zA, int zB)
{
    double longLine = Math.Sqrt((xB-xA)*(xB-xA)+(yB-yA)*(yB-yA)+(zB-zA)*(zB-zA));
    longLine = Math.Round(longLine, 2);
    return longLine;
}

Console.WriteLine("Введите X координаты точки А: ");
int xCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y координаты точки А: ");
int yCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z координаты точки А: ");
int zCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите X координаты точки B: ");
int xCoordB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y координаты точки B: ");
int yCoordB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z координаты точки B: ");
int zCoordB = Convert.ToInt32(Console.ReadLine());

double dist = LongLineAB(xCoordA, xCoordB, yCoordA, yCoordB, zCoordA, zCoordB);
Console.WriteLine($"Расстояние между точками А и В равно {dist}");



// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


void ThirdDegree(int numberN)
{
    int current = 1;
    while (current <= numberN)
    {
        double res = Math.Pow(current, 3);
        Console.Write($"{res:f0}, ");
        current++;
    }
    Console.WriteLine("\b\b.");
}

void ThirdDegreeNeg(int numberN)
{
    int current = 1;
    while (current >= numberN)
    {
        double res = Math.Pow(current, 3);
        Console.Write($"{res:f0}, ");
        current--;
    }
    Console.WriteLine("\b\b.");
}

Console.Write("Введите число: ");
int user_number = Convert.ToInt32(Console.ReadLine());

if (user_number > 0)
{
    ThirdDegree(user_number);
}
else
ThirdDegreeNeg(user_number);
