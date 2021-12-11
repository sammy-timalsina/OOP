using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDesign.Encapsulation
{
    public class User
    {
        private string _name;
        private int _age;
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public int Age
        {
            get => _age;
            set => _age = value > 0 ? value:0; 
        }
        //public void setAge(int age)
        //{
        //    if (age >= 0)
        //    {
        //        this._age = age;
        //    }           
        //}
        //public int getAge()
        //{
        //    return this._age;
        //}
    }
}
