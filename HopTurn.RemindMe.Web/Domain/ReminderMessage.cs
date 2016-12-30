using System;

namespace HopTurn.RemindMe.Web
{
    public abstract class ReminderMessage
    {

        public int Id { get; set; }

        public abstract void SendMessage();

        protected abstract void DoMessage(object context);

        public MessageStatus Status { get; set; }
    }

    public enum MessageStatus
    {
        NotSent,
        Sent
    }
}