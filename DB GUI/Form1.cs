using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DB_GUI
{
    public partial class Form1 : Form
    {
        string connStr = "server=localhost;user id=root;database=library;allow zero datetime=True";

        public Form1()
        {
            InitializeComponent();
        }
        public void EnterData(DataTable dt)
        {
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void showBooksBtn_Click(object sender, EventArgs e)
        {
            UpdateBooks();
        }
        public void UpdateBooks()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);

                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    string strSql = "CALL showAllBooks()";

                    MySqlCommand cmd = new MySqlCommand(strSql, conn);
                    cmd.CommandType = CommandType.Text;

                    MySqlDataAdapter adapter = new MySqlDataAdapter(strSql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void UpdateMembers()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);

                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    string strSql = "CALL showAllMembers()";

                    MySqlCommand cmd = new MySqlCommand(strSql, conn);
                    cmd.CommandType = CommandType.Text;

                    MySqlDataAdapter adapter = new MySqlDataAdapter(strSql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void booksHomeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);

                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    string strSql = "CALL showBooksHome()";

                    MySqlCommand cmd = new MySqlCommand(strSql, conn);
                    cmd.CommandType = CommandType.Text;

                    MySqlDataAdapter adapter = new MySqlDataAdapter(strSql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void booksBorrowedBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);

                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    string strSql = "CALL showBooksBorrowed()";

                    MySqlCommand cmd = new MySqlCommand(strSql, conn);
                    cmd.CommandType = CommandType.Text;

                    MySqlDataAdapter adapter = new MySqlDataAdapter(strSql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void newMemberBtn_Click(object sender, EventArgs e)
        {
            NewMember form2 = new NewMember(this);            
            form2.Visible = true;
        }

        private void showMembersBtn_Click(object sender, EventArgs e)
        {
            UpdateMembers();
        }

        private void newBookBtn_Click(object sender, EventArgs e)
        {
            NewBook form2 = new NewBook(this);
            form2.Visible=true;
        }

        private void borrowBookBtn_Click(object sender, EventArgs e)
        {
            BorrowBook form2 = new BorrowBook(this);
            form2.Visible=true;
        }

        private void memberBorrowedBtn_Click(object sender, EventArgs e)
        {
            MemberBorrowed form2 = new MemberBorrowed(this);
            form2.Visible = true;
        }

        private void memberBorrowingBtn_Click(object sender, EventArgs e)
        {
            MemberBorrowing form2 = new MemberBorrowing(this);
            form2.Visible = true;

        }

        private void deleteMemberBtn_Click(object sender, EventArgs e)
        {
            DeleteMember form2 = new DeleteMember(this);
            form2.Visible = true;

        }

        private void deleteBookBtn_Click(object sender, EventArgs e)
        {
            DeleteBook form2 = new DeleteBook(this);
            form2.Visible = true;

        }

        private void booksFromKategoryBtn_Click(object sender, EventArgs e)
        {
            BooksFromKategory form2 = new BooksFromKategory(this);
            form2.Visible = true;

        }
    }
}
