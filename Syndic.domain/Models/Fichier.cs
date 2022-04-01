﻿using System;
using System.Collections.Generic;

namespace Syndic.domain.Models
{
    public partial class Fichier
    {
        public int IdFichier { get; set; }
        public string? Note { get; set; }
        public string? Fichier1 { get; set; }
        public DateOnly? DateCreation { get; set; }
        public string? Typee { get; set; }
        public int? IdDossier { get; set; }

        public virtual Dossier? IdDossierNavigation { get; set; }
    }
}
