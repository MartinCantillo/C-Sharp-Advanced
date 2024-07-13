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

        public WondersOfTheAncientWorld FavoriteAncientWonder;

        public List <Person>Children=new List<Person>();
        

    }
}