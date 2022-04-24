using System;
using System.Collections.Generic;

#nullable disable

namespace DataBase.DB
{
    public partial class TPelicula
    {
        public int CodPelicula { get; set; }
        public string TxtDesc { get; set; }
        public int? CantDisponiblesAlquiler { get; set; }
        public int? CantDisponiblesVenta { get; set; }
        public decimal? PrecioAlquiler { get; set; }
        public decimal? PrecioVenta { get; set; }
        public int? IdGenero { get; set; }

        public virtual TGenero IdGeneroNavigation { get; set; }
    }
}
