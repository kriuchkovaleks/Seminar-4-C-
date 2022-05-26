/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int GetSummOfDigits(string str)
{
    int number = int.Parse(str);
    int digit  = 0;
    int result = 0;
    
    while (number > 0)
    {
        digit = number % 10;
        number = number / 10;
        
        result = result + digit; 
    }

    return result;
}


Console.WriteLine("Input number");
string Number  = Console.ReadLine();

int Result = GetSummOfDigits(Number);

Console.WriteLine(Result);

