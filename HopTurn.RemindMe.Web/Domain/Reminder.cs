namespace HopTurn.RemindMe.Web.App
{
    public class Reminder
    {

        public int Id { get; set; }

        public int ConditionId { get; set; }

        public virtual ReminderCondition Condition { get; set; }

        public int MessageId { get; set; }

        public virtual ReminderMessage Message { get; set; }
        
    }
}