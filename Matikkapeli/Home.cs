using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matikkapeli
{
    public partial class Home : Form
    {
        Random random = new Random();
        private int aikaaJäljellä;
        private int a;
        private int b;
        int min = 1;
        int max = 50;
        public Home()
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

        private void Home_Load(object sender, EventArgs e)
        {
            alabel1.Parent = pictureBox1;
            alabel1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            blabel3.Parent = pictureBox1;
            blabel3.BackColor = Color.Transparent;
            timerLabel.Parent = pictureBox1;
            timerLabel.BackColor = Color.Transparent;
            label5.Parent = pictureBox1;
            label5.BackColor = Color.Transparent;


            timer1.Enabled = true;
            timer1.Stop();

        }

        private void Aloita_Click(object sender, EventArgs e)
        {
            aikaaJäljellä = 2;
            timerLabel.Text = aikaaJäljellä.ToString();

            a = random.Next(min, max) + 1;
            b = random.Next(min, max) + 1;
            alabel1.Text = a.ToString();
            blabel3.Text = b.ToString();

            timer1.Start();


            Aloita.Enabled = false;
            Valmis.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (aikaaJäljellä > 0)
            {
                aikaaJäljellä--;
                timerLabel.Text = aikaaJäljellä.ToString();
            }
            else if (aikaaJäljellä == 0)
            {
                Valmis.Enabled = false;
                Aloita.Enabled = true;
                timer1.Stop();
                timerLabel.Text = "";
            }
        }

        private void Valmis_Click(object sender, EventArgs e)
        {
            vastausBox.Text = "";
            Valmis.Enabled = false;
            Aloita.Enabled = true;
            timer1.Stop();

            int c = a + b;
            if(vastausBox.Text == c.ToString())
            {
                timer1.Stop();
                timerLabel.Text = "Sinä voitit! ";
            }
            else
            {
                timerLabel.Text = "Sinä hävisit! ";
            }
            vastausBox.Text = string.Empty;
        }

        private void vastausBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Valmis_Click(sender, null);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Aloita_Click(sender, null);
            }
        }
    }
}
