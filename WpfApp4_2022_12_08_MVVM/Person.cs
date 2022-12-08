using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4_2022_12_08_MVVM
{
    public class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }        
        public string LastName { get; set; }
        public string Image { get; set; }

        public string ImageURl
        {
            get
            {
                return $"/img/{Image}";
            }
        }

        public Person(int age, string firstName, string lastName, string image)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
            Image = image;
        }
    }
}
