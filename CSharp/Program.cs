using System.ComponentModel.Design;
using System.Text;

namespace CSharp
{
    internal class Program
    {
        class Fraction
        {
            public int numerator;
            public int denominator;

            static int GreatestCommonDivisor(int a, int b)
            {
                while (b != 0)
                {
                    int t = b;
                    b = a % b;
                    a = t;
                }
                return a;
            }

            public static Fraction AddNumber(Fraction a, Fraction b)
            {
                Fraction resultfraction = new Fraction();
                resultfraction.numerator = a.numerator * b.denominator + a.denominator * b.numerator;
                resultfraction.denominator = a.denominator * b.denominator;
                int gcd = GreatestCommonDivisor(resultfraction.numerator, resultfraction.denominator);
                resultfraction.numerator /= gcd;
                resultfraction.denominator /= gcd;
                return resultfraction;
            }
        }


        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;// mã hóa sang hỗ trợ tiếng việt

            Fraction fraction = new Fraction();
            Fraction fraction2 = new Fraction();

            fraction.numerator = int.Parse(Console.ReadLine());
            Console.WriteLine("Tử số của phân số thứ nhất là: " + fraction.numerator);
            fraction.denominator = int.Parse(Console.ReadLine());
            Console.WriteLine("Mẫu số của phân số thứ nhất là: " + fraction.denominator);
            Console.WriteLine("Phân số của phân số thứ nhất: " + fraction.numerator + "/" + fraction.denominator);

            fraction2.numerator = int.Parse(Console.ReadLine());
            Console.WriteLine("Tử số của phân số thứ hai là: " + fraction2.numerator);
            fraction2.denominator = int.Parse(Console.ReadLine());
            Console.WriteLine("Mẫu số của phân số thứ nhất là: " + fraction2.denominator);
            Console.WriteLine("Phân số của phân số thứ nhất: " + fraction2.numerator + "/" + fraction2.denominator);

            Fraction result = Fraction.AddNumber(fraction, fraction2);
            if (result.denominator == 1)
            {
                Console.WriteLine("Kết quả là: " + result.numerator);
            }
            else if (result.denominator == -1)
            {
                result.numerator *= -1;
                Console.WriteLine("Kết quả là: " + result.numerator + "/" + result.denominator);
            }
            else
            {
                Console.WriteLine("Kết quả là: " + result.numerator + "/" + result.denominator);
            }


        }
    }
}
