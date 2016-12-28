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

            bool wasReminderTriggered = false;

            IReminderEngine engine = new ReminderEngine();
            IReminder reminder = new MockReminder()
            {
                Condition = new MockTrueCondition(),
                Message = new MockMessage()
                {
                    DoMessage = (obj) => {
                        wasReminderTriggered = true;
                        Console.WriteLine("Condition is Met");
                    }
                }
            };
            
            engine.Reminders.Add(reminder);

            engine.RunEngine();

            Assert.IsTrue(wasReminderTriggered);

        }
    }

    internal class MockMessage : IReminderMessage
    {
        public Action<object> DoMessage { get; set; }
    }

    internal class MockTrueCondition : IReminderCondition
    {
        public bool IsConditionMet()
        {
            return true;
        }
    }

    internal class MockReminder : IReminder
    {
        public IReminderCondition Condition { get; set; }
        public IReminderMessage Message { get; set; }
    }
}
