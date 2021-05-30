using System;
using System.Data;
using System.Windows.Forms;
using NLog;

namespace NFS
{
    public partial class LeaderboardForm : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public LeaderboardForm()
        {
            InitializeComponent();
            LoadData();
        }
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        private void LoadData()
        {
            DB db = new DB();
            DataTable table = db.GetData();
            
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(table.Rows[i][3], table.Rows[i][4], table.Rows[i][5]);
                }
            }
            else
            {
                dataGridView1.Text = @"No Data";
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            logger.Info("Return btn is click;");
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
