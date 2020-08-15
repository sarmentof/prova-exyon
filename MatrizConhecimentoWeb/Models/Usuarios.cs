using System;
using System.Collections.Generic;

namespace MatrizConhecimentoWeb.Models
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            NotasUsuariosAssunto = new HashSet<NotasUsuariosAssunto>();
        }

        public int idUsuario { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public DateTime dtNascimento { get; set; }
        public string login { get; set; }
        public string senha { get; set; }

        public virtual ICollection<NotasUsuariosAssunto> NotasUsuariosAssunto { get; set; }
    }
}
