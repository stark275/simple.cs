using System;
using System.Data;
using System.Windows.Forms;
using winform1.Data;


namespace winform1
{
    public partial class LoginForm : Form
    {

        public static Boolean keepSession;
        public static string Username;
        private Database database;

        public LoginForm()
        {
            database = new Database("localhost", "root", "", "game");
            InitializeComponent();    
        }

        private void Tilte_Click(object sender, EventArgs e)
        {

        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;


            //  DataTable dt = database.Read(String.Format(
            //      "Select * from users where username = '{0}' and password = '{1}'", username, password
            //  ));

            // DataTable dt = database.Login(username, password);

             DataTable dt = database.LoginPerf(username, password);


            if (dt.Rows.Count > 0)
            {
                LoginForm.Username = username;

                this.Hide();
                Form1 playPage = new Form1();
                playPage.Show();
            }
            else
            {
                MessageBox.Show("Identifiants incorrects");
            }
            
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
             usernameTextBox.Text = "";
             passwordTextBox.Text = "";
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            sessionInfoLabel.Text = "...";
            if (keepSessionCheckBox.Checked)
            {
                keepSession = true;
                sessionInfoLabel.Text = "Votre session restera active";
                
            }
        }
    }
}
