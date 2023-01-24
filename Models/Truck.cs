namespace Cars.Models 
{
    //Number 6
    public class Truck : Vehicle
    {
        private float Capacity {get; set;}
        private string Model {get; set;}

        //Number 7
        public Truck(string carColor, string carBrand, float carCapacity, string carModel)
            :base (carColor, carBrand)
        {
            this.Capacity = carCapacity;
            this.Model = carModel;
        }

        public string ShowVehicle()
        {
            string truckData = base.ShowVehicle() + " " + this.Model + " " + Convert.ToString(this.Capacity);

            return truckData;
        }
    }
}