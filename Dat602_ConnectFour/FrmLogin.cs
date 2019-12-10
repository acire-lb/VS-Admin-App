using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Dat602_ConnectFour
{
    public partial class FrmLogin : Form
    {
        private FrmPlayerListScreen _PlayerlistForm;
        private FrmAdmin _AdminPlayerListForm;

        public FrmLogin()
        {
            InitializeComponent();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            byte lcResult = Convert.ToByte(clsDBConnection.DbFunction("Login", new Dictionary<string, object>
            {
                ["Name"] = txtUserName.Text,
                ["Pwsd"] = txtPassword.Text
            })); 
            switch (lcResult)
            {
                case 0:
                    MessageBox.Show("Login Failed");
                    break;
                case 1:
                    MessageBox.Show("Sucessful Login");
                    // Register();  // test only
                    if (_PlayerlistForm == null)
                        _PlayerlistForm = new FrmPlayerListScreen();
                    Hide();
                    txtPassword.Text = "";
                    _PlayerlistForm.ShowDialog(txtUserName.Text);
                    
                    Show();
                    break;
                case 2:
                    if (MessageBox.Show("Would you Like to Register?", "Registering", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        Register();
                    break;
                case 3:
                    MessageBox.Show("Sucessful Admin Login");
                    if (_AdminPlayerListForm == null)
                        _AdminPlayerListForm = new FrmAdmin();
                    Hide();
                    txtPassword.Text = "";
                    _AdminPlayerListForm.ShowDialog(txtUserName.Text);
                    Show();
                    break;
                default:
                    MessageBox.Show("Not an expected result from Login function!");
                    break;
            }
        }
        private void Register()
        {
            try
            {
                byte lcRegister = Convert.ToByte(clsDBConnection.DbFunction("RegisterNewPlayer", new Dictionary<string, object>
                {
                    ["Name"] = txtUserName.Text,
                    ["Pwsd"] = txtPassword.Text
                }));

                switch (lcRegister)
                {
                    case 0:
                        MessageBox.Show("Unsucessful Register");
                        break;
                    case 1:
                        MessageBox.Show("Sucessful Register");
                        if (_PlayerlistForm == null)
                            _PlayerlistForm = new FrmPlayerListScreen();
                        txtPassword.Text = "";
                        _PlayerlistForm.ShowDialog(txtUserName.Text);
                        break;
                    default:
                        MessageBox.Show("Not an expected input for Register");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
