using System;

namespace lab_31_oop_events
{
    class Program
    {
        static void Main(string[] args)
        {
            // goal : annual event triggered by calendar - bday party
            Child james = new Child("James");

            james.AnotherYearOlder();
        }
    }

    class Child
    {
        public string Name { get; set; }
        public int Age { get; set; }

        delegate void BirthdayDelegate(int age);

        event BirthdayDelegate BirthdayEvent; // null right now

        public Child( string name)
        {
            this.Name = name;
            this.Age = 0;

            BirthdayEvent += Celebrate; //not null now
        }

        public void AnotherYearOlder ()
        {
            this.Age++;
            BirthdayEvent(this.Age);
        }

        void Celebrate (int age)
        {
            Console.WriteLine("Congrats! You have reach the age of " + age);
        }
    }
}
