using Tyuiu.TaranIV.Sprint1.Task2.V21.Lib;

DataService ds = new DataService();

int x, y;

Console.Title = "Спринт #1 | Выполнил: Таран И. В. | ПКТб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
Console.WriteLine("* Задание #1.2                                                            *");
Console.WriteLine("* Вариант #21                                                             *");
Console.WriteLine("* Выполнил: Таран Иван Владимирович | ПКТб-26-1                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные  *");
Console.WriteLine("* и вычисляет площадь прямоугольника.                                     *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите значение x:");
x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение y:");
y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Площадь прямоугольника равна:" + ds.CalculateRectangleSquare(x,y));

