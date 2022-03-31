using System;
using System.Collections.Generic;

namespace syndic1.Models
{
    public partial class Choix
    {
        public Choix()
        {
            Resultats = new HashSet<Resultat>();
        }

        public int IdChoix { get; set; }
        public string? Choix1 { get; set; }
        public int? IdVote { get; set; }

        public virtual Vote? IdVoteNavigation { get; set; }
        public virtual ICollection<Resultat> Resultats { get; set; }
    }
}
