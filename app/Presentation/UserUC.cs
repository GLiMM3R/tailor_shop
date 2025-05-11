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
using app.Model;
using app.Service;
using app.Utils;

namespace app.Presentation
{
    public partial class UserUC : UserControl
    {
        private AppDbContext _dbContext;
        private UserService _userService;
        private FilterUser _filter;
        private int _count;

        public UserUC()
        {
            InitializeComponent();
            InitializeUserService();

            this._filter = new FilterUser();
            total_users_lb.Text = this._count.ToString();
        }

        public async void InitializeUserService()
        {
            this._dbContext = new AppDbContext();
            this._userService = new UserService(_dbContext);

            this._count = _userService.Count();
        }

        private void UserUC_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        public async void LoadUsers()
        {
            var users = await _userService.GetAll(this._filter);

            user_dgv.AutoGenerateColumns = false;
            user_dgv.Columns.Clear();


            user_dgv.Columns.AddRange(
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Id", headerText: "ID"),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Username", headerText: "Username", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Role", headerText: "Role")
                );

            DataGridViewButtonColumn actionColumn = new DataGridViewButtonColumn
            {
                Name = "Action",
                HeaderText = "Action",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
            };
            user_dgv.Columns.Add(actionColumn);

            user_dgv.DataSource = users;
        }

        private void role_cb_SelectedValueChanged(object sender, EventArgs e)
        {
            if (role_cb.SelectedIndex == 0)
            {
                _filter.Role = null;
                LoadUsers();
            }
            else if (role_cb.SelectedIndex == 1)
            {
                _filter.Role = Role.User;
                LoadUsers();
            }
            else if (role_cb.SelectedIndex == 2)
            {
                _filter.Role = Role.Admin;
                LoadUsers();
            }
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            this._filter.Username = search_txt.Text.Trim();
            LoadUsers();
        }
    }
}
