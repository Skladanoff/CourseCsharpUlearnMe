using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApps
{
    class Program
    {
        static void Main(string[] args)
        {
            //TypeConversionErrors();
            //Bitcoins();
            //StringToInt();
            //GoodEmployer();
            //TheMainQuestionOfTheUniverse();
            //WantedMethods();

        }

        static void TypeConversionErrors()
        {
        /*
        * Ошибки преобразования типов
        * 
        * Исправьте все ошибки преобразования типов. Читайте и переводите с английского имена переменных, чтобы понять, что от вас требуется.
        *  public static void Main()
        {
            double pi = Math.PI;
            int tenThousand = 10000L;
            float tenThousandPi = pi*tenThousand;
            int roundedTenThousandPi = tenThousandPi;
            int integerPartOfTenThousandPi = tenThousandPi;
            Console.WriteLine(integerPartOfTenThousandPi);
            Console.WriteLine(roundedTenThousandPi);
        }
        */
            double pi = Math.PI;
            var tenThousand = 10000L;
            var tenThousandPi = pi * tenThousand;
            var roundedTenThousandPi = Math.Round(tenThousandPi);
            int integerPartOfTenThousandPi = (int)tenThousandPi;
            Console.WriteLine(integerPartOfTenThousandPi);
            Console.WriteLine(roundedTenThousandPi);
        }
        private static void Bitcoins()
        {

            /* Биткоины в массы!
             * 
             * Вася регулярно получает за красивые глазки от кого-нибудь по amount биткоинов.
             * Вася хочет знать, сколько биткоинов у него уже накопилось. А чтобы не мелочиться, хочет округлить сумму до ближайшего целого.
             * Он написал для этого программу, но что-то с ней не так... Помогите ему исправить все ошибки.
             * 
             * 
             */

            double amount = 1.11; //количество биткоинов от одного человека
            int peopleCount = 60; // количество человек
            int totalMoney = (int)Math.Round(amount * peopleCount); // ← исправьте ошибку в этой строке
            Console.WriteLine(totalMoney);
        }
        private static void StringToInt()
        {
            /*Преобразование строки в число
             * 
             * Вася написал код, прибавляющий к числу единичку, но он опять не работает :(
                public static void Main()
                {
                    string doubleNumber = "894376.243643";
                    int number = int.Pase(doubleNumber); // Вася уверен, что ошибка где-то тут
                    Console.WriteLine(number + 1);
                }
             * Немедленно помогите Васе, иначе он решит, что программирование слишком сложно для него!
             */

            string doubleNumber = "894376.243643";
            double number = double.Parse(doubleNumber, CultureInfo.InvariantCulture); // Вася уверен, что ошибка где-то тут
            Console.WriteLine(number + 1);

        }
  
        private static void GoodEmployer()
        {
            /*Добрый работодатель
             * 
             * Вася до завтра должен написать важную подпрограмму для Доброго Работодателя. Оставалось дописать всего один метод, когда Вася от переутомления крепчайше заснул.
             * Напишите метод, который принимает на вход имя и зарплату и возвращает строку вида: Hello, <Name>, your salary is <Salary>.
             * Но так как Работодатель Добр, он всегда округляет зарплату до ближайшего целого числа вверх.
             * Во многих редакторах и IDE сочетание клавиш Ctrl + Space показывает контекстную подсказку. Тут подсказки также работают, однако внутри Visual Studio они гораздо полнее и удобнее.
             * 
            public static void Main() 
            {
                Console.WriteLine(GetGreetingMessage("Student", 10.01));
                Console.WriteLine(GetGreetingMessage("Bill Gates", 10000000.5));
                Console.WriteLine(GetGreetingMessage("Steve Jobs", 1));
            }
            private static string GetGreetingMessage(string name, double salary)
            {
                    // возвращает "Hello, <name>, your salary is <salary>"
                    ...
            }
             */


        Console.WriteLine(GetGreetingMessage("Student", 10.01));
        Console.WriteLine(GetGreetingMessage("Bill Gates", 10000000.5));
        Console.WriteLine(GetGreetingMessage("Steve Jobs", 1));


        }
        private static string GetGreetingMessage(string name, double salary)
        {
            if ((salary - (int)salary) > 0.00001)
                salary = (int)salary + 1;

            return $"Hello, {name}, your salary is {(int)Math.Round(salary)}";

        }
        private static void TheMainQuestionOfTheUniverse()
        {
            /*Главный вопрос Вселенной
             * 
             * Многие знают, что ответ на главный вопрос жизни, вселенной и всего такого — 42. Но Вася хочет большего! Он желает знать квадрат этого числа!
             * Вы разделили с Васей работу — он написал главный метод Main, а вам осталось лишь дописать методы Print и GetSquare.
             * Создайте два метода Print и GetSquare, так, чтобы код снизу заработал. Если забыли синтаксис определения методов — подсмотрите в видеолекции или в предыдущие задачи.
             * 
             *  public static void Main()
             *  {
             *      Print(GetSquare(42));
             *  }
             *  
             */
            Print(GetSquare(42));


        }
        private static void Print(int s)
        {
            Console.WriteLine(s);
        }
        private static int GetSquare(int numb)
        {
            return numb * numb;

        }

        private static void WantedMethods()
        {
            /*Разыскиваются методы!
             * 
             * Напишите тело метода GetLastHalf() так, чтобы он возвращал вторую половину строки text, из которой затем удалены пробелы.
             * Можете считать, что text всегда четной длины.
             */
            Console.WriteLine(GetLastHalf("I love CSharp!"));
            Console.WriteLine(GetLastHalf("1234567890"));
            Console.WriteLine(GetLastHalf("до ре ми фа соль ля си"));
        }

        private static string GetLastHalf(string s)
        {
            s = s.Substring(s.Length / 2, s.Length/2). Replace(" ","");
            return s;
        }

    }

}
