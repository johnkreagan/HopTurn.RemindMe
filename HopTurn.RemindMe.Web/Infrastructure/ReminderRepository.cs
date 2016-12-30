using System;
using System.Collections.Generic;
using HopTurn.RemindMe.Web.App;

namespace HopTurn.RemindMe.Web
{
    internal class ReminderRepository : IReminderRepository
    {

        public ReminderRepository()
        {

        }

        public bool AddReminder(ReminderMessage remidner)
        {
            throw new NotImplementedException();
        }

        public bool DeleteReminder(ReminderMessage reminder)
        {
            throw new NotImplementedException();
        }

        public List<ReminderMessage> FindReminderById(int id)
        {
            throw new NotImplementedException();
        }

        public bool SaveReminder(ReminderMessage reminder)
        {
            throw new NotImplementedException();
        }
    }
}