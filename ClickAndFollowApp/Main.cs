using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClickAndFollowApp.HelperMethods;
using System.Data.SqlClient;

namespace ClickAndFollowApp
{
    public partial class Main : Form
    {
        SqlConnection conn = null;

        public Main()
        {
            InitializeComponent();
            InitializeLogger();
        }

        public void InitializeLogger()
        {
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void disconnect_bt_Click(object sender, EventArgs e)
        {
            conn.Close();
        }

        private void connect_bt_Click(object sender, EventArgs e)
        {
            conn = DbOptions.ConnectToSQLServerDb();
        }
    }
}
