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
    public partial class Rekisteröityminen : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public Rekisteröityminen()
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
        private void Rekisteröityminen_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Miksumi\Desktop\Uusi kansio\Matikkapeli\Database1.mdf;Integrated Security=True");
            cn.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kirjautuminen login = new Kirjautuminen();
            login.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != string.Empty || textBox2.Text != string.Empty || textBox1.Text != string.Empty)
            {
                if (textBox2.Text == textBox3.Text)
                {
                    cmd = new SqlCommand("select * from LoginTable where username='" + textBox1.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Käyttjänimi on jo olemassa yritä uutta. ", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into LoginTable values(@username,@password)", cn);
                        cmd.Parameters.AddWithValue("username", textBox1.Text);
                        cmd.Parameters.AddWithValue("password", textBox2.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sinun käyttäjä on valmis. Voit kirjautua sisään.", "Valmis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Anna molemmat salasanat oikein. ", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Anna arvo kaikkiin kenttiin.", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
