﻿using System;
using System.Collections.Generic;

namespace Syndic.domain.Models
{
    public partial class Note
    {
        public int IdNote { get; set; }
        public string? Note1 { get; set; }
        public DateOnly? DateCreation { get; set; }
        public string? Typee { get; set; }
        public int? IdDossier { get; set; }

        public virtual Dossier? IdDossierNavigation { get; set; }
    }
}
