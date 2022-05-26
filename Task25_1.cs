/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

double GetPowerOfNumber(int firstNumb, int secondNumb)
{
    double power = Math.Pow(firstNumb, secondNumb);
    
    return power;
}

Console.WriteLine("Введите число:");

int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень в которую возвести число:");

int power = Convert.ToInt32(Console.ReadLine());

double result = GetPowerOfNumber(number, power);

Console.WriteLine($"Результат: {result}");