using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolLibrary;
using System.Windows.Forms;

namespace SchoolsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // event handler 
            var testSchool = new SchoolLibrary.Class1();
            testSchool.Name = "Central City High";
        }
    }
}
