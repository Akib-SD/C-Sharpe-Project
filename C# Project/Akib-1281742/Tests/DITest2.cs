using Akib_1281742.Factories;
using Akib_1281742.Model;
using Akib_1281742.Responsitories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Akib_1281742.Tests
{
    public class DITest2
    {
        public void Run(IRepositoryFactory factory)
        {
            IGenecricRepostory<SmartWatch> repo = factory.GetRepo<SmartWatch>();
            Console.WriteLine("Smart Watches");
            Console.WriteLine("Insert operations");
            repo.Add(new SmartWatch { Id = 1, Model = "Apple Watch SE", YearMake = 2022, OriginCountry = "California", Price = 45.90M });
            repo.AddRange(new SmartWatch[] {
                new SmartWatch { Id = 2,Model = "Samsung Galaxy Watch 6",YearMake=2020,OriginCountry= "South Korea" ,Price = 28.55M},
                new SmartWatch { Id = 3,Model = "Noise Biggest Launch Pro",YearMake=2023,OriginCountry= "‎India" ,Price = 36.55M}
            });
            repo.Get()
                .ToList()
                .ForEach(s => Console.WriteLine($"Model: {s.Model}, YearMake:{s.YearMake}, OriginCountry:{s.OriginCountry} Price: {s.Price:C}"));
            Console.WriteLine();
            //update
            Console.WriteLine("Update operations");
            var smartWatch = repo.Get(2);
            smartWatch.Price = 99.99M;
            repo.Update(smartWatch);
            repo.Get()
                .ToList()
                .ForEach(s => Console.WriteLine($"Model: {s.Model}, YearMake:{s.YearMake}, OriginCountry:{s.OriginCountry} Price: {s.Price:C}"));
            Console.WriteLine();
            //delete
            Console.WriteLine("Delete operations");
            repo.Delete(1);
            repo.Get()
                .ToList()
                .ForEach(s => Console.WriteLine($"Model: {s.Model}, YearMake:{s.YearMake}, OriginCountry:{s.OriginCountry} Price: {s.Price:C}"));
            Console.WriteLine();
            Console.WriteLine("Manufacturer");
            IGenecricRepostory<Manufacturer> repo1 = factory.GetRepo<Manufacturer>();
            Console.WriteLine("Insert operations");
            repo1.Add(new Manufacturer { Id = 1, ManufacturerName = "Manu 1", Contact = "+7876XXXXXX", Email = "manu1@gmail.com" });
            repo1.AddRange(new Manufacturer[]
            {
                new Manufacturer { Id = 2, ManufacturerName = "Manu 2", Contact = "+66695XXXXX", Email = "manu2@gmail.com" },
                new Manufacturer { Id = 3, ManufacturerName = "Manu 3", Contact = "+77725XXXXXX", Email = "manu3@gmail.com" },
                new Manufacturer { Id = 4, ManufacturerName = "Manu 4", Contact = "+33255XXXXXX", Email = "manu4@gmail.com" }
            });
            repo1.Get()
                .ToList()
                .ForEach(m => Console.WriteLine($"Id:{m.Id}, Name: {m.ManufacturerName},Contact: {m.Contact}, Email: {m.Email}"));
            Console.WriteLine("Update operations");
            var me = repo1.Get(2);
            me.Email = "manu3@yahoo.com";
            repo1.Update(me);
            Console.WriteLine($"Id:{me.Id}, Name: {me.ManufacturerName},Contact: {me.Contact}, Email: {me.Email}");
            repo1.Delete(3);
            Console.WriteLine("Delete operations");
            repo1.Get()
                .ToList()
                .ForEach(m => Console.WriteLine($"Id:{m.Id}, Name: {m.ManufacturerName},Contact: {m.Contact}, Email: {m.Email}"));

        }
    }
}
