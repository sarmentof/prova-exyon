using System;
using System.Collections.Generic;

namespace MatrizConhecimentoWeb.Models
{
    public partial class Criterios
    {
        public Criterios()
        {
            NotasUsuariosAssunto = new HashSet<NotasUsuariosAssunto>();
        }

        public int idCriterio { get; set; }
        public string nomeCriterio { get; set; }
        public int valorCriterio { get; set; }

        public virtual ICollection<NotasUsuariosAssunto> NotasUsuariosAssunto { get; set; }
    }
}
