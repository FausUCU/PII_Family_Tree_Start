using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Linq;

namespace Library
{
    
    public class VisitorAge: IVisitor
    {
        public int Visit(Person person)
        {
            return person.Age;
        }
        public int Visit(Node n)
        {
            Person mayor=n.Person;
            if (n.Children.Count()>0)
            {
                foreach (Node child in n.Children)
                {
                   if(this.Visit(child) >mayor.Age)
                    {
                        mayor = child.Person;
                    }
                }
            }
            if(n.Person.Age>mayor.Age)
            {
                mayor = n.Person;
            }
           
            return mayor.Age;
           
           

        }
            
    }
    
}