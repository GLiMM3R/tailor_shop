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

        private void add_btn_Click(object sender, EventArgs e)
        {
            var newUser = new User
            {
                Username = username_txt.Text.Trim(),
            };

            var (hashedPwd, salt) = PasswordHasher.HashPassword(password_txt.Text.Trim());

            newUser.Password = hashedPwd;
            newUser.Salt = salt;

            if (user_rb.Checked)
            {
                newUser.Role = Role.User;
            }
            else if (admin_rb.Checked)
            {
                newUser.Role = Role.Admin;
            }

            try
            {
                _userService.Create(newUser);
                _userUC.LoadUsers();
                MessageBox.Show("New User Created!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
