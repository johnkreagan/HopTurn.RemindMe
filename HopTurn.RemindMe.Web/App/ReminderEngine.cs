using HopTurn.RemindMe.Web.App;
using System.Collections.Generic;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace HopTurn.RemindMe.Web
{
    public class ReminderEngine : IReminderEngine
    {
        private List<IReminder> _reminders = new List<IReminder>();

        public List<IReminder> Reminders
        {
            get { return _reminders; }
            set { _reminders = value; }
        }


        public async void RunEngine()
        {
            
            foreach (IReminder reminder in Reminders)
            {
                if (reminder.Condition?.IsConditionMet.Invoke(null) == true)
                {
                    reminder.Message.DoMessage.Invoke(null);
                }
            }
                
        }
        
    }
}