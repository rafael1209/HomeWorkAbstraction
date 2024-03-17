using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkAbstraction.Models
{
        internal class CargoPlane : Airplane
        {
                public int MaxCargo { get; set; }

                public CargoPlane(int maxSpeed, int maxHeight, int maxCargo) : base(maxSpeed, maxHeight)
                {
                        base.MaxSpeed = maxSpeed;

                        base.MaxHeight = maxHeight;

                        this.MaxCargo = maxCargo;
                }

                public CargoPlane MaxCargoPlane(CargoPlane cargoPlane)
                {
                        if (cargoPlane.MaxCargo > this.MaxCargo)
                                return cargoPlane;
                        else
                                return this;
                }

                public override string ToString()
                {
                        return base.ToString();
                }
        }
}
