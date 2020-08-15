using System;
using System.Collections.Generic;

namespace MatrizConhecimentoWeb.Models
{
    public partial class Assuntos
    {
        public Assuntos()
        {
            NotasUsuariosAssunto = new HashSet<NotasUsuariosAssunto>();
        }

        public int idAssunto { get; set; }
        public int idTipoAssunto { get; set; }
        public string nomeAssunto { get; set; }

        public virtual TiposAssunto idTipoAssuntoNavigation { get; set; }
        public virtual ICollection<NotasUsuariosAssunto> NotasUsuariosAssunto { get; set; }
    }
}
