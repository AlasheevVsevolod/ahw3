using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_3_Static_Interface
{
    public partial class Practice
    {
        /// <summary>
        /// AL3-P1/3. Создать класс UniqueItem c числовым полем Id. 
        /// Каждый раз, когда создается новый экземпляр данного класса, 
        /// его идентификатор должен увеличиваться на 1 относительно последнего созданного. 
        /// Приложение должно поддерживать возможность начать идентификаторы с любого числа. 
        /// </summary>
        /// AL3-P1/3.StaticUniqueId.
        public static void AL3_P1_3()
        {
            Random rand = new Random();
            for (int i = 0; i < rand.Next(10, 20); i++)
            {
                var newClass = new UniqueItem();
                Console.WriteLine(UniqueItem.id);
            }
        }

        class UniqueItem
        {
            public static int id { get; private set; }

            static UniqueItem()
            {
                id = 1000;
            }

            public UniqueItem()
            {
                id++;

            }
        }

        /// <summary>
        /// AL3-P2/3. Отредактировать консольное приложение Printer. 
        /// Заменить базовый абстрактный класс на интерфейс.
        /// </summary>
        public static void AL3_P2_3()
        {

        }


        /// <summary>
        /// AL3-P3/3. Создайте обобщенный метод GuessType<T>(T item), 
        /// который будет принимать переменную обобщенного типа и выводить на консоль, 
        /// что это за тип был передан.
        /// </summary>
        /// AL3-P3/3. GuessType.
        public static void AL3_P3_3()
        {
            string str1 = "123456", str2 = "123", str3 = "12345";
            int num1 = 50, num2 = -4;
            long byte1 = 30;
            double dNum1 = -3.2145, dNum2 = 123.45, dNum3 = 123.456, dNum4 = 12345, dNum5 = 0.1234, dNum6 = 0.12345;
            DateTime newDT = DateTime.Today;
            char cSymbol = 'z';

            Console.WriteLine("str1:");
            GuessType(str1);
            Console.WriteLine("str2:");
            GuessType(str2);
            Console.WriteLine("str3:");
            GuessType(str3);

            Console.WriteLine("num1:");
            GuessType(num1);
            Console.WriteLine("num2:");
            GuessType(num2);
            Console.WriteLine("byte1:");
            GuessType(byte1);

            Console.WriteLine("double1:");
            GuessType(dNum1);
            Console.WriteLine("double2:");
            GuessType(dNum2);
            Console.WriteLine("double3:");
            GuessType(dNum3);
            Console.WriteLine("double4:");
            GuessType(dNum4);
            Console.WriteLine("double5:");
            GuessType(dNum5);
            Console.WriteLine("double6:");
            GuessType(dNum6);

            Console.WriteLine("Date Time:");
            GuessType(newDT);

            Console.WriteLine("Char:");
            GuessType(cSymbol);

        }

        public static void GuessType<T>(T item)
        {
            string strToPrint;
            switch (item)
            {
                //Вы передали строку длинной 5 символов.
                case string tmpString when tmpString.Length == 5:
                    strToPrint = "String of 5 symbols";
                    break;

                //Вы передали положительное целое число.
                case int tmpIntNum when tmpIntNum > 0:
                    strToPrint = "Positive integer number";
                    break;

                //Вы передали вещественное число с 5 значимыми цифрами.
                case double tmpDoubleNum when tmpDoubleNum.ToString().Where(c => c <= '9' && c >= '0').Count() == 5:
                    strToPrint = "5 number double";
                    break;

                //Вы передали время.
                case DateTime tmpDateTime:
                    strToPrint = "Date/time object";
                    break;

                default:
                    strToPrint = "Some other type";
                    break;
            }
            Console.WriteLine(strToPrint + '\n');
        }

    }
}
