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
            username_txt.KeyDown += FormTextBox_KeyDown;
            password_txt.KeyDown += FormTextBox_KeyDown;
            user_rb.Checked = true; // Default to User role

            if (this._user != null)
            {
                add_btn.Text = "ແກ້ໄຂ";
                username_txt.Text = this._user.Username;

                if (this._user.Role == Role.User)
                {
                    user_rb.Checked = true;
                }
                else
                {
                    admin_rb.Checked = true;
                }
            }
        }

        private async void add_btn_Click(object sender, EventArgs e)
        {
            if (this._user != null)
            {
                await this.UpdateUser();
            }
            else
            {
                await this.CreateUser();
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

        private async Task CreateUser()
        {
            if (string.IsNullOrWhiteSpace(username_txt.Text) || string.IsNullOrWhiteSpace(password_txt.Text))
            {
                MessageBox.Show("Please enter valid user details.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var newUser = new User
                {
                    Username = username_txt.Text.Trim(),
                    Role = GetSelectedRole(),
                };

                var (hashedPwd, salt) = PasswordHasher.HashPassword(password_txt.Text.Trim());
                newUser.Password = hashedPwd;
                newUser.Salt = salt;

                await _userService.Create(newUser);
                MessageBox.Show("New User Created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await this._userUC.LoadUsers();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task UpdateUser()
        {
            try
            {
                var user = await this._userService.GetByID(this._user!.Id);
                var role = this.GetSelectedRole();

                if (user == null)
                {
                    MessageBox.Show("User not found!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (user.Username != username_txt.Text.Trim() && !string.IsNullOrWhiteSpace(username_txt.Text))
                {
                    user.Username = username_txt.Text.Trim();
                }

                if (password_txt.Text != null && !string.IsNullOrWhiteSpace(password_txt.Text))
                {
                    var (hashedPwd, salt) = PasswordHasher.HashPassword(password_txt.Text.Trim());
                    user.Password = hashedPwd;
                    user.Salt = salt;
                }

                if (user.Role != role)
                {
                    user.Role = role;
                }

                await _userService.Update(user);
                MessageBox.Show("New User Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await this._userUC.LoadUsers();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormTextBox_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Optionally prevent the ding sound
                e.SuppressKeyPress = true;
                add_btn.PerformClick();
            }
        }
    }
}
