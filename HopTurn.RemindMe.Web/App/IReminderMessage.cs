using System;

namespace HopTurn.RemindMe.Web
{
    public interface IReminderMessage
    {

        Action<Object> DoMessage { get; set; }
    }
}