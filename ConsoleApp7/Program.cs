using System;

namespace ConsoleApp7
{
    class Cars
    {
        protected string Model;
        private int Speed;

        public string GetModel
        {
            get { return Model; }
            set { Model = value; }
        }

        public int GetSpeed
        {
            get { return Speed; }
            set { Speed = value; }
        }
    }
    class Mercedec:Cars
    {
        public Mercedec()
        {
            Model = "Mercedec";
            GetSpeed = 150;
        }

        public Mercedec(string model, int speed)
        {
            Model = model;
            GetSpeed = speed;
        }

        public Mercedec(string model)
        {
            GetModel = model;
                
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cars cars = new Cars();
            Mercedec mercedec = new Mercedec();
            Mercedec mercedec2 = new Mercedec("s Class");
            Mercedec mercedec3 = new Mercedec("s Class",150);

            Console.WriteLine(mercedec.GetModel);
            Console.WriteLine(mercedec2.GetModel);
            Console.WriteLine(mercedec.GetSpeed);
            Console.WriteLine(mercedec3.GetSpeed);
            
        }
    }
}