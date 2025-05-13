using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app.Model;
using app.Service;
using app.Utils;

namespace app.Presentation
{
    public partial class UserForm : Form
    {
        private readonly UserUC _userUC;
        private readonly UserService _userService;
        private User? _user;

        public UserForm(UserUC userUC, UserService userService, User? user)
        {
            InitializeComponent();

            this._userUC = userUC;
            this._userService = userService;
            this._user = user;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            if (this._user != null) {
                add_btn.Text = "Update User";
                username_txt.Text = this._user.Username;

                if (this._user.Role == Role.User)
                {
                    user_rb.Checked = true;
                } else
                {
                    admin_rb.Checked = true;
                }
            }
        }

        private async void add_btn_Click(object sender, EventArgs e)
        {
            bool isSuccess = false;

            if (this._user != null)
            {
                isSuccess = await this.UpdateUser();
            }
            else
            {
                isSuccess = await this.CreateUser();
            }

            if (isSuccess)
            {
                _userUC.LoadUsers();
                this.Close();
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Role GetSelectedRole()
        {
            if (admin_rb.Checked) return Role.Admin;
            return Role.User; // No gender selected
        }

        private async Task<bool> CreateUser()
        {
            var newUser = new User
            {
               Username = username_txt.Text.Trim(),
               Role = GetSelectedRole(),
            };

            var (hashedPwd, salt) = PasswordHasher.HashPassword(password_txt.Text.Trim());
            newUser.Password = hashedPwd;
            newUser.Salt = salt;

            try
            {
                await _userService.Create(newUser);

                MessageBox.Show("New User Created!");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private async Task<bool> UpdateUser()
        {
            var user = await this._userService.GetByID(this._user!.Id);
            var role = this.GetSelectedRole();

            if (user == null)
            {
                return false;
            }

            if (user.Username != username_txt.Text.Trim())
            {
                user.Username = username_txt.Text.Trim();
            }

            if(password_txt.Text != null)
            {
                var (hashedPwd, salt) = PasswordHasher.HashPassword(password_txt.Text.Trim());
                user.Password = hashedPwd;
                user.Salt = salt;
            }

            if (user.Role != role)
            {
                user.Role = role;
            }

            try
            {
                await _userService.Update(user);

                MessageBox.Show("User Updated!");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
