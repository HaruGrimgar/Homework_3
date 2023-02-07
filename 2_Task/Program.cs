/* Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.  */
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

 double[] GetPointCordinates(string message)
 {
    double[] result = {0, 0, 0};
    Console.Write($"Введите координату x {message} -> ");
    result[0] = Convert.ToDouble(Console.ReadLine()); // 0 индекс - x координата
    Console.Write($"Введите координату y {message} -> ");
    result[1] = Convert.ToDouble(Console.ReadLine()); // 1 индекс - y координата
    Console.Write($"Введите координату z {message} -> ");
    result[2] = Convert.ToDouble(Console.ReadLine()); // 1 индекс - z координата
    return result;
 }

double[] FirstPoint = GetPointCordinates("первой точки");
double[] SecondPoint = GetPointCordinates("второй точки");

Console.WriteLine(); // только для вывода удобного
Console.WriteLine($"Первая точка ({FirstPoint[0]},{FirstPoint[1]},{FirstPoint[2]}) " +
$"Вторая точка ({SecondPoint[0]},{SecondPoint[1]},{SecondPoint[2]}) ");

double result = Math.Sqrt( Math.Pow(FirstPoint[0] - SecondPoint[0], 2) + Math.Pow(FirstPoint[1] - SecondPoint[1], 2) 
+ Math.Pow(FirstPoint[2] - SecondPoint[2], 2));
Console.WriteLine($"Расстояние между точками  = {Math.Round(result, 2)}");