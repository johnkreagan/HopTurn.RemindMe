namespace HopTurn.RemindMe.Web.App
{
    public interface IReminder
    {

        IReminderCondition Condition { get; set; }

        IReminderMessage Message { get; set; }
        
    }
}