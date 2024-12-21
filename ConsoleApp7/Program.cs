using System;

namespace ConsoleApp7
{
    class car
    {
        public string name;
        protected int speed;
        protected double motor;
        protected string model;

        public string getModel
        {
            get { return model; }
            set { model = value; }
        }

        public int getSpeed
        {
            get { return speed; }
            set { speed = value; }
        }

        public double getmotor
        {
            get { return motor; }
            set { motor = value; }
        }
    }

    class Bmw : car
    {
        public Bmw()
        {
            speed = 310;
            motor = 6.4;
            model = "m5 f90 cs";

        }
    }

    class Mercedes : car
    {
        public Mercedes()
        {
            speed = 360;
            motor = 1.4;
            model = "Amg one: hybrid";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bmw bmw = new Bmw();
            Mercedes mercedes = new Mercedes();
            bmw.name = "Bmw";
            mercedes.name = "Mercedes";
            
            Console.WriteLine(bmw.name);
            Console.WriteLine(bmw.getSpeed);
            Console.WriteLine(bmw.getmotor);
            Console.WriteLine(bmw.getModel);
            Console.WriteLine(mercedes.name);
            Console.WriteLine(mercedes.getSpeed);
            Console.WriteLine(mercedes.getmotor);
            Console.WriteLine(mercedes.getModel);
        }
    }
}