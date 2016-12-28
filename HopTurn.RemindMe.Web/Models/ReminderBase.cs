using HopTurn.RemindMe.Web.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HopTurn.RemindMe.Web.Models
{
    public class ReminderBase : IReminder
    {
        private IReminderCondition condition;

        public IReminderCondition Condition
        {
            get { return condition; }
            set { condition = value; }
        }

        private IReminderMessage message;

        public IReminderMessage Message
        {
            get { return message; }
            set { message = value; }
        }

    }
}