// Написать программу, которая вычисляет математическое выражение по исходным значениям данных, вводимых
// пользователем. Ответ округлите до 3 знаков после запятой.
//
//              y^2 + 6 + cos(x^3) + xy - 2x^2    
//   z = e^x - ---------------------------------
//                sin(x^4 + 13) + 9y - 2

using Tyuiu.TaranIV.Sprint1.Task7.V25.Lib;

DataService ds = new DataService();
double x, y, e, result;

Console.Title = "Спринт #1 | Выполнил: Таран И. В. | ПКТб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
Console.WriteLine("* Задание #1.7                                                            *");
Console.WriteLine("* Вариант #25                                                             *");
Console.WriteLine("* Выполнил: Таран Иван Владимирович | ПКТб-26-1                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                   *");
Console.WriteLine("* Ответ округлить до 3 знаков после запятой.                              *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите значение x: ");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение y: ");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение e: ");
e = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

result = Math.Pow(e, x) - ds.Calculate(x, y);
Console.WriteLine("Результат математического выражения: " + Math.Round(result, 3));