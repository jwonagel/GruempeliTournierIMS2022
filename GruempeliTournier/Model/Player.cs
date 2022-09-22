using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


[assembly: InternalsVisibleTo("GruempeliTournier.Test")]

namespace GruempeliTournier.Model
{
    internal class Player
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public Gender Gender { get; set; }


        public string GetFullName()
        {
            return $"{FirstName} {Name} ({BirthDate:dd. MMM yyyy})";
        }

    }

    public enum Gender
    {
        Male = 0,
        Female = 1,
        Undef = 2
    }
}
