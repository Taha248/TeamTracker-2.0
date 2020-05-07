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

namespace GridViewExample
{
    public  class GridViewHelper
    {
        private bool isEditEnable = false;
        private bool isDeleteEnable = false;

        private DataSet ds = null;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private BunifuCustomDataGrid bunifuCustomDataGrid = null;

        public GridViewHelper( BunifuCustomDataGrid bunifuCustomDataGrid, DataSet ds) {

            this.ds = ds;
            this.bunifuCustomDataGrid = bunifuCustomDataGrid;
            this.bunifuCustomDataGrid.RowTemplate.Height = 28;
            this.bunifuCustomDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid_CellContentClick);
            this.bunifuCustomDataGrid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.bunifuCustomDataGrid1_ColumnHeaderMouseClick);

            this.bunifuCustomDataGrid.DataSource = ds.Tables[0];

            loadProperties();
        }

        private void loadProperties()
        {   // 
            // bunifuCustomDataGrid1
            // 
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();

            this.bunifuCustomDataGrid.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid.AllowUserToDeleteRows = false;
            this.bunifuCustomDataGrid.AllowUserToResizeColumns = false;
            this.bunifuCustomDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(194)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.bunifuCustomDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(194)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid.ColumnHeadersHeight = 44;
            this.bunifuCustomDataGrid.DoubleBuffered = true;
            this.bunifuCustomDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.bunifuCustomDataGrid.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid.GridColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.bunifuCustomDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.bunifuCustomDataGrid.MultiSelect = false;
            this.bunifuCustomDataGrid.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid.ReadOnly = true;
            this.bunifuCustomDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(194)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid.RowHeadersVisible = false;
            this.bunifuCustomDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(194)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGrid.RowTemplate.Height = 33;
            this.bunifuCustomDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bunifuCustomDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid.ShowCellErrors = false;
            this.bunifuCustomDataGrid.ShowCellToolTips = false;
            this.bunifuCustomDataGrid.ShowEditingIcon = false;
            this.bunifuCustomDataGrid.ShowRowErrors = false;
            this.bunifuCustomDataGrid.StandardTab = true;
            this.bunifuCustomDataGrid.TabIndex = 0;
        }

        private void bunifuCustomDataGrid1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            this.addProgressBarColumn("Progress", this.getColumnValues("Progress"), Color.LightGreen, 5);
         
            this.addEditColumn();
            this.addDeleteColumn();
            this.hideColumn(bunifuCustomDataGrid.ColumnCount-3);
            this.hideColumn(bunifuCustomDataGrid.ColumnCount - 2);
            this.hideColumn(bunifuCustomDataGrid.ColumnCount - 1);
        }

        internal  void addProgressBarColumn(String header, List<String> progress,Color color, int columnNo)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.BackColor = color;
            pictureBox.Height =60;

            Panel panel = new Panel();
            panel.Controls.Add(pictureBox);
            panel.Height = 20;

            //For Progress bar
            DataGridViewImageColumn prog = new DataGridViewImageColumn();
            prog.Width = 100;
            prog.HeaderText = header;
            this.bunifuCustomDataGrid.Columns.Add(prog);
            setProgressbar(panel, pictureBox, columnNo, progress);
            setColumnWidth(columnNo,70);


        }

        private  void setProgressbar(Panel panel, PictureBox pictureBox, int columnNo ,List<String> progress)
        {
            Random r = new Random();
            for (int i = 0; i < this.bunifuCustomDataGrid.Rows.Count; i++)
            {
                this.bunifuCustomDataGrid.Rows[i].Cells[columnNo].Value = generate_pp(Convert.ToDouble( progress[i].Split('%')[0]), panel, pictureBox);
            }

        }
        public  Image generate_pp(double pass, Panel panel, PictureBox pictureBox)
        {
            double dgpp_d = double.Parse(panel.Width.ToString());
            double x = 0;

            x = (pass * dgpp_d) / 100;

            pictureBox.Width = (int)Math.Round(x, 0);

            return panelToBitmap(panel);
        }


        private  Image panelToBitmap(Control pnl)
        {
            var bmp = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            return bmp;
        }
        public  List<String> getColumnValues(String colName)
        {
            List<string> values = new List<string>();

            foreach (DataRow row in this.ds.Tables[0].Rows)
                values.Add( row["Progress"].ToString());

            return values;
        }


        internal  void addEditColumn()
        {
            Bitmap image = (Bitmap)getImage("iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAABHNCSVQICAgIfAhkiAAAAAlwSFlzAAAAcQAAAHEBHD+AdwAAABl0RVh0U29mdHdhcmUAd3d3Lmlua3NjYXBlLm9yZ5vuPBoAAAGeSURBVDiNldI7SEJhFAfw833385pmKYQ1RENQ4FAQNvSiWhpq6DG15yOapCGJUsKpMUiiqefSa2gKA+lF9LAhaAsCM+hBSw+09Kb33tOSEd2reM/8//3P+eAjiAhaxtA16kTKxgHwWie8uQgigr51qJ4ibcyGEOFJiCyGFbjbM4nIfF+OMSO9j8m68PY+M7S4AxRZNRL5/DdJOV4NS7VWL5SXyuxk50PsHDABITaGgH1CZMGe9+wfnAn0WoCjwOaOPvjVmSSRpBVGAagW/PNImYipzdTe7JRmzOYO49xpdEvYnXUB5NmeE59FN4XdoDubY2q4qMfjlXPhUHD4b1ZxASGEWNKfE2VCnAMJ/+Dbjf9Y9QJjk8vebvvMdDfcGP2+tcRLVSXQi9t1IRQcUbtWUVBqEvsrzKL16k7/LkVfePaYXkqGgp7/OUOLy08z3KKigKMg7FwWLz8ndFtf8H6MB0sptc0AUCPyYFYUPISXp3MA1cn7DwoqQIDXkg6HVQsidYM8IFSnLfoYMTQ725DAFCCYC2+ANJFhPhlZ2PgG3Hy3V++SfzgAAAAASUVORK5CYII=");
            int col = 0;
            DataGridViewImageColumn edit = new DataGridViewImageColumn();
            col = ds.Tables[0].Columns.Count+1;

            this.bunifuCustomDataGrid.Columns.Add(edit);

            for (int i = 0; i < this.bunifuCustomDataGrid.Rows.Count; i++)
            {
                this.bunifuCustomDataGrid.Rows[i].Cells[col].Value = image;
            }
            this.isEditEnable = true;
            setColumnWidth(col, 30);

        }

        internal void setColumnWidth(int col, int width)
        {
            this.bunifuCustomDataGrid.Columns[col].Width = width;
            this.bunifuCustomDataGrid.Columns[col].Width = width;
        }

        internal  void addDeleteColumn()
        {

            Bitmap image = (Bitmap) getImage("iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAABHNCSVQICAgIfAhkiAAAAAlwSFlzAAAAbwAAAG8B8aLcQwAAABl0RVh0U29mdHdhcmUAd3d3Lmlua3NjYXBlLm9yZ5vuPBoAAAEtSURBVDiNrZG9SgNBFIW/m40/jdhYWORhlk2zthYpRhttDHZiynQhIIjYiO1WSZGApAhEcJVpfYM0PoSYwp9srsVuEnEnkKAHbnEOZ865MyOqSg6VyjpvawY4zZRbtr7adDqfv62F/GlgVDwBImCUTZRpObgDVKoIfQatgEErQOijUnVZRVUhNNeIHP3Qt4F34CPjG8Am8Dov0Yj79lkxYzHIcWrQJ+dW884gLdA4C9J0QjPU0PRmfNGEpqehGU65+w1WgDvA2hKxrc94bOtYW3JZi86AMYcgDay9SQVpMNYxcLHcBivgzwHuKxQmXbSwg++n//5or5BJd/mAIHgBajNe9mtOH/96BeUZYZ+9g0uUxOkWPKCMcpcP8JImE28XOEeQBYUKPOAlzanwDSQzfx5HGDS8AAAAAElFTkSuQmCC");
            int col = 0;
            DataGridViewImageColumn delete = new DataGridViewImageColumn();

            if (isEditEnable)
                col=ds.Tables[0].Columns.Count + 2;
            else
                col = ds.Tables[0].Columns.Count + 1;


            this.bunifuCustomDataGrid.Columns.Add(delete);

            for (int i = 0; i < this.bunifuCustomDataGrid.Rows.Count; i++)
            {
                this.bunifuCustomDataGrid.Rows[i].Cells[col].Value = image;
            }

            this.isDeleteEnable = true;
            setColumnWidth(col, 30);
        }

        private void bunifuCustomDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isEditEnable && e.ColumnIndex == bunifuCustomDataGrid.ColumnCount - 2)
            {
                string value = this.bunifuCustomDataGrid.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                MessageBox.Show(value);
            }
            else if (isDeleteEnable &&  e.ColumnIndex == bunifuCustomDataGrid.ColumnCount - 1)
            {
                string value =
                this.bunifuCustomDataGrid.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                MessageBox.Show(value);
            }
        }

        internal void hideColumn(int col)
        {
            this.bunifuCustomDataGrid.Columns[col].Visible = false;
        }
        public Image getImage(string img)
        {
            //data:image/gif;base64,
            //this image is a single pixel (black)
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
