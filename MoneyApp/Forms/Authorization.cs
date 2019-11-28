using MoneyApp.Models;
using MoneyApp.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bcrypt = BCrypt.Net.BCrypt;

namespace MoneyApp.Forms
{
    public partial class Authorization : Form
    {
        private string new_name, new_username, new_password, new_repeat_password;
        private string username, password;
        UserRepository userRepository;
        public Authorization()
        {
            InitializeComponent();
            userRepository = new UserRepository();
        }

        private void SignInClick(object sender, EventArgs e)
        {
            username = tbx_username.Text;
            password = tbx_password.Text;

            if (!ValidateSignInInput()) return;

            User user = userRepository.GetUserByUsername(username);
            
            if (!CheckUser(user)) return;

            if (!CheckPassword(user)) return;
        }

        private void SignUpClick(object sender, EventArgs e)
        {
            new_name = tbx_new_name.Text;
            new_username = tbx_new_username.Text;
            new_password = tbx_new_password.Text;
            new_repeat_password = tbx_new_repeat_password.Text;

            if (!ValidateSignUpInput()) return;

            if (!CheckUsername()) return;

            EncryptPassword();

            bool result = userRepository.AddUser(new User { Name = new_name, Username = new_username, Password = new_password });

            string message = result ? "You have been signed up successfully!" : "Something went wrong!";

            MessageBox.Show(message);
        }

        private bool CheckUser(User user)
        {
            if (!(user.ID > 0))
            {
                MessageBox.Show("Username or password is incorrect!", "Error");
                return false;
            }
            return true;
        }

        private bool CheckPassword(User user)
        {
            bool isCorrect = bcrypt.Verify("MlADmsKS" + password + "FCkvSlS", user.Password);
            if (!isCorrect)
            {
                MessageBox.Show("Username or password is incorrect!", "Error");
                return false;
            }
            return true;
        }

        private void EncryptPassword()
        {
            new_password = bcrypt.HashPassword("MlADmsKS" + new_password + "FCkvSlS", bcrypt.GenerateSalt());
        }

        private bool CheckUsername()
        {
            User user = userRepository.GetUserByUsername(new_username);
            if (user.ID > 0)
            {
                MessageBox.Show("User with this username already exists!", "Error");
                return false;
            }
            return true;
        }

        private bool ValidateSignInInput()
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username field cannot be empty!", "Error");
                return false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password field cannot be empty!", "Error");
                return false;
            }
            return true;
        }

        private bool ValidateSignUpInput()
        {
            if (string.IsNullOrWhiteSpace(new_name))
            {
                MessageBox.Show("Name field cannot be empty!", "Error");
                return false;
            }

            if (string.IsNullOrWhiteSpace(new_username))
            {
                MessageBox.Show("Username field cannot be empty!", "Error");
                return false;
            }

            if (string.IsNullOrWhiteSpace(new_password))
            {
                MessageBox.Show("Password field cannot be empty!", "Error");
                return false;
            }

            if (string.IsNullOrWhiteSpace(new_repeat_password))
            {
                MessageBox.Show("Repeat password field cannot be empty!", "Error");
                return false;
            }

            if (new_name.Length < 3)
            {
                MessageBox.Show("Name must contain at least from 3 characters!", "Error");
                return false;
            } else if (new_name.Length > 50)
            {
                MessageBox.Show("Name must not contain more than 50 characters!", "Error");
                return false;
            }

            if (new_username.Length < 5)
            {
                MessageBox.Show("Username must contain at least from 5 characters!", "Error");
                return false;
            }
            else if (new_username.Length > 50)
            {
                MessageBox.Show("Username must not contain more than 50 characters!", "Error");
                return false;
            }

            if (new_password.Length > 50)
            {
                MessageBox.Show("Password must not contain more than 50 characters!", "Error");
                return false;
            }

            if (!new_password.Equals(new_repeat_password))
            {
                MessageBox.Show("Passwords do not match!", "Error");
                return false;
            }
            return true;
        }
    }
}
