using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Data.Entity;

namespace Cars
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CarDb>());
            InsertData();
            QueryData();
            Console.ReadKey();
        }

        private static void QueryData()
        {
            var db = new CarDb();

            var query =
                from car in db.Cars
                orderby car.Combined descending, car.Name ascending
                select car;

            foreach (var item in query.Take(10))
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void InsertData()
        {
            var cars = ProcessCars("fuel.csv");
            var db = new CarDb();

            if (!db.Cars.Any())
            {
                foreach (var car in cars)
                {
                    db.Cars.Add(car);
                }
                db.SaveChanges();
            }
        }

        private static void QueryXML()
        {
            var document = XDocument.Load("fuel.xml");
            var query =
                from element in document.Element("Cars").Elements("Car")
                where element.Attribute("Manufacturer")?.Value == "BMW"
                select element.Attribute("Name")?.Value;

            foreach (var name in query)
            {
                Console.WriteLine(name);
            }
        }

        private static void GenerateXML()
        {
            var records = ProcessCars("fuel.csv");
            var cars = new XElement("Cars",

                from car in records
                select new XElement(
                    "Car",
                    new XAttribute("Manufacturer", car.Manufacturer),
                    new XAttribute("Name", car.Name),
                    new XAttribute("Combined", car.Combined)
                    ));
            var document = new XDocument(cars);
            document.Save("fuel.xml");
        }

        public static List<Car> ProcessCars(string pathToFile)
        {
            var query =
                File.ReadAllLines(pathToFile)
                .Skip(1)
                .Where(l => l.Length > 1)
                .ToCar();

            return query.ToList();
        }

        public static List<Manufacturer> ProcessManufacturers(string pathToFile)
        {
            var query =
                File.ReadAllLines(pathToFile)
                .Where(l => l.Length > 1)
                .Select(l => toManufacturer(l));

            return query.ToList();
        }

        private static Manufacturer toManufacturer(string l)
        {
            l = l.Trim();
            var columns = l.Split(',');
            return new Manufacturer
            {
                Name = columns[0],
                Headquarters = columns[1],
                Year = int.Parse(columns[2])
            };
        }
    }
    
    public class CarStatistic
        {
            public int  Max { get; set; }
            public int Min { get; set; }
            public double Sum { get; set; }
            public double Average
            {
                get
                {
                    return Sum / Count;
                }
            }
            public int Count { get; set; }

            public CarStatistic Accumulate(Car car)
            {
                Max = Math.Max(Max, car.Combined);
                Min = Math.Min(Min, car.Combined);
                Count++;
                Sum += car.Combined;
                return this;
            }

        public CarStatistic Compute()
        {
            return this;
        }
    }
    public static class CarExtensions
    {
        public static IEnumerable<Car> ToCar(this IEnumerable<string> source)
        {
            foreach (var line in source)
            {
                string temp = line.Trim();
                var columns = temp.Split(',');
                yield return new Car
                {
                    Year = int.Parse(columns[0]),
                    Manufacturer = columns[1],
                    Name = columns[2],
                    Displacement = double.Parse(columns[3]),
                    Cylinders = int.Parse(columns[4]),
                    City = int.Parse(columns[5]),
                    Highway = int.Parse(columns[6]),
                    Combined = int.Parse(columns[7])
                };
            }
            
        }
    }
}
