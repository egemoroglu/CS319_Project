using System;
using System.Collections.Generic;
using System.Threading;

namespace PeeReview.Models
{
    public interface IObserverNotification
    //This needs to be connected with the views and models once done
    {
       // Receive update from subject
        void Update(SubjectNotification subject,List<Notification> notifications, string title, string content);
    }

    public interface ISubjectNotification
    {
        // Attach an observer to the subject.
        void Attach(IObserverNotification observer);

        // Detach an observer from the subject.
        void Detach(IObserverNotification observer);

        // Notify all observers about an event.
        void Notify(List<Notification> notifications,string title, string content);
    }

    // The Subject owns some important state and notifies observers when the
    // state changes.
    public class SubjectNotification : ISubjectNotification
    {
        // For the sake of simplicity, the Subject's state, essential to all
        // subscribers, is stored in this variable.
        public Boolean State { get; set; } = false;

        public string Name { get; private set; }

        // List of subscribers. In real life, the list of subscribers can be
        // stored more comprehensively (categorized by event type, etc.).
        private List<IObserverNotification> observers = new List<IObserverNotification>();

        // The subscription management methods.
        public void Attach(IObserverNotification observer)
        {
            
            this.observers.Add(observer);
        }

        public void Detach(IObserverNotification observer)
        {
            this.observers.Remove(observer);

        }

        // Trigger an update in each subscriber.
        public void Notify( List<Notification> notifications,string title, string content)
        {
            foreach (var observer in observers)
            {
                observer.Update(this, notifications,  title,  content);
            }
        }


    }

    // Concrete Observers react to the updates issued by the Subject they had
    // been attached to.
    public class ConcreteObserver : IObserverNotification //this should in controller
    {
        public void Update(SubjectNotification subject,List<Notification> notifications, string title, string content)
        {            
            if (subject.State)
            {
                notifications.Add( new Notification(title, content, subject.Name));
            }
        }
    }


}