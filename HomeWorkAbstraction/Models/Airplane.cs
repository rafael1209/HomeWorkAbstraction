using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkAbstraction.Models
{
        internal class Airplane : Vehicle
        {
                public int MaxHeight { get; set; }

                public Airplane(int maxSpeed,int maxHeight) : base("Air", maxSpeed)
                {
                        base.MaxSpeed = maxSpeed;

                        this.MaxHeight = maxHeight;
                }

                public int GetMaxHeight()
                {
                        return this.MaxHeight;
                }

                public override string ToString()
                {
                        return base.ToString();
                }
        }
}
