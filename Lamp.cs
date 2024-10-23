namespace MyCar
{
    public class Lamp
    {
        public string Name { get; set; }
        public bool IsLightOn { get; set; }

        public void turnOn()
        {
            if (IsLightOn) 
            {
                Console.WriteLine("Error, Light is already on");
                return;
            }

            IsLightOn = true;

            Console.WriteLine($"{Name} on");
            return;
        }

        public void turnOff()
        {
            if (!IsLightOn)
            {
                Console.WriteLine("Error, Light is already on");
                return;
            }

            IsLightOn = false;

            Console.WriteLine($"{Name} off");
            return;
        }
    }
}
