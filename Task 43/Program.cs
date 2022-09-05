// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Task_43();

void Task_43()
{
    Console.WriteLine("Задача 43. Вычисление точки пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2.");

    Console.Write("Введите значение b1: ");
    double coeff_B1 = double.Parse(Console.ReadLine()!);
    Console.Write("Введите значение k1: ");
    double coeff_K1 = double.Parse(Console.ReadLine()!);
    Console.Write("Введите значение b2: ");
    double coeff_B2 = double.Parse(Console.ReadLine()!);
    Console.Write("Введите значение k2: ");
    double coeff_K2 = double.Parse(Console.ReadLine()!);

    double coordinateX = (coeff_B2 - coeff_B1) / (coeff_K1 - coeff_K2);
    double coordinateY = coeff_K1 * coordinateX + coeff_B1;

    Console.Write($"b1 = {coeff_B1}, k1 = {coeff_K1}, b2 = {coeff_B2}, k2 = {coeff_K2} -> ({coordinateX}; {coordinateY})");
}