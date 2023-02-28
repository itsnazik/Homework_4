// Задача 25: Напишите метод, который принимает на вход два числа A и B и возводит число А в натуральную степень В. 

int Pow(int A, int B)
{
    int result = 1;
    while (B != 0)
    {
        if ((B & 1) == 1)
            result *= A;
        A *= A;
        B >>= 1;
    }
    return result;
}

Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Pow(A, B));
