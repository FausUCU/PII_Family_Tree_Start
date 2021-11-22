using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{

    
    public interface IVisitor
    {
      
        int Visit(Person person);

        int Visit(Node node);

    }
}