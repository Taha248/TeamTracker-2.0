using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GridViewExample;

namespace TeamTracker2._0
{
    public partial class UC_Permissions : UserControl
    {

        List<Permissions> permissionList = new List<Permissions>();
        Panel panel=null;
        String permissions = null;
        String userID = null;
        bool isNew = false;
        Dictionary<String, String> permissionMap = new Dictionary<string, string>();

        public bool IsNew
        {
            get
            {
                return isNew;
            }

            set
            {
                isNew = value;
            }
        }

        public UC_Permissions(Panel panel,String permissions,String UserID)
        {
            InitializeComponent();
            this.permissions = permissions;
            this.panel = panel;
            this.userID = UserID;
        }

        private void UC_Permissions_Load(object sender, EventArgs e)
        {
          DataTable permissions = DB_Initialization.user_permissions;
            Permissions permission = null;
            foreach (DataRow row in permissions.Rows)
            {
                permission = new Permissions();
                permission.UpID = int.Parse(row["UP_ID"].ToString());

                permission.PermissionTitle = row["PERMISSION_TITLE"].ToString();
                permission.PermissionKey = row["PERMISSION_KEY"].ToString();
                permission.UserAccess = row["USER_ACCESS"].ToString();
                permissionMap.Add(permission.UpID.ToString(), permission.PermissionKey);
                permissionList.Add(permission);
            }

            loadPermissionLabels();
        }

        private void loadPermissionLabels()
        {
            CheckBox checkbox = null;
            int x = 55, y = 30 ;

            for (int i = 0; i < permissionList.Count; i++) {
                checkbox = new CheckBox();
                checkbox.Text = permissionList[i].PermissionTitle;
                checkbox.Tag = permissionList[i].UpID;

                if (!isNew && permissions.Contains(permissionList[i].PermissionKey))
                    checkbox.Checked = true;

                if (i % 2 == 0)
                {
                    checkbox.Location = new Point(x, y);
                    x += 250;
                }
                else {
                    checkbox.Location = new Point(x, y);
                    y += 35;
                    x = 55;
                }
                checkbox.Font = new System.Drawing.Font("Alegreya Sans SC", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                checkbox.AutoSize = true;
                checkbox.Name = "checkbox" + (i+1);
                pnl_permission.Controls.Add(checkbox);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<String, String> values = new Dictionary<string, string>();
            String permissionString = ""; 
            foreach (var cb in pnl_permission.Controls.OfType<CheckBox>().Where(x => x.Checked))
            {
                permissionString += permissionMap [cb.Tag.ToString()];
            }
          //  MessageBox.Show(permissionString);


            values.Add("PERMISSIONS",permissionString);

            ManData.executeUpdateQuery(values,"USER","USERID='"+userID+"'");

        }
    }
}
