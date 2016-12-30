using System;

namespace HopTurn.RemindMe.Web
{
    public abstract class ReminderCondition
    {

        public int Id { get; set; }

        public abstract bool IsConditionMet();

    }
}