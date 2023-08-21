using DataLayer;
using EntityLayer.Abstract;
using EntityLayer.Concrete.Cargos;
using EntityLayer.Concrete.Orders;
using EntityLayer.Concrete.Persons;
using EntityLayer.Concrete.Vehicles;

IOrder order = new PostPayment();
IVehicle vehicle = new Vehicle();
vehicle.ID = 1;
vehicle.Name = "Ford 3820";
ICargo cargo = new Cargo();
cargo.ID = 1;
cargo.Name="Yeşil Mercimek";
IPerson person = new Driver();
person.ID = 1;
person.Name = "Fatih Aktürk";
Operation opr = new Operation();

opr.Vhc = vehicle;
opr.Order = order;
opr.Cargo = cargo;
opr.Person = person;


foreach (var item in DistanceCities.CityNames)
{
    Console.WriteLine("{0}-{1}",item.Key, item.Value);
}

Console.WriteLine("Hareket edecek şehrin plakasını giriniz: ");
int StartingPoint = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Varış şehrinin plakasını giriniz: ");
int EndingPoint = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("*************");
opr.LoadOnWay(Vehicle.Types.Truck,Cargo.Types.DryFood,StartingPoint,EndingPoint);
Console.WriteLine("*************");
opr.LoadIsArrived();