using DataLayer;
using EntityLayer.Abstract;
using EntityLayer.Concrete.Cargos;
using EntityLayer.Concrete.Orders;
using EntityLayer.Concrete.Persons;
using EntityLayer.Concrete.Vehicles;

IOrder order = new PostPayment();
IVehicle vehicle = new Truck();
vehicle.ID = 1;
vehicle.Name = "Ford 3820";
ICargo cargo = new DryFood();
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
/*
opr.loadOnWay(); //YÜK YOLA ÇIKTI
Thread.Sleep(5000); //5 SANİYE ARA
opr.loadIsArrived(); //YÜK YERİNE ULAŞTI
opr.Order.applyPayment(); //ÖDEME TAMAMLANDI
*/

opr.LoadOnWay(Vehicle.Types.Train,44,6);