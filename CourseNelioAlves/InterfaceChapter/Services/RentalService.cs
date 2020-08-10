
using Entities;

namespace Services
{

    public class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        public RentalService() { }
        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental)
        {

        }
    }
}
