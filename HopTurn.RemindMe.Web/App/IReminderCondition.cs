using System;

namespace HopTurn.RemindMe.Web
{
    public interface IReminderCondition
    {

        Func<object, bool> IsConditionMet { get; set; }

    }
}