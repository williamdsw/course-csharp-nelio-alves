
using System;
using System.Text;

namespace CourseNelioAlves.Entities
{
    public class Reservation
    {
        // PROPERTIES

        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        // CONSTRUCTORS

        public Reservation() { }
        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        // FUNCTIONS

        private int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int) duration.TotalDays;
        }

        public string UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                return "Reservation dates for update must be future dates";
            }

            if (checkOut <= checkIn)
            {
                return "Check-out date must be after check-in date";
            }

            CheckIn = checkIn;
            CheckOut = checkOut;

            return null;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append($"Room {RoomNumber}, ");
            builder.Append($"check-in {CheckIn.ToString("dd/MM/yyyy")}, ");
            builder.Append($"check-out {CheckIn.ToString("dd/MM/yyyy")}, ");
            builder.Append($"{Duration()} nights! ");
            return builder.ToString();
        }
    }
}
