using System;
using System.Collections.Generic;

#nullable disable

namespace DataBase.DB
{
    public partial class TiposUsuario
    {
        public TiposUsuario()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int IdTipoUsuario { get; set; }
        public string DescripcionTipo { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
