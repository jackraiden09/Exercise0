namespace Cars.Models 
{
    //Number 4
    public class Car : Vehicle
    {
        private string Model {get; set;}

        //Number 5
        public Car(string carColor, string carBrand, string carModel)
            :base (carColor, carBrand)
        {
            this.Model = carModel;
        }

        public string ShowVehicle()
        {
            string carData = base.ShowVehicle() + " " + this.Model;

            return carData;
        }
    }
}