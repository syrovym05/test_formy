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
    public partial class Ulozeni : Form
    {
        string jmeno;
        public Ulozeni()
        {
            InitializeComponent();            
        }

        

        public Ulozeni(string jmeno)
        {
            this.jmeno = jmeno;

            StreamWriter sw = new StreamWriter("hra.txt", true);
            string data = jmeno + " " + DateTime.Now.ToString();
            MessageBox.Show("Hra ulozena");
            sw.WriteLine(data);
            sw.Close();

        }

        private void Ulozeni_Load(object sender, EventArgs e)
        {
           
        }
    }
}
