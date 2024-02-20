using System.Windows.Forms;
using System;
using System.IO;
using PersonalFinanceManager.Properties;

namespace PersonalFinanceManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
         private void label6_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void registrationButton_Click(object sender, EventArgs e)
{
    string username = txtUsername.Text;
    string password = txtPassword.Text;

    string filePath = "users.txt";

    // Check if the users file exists
    if (!File.Exists(filePath))
    {
        MessageBox.Show("Users file not found. Please register first.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
    }

    // Check if username and password are provided
    if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
    {
        MessageBox.Show("Username and password are required.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
    }

    // Check if the user credentials are correct
    string[] lines = File.ReadAllLines(filePath);
    int index = -1;
    bool isAuthenticated = false;
    foreach (string line in lines)
    {
        index++;
        string[] parts = line.Split(',');
        string[] indexPart = parts[0].Split(':'); // Splitting "index: 1" into ["index", "1"]
        int userIndex = Convert.ToInt32(indexPart[1].Trim()); // Extracting the index value
        if (parts.Length >= 3 && parts[1].Trim() == $"username: {username}" && parts[2].Trim() == $"password: {password}")
        {
            isAuthenticated = true;
            index = userIndex; // Assigning the extracted index value
            break;
        }
    }

    // Handle login result
    if (isAuthenticated)
    {
        // Successful login
        // Save the index for later use
        // Here, you can use the index as needed
        // For example, you can pass it to the Dashboard constructor or save it in a global variable
        
        Dashboard dashboard = new Dashboard(username, index); // Pass the username and index to the dashboard
        dashboard.Show();
        this.Hide();
    }
    else
    {
        // Failed login
        MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtUsername.Text = "";
        txtPassword.Text = "";
        txtUsername.Focus();
    }
}


        
        
        
        
        

        private void checkboxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';

            }
        }


        private void label3_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}