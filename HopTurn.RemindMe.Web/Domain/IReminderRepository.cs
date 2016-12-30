using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopTurn.RemindMe.Web.App
{
    public interface IReminderRepository
    {

        bool AddReminder(ReminderMessage remidner);

        bool SaveReminder(ReminderMessage reminder);

        bool DeleteReminder(ReminderMessage reminder);

        List<ReminderMessage> FindReminderById(int id);
        
    }
}
