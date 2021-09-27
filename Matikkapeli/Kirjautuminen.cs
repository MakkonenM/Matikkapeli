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

namespace Matikkapeli
{
    public partial class Kirjautuminen : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public Kirjautuminen()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (CloseCancel() == false)
            {
                e.Cancel = true;
            }
        }
        public static bool CloseCancel()
        {
            const string message = "Haluatko varmasti poistua sovelluksesta?";
            const string caption = "Poistu Sovelluksesta";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }
        private void Kirjautuminen_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Miksumi\Desktop\Uusi kansio\Matikkapeli\Database1.mdf;Integrated Security=True");
            cn.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rekisteröityminen registration = new Rekisteröityminen();
            registration.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (textBox2.Text != string.Empty || textBox1.Text != string.Empty)
                {
                    cmd = new SqlCommand("select * from LoginTable where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        this.Hide();
                        Home home = new Home();
                        home.ShowDialog();
                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show("Tällä käyttäjätunnuksella ja salasanalla ei ole käytettävissä tiliä ", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Anna arvo kaikkiin kenttiin.", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
