using System;
using System.Collections.Generic;

namespace syndic1.Models
{
    public partial class Statut
    {
        public Statut()
        {
            Dossiers = new HashSet<Dossier>();
        }

        public int IdStatut { get; set; }
        public string? NomStatut { get; set; }

        public virtual ICollection<Dossier> Dossiers { get; set; }
    }
}
