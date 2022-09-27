using System;
using System.Collections.Generic;

#nullable disable

namespace AarcoApi.Models.entities
{
    public partial class Descripcion
    {
        public int Id { get; set; }
        public string Descripcion1 { get; set; }
        public string DescripcionId { get; set; }
        public int? IdModeloSubM { get; set; }

        public virtual ModelSubMar IdModeloSubMNavigation { get; set; }
    }
}
