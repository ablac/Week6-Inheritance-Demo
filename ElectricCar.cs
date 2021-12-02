using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6_Inheritance_Demo
{
    internal class ElectricCar : Car
    {
        //*************************************************************
        //*************************ATTRIBUTES**************************
        //*************************************************************
        protected int range;
        //*************************************************************
        //************************CONSTRUCTORS*************************
        //*************************************************************
        public ElectricCar() : base()
        {
            range = 0;
        }
        //************************************
        //***************CAR******************
        //************************************
        public ElectricCar(string make, string model, int year, double price, int speed, 
            int numDoors, bool hatchBack, int range)
            : base (make, model, year, price, speed, numDoors, hatchBack)
        {
            Range = range;
        }
        //*************************************************************
        //**************************BEHAVIORS**************************
        //*************************************************************

        //*************************************************************
        //*************************PROPERTIES**************************
        //*************************************************************
        //************************************
        //*************NUMDOORS***************
        //************************************
        public int Range
        {
            get { return range; }
            set { range = value; }
        }

    }
}
