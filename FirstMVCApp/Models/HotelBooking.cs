namespace FirstMVCApp.Models
{
    public class HotelBooking
    {
        public int Id { get; set; }
        public string GuestName { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
    }
}
