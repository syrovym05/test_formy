using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NovaHra novaHra = new NovaHra();
            

            Button button1 = new Button();
            button1.Location = new System.Drawing.Point(100, 100);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(102, 45);
            button1.TabIndex = 2;
            button1.Text = "Potvrdit";
            button1.UseVisualStyleBackColor = true;            
            button1.DialogResult = DialogResult.OK;

            TextBox textBox1 = new TextBox();
            textBox1.Location = new System.Drawing.Point(65, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(185, 26);

            novaHra.Controls.Add(button1);
            novaHra.Controls.Add(textBox1);


            if (novaHra.ShowDialog() == DialogResult.OK)
            {
                Ulozeni uloz = new Ulozeni(textBox1.Text);
                uloz.Show();
                uloz.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nastaveni nastaveni = new Nastaveni();
            nastaveni.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ukonceni ukoncit = new Ukonceni();


            button1.DialogResult = DialogResult.OK;            
            button2.DialogResult = DialogResult.Cancel;
  

            if (ukoncit.ShowDialog() == DialogResult.OK)
            {
                this.Close();
            }
            
        }
    }
}
