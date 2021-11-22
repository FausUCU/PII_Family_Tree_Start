using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Person: IVisitado
    {
        
        public Person(string name,int age)
        {
            this.Name=name;
            this.Age=age;

        }
        public string Name
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
      
        
    }
}