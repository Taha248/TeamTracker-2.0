using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTracker2._0
{
    public class User
    {
        int userID = 0;
        String name = null;
        String userName = null;
        String reputation = null;
        String completedTask = null;
        String role = null;
        String lastLogin = null;
        String cretedBy = null;
        String createdOn = null;
        String permissions = null;
        int activeBit = 0;
        public int UserID
        {
            get
            {
                return userID;
            }

            set
            {
                userID = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public string Reputation
        {
            get
            {
                return reputation;
            }

            set
            {
                reputation = value;
            }
        }

        public string CompletedTask
        {
            get
            {
                return completedTask;
            }

            set
            {
                completedTask = value;
            }
        }

        public string Role
        {
            get
            {
                return role;
            }

            set
            {
                role = value;
            }
        }

        public string LastLogin
        {
            get
            {
                return lastLogin;
            }

            set
            {
                lastLogin = value;
            }
        }

        public string CretedBy
        {
            get
            {
                return cretedBy;
            }

            set
            {
                cretedBy = value;
            }
        }

        public string CreatedOn
        {
            get
            {
                return createdOn;
            }

            set
            {
                createdOn = value;
            }
        }

        public string Permissions
        {
            get
            {
                return permissions;
            }

            set
            {
                permissions = value;
            }
        }

        public int Active
        {
            get
            {
                return this.activeBit;
            }

            set
            {

                activeBit = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }
}
