using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HopTurn.RemindMe.Web.Models.Reminders
{
    public class OneTimeReminderCondition : ReminderCondition
    {

        public DateTime TriggerTime { get; set; }

        public override bool IsConditionMet()
        {
            //make sure time is in UTC. >= 0 means UtcNow is later or equal to time
            return (DateTime.UtcNow.CompareTo(TriggerTime.ToUniversalTime()) >= 0);
        }
    }
}