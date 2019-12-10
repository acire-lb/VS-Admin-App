using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Dat602_ConnectFour
{
    public partial class FrmUpdatePlayer : Form
    {
        private string _PlayerName;
        private DataRow _PlayerRow;

        public FrmUpdatePlayer()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialog(string prPlayer)
        {
            _PlayerName = prPlayer;
                                         
            return ShowDialog();
        }
        public DialogResult ShowDialog(DataRow prPlayerRow)
        {
            _PlayerRow = prPlayerRow;
            txtName.Text = _PlayerRow["Player_Name"].ToString();
            txtPoints.Text = _PlayerRow["Highest_Points"].ToString();
            txtActiveStatus.Text = _PlayerRow["Active_Status"].ToString();
           
            Text = _PlayerRow["Player_Name"].ToString();
            return ShowDialog();

        }

     
        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
               
                byte lcUpdateResults = Convert.ToByte(clsDBConnection.DbFunction("UpdatePlayerDetails", new Dictionary<string, object>
                { ["Player_Name"] = txtName.Text, ["Highest_Points"] = txtPoints.Text, ["Active_Status"] = txtActiveStatus.Text}));

                switch (lcUpdateResults)
                {
                    case 0:
                        MessageBox.Show("Unsucessful Update");
                        break;
                    case 1:
                        MessageBox.Show("Successful Update");
                        Close();
                        break;
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you Sure you want to Cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            Close();
   
        }

        

        private void btnSet_Click(object sender, EventArgs e)
        {
            try
            { 

            byte lcUpdatePassword = Convert.ToByte(clsDBConnection.DbFunction("UpdatePlayerPassword", new Dictionary<string, object>
            { ["Player_Name"] = txtName.Text, ["Player_Password"] = txtPassword.Text }));


            switch (lcUpdatePassword)
            {
                case 0:
                    MessageBox.Show("Unsucessful Update");
                    break;
                case 1:
                    MessageBox.Show("Successful Update");
                    Close();
                    break;
                
            }

        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
            }
    }
}
