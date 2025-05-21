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

        private Debouncer searchDebouncer;

        public UserUC()
        {
            InitializeComponent();
            InitializeUserService();
            InitializeDataGridView();

            this._filter = new FilterUser();
            total_users_lb.Text = this._count.ToString();

            searchDebouncer = new Debouncer(300, () => LoadUsers());
        }

        public void InitializeUserService()
        {
            this._dbContext = new AppDbContext();
            this._userService = new UserService(_dbContext);

            this._count = _userService.Count();
        }

        private void UserUC_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void InitializeDataGridView()
        {
            user_dgv.AutoGenerateColumns = false;
            user_dgv.Columns.Clear();

            user_dgv.Columns.AddRange(
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Id", headerText: "ID"),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Username", headerText: "Username", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Role", headerText: "Role", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, fillWeight: 80)
                );

            DataGridViewButtonColumn actionColumn = new DataGridViewButtonColumn
            {
                Name = "Edit",
                HeaderText = "",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Flat,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Padding = new Padding(2),
                    BackColor = Color.FromArgb(78, 184, 206),
                    ForeColor = Color.White,
                    Font = new Font("Arial", 9F, FontStyle.Bold),
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    SelectionBackColor = Color.FromArgb(60, 140, 160),
                    SelectionForeColor = Color.White
                }
            };

            user_dgv.Columns.Add(actionColumn);
        }

        public async void LoadUsers()
        {
            var users = await _userService.GetAll(this._filter);
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
            searchDebouncer.Trigger();
        }

        private void new_user_btn_Click(object sender, EventArgs e)
        {
            UserForm form = new UserForm(this, _userService, null);
            form.ShowDialog();
        }

        private void user_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (user_dgv.Columns[e.ColumnIndex].Name == "Edit")
                {
                    if (user_dgv.Rows[e.RowIndex].DataBoundItem is User selectedUser)
                    {
                        var form = new UserForm(this, this._userService, selectedUser);
                        form.ShowDialog();
                    }
                }
            }
        }
    }
}
