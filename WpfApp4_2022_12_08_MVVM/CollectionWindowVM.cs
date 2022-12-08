using System;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4_2022_12_08_MVVM
{
    public class CollectionWindowVM : ObservableObject
    {
        public List<Person> Persons { get; set; }
        public CollectionWindowVM(){
            Persons = new List<Person>()
            {
                new Person(10,"James","Bond","1.png"),
                new Person(20,"George","Kal","2.png"),
                new Person(40,"Hector","Ben","3.png"),
                new Person(60,"John","Zap","4.png"),
                new Person(70,"Tom","Kay","5.png"),
                new Person(80,"Ben","Rasmika","6.png"),
        };
        
        }
    }

}

