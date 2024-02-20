using System.Windows.Forms;
using System;
using PersonalFinanceManager.Properties;


namespace PersonalFinanceManager.Properties
{
    public partial class Dashboard : Form
    {
        public static Dashboard instance;
        public Label lbl;
       public Dashboard(string username, int index)
{
    InitializeComponent();
    usernameDash.Text = "Welcome, " + username; // Set the username on the dashboard label
}
       
       public void loadform(object Form)
       {
           if (this.mainpanel.Controls.Count > 0)
               this.mainpanel.Controls.RemoveAt(0);
           Form f = Form as Form;
           f.TopLevel = false;
           f.Dock = DockStyle.Fill;
           this.mainpanel.Controls.Add(f);
           this.mainpanel.Tag = f;
           f.Show();
       }


       private void accountSum_Click(object sender, EventArgs e)
       {
           loadform(new AccountSummary());
       }
    }
}