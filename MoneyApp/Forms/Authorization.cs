using MoneyApp.Models;
using MoneyApp.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using bcrypt = BCrypt.Net.BCrypt;

using TBX = MoneyAppControls.TextBox;

namespace MoneyApp.Forms
{
    public partial class Authorization : Form
    {
        private string newName, newUsername, newPassword, newRepeatPassword;
        private string username, password;
        UserRepository userRepository;
        public Authorization()
        {
            InitializeComponent();
            Instances.MoneyApp.Hide();
            userRepository = UserRepository.Instance;
        }

        private async void SignInClick(object sender, EventArgs e)
        {
            username = tbx_username.Text;
            password = tbx_password.Text;

            if (!ValidateSignInInput()) return;

            User user = await Task.Run(() => userRepository.GetUserByUsername(username));
            
            if (!CheckUser(user)) return;

            if (!CheckPassword(user)) return;

            Instances.User = user;
            Close();
        }

        private async void SignUpClick(object sender, EventArgs e)
        {
            newName = tbx_new_name.Text;
            newUsername = tbx_new_username.Text;
            newPassword = tbx_new_password.Text;
            newRepeatPassword = tbx_new_validate_password.Text;

            if (!ValidateSignUpInput()) return;

            if (!await CheckUsername()) return;

            EncryptPassword();

            bool result = await Task.Run(() => userRepository.AddUser(new User { Name = newName, Username = newUsername, Password = newPassword }));

            if (!result) ShowMessage(btn_sign_up, "Something went wrong!");
            else
            {
                btn_sign_up.Text = "Successfully signed up!";
                btn_sign_up.Enabled = false;
                btn_sign_up.BackColor = Color.FromArgb(165, 214, 167);
                btn_sign_up.ForeColor = Color.FromArgb(76, 175, 80);
                btn_sign_up.FlatAppearance.BorderColor = Color.FromArgb(76, 175, 80);
            }
        }

        private void AuthorizationFormClosed(object sender, FormClosedEventArgs e)
        {
            if (Instances.User == null)
            {
                Instances.MoneyApp.Close();
            }
            else
            {
                Instances.MoneyApp.Activate();
                Instances.MoneyApp.Show();
            }
            Dispose();
        }

        private void DoWait(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = (BackgroundWorker)sender;
            bw.ReportProgress(0, (Button)e.Argument);
            Thread.Sleep(3000);
            bw.ReportProgress(1, (Button)e.Argument);
        }

        private void DoProgress(object sender, ProgressChangedEventArgs e)
        {
            Button btn = (Button)e.UserState;
            if (e.ProgressPercentage == 0)
            {
                string t = (string)btn.Tag;
                btn.Tag = btn.Text;
                btn.Text = t;
                btn.Enabled = false;
                btn.BackColor = Color.FromArgb(255, 205, 210);
                btn.ForeColor = Color.FromArgb(229, 115, 115);
                btn.FlatAppearance.BorderColor = Color.FromArgb(229, 115, 115);
            }
            else if (e.ProgressPercentage == 1)
            {
                btn.Text = (string)btn.Tag;
                btn.Enabled = true;
                btn.BackColor = Color.FromArgb(33, 150, 243);
                btn.ForeColor = Color.White;
                btn.FlatAppearance.BorderColor = Color.FromArgb(30, 136, 229);
                if (!tbx_password.ContainsFocus) tbx_password.Status = TBX.BoxStatus.None;
                if (!tbx_username.ContainsFocus) tbx_username.Status = TBX.BoxStatus.None;                
            }
        }

        private bool CheckUser(User user)
        {
            if (!(user.ID > 0))
            {
                tbx_username.Status = TBX.BoxStatus.Error;
                tbx_password.Status = TBX.BoxStatus.Error;
                ShowMessage(btn_sign_in, "Username or password is incorrect!");
                return false;
            }
            return true;
        }

        private bool CheckPassword(User user)
        {
            bool isCorrect = bcrypt.Verify("MlADmsKS" + password + "FCkvSlS", user.Password);
            if (!isCorrect)
            {
                tbx_username.Status = TBX.BoxStatus.Error;
                tbx_password.Status = TBX.BoxStatus.Error;
                ShowMessage(btn_sign_in, "Username or password is incorrect!");
                return false;
            }
            return true;
        }

        private void EncryptPassword()
        {
            newPassword = bcrypt.HashPassword("MlADmsKS" + newPassword + "FCkvSlS", bcrypt.GenerateSalt());
        }

        private async Task<bool> CheckUsername()
        {
            User user = await Task.Run(() => userRepository.GetUserByUsername(newUsername));
            if (user.ID > 0)
            {
                tbx_new_username.Status = TBX.BoxStatus.Error;
                MessageBox.Show("User with this username already exists!", "Error");
                return false;
            }
            return true;
        }

        private bool ValidateSignInInput()
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                ShowMessage(btn_sign_in, "Username field cannot be empty!");
                tbx_username.Status = TBX.BoxStatus.Error;
                return false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                ShowMessage(btn_sign_in, "Password field cannot be empty!");
                tbx_password.Status = TBX.BoxStatus.Error;
                return false;
            }
            return true;
        }

        private bool ValidateSignUpInput()
        {
            if (string.IsNullOrWhiteSpace(newUsername))
            {
                tbx_new_username.Status = TBX.BoxStatus.Error;
                ShowMessage(btn_sign_up, "Username field cannot be empty!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(newName))
            {
                tbx_new_name.Status = TBX.BoxStatus.Error;
                ShowMessage(btn_sign_up, "Name field cannot be empty!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(newPassword))
            {
                tbx_new_password.Status = TBX.BoxStatus.Error;
                ShowMessage(btn_sign_up, "Password field cannot be empty!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(newRepeatPassword))
            {
                tbx_new_validate_password.Status = TBX.BoxStatus.Error;
                ShowMessage(btn_sign_up, "Repeat password field cannot be empty!");
                return false;
            }

            if (newName.Length < 3)
            {
                tbx_new_name.Status = TBX.BoxStatus.Error;
                ShowMessage(btn_sign_up, "Name must be at least from 3 symbols!");
                return false;
            } else if (newName.Length > 50)
            {
                tbx_new_name.Status = TBX.BoxStatus.Error;
                ShowMessage(btn_sign_up, "Name must not be more than 50 symbols!");
                return false;
            }

            if (newUsername.Length < 5)
            {
                tbx_new_username.Status = TBX.BoxStatus.Error;
                ShowMessage(btn_sign_up, "Username must be at least from 5 symbols!");
                return false;
            }
            else if (newUsername.Length > 50)
            {
                tbx_new_username.Status = TBX.BoxStatus.Error;
                ShowMessage(btn_sign_up, "Username must not be more than 50 symbols!");
                return false;
            }

            if (newPassword.Length > 50)
            {
                tbx_new_password.Status = TBX.BoxStatus.Error;
                ShowMessage(btn_sign_up, "Password must not be more than 50 symbols!");
                return false;
            }

            if (!newPassword.Equals(newRepeatPassword))
            {
                tbx_new_password.Status = TBX.BoxStatus.Error;
                ShowMessage(btn_sign_up, "Passwords do not match!");
                return false;
            }
            return true;
        }

        private void ShowMessage(Button btn, string text)
        {
            btn.Tag = text;
            BackgroundWorker bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;
            bw.DoWork += DoWait;
            bw.ProgressChanged += DoProgress;
            bw.RunWorkerAsync(btn);
        }
    }
}
