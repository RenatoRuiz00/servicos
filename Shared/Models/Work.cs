using System;

namespace Servicos.Shared.Models
{
    public class Work
    {
        public int Id { get; set; }
        public User Contractor { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public DateTime DtRegistration { get; set; }
        public bool Finished { get; set; }
    }
}
