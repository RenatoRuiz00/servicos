namespace Servicos.Shared.Models
{
    class Rating
    {
        public int Id { get; set; }
        public double Level { get; set; }
        public string Comment { get; set; }
        public User UserRated { get; set; }
        public User UserPost { get; set; }
    }
}
