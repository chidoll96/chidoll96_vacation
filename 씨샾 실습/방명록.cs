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

namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        DBManager m = DBManager.getInstance();

        public Form1()
        {
            InitializeComponent();
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             MySqlConnection con = m.getDBConnection();
            String iname = textBox1.Text;
            String icon = richTextBox1.Text;
            String inq = "insert into Cs_twit(author,content)values(@author,@content)";
            MySqlCommand mc = new MySqlCommand();
            mc.Connection = con;
            mc.CommandText = inq;
            mc.Prepare();
            mc.Parameters.AddWithValue("@author", iname);
            mc.Parameters.AddWithValue("@content", icon);
            mc.ExecuteNonQuery();
            String query = "select * from Cs_twit";
            MySqlCommand command = new MySqlCommand(query, con);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                String number = reader.GetString("num");
                String author = reader.GetString("author");
                String content = reader.GetString("content");
                String createdtime = reader.GetDateTime("createdtime").ToString();
                this.dataGridView1.Rows.Add(number, author, createdtime, content);
            }
            reader.Close();
           
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        
    }
}
