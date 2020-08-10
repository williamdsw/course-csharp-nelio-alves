﻿
using Services;
using Entities;
using System;

namespace Services
{
    public class RentalService
    {
        private BrazilTaxService _brazilTaxService = new BrazilTaxService();

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
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment = 0.0;

            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _brazilTaxService.Tax(basicPayment);

            Invoice invoice = new Invoice(basicPayment, tax);
            carRental.Invoice = invoice;
        }
    }
}
