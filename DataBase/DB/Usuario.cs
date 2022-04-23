using System;
using System.Collections.Generic;

#nullable disable

namespace DataBase.DB
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public string UserName { get; set; }
        public int? IdTipoUsuario { get; set; }
    }
}
