using HomeWorkAbstraction.Models;

internal class Program
{
        private static void Main(string[] args)
        {
                Vehicle[] vehicles = new Vehicle[]
                {
                        new Car(120,5) {},
                        new Car(90,8) {},
                        new Airplane(995,40000) {},
                        new Airplane(1195,35000) {},
                        new CargoPlane(888,20000,120000){},
                        new CargoPlane(1009,25000,150000){}
                };
                PlanesInfo(vehicles);
        }

        public static void PlanesInfo(Vehicle[] vehicles)
        {
                var lowerAirplane = new Airplane(int.MaxValue, int.MaxValue) { };

                var hightCargoPlane = new CargoPlane(0,0,0) { };

                int countAirPlane = 0, countCargoPlane = 0;

                List<CargoPlane> cargoPlaneList = new List<CargoPlane>();

                foreach (Vehicle vehicle in vehicles)
                {
                        if (vehicle is Airplane)
                        {
                                countAirPlane++;

                                lowerAirplane = LowerHightAirplane(lowerAirplane, vehicle as Airplane);
                        }

                        if (vehicle is CargoPlane)
                        {
                                cargoPlaneList.Add(vehicle as CargoPlane);

                                countCargoPlane++;
                        }
                }

                hightCargoPlane = GetHightCargoPlane(cargoPlaneList);

                Console.WriteLine($"Array has: {countAirPlane} planes.\nArray has: {countCargoPlane} cargo planes.");
                Console.WriteLine($"The Lower airplane is: max height: {lowerAirplane.MaxHeight}, max speed: {lowerAirplane.MaxSpeed}");
                Console.WriteLine($"The hight cargo airplane is: max height: {hightCargoPlane.MaxHeight}, max speed: {hightCargoPlane.MaxSpeed}, max cargo: {hightCargoPlane.MaxCargo}");

        }

        public static Airplane LowerHightAirplane(Airplane firstAirplane, Airplane? secondAirplane)
        {
                if (secondAirplane != null && secondAirplane.MaxHeight < firstAirplane.MaxHeight)
                        return secondAirplane;

                return firstAirplane;
        }

        public static CargoPlane GetHightCargoPlane(List<CargoPlane> cargoPlanes)
        {
                var hightCargoPlane = new CargoPlane(0,0,0) { };

                foreach (var cargoPlane in cargoPlanes)
                {
                        hightCargoPlane = cargoPlane.MaxCargoPlane(hightCargoPlane);
                }

                return hightCargoPlane;
        }
}