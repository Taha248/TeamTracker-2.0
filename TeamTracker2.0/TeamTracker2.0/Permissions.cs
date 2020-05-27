using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTracker2._0
{
    class Permissions
    {
        int upID = 0;
        String permissionTitle = null;
        String permissionKey = null;
        String userAccess = null;

        public Permissions(int upID, string permissionTitle, string permissionKey, string userAccess)
        {
            this.upID = upID;
            this.permissionTitle = permissionTitle;
            this.permissionKey = permissionKey;
            this.userAccess = userAccess;
        }
        public Permissions() { }

        public int UpID
        {
            get
            {
                return upID;
            }

            set
            {
                upID = value;
            }
        }

        public string PermissionTitle
        {
            get
            {
                return permissionTitle;
            }

            set
            {
                permissionTitle = value;
            }
        }

        public string PermissionKey
        {
            get
            {
                return permissionKey;
            }

            set
            {
                permissionKey = value;
            }
        }

        public string UserAccess
        {
            get
            {
                return userAccess;
            }

            set
            {
                userAccess = value;
            }
        }
    }
}

