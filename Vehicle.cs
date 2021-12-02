using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6_Inheritance_Demo
{
    internal class Vehicle
    {
        //*************************************************************
        //*************************ATTRIBUTES**************************
        //*************************************************************
        protected string make;
        protected string model;
        protected int year;
        protected double price;
        protected int speed;
        //*************************************************************
        //************************CONSTRUCTORS*************************
        //*************************************************************
        public Vehicle()
        {
            make = "Unknown";
            model = "Unknown";
            year = 0;
            price = 0;
            speed = 0;
        }
        //************************************
        //*************VEHICLE****************
        //************************************
        public Vehicle(string make, string model, int year, double price, int speed)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
            Speed = speed;
        }
        //*************************************************************
        //**************************BEHAVIORS**************************
        //*************************************************************
        //************************************
        //************ACCELERATE**************
        //************************************
        public void accelerate()
        {
            speed ++;
        }
        //************************************
        //************DECELERATE**************
        //************************************
        public void decelerate()
        {
            if (speed - 1 > 0)  
                speed --;
        }
        //*************************************************************
        //*************************PROPERTIES**************************
        //*************************************************************
        //************************************
        //***************MAKE*****************
        //************************************
        public string Make
        {
            get
            {
                return make;
            }
            set
            {
                make = value;

            }
        }
        //************************************
        //***************MODEL****************
        //************************************
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;

            }
        }
        //************************************
        //***************YEAR*****************
        //************************************
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;

            }
        }
        //************************************
        //***************PRICE****************
        //************************************
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;

            }
        }
        //************************************
        //***************SPEED****************
        //************************************
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;

            }
        }
    }
}
