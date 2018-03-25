using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    // Represents the data in the database, this is the .java file
    public class StarWarsCharacter
    {
        //This is the way that we declare not only instance variables, but their getter's and setter's 
        //as well. 

        // Also not the PascalCase variable naming convention

        public string Name { get; set; }
        public string HomePlanet { get; set; }
        public bool IsForceSensitive { get; set; }
        public bool IsDarkSide { get; set; }
    }
}