using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DB_GUI
{
    public partial class DeleteBook : Form
    {
        private Form1 motherForm;

        public DeleteBook (Form1 F)
        {
            motherForm = F;
            InitializeComponent();
        }
        string connStr = "server=localhost;user id=root;database=library";
        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);

                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    string strSql = "CALL deleteBook(" + bookIDTxt.Text + ")";

                    MySqlCommand cmd = new MySqlCommand(strSql, conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteReader();

                    motherForm.UpdateBooks();
                }
                conn.Close();
                Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
