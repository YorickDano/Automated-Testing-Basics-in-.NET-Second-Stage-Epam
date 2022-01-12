using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using static System.Console;
using Epam.OOP.Cars;

namespace Epam
{
    [Serializable]
    public class Collections
    {
        static ArrayList array = new ArrayList() { new LightCar(), new HeavyCar(), new Bus(), new Scooter() };

        public static void ToXml()
        {
            foreach (var item in array)
            {
                XmlSerializer xml = new XmlSerializer(item.GetType());
                using (FileStream fs = new FileStream($"{item}.xml", FileMode.OpenOrCreate))
                {
                    xml.Serialize(fs, item);
                }
            }
        }

        public static void Collection()
        {
            var vehiclesList = new List<Vehicle>();

            Setting(ref vehiclesList);
            
            WriteLine("\nAll Vehicles with engine volume more than 1.5l\n");
            GetInfoAboutEngines(vehiclesList);

            WriteLine("\nInformation about Buses and Trucks engines\n");
            GetInfoAboutTracksAndBusesEngines(vehiclesList);

            GetInfoAboutAllVehicleByTransmissionType(vehiclesList);
        }

        public static void GetInfoAboutAllVehicleByTransmissionType(List<Vehicle> array)
        {
            var TransmissionTypes = FindAllTransmissionTypes(array);

            foreach (var item in TransmissionTypes)
            {
                WriteLine("\nTransmission type: {0}\n", item);

                foreach (var element in array.FindAll(x => x.transmission.type == item))
                {
                    if (element is LightCar)
                    {
                        (element as LightCar).ShowInfo();
                    }

                    if (element is HeavyCar)
                    {
                        (element as HeavyCar).ShowInfo();
                    }

                    if (element is Bus)
                    {
                        (element as Bus).ShowInfo();
                    }

                    if (element is Scooter)
                    {
                        (element as Scooter).ShowInfo();
                    }
                }
            }
        }

        public static List<string> FindAllTransmissionTypes(List<Vehicle> array)
        {
            List<string> AllTransmissionTypes = new List<string>();

            foreach (var item in array)
            {
                AllTransmissionTypes.Add(item.transmission.type);
            }

            return AllTransmissionTypes.Distinct().ToList();
        }

        public static void Setting(ref List<Vehicle> array)
        {
            Random random = new Random();

            for (int i = 0; i < 3; ++i)
            {
                array.Add(new LightCar(random.Next(100000)));
            }

            for (int i = 0; i < 2; ++i)
            {
                array.Add(new HeavyCar(random.Next(10000)));
            }

            for (int i = 0; i < 1; ++i)
            {
                array.Add(new Bus(random.Next(1000)));
            }

            for (int i = 0; i < 2; ++i)
            {
                array.Add(new Scooter(random.Next(100)));
            }
        }

        public static void GetInfoAboutEngines(List<Vehicle> array)
        {
            foreach (var element in array.FindAll(x => x.engine.volume > 1.5))
            {
                if (element is HeavyCar)
                {
                    (element as HeavyCar).ShowInfo();
                }

                if (element is Bus)
                {
                    (element as Bus).ShowInfo();
                }  
            }
        }

        public static void GetInfoAboutTracksAndBusesEngines(List<Vehicle> array)
        {
            foreach (var item in array.FindAll(x => x.GetType() == new HeavyCar().GetType() || x.GetType() == new Bus().GetType()))
            {
                item.ShowEngineInfo();
            }
        }
    }
}
