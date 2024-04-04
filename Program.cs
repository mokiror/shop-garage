using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//на самом деле это гараж

namespace shop
{
    //
    public class Auto
    {
        private static int counter = 10000;
        public static int Counter { get { return counter; } }
        private int id;
        public int Id { get { return id; } }

        public Auto()
        {
            id = ++counter;
        }
    }


    public class Garage
    {
        private List<Auto> list;

        //свойство возвращающее список 
        // public List<Auto> List { get { return list; } }
        public Auto this[int index]
        {
            get
            {
                if (index < 0 || index >= list.Count)
                {
                    return null;
                }
                else
                {
                    return list[index];
                }
                
            }
        }
        public Garage()
        {
            list = new List<Auto>();
        }
        public void AddAuto(Auto mobile)
        {
            list.Add(mobile);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage();

            for (int i = 0; i < 5; i++)
            {
                Auto auto = new Auto();
                garage.AddAuto(auto);
                WriteLine($"Создан объект: {auto.Id}");
            }
            WriteLine($"Всего создано {Auto.Counter}");

            for (int i = 0; i < 15; i++)
            {
                if (garage[i] != null)
                {
                    WriteLine($"Выводится объект № {i} {garage[i].Id}");
                }
                else
                {
                    continue;
                }
            }

            //пере5числение возхможно когда есть свойство 
            //возвращающее перечисмляемую коллекцию
           /* foreach (var item in garage.List)
            {
                WriteLine(item.Id);
            }*/

            ReadKey();
        }
    }
    
}
