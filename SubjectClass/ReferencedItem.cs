using System;
using System.Collections.Generic;
using ObserverPattern.Interface;

namespace ObserverPattern.SubjectClass
{
    /// <summary>
    /// The 'Subject abstract class
    /// </summary>
    abstract class ReferencedItem
    {
        private string _itemType;
        private string _title;
        private string _referenceID;
        private string _updatedBy;
        private string _updateType;
        private List<IPerson> _stakeholders = new List<IPerson>();

        public ReferencedItem(string title, string referenceID)
        {
            this._title = title;
            this._referenceID = referenceID;
        }

        public string ItemType 
        {
            get { return _itemType; }
            set { _itemType = value; }
        }

        public string ItemTitle { get { return _title; } }
        public string UpdatedBy { get { return _updatedBy; } }
        public string UpdateType { get { return _updateType; } }
        
        public string ReferenceID
        {
            get { return _referenceID; }
            set { _referenceID = value; }
        }

        public void Attach(IPerson person)
        {
            _stakeholders.Add(person);
        }

        public void Notify()
        {
            foreach (IPerson stakeholder in _stakeholders)
            {
                stakeholder.Update(this);
            }
        }

        public void UpdateItem(string updateType, string updatedBy)
        {
            this._updatedBy = updatedBy;
            this._updateType = updateType;
            this.Notify();
        }
    }


    /// <summary>
    /// Concrete class: Project Task
    /// </summary>
    class ProjectTask : ReferencedItem
    {
        private string _itemType = "Project Task";

        public ProjectTask(string title, string referenceID) :
            base(title, referenceID)
        {
            base.ItemType = _itemType;
        }
    }

    /// <summary>
    /// Concrete class: Development Project
    /// </summary>
    class DevelopmentProject : ReferencedItem
    {
        private string _itemType = "Development Project";

        public DevelopmentProject(string title, string referenceID)
            : base(title, referenceID)
        {
            base.ItemType = _itemType;
        }
    }
}
