using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroForm_Demo
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Form1";
            this.Resize += On_Form1_Resize;
        }

        private void On_Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal || this.WindowState == FormWindowState.Maximized)
                this.Text = "Form1";
            else if (this.WindowState == FormWindowState.Minimized)
                this.Text = "Form1 - Minimized";
        }
    }
}
