using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foreach_826
{
    
    public partial class Form1 : Form
    {
        List<string> isimler = new List<string>() { "kübra", "nisa", "eymen", "efe" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string isim in isimler)
            {
                MessageBox.Show(isim);
            }

            
        }
    }
}
