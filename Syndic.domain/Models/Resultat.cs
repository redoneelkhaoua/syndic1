using System;
using System.Collections.Generic;

namespace syndic1.Models
{
    public partial class Resultat
    {
        public int IdVote { get; set; }
        public int IdParticipant { get; set; }
        public int? IdChoix { get; set; }

        public virtual Choix? IdChoixNavigation { get; set; }
        public virtual Participant IdParticipantNavigation { get; set; } = null!;
        public virtual Vote IdVoteNavigation { get; set; } = null!;
    }
}
