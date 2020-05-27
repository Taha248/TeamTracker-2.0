using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTracker2._0
{
    class DB_Initialization
    {
        public static void initializeDB() {
            initializeDashBoard();
            initializeManageTask();
            initializeSessionLogs();
            initializeUserAccounts();

        }

        private static void initializeUserAccounts()
        {
            UC_UserAccounts.gridViewHelper = new GridViewHelper("UserID,NAME as Name,Username as Username,Role AS Type,LAST_LOGIN as 'Last Login'", "user", null);

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
            UC_Dashboard.activeUsers = UC_Dashboard.showActiveUsers();
            UC_Dashboard.totalUsers = UC_Dashboard.getTotaluser();
            UC_Dashboard.incompletedTask = UC_Dashboard.getincompleteTasks();
            UC_Dashboard.completedTask = UC_Dashboard.tasksCompleted();
            UC_Dashboard.currentTask = UC_Dashboard.getCurrentTask("4");

        }
    }
}
