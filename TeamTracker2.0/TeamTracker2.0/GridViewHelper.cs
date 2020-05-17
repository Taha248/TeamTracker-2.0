using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bunifu.Framework.UI;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using GridViewExample;

namespace TeamTracker2._0
{
    public class GridViewHelper
    {
        private bool isEditEnable = false;
        private bool isDeleteEnable = false;
        //private EditScreenGeneral editForm = null;
        private DataSet ds = null;
        public static System.Windows.Forms.BindingSource bs;
        private BunifuCustomDataGrid bunifuCustomDataGrid = null;
        private BunifuCustomDataGrid bunifuCustomDataGridCopy = null;
        private bool isProgressEnable = false;
        private BunifuMetroTextbox searchBox;
        private PictureBox pictureBox1;
        private Panel panel4;
        private UserControl form = null;
        private Dictionary<int, int> colWidth = null;
        private List<String> searchColumns = null;
        private List<int> hideColumns = null;
        private string cols = null, table = null, condition = null;
        private string v1;
        private string v2;
        private object p;
        private UC_SessionLogs uC_SessionLogs;
        private BunifuCustomDataGrid bunifuCustomDataGrid1;

        public BunifuCustomDataGrid BunifuCustomDataGrid
        {
            get
            {
                return bunifuCustomDataGrid;
            }

            set
            {
                bunifuCustomDataGrid = value;
            }
        }

        public bool IsEditEnable
        {
            get
            {
                return isEditEnable;
            }

            set
            {
                isEditEnable = value;
            }
        }

        public bool IsDeleteEnable
        {
            get
            {
                return isDeleteEnable;
            }

            set
            {
                isDeleteEnable = value;
            }
        }

        public GridViewHelper(string columns, string table, string condition, UserControl form, BunifuCustomDataGrid bunifuCustomDataGrid)
        {
            InitializeGridView(columns, table, condition, form, bunifuCustomDataGrid);
          
        }



        //internal void addEditColumn(EditScreenGeneral dataManupilation)
        //{
        //    this.editForm = dataManupilation;
        //    addEditColumn();
        //}

        public void InitializeGridView(string columns, string table, string condition, UserControl form, BunifuCustomDataGrid bunifuCustomDataGrid)
        {

            this.cols = columns;
            this.table = table;
            this.condition = condition;
            ds = ManData.getDataSet(columns, table, condition);
            this.form = form;
            this.BunifuCustomDataGrid = null;
            this.BunifuCustomDataGrid = bunifuCustomDataGrid;
            this.bunifuCustomDataGridCopy = bunifuCustomDataGrid;
            this.BunifuCustomDataGrid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.bunifuCustomDataGrid1_ColumnHeaderMouseClick);

            //          this.bunifuCustomDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid_CellContentClick);


            this.BunifuCustomDataGrid.DataSource = ds.Tables[0];
            this.searchColumns = new List<String>();
            colWidth = new Dictionary<int, int>();
            hideColumns = new List<int>();

            loadProperties();
        }

        internal void addContentClickEvent(Action<object, DataGridViewCellEventArgs> bunifuCustomDataGrid_CellContentClick)
        {
            this.bunifuCustomDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(bunifuCustomDataGrid_CellContentClick);
        }

        private void addCellContentEvent()
        {
        }
        private void loadProperties()
        {

            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();

            this.BunifuCustomDataGrid.AllowUserToAddRows = false;
            ////this.BunifuCustomDataGrid.AllowUserToDeleteRows = false;
            this.BunifuCustomDataGrid.AllowUserToResizeColumns = false;
            this.BunifuCustomDataGrid.AllowUserToResizeRows = false;
           
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Navy;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(194)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            this.BunifuCustomDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BunifuCustomDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.BunifuCustomDataGrid.BackgroundColor = Color.Beige;
            this.BunifuCustomDataGrid.BorderStyle = BorderStyle.None;
            this.BunifuCustomDataGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.BunifuCustomDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            //dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.NullValue = null;
            //dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(194)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BunifuCustomDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BunifuCustomDataGrid.ColumnHeadersHeight =49;
            this.BunifuCustomDataGrid.DoubleBuffered = true;
            this.BunifuCustomDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.BunifuCustomDataGrid.EnableHeadersVisualStyles = false;
            this.BunifuCustomDataGrid.GridColor = System.Drawing.Color.Beige;
           this.BunifuCustomDataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.BunifuCustomDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.BunifuCustomDataGrid.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.BunifuCustomDataGrid.MultiSelect = false;
            this.BunifuCustomDataGrid.Name = "bunifuCustomDataGrid1";
            this.BunifuCustomDataGrid.ReadOnly = true;
            this.BunifuCustomDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(194)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
             this.BunifuCustomDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.BunifuCustomDataGrid.RowHeadersVisible = false;
            this.BunifuCustomDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
           dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(194)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BunifuCustomDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
           this.BunifuCustomDataGrid.RowTemplate.Height = 32;
            this.BunifuCustomDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BunifuCustomDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BunifuCustomDataGrid.ShowCellErrors = false;
            this.BunifuCustomDataGrid.ShowCellToolTips = false;
            this.BunifuCustomDataGrid.ShowEditingIcon = false;
            this.BunifuCustomDataGrid.ShowRowErrors = false;
            this.BunifuCustomDataGrid.StandardTab = true;
            this.BunifuCustomDataGrid.TabIndex = 0;

            // -----------------------------------
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;

            //dataGridViewCellStyle4.SelectionBackColor = Color.White;
            //dataGridViewCellStyle1.SelectionBackColor = Color.White;

            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;

            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle1.BackColor = Color.White;

            this.BunifuCustomDataGrid.ColumnHeadersHeight = 33;

            this.BunifuCustomDataGrid.HeaderForeColor = Color.White;
            this.BunifuCustomDataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            
            //dataGridViewCellStyle4.BackColor = Color.FromArgb(243, 246, 249);
            //dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            //this.BunifuCustomDataGrid.ColumnHeadersHeight = 40;
            //this.BunifuCustomDataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);

            //dataGridViewCellStyle4.BackColor = Color.FromArgb(243, 246, 249);
            //dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            //dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            //this.BunifuCustomDataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10.5F, FontStyle.Bold);
            //this.BunifuCustomDataGrid.ColumnHeadersHeight = 40;
            //this.BunifuCustomDataGrid.HeaderBgColor = Color.Navy;
            //dataGridViewCellStyle1.SelectionBackColor = Color.Gold;
            //dataGridViewCellStyle4.SelectionBackColor = Color.Gold;

        }


        internal void reloadGridView()
        {
            try
            {
                this.BunifuCustomDataGrid.Columns.Clear();

                ds = ManData.getDataSet(this.cols, table, condition);
                this.BunifuCustomDataGrid.DataSource = ds.Tables[0];

                foreach (int colNum in hideColumns)
                {
                    this.BunifuCustomDataGrid.Columns[colNum].Visible = false;
                }

                if(isProgressEnable)
                this.addProgressBarColumn("Progress", this.getColumnValues("Progress"), Color.LightGreen, 5);
                if(isEditEnable)
                addEditColumn();
                if(isDeleteEnable)
                addDeleteColumn();

                this.adjustWidth();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        internal void adjustWidth()
        {
            setColumnsWidth();
        }

        internal void filterGridView(string text)
        {
            String q_search = "";

            for (int i = 0; i < searchColumns.Count; i++)
            {
                q_search += searchColumns[i];
                q_search += " LIKE ";
                q_search += " '%" + text + "%' ";
                if (i != (searchColumns.Count - 1))
                    q_search += " OR ";
            }

            (this.BunifuCustomDataGrid.DataSource as DataTable).DefaultView.RowFilter = string.Format(q_search);

            if(isProgressEnable)
            this.addProgressBarImage("Progress", this.getColumnValues("Progress"), Color.LightGreen, 5);
            if(isEditEnable)
            addEditColumnImage();
            if(isDeleteEnable)
            addDeleteColumnImage();


        }
        public void enableSearchEngine(String[] criteria)
        {

            this.searchColumns.AddRange(criteria);

            String icon = "iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAQAAAC1+jfqAAAABGdBTUEAALGPC/xhBQAAACBjSFJNAAB6JgAAgIQAAPoAAACA6AAAdTAAAOpgAAA6mAAAF3CculE8AAAAAmJLR0QAAKqNIzIAAAAJcEhZcwAADsQAAA7EAZUrDhsAAAAHdElNRQfkBQYROh33wVh/AAAA20lEQVQoz33QsUrDUBSH8Z9mEyrSR1D6Ai4dxRewm4LQtZOD3VyELh3sKtoncOwgmdyFFqSb0M1Jh4KoZGqWxCGmMYn4Tefc/3fPuVwyOkJLsRdjLRW2TCRCZ05dWoj1ysLEu4N1FxhInBRxR/Irzri11MibUFjdqWmlm5Wb2h5qwocn7VzY9qXOp51ceLP7h7DnNS/HFoJKvC91mDctsUHlX+amNoqDnsSN5vr2XGpYHnlsaeXRvWepqaFEv6w0dF27c/Wzu19XqpxLXai9v2AmMhIF/8yYiRx9A/JQOUWkpKTSAAAAJXRFWHRkYXRlOmNyZWF0ZQAyMDIwLTA1LTA2VDE3OjU4OjI5KzAwOjAwNMbLmgAAACV0RVh0ZGF0ZTptb2RpZnkAMjAyMC0wNS0wNlQxNzo1ODoyOSswMDowMEWbcyYAAAAZdEVYdFNvZnR3YXJlAHd3dy5pbmtzY2FwZS5vcmeb7jwaAAAAAElFTkSuQmCC";

            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new Panel();
            this.panel4.SuspendLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.Location = new System.Drawing.Point(BunifuCustomDataGrid.Width - 188, BunifuCustomDataGrid.Location.Y - 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(188, 29);
            this.panel4.TabIndex = 11;
            this.panel4.BackColor = Color.Black;
            form.Controls.Add(panel4);
            form.Controls.Add(this.panel4);
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(getImage(icon)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(157, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 25);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();

            this.searchBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.searchBox.BackColor = System.Drawing.Color.White;
            this.searchBox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(194)))), ((int)(((byte)(203)))));
            this.searchBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchBox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(194)))), ((int)(((byte)(203)))));
            this.searchBox.BorderThickness = 3;
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.searchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.searchBox.isPassword = false;
            this.searchBox.Location = new System.Drawing.Point(-3, -3);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(193, 34);
            this.searchBox.TabIndex = 12;
            this.searchBox.Text = "  Search";
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchBox.Enter += new System.EventHandler(this.bunifuMetroTextbox3_Enter);
            this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bunifuMetroTextbox3_KeyPress);
            this.searchBox.MouseLeave += new System.EventHandler(this.bunifuMetroTextbox3_MouseLeave);
            this.searchBox.Leave += new System.EventHandler(this.searchBox_LostFocus);
            panel4.Controls.Add(searchBox);
            searchBox.BringToFront();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();

            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.searchBox);

        }

        private void searchBox_LostFocus(object sender, EventArgs e)
        {
            if (searchBox.Text.Equals(""))
            {
                searchBox.Text = "  Search";
                searchBox.ForeColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void bunifuMetroTextbox3_MouseLeave(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.filterGridView(searchBox.Text);
            adjustWidth();
        }

        private void bunifuMetroTextbox3_Enter(object sender, EventArgs e)
        {
            searchBox.Text = "";
            searchBox.ForeColor = Color.Black;
        }

        private void bunifuCustomDataGrid1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if(isProgressEnable)
            this.addProgressBarImage("Progress", this.getColumnValues("Progress"), Color.LightGreen, 5);
            if (isDeleteEnable)
                this.addDeleteColumnImage();
            if (isEditEnable)
                this.addEditColumnImage();
            adjustWidth();
        }

        internal void addProgressBarColumn(String header, List<String> progress, Color color, int columnNo)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.BackColor = color;
            pictureBox.Height = 60;

            Panel panel = new Panel();
            panel.Controls.Add(pictureBox);
            panel.Height = 20;

            //For Progress bar
            DataGridViewImageColumn prog = new DataGridViewImageColumn();
            prog.Width = 100;
            prog.HeaderText = header;
            this.BunifuCustomDataGrid.Columns.Add(prog);
            setProgressbar(panel, pictureBox, columnNo, progress);
            setColumnWidth(columnNo, 70);

            isProgressEnable = true;


        }
        internal void addProgressBarImage(String header, List<String> progress, Color color, int columnNo)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.BackColor = color;
            pictureBox.Height = 60;

            Panel panel = new Panel();
            panel.Controls.Add(pictureBox);
            panel.Height = 20;

            //For Progress bar
            DataGridViewImageColumn prog = new DataGridViewImageColumn();
            prog.Width = 100;
            prog.HeaderText = header;
            Random r = new Random();
            int prog_cell = 0;

            if (isDeleteEnable && isEditEnable)
                prog_cell = BunifuCustomDataGrid.Columns.Count - 3;
            else if ((isDeleteEnable && !isEditEnable) || (isEditEnable && !isDeleteEnable))
                prog_cell = BunifuCustomDataGrid.Columns.Count - 2;
            else if (isEditEnable || isDeleteEnable)
                prog_cell = BunifuCustomDataGrid.Columns.Count - 1;


            for (int i = 0; i < this.BunifuCustomDataGrid.Rows.Count; i++)
            {
                this.BunifuCustomDataGrid.Rows[i].Cells[prog_cell].Value = generate_pp(Convert.ToDouble(progress[i].Split('%')[0]), panel, pictureBox);
            }

            setColumnWidth(columnNo, 70);


        }


        internal void addProgressBarImageOnReload(String header, List<String> progress, Color color, int columnNo)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.BackColor = color;
            pictureBox.Height = 60;

            Panel panel = new Panel();
            panel.Controls.Add(pictureBox);
            panel.Height = 20;

            //For Progress bar
            DataGridViewImageColumn prog = new DataGridViewImageColumn();
            prog.Width = 100;
            prog.HeaderText = header;
            Random r = new Random();
            int prog_cell = BunifuCustomDataGrid.Columns.Count - 1;
            MessageBox.Show(BunifuCustomDataGrid.Columns[8].HeaderText);


            for (int i = 0; i < this.BunifuCustomDataGrid.Rows.Count; i++)
            {
                this.BunifuCustomDataGrid.Rows[i].Cells[prog_cell].Value = generate_pp(Convert.ToDouble(progress[i].Split('%')[0]), panel, pictureBox);
            }

            setColumnWidth(columnNo, 70);


        }
        private void setProgressbar(Panel panel, PictureBox pictureBox, int columnNo, List<String> progress)
        {

            Random r = new Random();
            double prog = 0;
            for (int i = 0; i < this.BunifuCustomDataGrid.Rows.Count; i++)
            {
                prog = Convert.ToDouble(progress[i].Split('%')[0]);
                if (prog < 20) pictureBox.BackColor = Color.Orange; else if (prog >= 20 && prog < 99) pictureBox.BackColor = Color.Yellow; else pictureBox.BackColor = Color.LightGreen;
                this.BunifuCustomDataGrid.Rows[i].Cells[BunifuCustomDataGrid.Columns.Count - 1].Value = generate_pp(prog, panel, pictureBox);
            }

        }
        public Image generate_pp(double pass, Panel panel, PictureBox pictureBox)
        {
            double dgpp_d = double.Parse(panel.Width.ToString());
            double x = 0;

            x = (pass * dgpp_d) / 100;

            pictureBox.Width = (int)Math.Round(x, 0);

            return panelToBitmap(panel);
        }


        private Image panelToBitmap(Control pnl)
        {
            var bmp = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            return bmp;
        }
        public List<String> getColumnValues(String colName)
        {
            List<string> values = new List<string>();
                foreach (DataRow row in this.ds.Tables[0].Rows)
                    values.Add(row["Progress"].ToString());

            return values;
        }


        internal void addEditColumn()
        {
            Bitmap image = (Bitmap)getImage("iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAABHNCSVQICAgIfAhkiAAAAAlwSFlzAAAAcQAAAHEBHD+AdwAAABl0RVh0U29mdHdhcmUAd3d3Lmlua3NjYXBlLm9yZ5vuPBoAAAGeSURBVDiNldI7SEJhFAfw833385pmKYQ1RENQ4FAQNvSiWhpq6DG15yOapCGJUsKpMUiiqefSa2gKA+lF9LAhaAsCM+hBSw+09Kb33tOSEd2reM/8//3P+eAjiAhaxtA16kTKxgHwWie8uQgigr51qJ4ibcyGEOFJiCyGFbjbM4nIfF+OMSO9j8m68PY+M7S4AxRZNRL5/DdJOV4NS7VWL5SXyuxk50PsHDABITaGgH1CZMGe9+wfnAn0WoCjwOaOPvjVmSSRpBVGAagW/PNImYipzdTe7JRmzOYO49xpdEvYnXUB5NmeE59FN4XdoDubY2q4qMfjlXPhUHD4b1ZxASGEWNKfE2VCnAMJ/+Dbjf9Y9QJjk8vebvvMdDfcGP2+tcRLVSXQi9t1IRQcUbtWUVBqEvsrzKL16k7/LkVfePaYXkqGgp7/OUOLy08z3KKigKMg7FwWLz8ndFtf8H6MB0sptc0AUCPyYFYUPISXp3MA1cn7DwoqQIDXkg6HVQsidYM8IFSnLfoYMTQ725DAFCCYC2+ANJFhPhlZ2PgG3Hy3V++SfzgAAAAASUVORK5CYII=");
            int col = 0;
            DataGridViewImageColumn edit = new DataGridViewImageColumn();
            if(isProgressEnable)
            col = ds.Tables[0].Columns.Count + 1;
            else
                col = ds.Tables[0].Columns.Count;


            this.BunifuCustomDataGrid.Columns.Add(edit);

            for (int i = 0; i < this.BunifuCustomDataGrid.Rows.Count; i++)
            {
                this.BunifuCustomDataGrid.Rows[i].Cells[col].Value = image;
            }
            this.isEditEnable = true;
            setColumnWidth(col, 30);

        }


        internal void addEditColumnImage()
        {
            Bitmap image = (Bitmap)getImage("iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAABHNCSVQICAgIfAhkiAAAAAlwSFlzAAAAcQAAAHEBHD+AdwAAABl0RVh0U29mdHdhcmUAd3d3Lmlua3NjYXBlLm9yZ5vuPBoAAAGeSURBVDiNldI7SEJhFAfw833385pmKYQ1RENQ4FAQNvSiWhpq6DG15yOapCGJUsKpMUiiqefSa2gKA+lF9LAhaAsCM+hBSw+09Kb33tOSEd2reM/8//3P+eAjiAhaxtA16kTKxgHwWie8uQgigr51qJ4ibcyGEOFJiCyGFbjbM4nIfF+OMSO9j8m68PY+M7S4AxRZNRL5/DdJOV4NS7VWL5SXyuxk50PsHDABITaGgH1CZMGe9+wfnAn0WoCjwOaOPvjVmSSRpBVGAagW/PNImYipzdTe7JRmzOYO49xpdEvYnXUB5NmeE59FN4XdoDubY2q4qMfjlXPhUHD4b1ZxASGEWNKfE2VCnAMJ/+Dbjf9Y9QJjk8vebvvMdDfcGP2+tcRLVSXQi9t1IRQcUbtWUVBqEvsrzKL16k7/LkVfePaYXkqGgp7/OUOLy08z3KKigKMg7FwWLz8ndFtf8H6MB0sptc0AUCPyYFYUPISXp3MA1cn7DwoqQIDXkg6HVQsidYM8IFSnLfoYMTQ725DAFCCYC2+ANJFhPhlZ2PgG3Hy3V++SfzgAAAAASUVORK5CYII=");
            int col = 0;
            DataGridViewImageColumn edit = new DataGridViewImageColumn();
            if (isProgressEnable)
                col = ds.Tables[0].Columns.Count + 1;
            else
                col = ds.Tables[0].Columns.Count;



            for (int i = 0; i < this.BunifuCustomDataGrid.Rows.Count; i++)
            {
                this.BunifuCustomDataGrid.Rows[i].Cells[col].Value = image;
            }
            this.isEditEnable = true;
            setColumnWidth(col, 30);

        }

        internal void setColumnWidth(int col, int width)
        {
            this.BunifuCustomDataGrid.Columns[col].Width = width;
        }

        internal void setColumnsWidth()
        {
            try
            {
                foreach (KeyValuePair<int, int> item in colWidth)
                {
                    this.BunifuCustomDataGrid.Columns[item.Key].Width = item.Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        internal void addColumnWidth(int col, int width)
        {
            colWidth.Add(col, width);
            setColumnsWidth();
        }



        internal void addDeleteColumn()
        {

            Bitmap image = (Bitmap)getImage("iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAABHNCSVQICAgIfAhkiAAAAAlwSFlzAAAAbwAAAG8B8aLcQwAAABl0RVh0U29mdHdhcmUAd3d3Lmlua3NjYXBlLm9yZ5vuPBoAAAEtSURBVDiNrZG9SgNBFIW/m40/jdhYWORhlk2zthYpRhttDHZiynQhIIjYiO1WSZGApAhEcJVpfYM0PoSYwp9srsVuEnEnkKAHbnEOZ865MyOqSg6VyjpvawY4zZRbtr7adDqfv62F/GlgVDwBImCUTZRpObgDVKoIfQatgEErQOijUnVZRVUhNNeIHP3Qt4F34CPjG8Am8Dov0Yj79lkxYzHIcWrQJ+dW884gLdA4C9J0QjPU0PRmfNGEpqehGU65+w1WgDvA2hKxrc94bOtYW3JZi86AMYcgDay9SQVpMNYxcLHcBivgzwHuKxQmXbSwg++n//5or5BJd/mAIHgBajNe9mtOH/96BeUZYZ+9g0uUxOkWPKCMcpcP8JImE28XOEeQBYUKPOAlzanwDSQzfx5HGDS8AAAAAElFTkSuQmCC");
            int col = 0;
            DataGridViewImageColumn delete = new DataGridViewImageColumn();

            if (isProgressEnable && isEditEnable)
                col = ds.Tables[0].Columns.Count + 2;
            else if ((isProgressEnable && !isEditEnable )|| (!isProgressEnable && isEditEnable))
                col = ds.Tables[0].Columns.Count + 1;
            else
                col = ds.Tables[0].Columns.Count; ;


            this.BunifuCustomDataGrid.Columns.Add(delete);

            for (int i = 0; i < this.BunifuCustomDataGrid.Rows.Count; i++)
            {
                this.BunifuCustomDataGrid.Rows[i].Cells[col].Value = image;
            }

            this.isDeleteEnable = true;
            setColumnWidth(col, 30);
        }


        internal void addDeleteColumnImage()
        {

            Bitmap image = (Bitmap)getImage("iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAABHNCSVQICAgIfAhkiAAAAAlwSFlzAAAAbwAAAG8B8aLcQwAAABl0RVh0U29mdHdhcmUAd3d3Lmlua3NjYXBlLm9yZ5vuPBoAAAEtSURBVDiNrZG9SgNBFIW/m40/jdhYWORhlk2zthYpRhttDHZiynQhIIjYiO1WSZGApAhEcJVpfYM0PoSYwp9srsVuEnEnkKAHbnEOZ865MyOqSg6VyjpvawY4zZRbtr7adDqfv62F/GlgVDwBImCUTZRpObgDVKoIfQatgEErQOijUnVZRVUhNNeIHP3Qt4F34CPjG8Am8Dov0Yj79lkxYzHIcWrQJ+dW884gLdA4C9J0QjPU0PRmfNGEpqehGU65+w1WgDvA2hKxrc94bOtYW3JZi86AMYcgDay9SQVpMNYxcLHcBivgzwHuKxQmXbSwg++n//5or5BJd/mAIHgBajNe9mtOH/96BeUZYZ+9g0uUxOkWPKCMcpcP8JImE28XOEeQBYUKPOAlzanwDSQzfx5HGDS8AAAAAElFTkSuQmCC");
            int col = 0;
            DataGridViewImageColumn delete = new DataGridViewImageColumn();

            if (isProgressEnable && isEditEnable)
                col = ds.Tables[0].Columns.Count + 2;
            else if ((isProgressEnable && !isEditEnable) || (!isProgressEnable && isEditEnable))
                col = ds.Tables[0].Columns.Count + 1;
            else
                col = ds.Tables[0].Columns.Count; ;



            for (int i = 0; i < this.BunifuCustomDataGrid.Rows.Count; i++)
            {
                this.BunifuCustomDataGrid.Rows[i].Cells[col].Value = image;
            }

            this.isDeleteEnable = true;
            setColumnWidth(col, 30);
        }

        private void bunifuCustomDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (isEditEnable && e.ColumnIndex == bunifuCustomDataGrid.ColumnCount - 2)
            {
                string value = this.bunifuCustomDataGrid.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                //        MessageBox.Show(value);
                //EditScreenGeneral dm = new DataManupilation(panel);
                //DataTable reader = ManData.getDataReader(" * ", "task", " taskID=" + value);

                // dm.Show();



            }
            else if (isDeleteEnable && e.ColumnIndex == bunifuCustomDataGrid.ColumnCount - 1)
            {
                string value =
                this.bunifuCustomDataGrid.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                //          MessageBox.Show(value);
            }

        }

        internal void hideColumn(int col)
        {
            this.BunifuCustomDataGrid.Columns[col].Visible = false;
            hideColumns.Add(col);
        }
        public Image getImage(string img)
        {

            byte[] bytes = Convert.FromBase64String(img);

            Image image;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = Image.FromStream(ms);
            }

            return image;
        }
    }

}
