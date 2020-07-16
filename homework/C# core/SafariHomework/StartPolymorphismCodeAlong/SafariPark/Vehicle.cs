using System;

namespace SafariPark
{
    public class Vehicle : IMovable
    {
       protected int _capacity;
       protected int _speed = 10;
       protected int _numPassengers;
       public int Position
        { get; private set; }
        public int NumPassengers
        {
            get { return _numPassengers; }
            set 
            {
                if (value >= 0 && value <= _capacity)
                {
                    _numPassengers = value;
                }
                else if (value > _capacity)
                {
                    _numPassengers = _capacity;
                }
            }
        }

        
        public Vehicle()
        {
        }

        public Vehicle(int capacity = 6, int speed = 10)
        {
            _capacity = capacity;
            _speed = speed;
        }

        public virtual string Move(int times)
        {
            Position += _speed * times;
            return $"Moving along {times} times";
        }
        public virtual string Move()
        {
            Position += _speed;
            return "Moving along";
        }
        public override string ToString()
        {
            return base.ToString() + $" capacity: {_capacity} passengers: {_numPassengers} speed: {_speed} position: { Position}";
        }

    }
}