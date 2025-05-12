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
        public CustomerForm(CustomerUC customerUC, CustomerService customerService, Customer? customer)
        {
            InitializeComponent();

            this._customerUC = customerUC;
            this._customerService = customerService;
            _customer = customer;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            if (this._customer != null)
            {
                add_btn.Text = "Update Customer";

                name_txt.Text = this._customer.Name;
                phone_txt.Text = this._customer.Phone;
                address_txt.Text = this._customer.Address;

                if (this._customer.Gender == Gender.Male)
                {
                    gender_male_rb.Checked = true;
                }
                else if (this._customer.Gender == Gender.Female)
                {
                    gender_female_rb.Checked = true;
                }
                else if (this._customer.Gender == Gender.Other)
                {
                    gender_other_rb.Checked = true;
                }
                else if (this._customer.Gender == Gender.PreferNotToSay)
                {
                    gender_prefer_not_to_say_rb.Checked = true;
                }

            }
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
            }
            else if (gender_prefer_not_to_say_rb.Checked)
            {
                newCustomer.Gender = Gender.Other;
            }

            try
            {
                if (this._customer != null)
                {
                    _customerService.Update(this._customer.Id, newCustomer);
                    MessageBox.Show("Customer Updated!");
                }
                else
                {
                    _customerService.Create(newCustomer);
                    MessageBox.Show("New Customer Created!");
                }

                _customerUC.LoadCustomers();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
