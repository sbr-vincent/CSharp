Vehicle v = new Vehicle("Hyundai", 5, "silver", true);
Vehicle v2 = new Vehicle("Corvette", 2, "grey green", true);
Vehicle v3 = new Vehicle("Toyota", "blue");
Vehicle v4 = new Vehicle("Hyundai", "white");

List<Vehicle> lot = new List<Vehicle>() {v, v2, v3, v4};
foreach(Vehicle car in lot){
    car.ShowInfo();
}

v.Travel(100);
v.ShowInfo();

