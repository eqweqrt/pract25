using System;

namespace Task5
{
    public class Program 
    {
        public static void Main()
        {
            // Просмотр и добавление типов машин
            string careta = Console.ReadLine();
            DatabaseRequests.AddTypeCarQuery(careta);
            DatabaseRequests.GetTypeCarQuery();

            // Просмотр и добавление водителей 
            Console.WriteLine("Водитель");
            string name = Console.ReadLine();
            string lastname = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            
            DatabaseRequests.AddDriverQuery(name, lastname, new DateTime(year,month,day));
            DatabaseRequests.GetDriverQuery();
            
            // Просмотр и добавление водителей прав
            Console.WriteLine("права");
            //DatabaseRequests.GetDriverRightsCategoryQuery(1);
            string categ = Console.ReadLine();
            DatabaseRequests.AddRightsCategoryQuery(categ);
            DatabaseRequests.GetDriverRightsCategoryQuery(1);
            
            // Просмотр и добавление машин
            Console.WriteLine("Машина");
            int tp = int.Parse(Console.ReadLine());
            string carName = Console.ReadLine();
            string statName = Console.ReadLine();
            int pas = int.Parse(Console.ReadLine());
            
            DatabaseRequests.AddCarQuery(tp,carName,statName, pas);
            DatabaseRequests.GetCarQuery();

            // Просмотр и добавление маршрутов
            Console.WriteLine("Маршрут");
            string iter = Console.ReadLine();
            DatabaseRequests.AddItineraryQuery(iter);
            DatabaseRequests.GetItineraryQuery();
            
            // Просмотр и добавление рейсов
            Console.WriteLine("Рейс");
            int driv = int.Parse(Console.ReadLine());
            int car = int.Parse(Console.ReadLine());
            int iterr = int.Parse(Console.ReadLine());
            int numpass = int.Parse(Console.ReadLine());
            DatabaseRequests.AddRouteQuery(driv,car,iterr,numpass);
            DatabaseRequests.GetRouteQuery();

        }
    }   
}