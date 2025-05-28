using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app.Database;
using app.Service;
using app.Utils;
using Microsoft.EntityFrameworkCore;

namespace app
{
    public partial class LoginForm : Form
    {
        private AppDbContext _context;
        private AuthService _authService;

        public LoginForm()
        {
            InitializeComponent();
            InitializeService();
        }

        private void InitializeService()
        {
            this._context = new AppDbContext();
            this._authService = new AuthService(this._context);
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            username_txt.KeyDown += LoginTextBox_KeyDown;
            password_txt.KeyDown += LoginTextBox_KeyDown;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var user = await _authService.Login(username_txt.Text, password_txt.Text);

                if (user == null)
                {
                    MessageBox.Show("Username or password is incorrect!");
                    return;
                }
                var form = new MainForm(user);
                form.Show();
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Username or password is incorrect!");
            }

        }

        private void LoginTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Optionally prevent the ding sound
                e.SuppressKeyPress = true;
                login_btn.PerformClick();
            }
        }

        private void setting_btn_Click(object sender, EventArgs e)
        {
            var form = new ConnectionSettingsForm();
            form.ShowDialog();
        }
    }
}
