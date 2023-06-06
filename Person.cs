using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrstruktor
{
    public class Person
    {
        // property
        public string Name;
        public int Age;

        //kosntructor
        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public Person()
        {

        }

        //fungsi
        public void InfoPerson(string Name, int Age)
        {
            Console.WriteLine("Nama : " + Name);
            Console.WriteLine("Age  : " + Age);
        }
    }

    //class turunan
    public class karyawan : Person
    {
        public string KaryawanID { get; set; }
        public string subject { get; set; }

        //overfride method
        public void InfoPerson(string KaryawanID, string subject)
        {
            //constructor
            this.subject = subject;
            Console.WriteLine("Nama : " + Name);
            Console.WriteLine("Age  : " + Age);

        }
    }
   
}
