using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Dat602_ConnectFour
{
    public partial class FrmNewPlayer : Form
    {
        public FrmNewPlayer()
        {
            InitializeComponent();
        }

        
        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                byte lcAddNewPlayer = Convert.ToByte(clsDBConnection.DbFunction("RegisterNewPlayer", new Dictionary<string, object>
            {
                ["Name"] = txtName.Text, 
                ["Pwsd"] = txtPassword.Text
            }));
                switch (lcAddNewPlayer)
                {
                    case 0:
                        MessageBox.Show("That Was an Unsuccessful, Player Not Added!");
                        break;
                    case 1:
                        MessageBox.Show("Successful, Player was Added to List Of players");
                        Hide();
                        txtName.Text = "";
                        txtPassword.Text = "";
                        break;
                    default:
                        MessageBox.Show("An Unexpected Input, Player will not be added!", "Unexpected Input");
                        break;
                }
            }
            catch (Exception ex)
        
            {
                MessageBox.Show(ex.GetBaseException().Message); // Catches errors when adding a new player does not work they way it should.
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            Close();
            
        }
    }
}
