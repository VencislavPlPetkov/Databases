using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace HelloWF
{
    public partial class MyStartingForm : Form
    {

        private SqlConnection con;

        private SqlCommand cmd;

        private SqlDataAdapter da;

        private DataTable dt;




        public MyStartingForm()
        {
            InitializeComponent();
            ConnectDB();
        }


        public void ConnectDB()
        {

            con = new SqlConnection(@"Data Source=OMEN\SQLEXPRESS;Initial Catalog=MyDatabase;Integrated Security=True");

            con.Open();

            cmd = new SqlCommand("SELECT * FROM person");

            cmd.Connection = con;

            da = new SqlDataAdapter(cmd);

            dt = new DataTable();

            da.Fill(dt);

            textBox1.Text = dt.Rows[0]["name"].ToString().Trim();





        }






        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Aqua;
        }

        private void OnShowAbout(object sender, EventArgs e)
        {

            MessageBox.Show("Pic img");


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
