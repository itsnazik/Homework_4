// Напишите метод, который принимает на вход число и выдает сумму цифр в числе
 
static int Sum(int value)
        {
            int result = 0;
            result += value % 10;
            value /= 10;
            if(value > 0)
            {
                result += Sum(value);
            }
            return result;
        }

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sum(number));
