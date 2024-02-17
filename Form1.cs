using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PersonalFinanceManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
         private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtComPassword.Text = "";
            txtUsername.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

       private void registrationButton_Click(object sender, EventArgs e)
{
    //Let Check if username and passwords are empty
    if (txtUsername.Text == "" || txtPassword.Text == "" || txtComPassword.Text == "")
    {
        MessageBox.Show("Username and Password fields are required", "Sign Up Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    // Let Check if passwords match
    else if (txtPassword.Text == txtComPassword.Text)
    {
        try
        {
            // Path to the text file where user data will be stored
            string filePath = "users.txt";

            // Read the current index value from the file or set it to 0 if the file doesn't exist
            int currentIndex = File.Exists(filePath) ? GetNextIndex(filePath) : 0;

            // Save user data to the text file
            using (StreamWriter writer = File.AppendText(filePath))
            {
                // Increment index for the new user
                currentIndex++;

                // Write user data in the desired format
                writer.WriteLine($"index: {currentIndex}, username: {txtUsername.Text}, password: {txtPassword.Text}");
            }

            // Clear input fields
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtComPassword.Text = "";

            MessageBox.Show("Your account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    else
    {
        MessageBox.Show("Passwords do not match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtComPassword.Text = "";
        txtPassword.Text = "";
        txtPassword.Focus();
    }
}

// Method to get the next available index from the file
private int GetNextIndex(string filePath)
{
    int currentIndex = 0;

    // Read the last index from the file and increment it
    using (StreamReader reader = new StreamReader(filePath))
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            string[] parts = line.Split(',');
            if (parts.Length >= 1 && parts[0].StartsWith("index: "))
            {
                int index;
                if (int.TryParse(parts[0].Replace("index: ", ""), out index))
                {
                    currentIndex = Math.Max(currentIndex, index);
                }
            }
        }
    }

    return currentIndex;
}

// Method to check if username already exists in the text file
private bool CheckUsernameExists(string username, string filePath)
{
    using (StreamReader reader = new StreamReader(filePath))
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            string[] parts = line.Split(',');
            if (parts.Length >= 1 && parts[0] == username)
            {
                return true; // Username already exists
            }
        }
    }
    return false; // Username doesn't exist
}

        private void checkboxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';

            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtComPassword.PasswordChar = '*';
            }
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

            new LoginForm().Show();
            this.Hide();
        }

       
  }

    
}