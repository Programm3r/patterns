using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public enum NotificationType
    {
        Achievement,
    }

    public abstract class Observer
    {
        public abstract void OnNotify(object value, NotificationType type);
    }

    /// <summary>
    /// Our concrete observer class
    /// </summary>
    public class Achievement : Observer
    {
        public List<string> achievementList = new List<string>();

        public override void OnNotify(object value, NotificationType type)
        {
            if(type == NotificationType.Achievement)
            {
                string achievementKey = "Achievement-" + value;

                //If achievement unlocked return.
                if(achievementList.Contains(achievementKey))
                {
                    return;
                }

                achievementList.Add(achievementKey);//Add the achievement to list.

                //After this point you can do whatever you want
                //It can be firing an event, or printing a log.
            }

        }
    }
}
