using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HopTurn.RemindMe.Web.Models;
using HopTurn.RemindMe.Web.Models.Reminders;

namespace HopTurn.RemindMe.Web.Tests.ConditionTests
{
    [TestClass]
    public class OneTimeReminderConditionTests
    {
        [TestMethod]
        public void TestReminderIsTriggeredWhenTriggeredTimeIsReached()
        {

            OneTimeReminderCondition condition = new OneTimeReminderCondition();

            condition.TriggerTime = DateTime.Now;

            Assert.IsTrue(condition.IsConditionMet());
        }

        [TestMethod]
        public void TestReminderIsNotTriggeredIfTririggerdTimeIsInFuture()
        {

            OneTimeReminderCondition condition = new OneTimeReminderCondition();

            condition.TriggerTime = DateTime.Now.AddMinutes(15);

            Assert.IsFalse(condition.IsConditionMet());
        }
    }
}
