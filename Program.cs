using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGB
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пшеничный Иван
            //1.Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).В результате вся информация выводится в одну строчку:
            //а) используя склеивание;
            //б) вывод;
            //в) используя вывод со знаком $.

            questionnaire();

            //2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
            IMTcalculation();

            //3.
            //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
            //Вывести результат,используя спецификатор формата .2f(с двумя знаками после запятой);
            //б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
            calculationDistance();
            //4.Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
            //а) с использованием третьей переменной;
            //б) *без использования третьей переменной.
            taskfourWithThreeVariable();
            taskfourWithTwoVariable();


            //5.
            //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            //б) Сделать задание, только вывод организовать в центре экрана.
            //в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).
            PrintProfile();

            //6.*Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
            collorUserMessege("Выводит цветное сообщение в консоль");
        }
        #region first task
        static void questionnaire()
        {
            string name;
            string age;
            string weight;
            string height;

            collorUserMessege("Здравствуйте, просим вас ответить на пару вопросов.");

            name = userResponse("Как вас зовут?");
            age = userResponse("Ваш возраст?");
            height = userResponse("Ваш рост?");
            weight = userResponse("Ваш вес?");

            Console.Clear();
            collorUserMessege("Результат заполнения анкеты:");
            Console.WriteLine($"Имя: {name}, " + $"Возраст: {age}, " + $"Вес: {weight}, " + $"Рост: {height}.");
            Console.ReadLine();
            Console.Clear();
        }
        static void collorUserMessege(string qestion)
        {
            Console.ForegroundColor = ConsoleColor.Green; // Хочу что бы цвет приветствия был зеленый 
            Console.WriteLine(qestion);
            Console.ResetColor();

        }
        static string userResponse(string qestion)
        {
            collorUserMessege(qestion);
            return Console.ReadLine();
        }
        #endregion

        #region second task
        static void IMTcalculation()
        {
            double result;
            double weight;
            double height;
            collorUserMessege("Даваайте рассчитаем индекс массы тела.");
            collorUserMessege("Для этого вам необходимо ввести некоторые параметы:");
            //Ввести вес и рост человека.Рассчитать и вывести индекс массы тела (ИМТ) по формуле I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.
            height = int.Parse(userResponse("Ваш рост?"));
            weight = int.Parse(userResponse("Ваш вес?"));
            result = weight / (height * height);

            collorUserMessege($"Ваш ИМТ (индекс массы тела) равен: {result:f3}.");
            Console.ReadLine();

        }

        #endregion

        #region thierd task
        static void calculationDistance()
        {
            Console.Clear();

            int x1 = 50;
            int x2 = 78;
            int y1 = 25;
            int y2 = 90;
            collorUserMessege($"Расчет растояния между точками по формуле r = Math.Sqrt(Math.Pow({x2} - {x1}, 2) + Math.Pow({y2} - {y1}, 2))");
            Console.Write("Результат расчета = ");
            DoCalculationDistance(x1, x2, y1, y2);
        }
        static void DoCalculationDistance(int x1, int x2, int y1, int y2)
        {
            double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"{result:f2}");
            Console.ReadLine();
        }


        #endregion

        #region four task
        static void taskfourWithTwoVariable()
        {
            Console.Clear();
            collorUserMessege("Замена переменных местами без использования третей переменной");
            Console.WriteLine("Введите переменную a ");
            int varA = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите переменную b ");
            int varB = int.Parse(Console.ReadLine());
            Console.WriteLine($"Переменная а = {varA}, b =  {varB}");
            varA = varA + varB;
            varB = varA - varB;
            varA = varA - varB;
            Console.WriteLine($"Замена переменных а = {varA}, b =  {varB}");
            Console.ReadLine();
        }
        static void taskfourWithThreeVariable()
        {
            Console.Clear();
            collorUserMessege("Замена переменных местами с использования третей переменной");
            Console.WriteLine("Введите переменную a ");
            int varA = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите переменную b ");
            int varB = int.Parse(Console.ReadLine());
            Console.WriteLine($"Переменная а = {varA}, b =  {varB}");
            int res;
            Console.WriteLine($"Замена переменных с использованием третей с = {res = varA} а = {varA = varB}, b =  {varB = res}");
            Console.ReadLine();
        }

        #endregion

        #region five task

        static void PrintProfile()
        {
            Console.Clear();
            string Text = "Иван Пшеничный, г. Санкт-Петербург.";
            // Выводим строку в центре экрана
            int X = (Console.WindowWidth / 2) - (Text.Length / 2);
            int Y = (Console.WindowHeight / 2) - 1;
            Print(Text, X, Y);

        }
        static void Print(string ms, int x, int y)
        {
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(ms);
            Console.ResetColor();
            Console.ReadKey();
        }
        #endregion
    }
}