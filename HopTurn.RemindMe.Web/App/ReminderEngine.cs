using HopTurn.RemindMe.Web.App;
using System.Collections.Generic;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace HopTurn.RemindMe.Web
{
    public class ReminderEngine : IReminderEngine
    {
        private List<Reminder> _reminders = new List<Reminder>();

        public List<Reminder> Reminders
        {
            get { return _reminders; }
            set { _reminders = value; }
        }


        public async void RunEngine()
        {
            
            foreach (Reminder reminder in Reminders)
            {
                if (reminder.Condition?.IsConditionMet() == true)
                {
                    reminder.Message.SendMessage();
                }
            }
                
        }
        
    }
}