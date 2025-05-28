using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app.Database;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace app
{
    public partial class ConnectionSettingsForm : Form
    {
        public ConnectionSettingsForm()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            try
            {
                var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"]?.ConnectionString;

                var builder = new Microsoft.Data.SqlClient.SqlConnectionStringBuilder(connectionString);
                server_txt.Text = builder.DataSource;
                database_txt.Text = builder.InitialCatalog;
                intergrated_security_cb.Checked = builder.IntegratedSecurity;
                username_txt.Text = builder.UserID;
                password_txt.Text = builder.Password;
                username_txt.Enabled = !intergrated_security_cb.Checked;
                password_txt.Enabled = !intergrated_security_cb.Checked;
                trust_server_certificate_cb.Checked = builder.TrustServerCertificate;
            }
            catch (Exception)
            {
                throw new InvalidOperationException("Failed to load connection settings. Please check your configuration file.");
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            string connectionString = BuildConnectionString();

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConnectionStringsSection csSection = config.ConnectionStrings;


            if (csSection.ConnectionStrings["DefaultConnection"] != null)
            {
                csSection.ConnectionStrings["DefaultConnection"].ConnectionString = connectionString;
                csSection.ConnectionStrings["DefaultConnection"].ProviderName = "System.Data.SqlClient";
            }
            else
            {
                csSection.ConnectionStrings.Add(new ConnectionStringSettings("DefaultConnection", connectionString));
            }

            if (TestConnection(connectionString))
            {
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("connectionStrings");
                MessageBox.Show("Connection successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Application.Restart();
                this.Close();
            }
            else
            {
                MessageBox.Show("Connection failed. Please check your settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void intergrated_security_cb_CheckedChanged(object sender, EventArgs e)
        {
            username_txt.Enabled = !intergrated_security_cb.Checked;
            password_txt.Enabled = !intergrated_security_cb.Checked;
        }

        private void test_btn_Click(object sender, EventArgs e)
        {
            string connectionString = BuildConnectionString();
            if (connectionString == null)
            {
                MessageBox.Show("Invalid connection string. Please check your settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (TestConnection(connectionString))
                {
                    MessageBox.Show("Connection successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Connection failed. Please check your settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool TestConnection(string connectionString)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    connection.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private string BuildConnectionString()
        {
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = server_txt.Text,
                InitialCatalog = database_txt.Text,
                IntegratedSecurity = intergrated_security_cb.Checked,
                TrustServerCertificate = trust_server_certificate_cb.Checked, // This is optional, set to true if you want to trust the server certificate
                ConnectTimeout = 15 // Optional, default is 15 seconds
            };
            if (!intergrated_security_cb.Checked)
            {
                builder.UserID = username_txt.Text;
                builder.Password = password_txt.Text;
            }
            return builder.ConnectionString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
