/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

int InputInt(string message)
{
    Console.Write($"{message} -> ");
    return Convert.ToInt32(Console.ReadLine());
}

int N = InputInt("Введите число N");
int i = 1;
while (i <= N)
{
    Console.Write($"{Math.Pow(i, 3)} ");
    i++;
}

