namespace Cars.Models {

    //Number 2
    public class Vehicle 
    {
        private string Color;
        private string Brand;

        //Number 3
        public Vehicle(string carColor, string carBrand)
        {
            this.Color = carColor;
            this.Brand = carBrand;
        }

        public string ShowVehicle()
        {
            string vehicleData = this.Color + " " + this.Brand;
            return vehicleData;
        }

    }

}