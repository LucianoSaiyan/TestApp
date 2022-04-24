using System;
using System.Collections.Generic;

#nullable disable

namespace DataBase.DB
{
    public partial class TGenero
    {
        public TGenero()
        {
            TPeliculas = new HashSet<TPelicula>();
        }

        public int CodGenero { get; set; }
        public string TxtDesc { get; set; }

        public virtual ICollection<TPelicula> TPeliculas { get; set; }
    }
}
