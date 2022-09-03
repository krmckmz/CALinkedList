using System;
using System.Collections.Generic;

namespace CALinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList(new Person("Kerem","Çökmez","05313545678",null));
            Person secondNode = new Person("Çağdaş","Çökmez","53145648754",linkedList.FirstNode);
            linkedList.AddNode(secondNode);

        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }   
        public Person PrevNode { get; set; }
        public Person NextNode { get; set; }

        public Person(string firstName,string lastName,string phoneNumber,Person prevNode)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            PrevNode = prevNode;
        }
    }

    public class LinkedList
    {
        public Person FirstNode { get; set; } 
        public Person CurrentNode { get; set; }                
        public Person LastNode { get; set; }
        public bool IsNextNodeExist = false;

         public LinkedList(Person firstNode)
        {
            FirstNode = firstNode;
            CurrentNode = firstNode;
            LastNode = firstNode;
        }

        public void AddNode(Person person)
        {
            if(CurrentNode.NextNode is null)
            {
                CurrentNode = CurrentNode.NextNode=person;
                LastNode = person;
            }
            else 
            {
                Person tempNextNode = CurrentNode.NextNode;
                CurrentNode = person;
                CurrentNode.NextNode = tempNextNode;
            }
        }
        public bool NextNode()
        {
            if(!IsNextNodeExist)
               CurrentNode=FirstNode;

            if(CurrentNode.NextNode!=null)
            {
                CurrentNode = CurrentNode.NextNode;

                IsNextNodeExist=true;
                return true;
            }   

            IsNextNodeExist = false;
            return false;
        }
    }
}