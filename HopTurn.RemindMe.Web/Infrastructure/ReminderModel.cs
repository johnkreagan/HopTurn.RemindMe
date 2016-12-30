namespace HopTurn.RemindMe.Web.Infrastructure
{
    using App;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ReminderModel : DbContext
    {
        // Your context has been configured to use a 'ReminderModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'HopTurn.RemindMe.Web.Infrastructure.ReminderModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ReminderModel' 
        // connection string in the application configuration file.
        public ReminderModel()
            : base("name=ReminderModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Reminder> Reminders { get; set; }

        public virtual DbSet<ReminderCondition> ReminderConditions { get; set; }

        public virtual DbSet<ReminderMessage> ReminderMessages { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}