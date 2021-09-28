
namespace Matikkapeli
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.alabel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.blabel3 = new System.Windows.Forms.Label();
            this.vastausBox = new System.Windows.Forms.TextBox();
            this.Valmis = new System.Windows.Forms.Button();
            this.Aloita = new System.Windows.Forms.Button();
            this.timerLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(472, 347);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // alabel1
            // 
            this.alabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alabel1.BackColor = System.Drawing.Color.Transparent;
            this.alabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alabel1.Location = new System.Drawing.Point(130, 94);
            this.alabel1.Name = "alabel1";
            this.alabel1.Size = new System.Drawing.Size(35, 41);
            this.alabel1.TabIndex = 1;
            this.alabel1.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "+";
            // 
            // blabel3
            // 
            this.blabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.blabel3.BackColor = System.Drawing.Color.Transparent;
            this.blabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blabel3.Location = new System.Drawing.Point(289, 94);
            this.blabel3.Name = "blabel3";
            this.blabel3.Size = new System.Drawing.Size(31, 41);
            this.blabel3.TabIndex = 3;
            this.blabel3.Text = "0";
            // 
            // vastausBox
            // 
            this.vastausBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vastausBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vastausBox.Location = new System.Drawing.Point(146, 147);
            this.vastausBox.Multiline = true;
            this.vastausBox.Name = "vastausBox";
            this.vastausBox.Size = new System.Drawing.Size(151, 30);
            this.vastausBox.TabIndex = 0;
            this.vastausBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vastausBox_KeyDown);
            // 
            // Valmis
            // 
            this.Valmis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Valmis.BackColor = System.Drawing.Color.Transparent;
            this.Valmis.Enabled = false;
            this.Valmis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valmis.Location = new System.Drawing.Point(18, 206);
            this.Valmis.Name = "Valmis";
            this.Valmis.Size = new System.Drawing.Size(414, 50);
            this.Valmis.TabIndex = 5;
            this.Valmis.Text = "Paina Enter Näppäintä Lukitaksesi Vatstauksesi";
            this.Valmis.UseVisualStyleBackColor = false;
            // 
            // Aloita
            // 
            this.Aloita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Aloita.BackColor = System.Drawing.Color.Transparent;
            this.Aloita.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aloita.Location = new System.Drawing.Point(18, 282);
            this.Aloita.Name = "Aloita";
            this.Aloita.Size = new System.Drawing.Size(414, 43);
            this.Aloita.TabIndex = 6;
            this.Aloita.Text = "Paina Esc Näppäintä Aloittaaksesi Pelin Uudelleen";
            this.Aloita.UseVisualStyleBackColor = false;
            this.Aloita.Click += new System.EventHandler(this.Aloita_Click);
            // 
            // timerLabel
            // 
            this.timerLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timerLabel.BackColor = System.Drawing.Color.Transparent;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(220, 9);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(211, 34);
            this.timerLabel.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 34);
            this.label5.TabIndex = 8;
            this.label5.Text = "Aikaa jäljellä:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 347);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.Aloita);
            this.Controls.Add(this.Valmis);
            this.Controls.Add(this.vastausBox);
            this.Controls.Add(this.blabel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.alabel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Home";
            this.Text = "Matikkapeli";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label alabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label blabel3;
        private System.Windows.Forms.TextBox vastausBox;
        private System.Windows.Forms.Button Valmis;
        private System.Windows.Forms.Button Aloita;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
    }
}

