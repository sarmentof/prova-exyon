using System;
using System.Collections.Generic;

namespace MatrizConhecimentoWeb.Models
{
    public partial class NotasUsuariosAssunto
    {
        public int idNotaUsuarioAssunto { get; set; }
        public int idAssunto { get; set; }
        public int idTipoAssunto { get; set; }
        public int idUsuario { get; set; }
        public int idCriterio { get; set; }

        public virtual Assuntos id { get; set; }
        public virtual Criterios idCriterioNavigation { get; set; }
        public virtual Usuarios idUsuarioNavigation { get; set; }
    }
}
