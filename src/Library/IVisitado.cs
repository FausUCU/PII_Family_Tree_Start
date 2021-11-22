using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public interface IVisitado
    {
        void Accept(IVisitor visitor);
    }
}