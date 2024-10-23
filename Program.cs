using MyCar;

Console.WriteLine("Hello, World!");

Tire leftFrontTire = new Tire { name = "leftFrontTire" };
Tire rightFrontTire = new Tire { name = "rightFrontTire" };
Tire leftRearTire = new Tire { name = "leftRearTire" };
Tire rightRearTire = new Tire { name = "rightRearTire" };
List<Tire> tires = [leftFrontTire, rightFrontTire, leftRearTire, rightRearTire];

Lamp leftFrontLight = new Lamp { Name = "leftFrontLight" };
Lamp rightFrontLight = new Lamp { Name = "rightFrontLight" };
List<Lamp> frontLights = [leftFrontLight, rightFrontLight];

Lamp leftRearLight = new Lamp { Name = "leftRearLight" };
Lamp rightRearLight = new Lamp { Name = "leftRearLight" };
List<Lamp> rearLights = [leftRearLight, rightRearLight];

Engine engine = new Engine();

Car car = new Car(tires, frontLights, rearLights, engine);
rightRearLight.Name = "rightRearLight";

car.Drive();

foreach(Lamp lamp in car.RearLight)
{
    lamp.turnOn();
}