using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            LabelAbout.Text = "Translator is an app that allows translate text written in Latin letters and uploaded from file.";
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
