using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform1
{
    public partial class Form1 : Form
    {

        Random random = new Random();
        public int randomNumber ;

        public Form1()
        {
            randomNumber = random.Next(1,100);
            InitializeComponent();
            // randomInt.Text = randomNumber.ToString();
            

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Test_btn_Click(object sender, EventArgs e)
        {
            //string.IsNullOrEmpty(textBox1.Text)
            int input = Convert.ToInt32(myInputTextBox.Text);
            if (input > randomNumber)
            {
                retryMessage.Text = "Le nombre mystere est plus petit";
            }
            else if (input < randomNumber)
            {
                retryMessage.Text = "Le nombre mystere est plus grand";
            }
            else if (input == randomNumber)
            {
                MessageBox.Show("Bravo, vous avez deviné le nombre mystère");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loggedUsername.Text = LoginForm.Username;
        }

        private void MyInputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
