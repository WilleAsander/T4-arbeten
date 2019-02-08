using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18OKT25
{
    class Program
    {
        static void Main(string[] args)
        {
            DVD d = new DVD();  
            d.ID = "1337";
            d.Play();

            IDisplay anka;
            anka = d;

            d.ID = "XXX234";

            anka.Play();

            Washer w = new Washer() { Model = "AC4" };
            w.Play();
            anka = w;
            anka.Play();

            anka = new BluRay() { Movie = "Breakfast Club" };
            anka.Play();

            List<IDisplay> machines = new List<IDisplay>();
            machines.Add(new Washer() { Model = "HG2" });
            machines.Add(new DVD() { ID = "123" });
            machines.Add(new BluRay() { Movie = "Scary Movie" });

            foreach (var item in machines)
            {
                Console.WriteLine(item.GetType().Name);
                item.Play();
                if (item.GetType().Name == "DVD")
                {
                    Console.WriteLine(((DVD)item).ID);
                }
                if (item.GetType().Name == "Washer")
                {
                    Console.WriteLine("Model is " + ((Washer)item).Model);
                }
                if (item.GetType().Name == "BluRay")
                {
                    Console.WriteLine("The Movie is " + ((BluRay)item).Movie);
                }
            }
        }
    }

    public class DVD : IDisplay
    {
        public string ID { get; set; }
        public int SerialNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Play()
        {
            Console.WriteLine("DVD {0} is playing...", ID);
        }
    }

    public class Washer : IDisplay
    {
        public string Model { get; set; }
        public int SerialNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Play()
        {
            Console.WriteLine("Washer is running...");
        }
    }

    public class BluRay : IDisplay
    {
        public string Movie { get; set; }
        public int SerialNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Play()
        {
            Console.WriteLine("BluRay {0} is playing...", Movie);
        }
    }



    public interface IDisplay
    {
        void Play();
        int SerialNumber { get; set; }
    }
}
