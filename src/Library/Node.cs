using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node: IVisitado 
    {
        private bool isChild=false;

        private bool hasChild=false;

        private Person person;

        private List<Node> children = new List<Node>();

        private int childrenNumber
        {
            get
            {
                return children.Count;
            }
        }
        
        public bool IsChild
        {
            get
            {
                return isChild;
            }
            set
            {
                isChild = value;
            }
        }
        public bool HasChild
        {
            get
            {
                return hasChild;
            }
            set
            {
                hasChild = value;

            }
        }

        public Person Person
        {
            get
            {
                return this.person;
            }
        }

        public List<Node> Children 
        { 
            get
            {
                return this.children;
            }
        }
        public int ChildrenNumber
        {
            get
            {
                return this.childrenNumber;
            }
        }

        public Node(Person Person)
        {
            this.person = Person;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
            n.IsChild = true;
            this.HasChild = true;
            
        }
        public void AddPerson(Person p)
        {
            this.person=p;
        }
       
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        

        
        

        
    }
}
