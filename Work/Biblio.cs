namespace Work
{
    /// <summary>
    ///  Класс содержит в себе функции для вычисления площади геометрических фигур.
    /// </summary>
    public class Biblio
    {
        private const double pi = 3.1415926535897932384626433832795028841971693993751058209749445923078164062862089986280348253421170679;
        /// <summary>
        /// Метод Сircle_area вычисляет площаль круга через его радиус.
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        public static double Circle_area(double radius){return pi * pi * radius;}
        /// <summary>
        /// Метод Еriangle_area вычисляет площаль треугольника через его основание и высоту.
        /// </summary>
        /// <param name="height">Высота треугольника</param>
        /// <param name="_base">Длина основания треугольника</param>
        public static bool IsTriangleReal(double a, double b, double c)
        {
            double sqrA = GetDegree(a, 2);
            double sqrB = GetDegree(b, 2);
            double sqrC = GetDegree(c, 2);
            if ((sqrA + sqrB == sqrC) || (sqrC + sqrB == sqrA) || (sqrA + sqrC == sqrB))
            { return true; }
            else
            { return false; }
        }

        public static double Triangle_Area(double a,double b, double c)
        {
            double P = (a + b + c) / 2;
            double S = P * (P - a) * (P - b) * (P - c);
            return System.Math.Sqrt(S);
        }

        private static double GetDegree(double num,double degree)
        {
            return System.Math.Pow(num,degree);
        }

    }
}
