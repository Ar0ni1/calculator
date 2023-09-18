using System.Numerics;

namespace калькулятор 
{
    internal class Program
    {
        public int Num1;
        public static int Num2;
        public static int Count;
        static void Main(string[] args)
        {

            Console.WriteLine("1. Сложить 2 числа\n" +
                "2. Вычесть первое из второго\n" +
                "3. Перемножить два числа\n" +
                "4. Разделить первое на второе\n" +
                "5. Возвести в степень N первое число\n" +
                "6. Найти квадратный корень из числа\n" +
                "7. Найти 1 процент от числа\n" +
                "8. Найти факториал из числа\n" +
                "9. Выход из программы");

            Console.WriteLine("Введите действие");

            SelectedCase(Convert.ToInt32(Console.ReadLine()));
            
        }

        public static void SelectedCase(int id)
        {
            switch(id)
            {
                case 1:

                    Console.WriteLine("Введите первое число для сложения:");

                    int Num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите второе число для сложения:");
                    Num2 = Convert.ToInt32(Console.ReadLine());

                    Count = Num1 + Num2;
                    Console.WriteLine("Сумма данных чисел равна:");
                    Console.WriteLine(Count);

                    Console.WriteLine("Введите действие");

                    SelectedCase(Convert.ToInt32(Console.ReadLine()));
                    break;

                case 2:

                    Console.WriteLine("Введите первое число для вычитания:");

                    Num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите второе число для вычитания:");
                    Num2 = Convert.ToInt32(Console.ReadLine());

                    Count = Num1 - Num2;
                    Console.WriteLine("Разность равна :");
                    Console.WriteLine(Count);

                    Console.WriteLine("Введите выбранное действие");

                    SelectedCase(Convert.ToInt32(Console.ReadLine()));
                    break;

                case 3:
        
                    Console.WriteLine("Введите первое число для умножения:");

                    Num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите второе число для умножения:");
                    Num2 = Convert.ToInt32(Console.ReadLine());

                    Count = Num1 * Num2;
                    Console.WriteLine("Произведенние:");
                    Console.WriteLine(Count);

                    Console.WriteLine("Введите выбранное действие");

                    SelectedCase(Convert.ToInt32(Console.ReadLine()));
                    break;

                 case 4:

                    Console.WriteLine("Введите первое число для деления:");

                    Num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите второе число для деления:");
                    Num2 = Convert.ToInt32(Console.ReadLine());

                    Count = Num1 / Num2;
                    Console.WriteLine("Частное:");
                    Console.WriteLine(Count);

                    Console.WriteLine("Введите выбранное действие");

                    SelectedCase(Convert.ToInt32(Console.ReadLine()));
                    break;

                case 5:
                    double a, b, c;
                    Console.WriteLine("Введите первое число для возведения в степень:");
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите второе число для степени:");
                    b = Convert.ToInt32(Console.ReadLine());

                    c = Math.Pow(a, b);

                    Console.WriteLine("Ответ:");
                    Console.WriteLine(c);

                    Console.WriteLine("Введите выбранное действие");

                    SelectedCase(Convert.ToInt32(Console.ReadLine()));
                    break;
                case 6:

                    double aa, cc;
                    Console.WriteLine("Введите первое число для нахождения корня:");
                    aa = Convert.ToInt32(Console.ReadLine());


                    cc = Math.Sqrt(aa);

                    Console.WriteLine("Корень равен:");
                    Console.WriteLine(cc);

                    Console.WriteLine("Введите выбранное действие");

                    SelectedCase(Convert.ToInt32(Console.ReadLine()));
                    break;

                case 7:

                    Console.WriteLine("Введите первое число для нахождения процента :");
                    Num1 = Convert.ToInt32(Console.ReadLine());

                    Count = Num1 / 100;

                    Console.WriteLine("Ваш процент равен:");
                    Console.WriteLine(Count);

                    Console.WriteLine("Введите выбранное действие");

                    SelectedCase(Convert.ToInt32(Console.ReadLine()));
                    break;

                case 8:                  

                    Console.WriteLine("Введите первое число для нахождения факториала:");
                    Num1 = Convert.ToInt32(Console.ReadLine());

                    Factarial(Num1);

                    Console.WriteLine("Введите выбранное действие");

                    SelectedCase(Convert.ToInt32(Console.ReadLine()));
                    break;

                case 9:
                    Console.WriteLine("Всего хорошего, досвидания");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Такой операции нет!");

                    Console.WriteLine("Введите выбранное действие");
                    break;
            }
        }

        static BigInteger Factarial(int i)
        {
            var Fact = new BigInteger(i);
            for (int n = 1; n < i; n++)
            {
                Fact *= n;
            }
            Console.WriteLine("Ответ фактариал " + Fact);
            return Fact;
        }
    }
}