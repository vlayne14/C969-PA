using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Victoria_Brown_C969_PA
{
    public partial class login : Form
    {
        private List<User> users;
        private string culture;
        public login()
        {
            InitializeComponent();
        }

        //changing labels to french
        private void loginToFrench()
        {
            loginLabel.Text = "Connexion";
            userNameLabel.Text = "Nom d’utilisateur";
            passwordLabel.Text = "Mot de passe";
            loginStartButton.Text = "Début";
            loginCloseButton.Text = "Fermer";
        }

        //changing language to french upon login load
        private void login_Load_1(object sender, EventArgs e)
        {
            culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            //getting users from database
            users = SQL_Data.getUsers();
            //error label should be blank at start
            loginErrorLabel.Text = "";
            if (culture == "fr")
            {
                loginToFrench();
            }
        }
        private void loginStartButton_Click(object sender, EventArgs e)
        {
            string userName = loginUserNameText.Text;
            string password = loginPasswordText.Text;

            try
            {   //username and password fields are empty
                if (userName == "" || password == "")
                {
                    if (culture == "fr")
                    {
                        //both a username and a password are required to login
                        throw new LoginFormExceptions("Un nom d’utilisateur et un mot de passe sont requis pour la connexion.");
                    }
                    throw new LoginFormExceptions("Both a username and a password are required to login.");
                }

                //lambda expression determining if username matches username in database
                List<User> currentUser = users.Where(user => user.userName == userName).ToList();

                if (currentUser.Count < 1)
                {
                    if (culture == "fr")
                    {
                        //username does not exist
                        throw new LoginFormExceptions("Le nom d’utilisateur n’existe pas.");
                    }
                    throw new LoginFormExceptions("Username does not exist.");
                }

                if (currentUser[0].password != password)
                {
                    if (culture == "fr")
                    {
                        //password is incorrect
                        throw new LoginFormExceptions("Le mot de passe est incorrect.");
                    }
                    throw new LoginFormExceptions ( "Password is incorrect.");
                
                }
                User_Tracking.trackUser(currentUser[0]);

                var main = new Main(currentUser[0]);
                main.Show();
                Hide();
            }
            catch(LoginFormExceptions error)
            {
                loginErrorLabel.Text = error.Message;
            }
        
        }

        //close button clicked
		private void loginCloseButton_Click(object sender, EventArgs e)
		{
            Application.Exit();
		}
	}
}
