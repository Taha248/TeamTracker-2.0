using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTracker2._0
{
    public class User
    {
        private string UserID;
        private string total_users;
        private string incomplete_tasks;
        private string tasks_completed;
        public string ActiveUsers
        {
            get { return UserID; }
            set { UserID = value; }
        }
        public string TotalUsers
        {
            get { return total_users; }
            set { total_users = value; }
        }
        private string CompletedTask { get; set; }
        public string TaskInProgress
        {
            get { return incomplete_tasks; }
            set { incomplete_tasks = value; }
        }
        public string TaskCompleted
        {
            get { return tasks_completed; }
            set { tasks_completed = value; }
        }
    }
}
