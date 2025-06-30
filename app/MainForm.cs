using app.Database;
using app.Model;
using app.Presentation;

namespace app
{
    public partial class MainForm : Form
    {
        // User
        public User _user;
        // Color
        private Color activeColor = Color.FromArgb(84, 119, 146);
        private Color inactiveColor = Color.Transparent;
        private Color hoverColor = Color.LightGray;

        // Button
        private List<Button> sidebarButtons = new List<Button>();

        // active button
        private Button currentActiveButton = null;

        public MainForm(User user)
        {
            InitializeComponent();
            InitializeService();
            InitializeSidebarButtons();

            this._user = user;
        }

        private void InitializeService()
        {
        }

        private void InitializeSidebarButtons()
        {
            sidebarButtons.Add(home_btn);
            sidebarButtons.Add(order_btn);
            sidebarButtons.Add(customer_btn);
            sidebarButtons.Add(user_btn);
            sidebarButtons.Add(fabric_btn);
            sidebarButtons.Add(garment_btn);
            sidebarButtons.Add(report_btn);

            SetupButtonEvents();
        }

        private void SetupButtonEvents()
        {
            foreach (Button btn in sidebarButtons)
            {
                btn.BackColor = inactiveColor;
                btn.Click += SidebarButton_Click;

                btn.MouseEnter += (sender, e) =>
                {
                    Button hoveredButton = sender as Button;
                    if (hoveredButton != currentActiveButton)
                    {
                        hoveredButton.BackColor = hoverColor;
                    }
                };

                btn.MouseLeave += (sender, e) =>
                {
                    Button leftButton = sender as Button;
                    if (leftButton != currentActiveButton)
                    {
                        leftButton.BackColor = inactiveColor;
                    }
                };
            }
            ;
        }

        private void SidebarButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                if (currentActiveButton != null && currentActiveButton != clickedButton)
                {
                    currentActiveButton.BackColor = inactiveColor;
                }

                clickedButton.BackColor = activeColor;
                currentActiveButton = clickedButton;
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            var home = new HomeUC();
            LoadFormIntoPanel(home);
        }

        public void LoadFormIntoPanel(UserControl child)
        {
            content_pn.Controls.Clear();

            child.Dock = DockStyle.Fill;

            content_pn.Controls.Add(child);
            content_pn.Tag = child;
            child.Show();
        }

        private void order_btn_Click(object sender, EventArgs e)
        {
            var order = new OrderUC(_user, this);
            LoadFormIntoPanel(order);
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            var home = new HomeUC();
            LoadFormIntoPanel(home);
        }
        private void customer_btn_Click(object sender, EventArgs e)
        {
            var customer = new CustomerUC();
            LoadFormIntoPanel(customer);
        }
        private void user_btn_Click(object sender, EventArgs e)
        {
            var user = new UserUC(_user);
            LoadFormIntoPanel(user);
        }

        private void fabric_btn_Click(object sender, EventArgs e)
        {
            var fabric = new FabricUC(_user);
            LoadFormIntoPanel(fabric);
        }
        private void garment_btn_Click(object sender, EventArgs e)
        {
            var garment = new GarmentUC(_user);
            LoadFormIntoPanel(garment);
        }
        private void report_btn_Click(object sender, EventArgs e)
        {
            var garment = new ReportUC(this);
            LoadFormIntoPanel(garment);
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            var _login = new LoginForm();
            _login.Show();
            this.Hide();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
