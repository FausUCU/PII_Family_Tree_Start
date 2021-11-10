using System;
using Library;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Maria=new Person("Maria",1);
            Node n1 = new Node(Maria);
            Person Rafaela=new Person("Rafaela",2);
            Node n2 = new Node(Rafaela);
            Person Juana=new Person("Juana",3);
            Node n3 = new Node(Juana);
            Person Violeta=new Person("Violeta",4);
            Node n4 = new Node(Violeta);
            Person Michaela=new Person("Michaela",5);
            Node n5 = new Node(Michaela);
            Person Rosa=new Person("Rosa",6);
            Node n6 = new Node(Rosa);
            Person Ronda=new Person("Ronda",7);
            Node n7 = new Node(Ronda);
            Person Elena=new Person("Elena",999);
            Node n8 =new Node(Elena);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);
            n4.AddChildren(n8);

            // visitar el árbol aquí
           
            
            Console.WriteLine($" N1 Es hijo = {n1.IsChild}, N1 tiene hijo = {n1.HasChild}");
            Console.WriteLine($" N4 Es hijo = {n4.IsChild}, N4 tiene hijo = {n4.HasChild}");
            Console.WriteLine($" N8 Es hijo = {n8.IsChild}, N8 tiene hijo = {n8.HasChild}");

            VisitorAge age=new VisitorAge();
           int edadmayor=age.Visit(n1);
            Console.WriteLine($"La edad mayor es {edadmayor}");

            
           
           
            
            
        }
    }
}
