using System.Globalization;
using Tyuiu.TaranIV.Sprint1.Task5.V5.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Таран И. В. | ПКТб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
Console.WriteLine("* Задание #1.5                                                            *");
Console.WriteLine("* Вариант #5                                                             *");
Console.WriteLine("* Выполнил: Таран Иван Владимирович | ПКТб-26-1                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные  *");
Console.WriteLine("* выполняет указанные расчёты, присваивает значение другой переменной и   *");
Console.WriteLine("* печатает результат на экране                                            *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите значение x в формате вещественного числа: ");

string input = Console.ReadLine().Replace(',', '.');

if (double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out double x))
{
    int d = ds.Calculate(x);

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine("Значение переменной d: " + d);
}
else
{
    Console.WriteLine("Ошибка: введено не число.");
}

