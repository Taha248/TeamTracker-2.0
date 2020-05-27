using GridViewExample;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTracker2._0
{
    class DB_Initialization
    {
        public static List<User> activeUsers = null;
        public static List<User> totalUsers = null;
        public static List<User> incompletedTask = null;
        public static List<User> completedTask = null;
        public static Task currentTask = null;

        public static DataTable user_permissions = null;

        public static void initializeDB() {
            initializeDashBoard();
            initializeManageTask();
            initializeSessionLogs();
            initializeUserAccounts();

        }

        private static void initializeUserAccounts()
        {
            UC_UserAccounts.gridViewHelper = new GridViewHelper("UserID,NAME as Name,Username as Username,Role AS Type,LAST_LOGIN as 'Last Login'", "user", null);
            user_permissions = getUserPermissions();
        }

        private static void initializeSessionLogs()
        {

            UC_SessionLogs.gridViewHelper = new GridViewHelper("u.name as Name ,s.timein as TimeIn ,s.timeout as TimeOut,TIMEDIFF(timeout,timein) AS TimeDifference", "session as s, user as u", "s.UserID=u.UserID ORDER BY timein DESC ");

        }

        private static void initializeManageTask()
        {
           UC_ManageTask. gridViewHelper = new GridViewHelper(" Progress,taskID AS TaskID, TaskDesc , TaskTitle AS TaskName," +
                           "TaskStatus AS Status,LastDate AS LastDate", "task", null);
        }

        private static void initializeDashBoard()
        {
            activeUsers = showActiveUsers();
            totalUsers = getTotaluser();
            incompletedTask = getincompleteTasks();
            completedTask = tasksCompleted();
            currentTask = getCurrentTask("4");

        }

        public static List<User> showActiveUsers()
        {
            User user = null;
            List<User> taskList = new List<User>();
            DataTable readUserTask = GridViewExample.ManData.getDataReader("*", "user", " IS_ACTIVE='1'");
            foreach (DataRow row in readUserTask.Rows)
            {
                user = new User();
                user.UserID = int.Parse(row["USERID"].ToString());
                user.Name = row["NAME"].ToString();
                user.UserName = row["USERNAME"].ToString();
                user.Reputation = row["REPUTATION"].ToString();
                user.CompletedTask = row["COMPLETED_TASK"].ToString();
                user.Role = row["ROLE"].ToString();
                user.LastLogin = row["LAST_LOGIN"].ToString();
                user.CretedBy = row["CREATED_BY"].ToString();
                user.CreatedOn = row["CREATED_ON"].ToString();
                user.Permissions = row["PERMISSIONS"].ToString();
                user.Active = int.Parse(row["IS_ACTIVE"].ToString());
                taskList.Add(user);
            }
            return taskList;
        }

        public static Task getCurrentTask(string userId)
        {
            Task taskname = new Task();
            DataTable readUserTask = ManData.getDataReader("task.TaskTitle,DATEDIFF(NOW(),LastDate) AS deadline ", "task", "  AssignedTo = '" + userId + "' AND (TaskStatus != 'Rejected' AND TaskStatus != 'Approved' ) ORDER BY deadline ASC LIMIT 0,1");
            foreach (DataRow row in readUserTask.Rows)
            {
                taskname.TaskName = row["TaskTitle"].ToString();
            }
            return taskname;
        }

        public static List<User> getTotaluser()
        {
            User user = null;
            List<User> taskList = new List<User>();
            DataTable readUserTask = ManData.getDataReader("*", "user", null);
            foreach (DataRow row in readUserTask.Rows)
            {
                user = new User();

                user.UserID = int.Parse(row["USERID"].ToString());
                user.Name = row["NAME"].ToString();
                user.UserName = row["USERNAME"].ToString();
                user.Reputation = row["REPUTATION"].ToString();
                user.CompletedTask = row["COMPLETED_TASK"].ToString();
                user.Role = row["ROLE"].ToString();
                user.LastLogin = row["LAST_LOGIN"].ToString();
                user.CretedBy = row["CREATED_BY"].ToString();
                user.CreatedOn = row["CREATED_ON"].ToString();
                user.Permissions = row["PERMISSIONS"].ToString();
                user.Active = int.Parse(row["IS_ACTIVE"].ToString());
                taskList.Add(user);
            }
            return taskList;
        }

        public static List<User> getincompleteTasks()
        {
            User user = null;
            List<User> taskList = new List<User>();
            DataTable readUserTask = ManData.getDataReader("u.*", "task t , USER u  ", " u.`USERID` = t.`AssignedTo` AND Progress != '100%' AND TaskStatus = 'Unapproved' ");
            foreach (DataRow row in readUserTask.Rows)
            {
                user = new User();

                user.UserID = int.Parse(row["USERID"].ToString());
                user.Name = row["NAME"].ToString();
                user.UserName = row["USERNAME"].ToString();
                user.Reputation = row["REPUTATION"].ToString();
                user.CompletedTask = row["COMPLETED_TASK"].ToString();
                user.Role = row["ROLE"].ToString();
                user.LastLogin = row["LAST_LOGIN"].ToString();
                user.CretedBy = row["CREATED_BY"].ToString();
                user.CreatedOn = row["CREATED_ON"].ToString();
                user.Permissions = row["PERMISSIONS"].ToString();
                user.Active = int.Parse(row["IS_ACTIVE"].ToString());
                taskList.Add(user);
            }
            return taskList;
        }

        public static List<User> tasksCompleted()
        {
            User user = null;
            List<User> taskList = new List<User>();
            DataTable readUserTask = ManData.getDataReader("u.*", "task t , USER u  ", " u.`USERID` = t.`AssignedTo` AND Progress = '100%' AND TaskStatus = 'Approved' ");

            foreach (DataRow row in readUserTask.Rows)
            {
                user = new User();

                user.UserID = int.Parse(row["USERID"].ToString());
                user.Name = row["NAME"].ToString();
                user.UserName = row["USERNAME"].ToString();
                user.Reputation = row["REPUTATION"].ToString();
                user.CompletedTask = row["COMPLETED_TASK"].ToString();
                user.Role = row["ROLE"].ToString();
                user.LastLogin = row["LAST_LOGIN"].ToString();
                user.CretedBy = row["CREATED_BY"].ToString();
                user.CreatedOn = row["CREATED_ON"].ToString();
                user.Permissions = row["PERMISSIONS"].ToString();
                user.Active = int.Parse(row["IS_ACTIVE"].ToString());
                taskList.Add(user);
            }
            return taskList;
        }

        public static DataTable getUserPermissions() {
            return ManData.getDataReader("*","user_permissions",null);

        }
    }
}
