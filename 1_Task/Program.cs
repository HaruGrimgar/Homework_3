/* Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
 Не использовать строки ;(( */
int InputInt(string message)
{
    Console.Write($"{message} -> ");
    return Convert.ToInt32(Console.ReadLine());
}

Boolean Length_check(int number)
{
    if (9999 < number && number < 100000)   // в C#  9999 < number < 100000 - выдаёт ошибку
        return true; 
    else 
        return false;
}

int number = InputInt("Введите пятизначное число");

if ( Length_check(number) )
{
    if ( (number / 10000 == number % 10) && ( number / 1000 % 10 == number % 100 / 10) )
    {
        Console.WriteLine("Число являеться палиндромом");
    }
    else  Console.WriteLine("Число не являеться палиндромом");
}
else Console.WriteLine("Введённое число не пятизначное");

