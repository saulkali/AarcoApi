using System;
using System.Collections.Generic;

#nullable disable

namespace AarcoApi.Models.entities
{
    public partial class Marcas
    {
        public Marcas()
        {
            SubMarca = new HashSet<SubMarca>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<SubMarca> SubMarca { get; set; }
    }
}
