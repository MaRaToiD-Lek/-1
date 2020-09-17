using System;

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {            
            //Инфа студента
            string studentName = null, studentSurname = null;
            byte studentCourse = 0, studentNumber = 0;
            
            //Инфа аспиранта
            string aspirantName = null, aspirantSurname = null, aspirantThesis = null;
            byte aspirantCourse = 0, aspirantNumber = 0;

            //Вывод студента на консоль
            StudentGet(ref studentName, ref studentSurname, ref studentCourse, ref studentNumber);
            Student student = new Student(studentName, studentSurname, studentCourse, studentNumber);
            Console.WriteLine();         
            
            //Вывод аспиранта на консоль
            AspirantGet(ref aspirantName, ref aspirantSurname, ref aspirantCourse, ref aspirantNumber, ref aspirantThesis);
            Aspirant aspirant = new Aspirant(aspirantName, aspirantSurname, aspirantCourse, aspirantNumber, aspirantThesis);            
        }
        
        public static void VallidationNumbers(bool flag, ref byte temp)
        {
            flag = false;            
            do
            {        
                
                if (byte.TryParse(Console.ReadLine(), out temp))
                {
                    flag = true;
                }
                else
                {
                    Console.WriteLine("Введите число!");
                    Console.WriteLine("Введите курс студента!");
                    continue;
                }
            } while (flag == false);
        }

        public static void VallidationStringStudent(ref string name, ref string surname)
        {
            // Имя студента
            bool isContinueLoop;
            do
            {
                isContinueLoop = false;
                Console.WriteLine("Введите имя студента!");
                name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Имя не должно быть пустой!");
                    isContinueLoop = true;
                }
                else
                {
                    for (int i = 0; i < name.Length; i++)
                    {
                        if (!char.IsLetter(name[i]))
                        {
                            Console.WriteLine("В имени не должны присудствовать цифры!");
                            isContinueLoop = true;
                        }
                    }
                }
            } while (isContinueLoop);

            // Фамилия студента
            bool isContinueLoop2;
            do
            {
                isContinueLoop2 = false;
                Console.WriteLine("Введите фамилию студента!");
                surname = Console.ReadLine();
                if (string.IsNullOrEmpty(surname))
                {
                    Console.WriteLine("Имя не должно быть пустой!");
                    isContinueLoop2 = true;
                }
                else
                {
                    for (int i = 0; i < surname.Length; i++)
                    {
                        if (!char.IsLetter(surname[i]))
                        {
                            Console.WriteLine("В имени не должны присудствовать цифры!");
                            isContinueLoop2 = true;
                        }
                    }
                }
            } while (isContinueLoop2);
        }

        public static void VallidationStringAspirant(ref string name, ref string surname)
        {
            // Имя студента
            bool isContinueLoop;
            do
            {
                isContinueLoop = false;
                Console.WriteLine("Введите имя аспиранта!");
                name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Имя не должно быть пустой");
                    isContinueLoop = true;
                }
                else
                {
                    for (int i = 0; i < name.Length; i++)
                    {
                        if (!char.IsLetter(name[i]))
                        {
                            Console.WriteLine("В имени не должны присудствовать цифры!");
                            isContinueLoop = true;
                        }
                    }
                }
            } while (isContinueLoop);

            // Фамилия студента
            bool isContinueLoop2;
            do
            {
                isContinueLoop2 = false;
                Console.WriteLine("Введите фамилию аспиранта!");
                surname = Console.ReadLine();
                if (string.IsNullOrEmpty(surname))
                {
                    Console.WriteLine("Имя не должно быть пустой");
                    isContinueLoop2 = true;
                }
                else
                {
                    for (int i = 0; i < surname.Length; i++)
                    {
                        if (!char.IsLetter(surname[i]))
                        {
                            Console.WriteLine("В имени не должны присудствовать цифры!");
                            isContinueLoop2 = true;
                        }
                    }
                }
            } while (isContinueLoop2);
        }

        public static void StudentGet(ref string studentName, ref string studentSurname, ref byte studentCourse, ref byte studentNumber)
        {
            bool flag = false;
            VallidationStringStudent(ref studentName, ref studentSurname);
            Console.WriteLine("Введите курс студента!");
            VallidationNumbers(flag, ref studentCourse);
            Console.WriteLine("Введите номер зачетной книжки студента!");
            VallidationNumbers(flag, ref studentNumber);
        }

        public static void AspirantGet(ref string aspirantName, ref string aspirantSurname, ref byte aspirantCourse, ref byte aspirantNumber, ref string aspirantThesis)
        {
            bool flag = false;            
            VallidationStringAspirant(ref aspirantName, ref aspirantSurname);
            Console.WriteLine("Введите курс студента!");
            VallidationNumbers(flag, ref aspirantCourse);
            Console.WriteLine("Введите номер зачетной книжки аспиранта!");
            VallidationNumbers(flag, ref aspirantNumber);
            Console.WriteLine("На какую тему пишите диссертацию?"); // Здесь я специально не сделал валидацию! 
            aspirantThesis = Console.ReadLine();
        }
    }
}
