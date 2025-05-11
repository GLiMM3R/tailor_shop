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

namespace app.Presentation
{
    public partial class CustomerForm : Form
    {
        private readonly CustomerUC _customerUC;
        private readonly CustomerService _customerService;
        private Customer? _customer;
        public CustomerForm(CustomerUC customerUC,CustomerService customerService, Customer? customer)
        {
            InitializeComponent();

            this._customerUC = customerUC;
            this._customerService = customerService;
            _customer = customer;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            var newCustomer = new Customer
            {
                Name = name_txt.Text.Trim(),
                Phone = phone_txt.Text.Trim(),
                Address = address_txt.Text.Trim(),
            };

            if (gender_male_rb.Checked)
            {
                newCustomer.Gender = Gender.Male;
            }
            else if (gender_female_rb.Checked)
            {
                newCustomer.Gender = Gender.Female;
            }
            else if (gender_other_rb.Checked)
            {
                newCustomer.Gender = Gender.Other;
            }else if (gender_prefer_not_to_say_rb.Checked)
            {
                newCustomer.Gender = Gender.Other;
            }

            try
            {
                _customerService.Create(newCustomer);
                _customerUC.LoadCustomers();
                MessageBox.Show("New Customer Created!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
