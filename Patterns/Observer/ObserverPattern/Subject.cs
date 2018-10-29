using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public abstract class Subject
    {
        private List<Observer> _observers = new List<Observer>();

        public void Register(Observer o)
        {
            _observers.Add(o);
        }

        public void Unregister(Observer o)
        {
            _observers.Remove(o);
        }

        public void NotifyObserver(object value, NotificationType type)
        {
            foreach(Observer o in _observers)
            {
                o.OnNotify(value, type);
            }
        }
    }

    public class Player : Subject
    {
        private int _spidersKilled;
        public int SpidersKilled
        {
            get { return _spidersKilled; }
            set
            {
                _spidersKilled = value;
                if(_spidersKilled == 5)
                {
                    NotifyObserver("5 Spiders Killed", NotificationType.Achievement);
                }
            }
        }

        public void KillSpider()
        {
            SpidersKilled++;
        }
    }
}
