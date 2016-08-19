using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Mohamoud Mohamed 300435435
/// Final exam comp123
/// v.1
///  date 8/19/2016
/// </summary>
namespace COMP123_S2016_FinalExam
{
    public partial class GenerateNameForm : Form
    {
        public SplashForm splashperv { get; set; }
        private Random _random;
        //private TextBox;
        public GenerateNameForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Tried to do this method but it didnt work
        /// </summary>
        private void GenerateNames()
        {
           
            List<string> FirstName = new List<string>();
            List<string> LastName = new List<string>();
            //string result;
            for (int count = 0; count < 50; count++)
            {
                //TextBox first = new TextBox();
                int fristname = this._random.Next(0, 50);
                FirstName.Add(FirstNameListBox.Text);

             //   Program.character.FirstName = FirstName.Add(FirstNameListBox.Text).Tostro;

            }
            List<string> Lastname = new List<string>();
            //string result;
            for (int count = 0; count < 50; count++)
            {
                int fristname = this._random.Next(0, 50);
                LastName.Add(FirstNameListBox.Text);

               // Program.character.LastName = FirstName.Add(FirstNameListBox.Text);

            }
            // FirstNameListBox.SelectedValue

        }
        /// <summary>
        /// This did not work as a work around
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FirstNametextBox_TextChanged(object sender, EventArgs e)
        {
          // int  x = this._random.Next(0, 50);
           // Convert.ToInt32()
           // FirstNametextBox.Text = 
        }
        /// <summary>
        /// this passes the chacter first&Last name prop to the firstname text box
        /// unfourtently no data was passes to the charachter.firstname
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            Program.character.FirstName = FirstNametextBox.Text;
            Program.character.LastName = FirstNametextBox.Text;


        }
        /// <summary>
        /// This method generates name method on click 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateNames();
        }
        /// <summary>
        /// this makes the next button work
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            AbilityGeneratorForm abilityform = new AbilityGeneratorForm();
            abilityform.Show();
            this.Hide();

        }
    }
}
