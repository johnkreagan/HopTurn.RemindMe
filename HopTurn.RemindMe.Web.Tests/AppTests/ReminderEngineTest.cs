using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HopTurn.RemindMe.Web.App;

namespace HopTurn.RemindMe.Web.Tests.AppTests
{
    [TestClass]
    public class ReminderEngineTests
    {
        [TestMethod]
        public void TestReminderIsTriggeredWhenConditionIsMet()
        {

            
            IReminderEngine engine = new ReminderEngine();
            

            Reminder reminder = new MockReminder()
            {
                Condition = new MockTrueCondition(),
                Message = new MockMessage()
            };
            
            engine.Reminders.Add(reminder);

            engine.RunEngine();

            Assert.IsTrue(reminder.Message.Status == MessageStatus.Sent);

        }
    }

    internal class MockMessage : ReminderMessage
    {
        public override void SendMessage()
        {
            this.DoMessage(null);
            this.Status = MessageStatus.Sent;
        }

        protected override void DoMessage(object obj)
        {

            Console.WriteLine("Condition is Met");
        }
    }

    internal class MockTrueCondition : ReminderCondition
    {
        public override bool IsConditionMet()
        {
            return true;
        }
    }

    internal class MockReminder : Reminder
    {

    }
}
