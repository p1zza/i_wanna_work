using System;
/*
 * Задание:
Напишите библиотеку для поставки внешним клиентам, 
которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. 
Дополнительно к работоспособности оценим:

Юнит-тесты
Легкость добавления других фигур
Вычисление площади фигуры без знания типа фигуры
Проверку на то, является ли треугольник прямоугольным
 */
namespace Work
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Программа умеет считать площадь треугольника по высоте и основанию, \n" +
                                  "Площадь круга по его радиусу, \n" +
                                  "Может проверить реальность треугольника по его 3м сторонам. \n" +
                                  "Хотите начать работу? Y or N");
                if (Console.ReadLine().ToUpper().Contains("Y"))
                {
                    Console.WriteLine("Введите значения, которые у вас есть. \n" +
                                      "Для вычисления площади круга нужно ввести одно значение," +
                                      "Проверить реальность треугольника и посчитать его площадь - три. \n" +
                                      "Пример ввода: '1 4 5  / 1' \n");
                    string vvod = Console.ReadLine();
                    string[] mass = vvod.Split(' ', '\n', '\t');
                    if ((mass.Length > 3)|| (mass.Length < 1))
                    {
                        throw new Exception("Неверная длина ввода");
                    }
                    if (mass.Length == 3)
                    {
                        double a = Convert.ToDouble(mass[0]);
                        double b = Convert.ToDouble(mass[1]);
                        double c = Convert.ToDouble(mass[2]);
                        if (Biblio.IsTriangleReal(a, b, c))
                        {
                            Console.WriteLine("Для введённой последовательности значений можно построить треугольник\n");

                            Console.WriteLine("Его площадь по 3м сторонам будет равна: {0} \n", Biblio.Triangle_Area(a, b, c));
                        }
                        else
                        {
                            Console.WriteLine("Треугольник построить нельзя\n");
                        }
                    }
                    if (mass.Length == 1)
                    {
                        Console.WriteLine("Площадь круга равна {0}", Biblio.Circle_area(Convert.ToDouble(mass[0])));
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода строки. Попробуйте снова. \n");
                        Main();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Main();
            }
            Console.ReadKey();
        }
    }
}
