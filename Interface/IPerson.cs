using System;
using ObserverPattern.SubjectClass;

namespace ObserverPattern.Interface
{
    // This is the Observer Interface Class
    interface IPerson
    {
        void Update(ReferencedItem refItem);
    }


    // This is the 'ConcreteObserver' class
    class Person : IPerson
    {
        private string _name;
        private ReferencedItem _refItem;

        public Person(string name)
        {
            this._name = name;
        }

        // This will stakeholders of changes to the referenced item
        public void Update(ReferencedItem refItem)
        {
            Console.WriteLine("");
            Console.WriteLine("{0} notified of update to {1}: {2}", 
                _name, refItem.ItemType, refItem.ItemTitle);
            Console.WriteLine("Update: {0} by {1}",
                refItem.UpdateType, refItem.UpdatedBy);
            Console.WriteLine("Update reference ID: {0}", refItem.ReferenceID);
        }

        // This will get/set the referenced item
        public ReferencedItem ReferencedItem
        {
            get { return _refItem; }
            set { _refItem = value; }
        }
    }
}
