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
    public partial class Login : Form
    {
        private AppDbContext _context;
        private AuthService _authService;
        private MainForm _dashboard;

        public Login()
        {
            InitializeComponent();
            InitializeService();
        }

        private void InitializeService()
        {
            this._context = new AppDbContext();
            this._authService = new AuthService(this._context);
            this._dashboard = new MainForm();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var isAuthenticated = await _authService.Login(username_txt.Text, password_txt.Text);

                if (!isAuthenticated)
                {
                    MessageBox.Show("Username or password is incorrect!");
                    return;
                }

                _dashboard.Show();
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Username or password is incorrect!");
                throw;
            }

        }
    }
}
