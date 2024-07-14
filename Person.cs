using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OOP.enums;

namespace OOP.Person
{
    public class Person : Object
    {


        public String Name;
        public DateTime DateOfBirth;
        // constants
        public const string Species = "Homo Sapien";
        public WondersOfTheAncientWorld FavoriteAncientWonder;

        public List<Person> Children = new List<Person>();


        //Setting setter and getters

        private string favoritePrimaryColor;

        public string FavoritePrimaryColor
        {
            get
            {
                return favoritePrimaryColor;
            }
            set
            {
                switch (value.ToLower())
                {
                    case "red":
                    case "green":
                    case "blue":
                        favoritePrimaryColor = value;
                        break;
                    default:
                        throw new System.ArgumentException(
                        $"{value} is not a primary color. " +
                        "Choose from: red, green, blue.");

                }
            }
        }


    }
}