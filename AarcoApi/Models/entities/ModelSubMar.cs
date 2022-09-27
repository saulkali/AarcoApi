using System;
using System.Collections.Generic;

#nullable disable

namespace AarcoApi.Models.entities
{
    public partial class ModelSubMar
    {
        public ModelSubMar()
        {
            Descripcion = new HashSet<Descripcion>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int? IdSubMarca { get; set; }

        public virtual SubMarca IdSubMarcaNavigation { get; set; }
        public virtual ICollection<Descripcion> Descripcion { get; set; }
    }
}
