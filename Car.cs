using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6_Inheritance_Demo
{
    internal class Car : Vehicle
    {
        //*************************************************************
        //*************************ATTRIBUTES**************************
        //*************************************************************
        protected int numDoors;
        protected bool hatchBack;
        //*************************************************************
        //************************CONSTRUCTORS*************************
        //*************************************************************
        public Car() : base()
        {
            numDoors = 0;
            hatchBack = false;
        }
        //************************************
        //***************CAR******************
        //************************************
        public Car(string make, string model, int year, double price, int speed, int numDoors, bool hatchBack) 
            : base(make, model, year, price, speed)
        {
            NumDoors = numDoors;
            HatchBack = hatchBack;
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
        public int NumDoors
        {
            get { return numDoors; }
            set { numDoors = value; } 
        }

        //************************************
        //*************HATCHBACK**************
        //************************************
        public bool HatchBack
        {
            get { return hatchBack; }
            set { hatchBack = value; }
        }
    }
}
