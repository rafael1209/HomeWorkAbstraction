using System;

namespace HomeWorkAbstraction.Models
{
        internal class Car : Vehicle
        {
                public int MaxPassengers { get; set; }

                public Car(int maxSpeed, int maxPassengers) : base("Land", maxSpeed)
                {
                        MaxPassengers = maxPassengers;
                }

                public override string ToString()
                {
                        return base.ToString();
                }
        }
}
