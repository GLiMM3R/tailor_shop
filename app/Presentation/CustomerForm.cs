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

        private Gender GetSelectedGender()
        {
            if (gender_male_rb.Checked) return Gender.Male;
            if (gender_female_rb.Checked) return Gender.Female;
            if (gender_other_rb.Checked) return Gender.Other;
            if (gender_prefer_not_to_say_rb.Checked) return Gender.PreferNotToSay;

            return Gender.Other; // No gender selected
        }

        private async void add_btn_Click(object sender, EventArgs e)
        {
            if (this._customer != null)
            {
                await this.UpdateCustomer();
            }
            else
            {
                await this.CreateCustomer();
            }

            this._customerUC.LoadCustomers();
            this.Close();

        }

        private async Task CreateCustomer()
        {
            if (string.IsNullOrWhiteSpace(name_txt.Text) || string.IsNullOrWhiteSpace(phone_txt.Text) || string.IsNullOrWhiteSpace(address_txt.Text))
            {
                MessageBox.Show("Please enter valid customer details.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var newCustomer = new Customer
                {
                    Name = name_txt.Text.Trim(),
                    Phone = phone_txt.Text.Trim(),
                    Address = address_txt.Text.Trim(),
                    Gender = this.GetSelectedGender()
                };

                await _customerService.Create(newCustomer);
                MessageBox.Show("New Customer Created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task UpdateCustomer()
        {

            try
            {
                var customer = this._customerService.GetByID(this._customer!.Id);
                var gender = this.GetSelectedGender();

                if (customer == null)
                {
                    MessageBox.Show("User not found!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (customer.Name != name_txt.Text && !string.IsNullOrWhiteSpace(name_txt.Text))
                {
                    customer.Name = name_txt.Text;
                }

                if (customer.Phone != phone_txt.Text && !string.IsNullOrWhiteSpace(phone_txt.Text))
                {
                    customer.Phone = phone_txt.Text;
                }

                if (customer.Address != address_txt.Text && !string.IsNullOrWhiteSpace(address_txt.Text))
                {
                    customer.Address = address_txt.Text;
                }

                if (customer.Gender != gender)
                {
                    customer.Gender = gender;
                }

                await _customerService.Update(customer);
                MessageBox.Show("Customer Update!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
