1)
using System;
using System.Collections.Generic;

namespace Lern_pract_2._1
{
    class Student
    {
        public string lastName, data;
        public int numberGroup;
        public int[] grade;

    }


    public class Program
    {
        public static void Main(string[] args)
        {
            Student ferstStudent = new Student();
            ferstStudent.lastName = "ivanov";
            ferstStudent.data = "16.07.2000";
            ferstStudent.numberGroup = 621;
            ferstStudent.grade = new[] { 4, 3, 5, 2, 5 };

           

            bool condition = true;
            int x = 0;
            while (condition)
            {
                Console.WriteLine("Введите 1, чтоб изменить данные, введите 2, чтоб вывести информацию о студенти, для завершения введите 10");
                try
                {
                    x = int.Parse(Console.ReadLine());

                if (x == 10)
                {
                    condition = false;
                }
                switch (x)
                {
                    case 1:
                        int choise = 10;
                        Console.WriteLine(
                            "Изменить Фамилию 1, Изменить дату рождения 2, Изменить номер группы 3, Изменить оценки 4");
                        choise = int.Parse(Console.ReadLine());
                        if (choise == 1)
                        {
                            Console.WriteLine($"Фамилия студента: {ferstStudent.lastName}, изменить ее на:");
                            ferstStudent.lastName = Console.ReadLine();
                        }

                        if (choise == 2)
                        {
                            Console.WriteLine($"датa рождения студента: {ferstStudent.data}, изменить ее на:");
                            ferstStudent.data = Console.ReadLine();
                        }

                        if (choise == 3)
                        {
                            Console.WriteLine($"номер группы студента: {ferstStudent.numberGroup}, изменить ее на:");
                            ferstStudent.numberGroup = int.Parse(Console.ReadLine());
                        }

                        if (choise == 4)
                        {
                            Console.WriteLine($"Оценки студента: ");
                            foreach (var i in ferstStudent.grade)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("изменить их на:");
                            for (int i = 0; i < 5; i++)
                            {
                                ferstStudent.grade[i] = int.Parse(Console.ReadLine());
                            }
                        }

                        

                        break;

                    case 2:
                        Console.WriteLine(
                            $"Фамилия: {ferstStudent.lastName}\nДень рождение: {ferstStudent.data}\nГруппа: {ferstStudent.numberGroup}");
                        Console.WriteLine($"Оценки студента: ");
                        foreach (var i in ferstStudent.grade)
                        {
                            Console.WriteLine(i);
                        }

                        break;
                }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            
        }
    }
}
    

 
 
 
 

2)
using System;
using System.Collections.Generic;

namespace Lern_pract_2._1
{
    class Train
    {
        public string paragraphDestination, departureTime;
        public int trainNumber;


    }


    public class Program
    {
        public static void Main(string[] args)
        {
            Train chu_chu = new Train();
            chu_chu.paragraphDestination = "Tomsk";
            chu_chu.trainNumber = 7;
            chu_chu.departureTime = "13:30";

           

            bool condition = true;
            int x = 0;
            while (condition)
            {
                Console.WriteLine("Введите номер поезда:");
                x = int.Parse(Console.ReadLine());
                if (x == chu_chu.trainNumber)
                {
                    Console.WriteLine($"Номер поезда: {chu_chu.trainNumber}\nПункт назначения: {chu_chu.paragraphDestination}\nВремя отправления: {chu_chu.departureTime}");
                }
                else
                {
                    Console.WriteLine("Такого поезда не найдено");
                }
            }
        }
    }
}
    


  
3)
using System;
using System.Collections.Generic;

namespace Lern_pract_2._1
{
    class Numbers
    {
        public int x;
        public int y;
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            Numbers Meaning = new Numbers();
            Meaning.x = 6;
            Meaning.y = 7;

            bool condition = true;
            int x = 0;
            while (condition)
            {
                Console.WriteLine("Для вывода чисел введите 1, для их изменения 2, для нахождении суммы чисел введите 3 и для нахождения наибольшего введите 4");
                x = int.Parse(Console.ReadLine());

                switch (x)
                {
                    case 1:
                        Console.WriteLine($"{Meaning.x} {Meaning.y}");
                        break;
                    case 2:
                        Console.WriteLine("Первое число равно:");
                        Meaning.x = int.Parse(Console.ReadLine());
                        Console.WriteLine("Второе число равно:");
                        Meaning.y = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine(Meaning.x + Meaning.y);
                        break;
                    case 4:
                        if (Meaning.x > Meaning.y){Console.WriteLine(Meaning.x);}
                        if (Meaning.x == Meaning.y){Console.WriteLine("Они равны");}
                        else {Console.WriteLine(Meaning.y);}
                        break;
                }
            }
        }
    }
}
    


 
 
 
4)
using System;
using System.Collections.Generic;

namespace Lern_pract_2._1

public class Numbers
    {
        public int x;
        public int y;
        
        public static void Main(string[] args)
        {
            Numbers Meaning = new Numbers();
            Meaning.x = 0;

            bool condition = true;
            int g = 0;
            while (condition)
            {
                Console.WriteLine("Чтобы присвоить счетчику значение по умолчанию(10) введите 1, для присвоение произвольного значения введите 2, " +
                                  "Чтобы увеличить счетчик введите 3, для уменьшения введите 4, чтобы узнаеть его текущее состояние 5");
                try
                {
                    g = int.Parse(Console.ReadLine());

                    switch (g)
                    {
                        case 1:
                            Meaning.x = 10;
                            break;
                        case 2:
                            Console.WriteLine("Произвольное значение:");
                            Meaning.x = int.Parse(Console.ReadLine());
                            break;
                        case 3:
                            Console.WriteLine("Увеличить счетчик на:");
                            Meaning.y = int.Parse(Console.ReadLine());
                            Meaning.x += Meaning.y;
                            break;
                        case 4:
                            Console.WriteLine("Увеличить счетчик на:");
                            Meaning.y = int.Parse(Console.ReadLine());
                            Meaning.x -= Meaning.y;
                            break;
                        case 5:
                            Console.WriteLine(Meaning.x);
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }
    }
}

Вроде сказали, что эти не надо) 

5)
using System;
namespace Lern_pract_2._1

{
    class Numbers
    {
        public string country, chto_to;
        public Numbers()
        {
            country = "Russia";
            chto_to = "Da Da";
        }
        
        public void outPut()
        {
            Console.WriteLine($"{country}\n{chto_to}");
        }

        public void Dispose()
        {
            this.Dispose();
        }
        
        ~Numbers()
        {
            Console.WriteLine($"{country} has deleted");
        }

        public static void Main(string[] args)
        {
            Numbers example = new Numbers();
            example.outPut();
        }
    }
}

