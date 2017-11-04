using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Person
    {
        int id;
        string firstname;
        string lastname;
        string address;
        int age;
        string gender;

        public Person()
        {
            id = 1;
            firstname = "Marcin";
            lastname = "Kowal";
            age = 14;
        }

        public Person(int id, string firstname, string lastname, string address, int age, string gender)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.address = address;
            this.age = age;
            this.gender = gender;
        }

        public Person(int id, string firstname, string lastname)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            address = "Katowice";
            age = 18;
        }

        public Person(int id, string firstname)
        {
            this.id = id;
            this.firstname = firstname;
        }
    }
}
