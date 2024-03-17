using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkAbstraction.Models
{
        internal class Vehicle
        {
                public string Way {  get; set; }

                public int MaxSpeed { get; set; }

                public Vehicle(string way,int maxSpeed) 
                {
                        this.Way = way;

                        this.MaxSpeed = maxSpeed;
                }

                public override string ToString()
                {
                        return $"Current vehicle has {this.Way} and {this.MaxSpeed}";
                }
        }
}
