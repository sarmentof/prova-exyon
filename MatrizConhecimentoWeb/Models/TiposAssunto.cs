using System;
using System.Collections.Generic;

namespace MatrizConhecimentoWeb.Models
{
    public partial class TiposAssunto
    {
        public TiposAssunto()
        {
            Assuntos = new HashSet<Assuntos>();
        }

        public int idTipoAssunto { get; set; }
        public string nomeTipoAssunto { get; set; }

        public virtual ICollection<Assuntos> Assuntos { get; set; }
    }
}
