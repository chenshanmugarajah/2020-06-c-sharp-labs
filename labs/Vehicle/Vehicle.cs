using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    public class Vehicle
    {
        private int _capacity;
        private int _numPassengers;
        private int _speed;

        public int NumPassengers
        {
            get { return _numPassengers; }
            set { _numPassengers = value; }
        }

        public int Position { get; set; }

        public string Move(int i)
        {
            Position += i;
            return $"Moving along {i} times";
        }

        public string Move()
        {
            return "Moving along";
        }

        public Vehicle()
        {
        }

        public Vehicle(int capacity, int speed = 10)
        {
            _capacity = capacity;
            _speed = speed;
        } 
    }
}
