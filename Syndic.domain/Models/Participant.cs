using System;
using System.Collections.Generic;

namespace syndic1.Models
{
    public partial class Participant
    {
        public Participant()
        {
            Resultats = new HashSet<Resultat>();
        }

        public int IdParticipant { get; set; }
        public string? Nom { get; set; }

        public virtual ICollection<Resultat> Resultats { get; set; }
    }
}
