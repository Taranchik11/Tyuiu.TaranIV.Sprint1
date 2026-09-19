using Tyuiu.TaranIV.Sprint1.Task3.V12.Lib;

DataService ds = new DataService();
double x, y;

Console.Title = "Спринт #1 | Выполнил: Таран И. В. | ПКТб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
Console.WriteLine("* Задание #1.3                                                            *");
Console.WriteLine("* Вариант #12                                                             *");
Console.WriteLine("* Выполнил: Таран Иван Владимирович | ПКТб-26-1                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные  *");
Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите значение первого катета:");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение второго катета:");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Площадь прямоугольного треугольника равна:" + ds.TriangleArea(x, y));
Console.ReadKey();

