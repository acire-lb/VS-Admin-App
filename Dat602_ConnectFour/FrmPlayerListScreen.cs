using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Dat602_ConnectFour
{
    public partial class FrmPlayerListScreen : Form
    {

        private string _Me; //Current User of Screen

        private DataTable _OnlinePlayers;


        protected FrmGame _GameForm = new FrmGame();

        public FrmPlayerListScreen()
        {
            InitializeComponent();
        }
        public DialogResult ShowDialog(string prPlayer)

        {
            _Me = prPlayer; //Current User of Screen
            Text = "Welcome " + _Me;
            lblPlayerName.Text = _Me;

            UpdateListOfOnlinePlayers();

            tmPlayerScreenTimer.Interval = (1000) * (10);             // Timer will tick every 10 seconds
            tmPlayerScreenTimer.Enabled = true;                       // Enable the timer
            tmPlayerScreenTimer.Start();                              // Starting Timer
            return ShowDialog();

        }

        private void UpdateListOfOnlinePlayers()
        {
            try
            {
                _OnlinePlayers = clsDBConnection.SProcTable("OnlinePlayers_PlayerListScreen", new Dictionary<string, object>
                { ["pPlayerName"] = _Me });

                lstOnlinePlayers.DataSource = null;
                lstOnlinePlayers.DataSource = (from DataRow lcRow in _OnlinePlayers.Rows
                                               select lcRow["Player_Name"] + "\t" + lcRow["Highest_Points"] + "\t" + lcRow["Active_Status"]).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                tmPlayerScreenTimer.Stop();
                if (lstOnlinePlayers.SelectedIndex >= 0)
                {
                    string lcOpponent = _OnlinePlayers.Rows[lstOnlinePlayers.SelectedIndex]["Player_Name"].ToString();

                    if (_GameForm == null)
                        _GameForm = new FrmGame();
                    _GameForm.StartGame(_Me, lcOpponent);
                }
                tmPlayerScreenTimer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
        }

       
       

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable lcLogout = clsDBConnection.SProcTable("Logout", new Dictionary<string, object>
                { ["prExistingPlayerName"] = _Me });
                tmPlayerScreenTimer.Stop();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
        }
        private void tmPlayerScreenTimer_Tick(object sender, EventArgs e)
        {
            UpdateListOfOnlinePlayers();
        }
        private void lstOnlinePlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
