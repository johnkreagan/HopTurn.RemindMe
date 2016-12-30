using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopTurn.RemindMe.Web.App
{
    public interface IReminderEngine
    {


        List<Reminder> Reminders {
            get; set;
        }

        void RunEngine();
    }
}
