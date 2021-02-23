using System;

namespace Servicos.Shared.Models
{
    class Candidate
    {
        public Work Work { get; set; }
        public User Worker { get; set; }
        public DateTime DtSubscription { get; set; }
    }
}
