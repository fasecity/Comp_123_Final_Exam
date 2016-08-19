using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_FinalExam
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //enabled timer to false
            timer1.Enabled = false;
            // hid splash form
            this.Hide();
            //instantiated generatenameForm
            GenerateNameForm generatenameform = new GenerateNameForm();
            //call
            generatenameform.splashperv = this;
            //show
            generatenameform.Show();
            // Application.Run(new AbilityGeneratorForm());
            //Application.Run(new AbilityGeneratorForm());
        }
    }
}
