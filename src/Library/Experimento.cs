using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Linq;

namespace Library
{
    public class Experimento: IVisitor
    {
        public int Visit(Person person)
        {
            return person.Age;
        }

        public int Visit(Node node)
        {
            int<descent>
            if(node.HasChild)
            {
                foreach(var child in node.Children)
                {
                    Visit(child);
                }
            }
        }
        

    }
}