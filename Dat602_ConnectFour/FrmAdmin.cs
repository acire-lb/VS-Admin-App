using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Dat602_ConnectFour
{
  
    public partial class FrmAdmin : Form
    {
   
        private string _Admin;
    
        DataTable _OnlinePlayers;
        DataTable _GameCurrentlyPlaying;

        private FrmNewPlayer _NewPlayerForm;

        private FrmUpdatePlayer _UpdatePlayerForm;


        public FrmAdmin()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialog(string prAdmin)
        {
            _Admin = prAdmin;
            Text = "Welcome " + _Admin;
            UpdateOnlinePlayersList();
            UpdateCurrentGamesList();

            tmAdminScreenTimer.Interval = (1000) * (5);             // Timer will tick evert 10 seconds
            tmAdminScreenTimer.Enabled = true;                       // Enable the timer
            tmAdminScreenTimer.Start();                              // Start the timer  
            return ShowDialog();

        }
       
        private void UpdateOnlinePlayersList()
        {
            try
            {
                _OnlinePlayers = clsDBConnection.SProcTable("OnlinePlayersA", new Dictionary<string, object>
                { ["pPlayerName"] = _Admin });
                lstOnlinePlayers.DataSource = null;
                lstOnlinePlayers.DataSource = (from DataRow lcRow in _OnlinePlayers.Rows
                                               select lcRow["Player_Name"] + "\t" + lcRow["Highest_Points"] + "\t" + lcRow["Active_Status"]).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }  
        }
        private void UpdateCurrentGamesList()
        {
            try
            {
                _GameCurrentlyPlaying = clsDBConnection.SProcTable("GameCurrentlyPlaying", new Dictionary<string, object>
                { });
                lstCurrentGames.DataSource = null;
                lstCurrentGames.DataSource = (from DataRow lcRow in _GameCurrentlyPlaying.Rows
                                                select lcRow["Game_ID"] + "\t" + lcRow["player"] + "\t" + lcRow["GameStartTime"]).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
        }
        private void btnUpdatePlayer_Click(object sender, EventArgs e)
        {
            string lcSelectedOnlinePlayer = _OnlinePlayers.Rows[lstOnlinePlayers.SelectedIndex]["Player_Name"].ToString();

            if (_UpdatePlayerForm == null)
                _UpdatePlayerForm = new FrmUpdatePlayer();
                 
                _UpdatePlayerForm.ShowDialog(_OnlinePlayers.Rows[lstOnlinePlayers.SelectedIndex]);
            
            
        }

        private void btnRemovePlayer_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("You are about to Delete a Player, Are you Sure?");

                string lcSelectedOnlinePlayer  = _OnlinePlayers.Rows[lstOnlinePlayers.SelectedIndex]["Player_Name"].ToString();

                byte lcResult = Convert.ToByte(clsDBConnection.DbFunction("DeletePlayer", new Dictionary<string, object>
                {
                    ["prOnlinePlayer"] = lcSelectedOnlinePlayer
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
        }

        private void btnKillGame_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("You are about to Delete a Game, Are you Sure?");
                string lcCurrentGamePlaying = _GameCurrentlyPlaying.Rows[lstCurrentGames.SelectedIndex]["Game_ID"].ToString();

                byte lcDeleteAGame = Convert.ToByte(clsDBConnection.DbFunction("DeleteGame", new Dictionary<string, object>
                {
                    ["prGameID"] = lcCurrentGamePlaying
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
        }
        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            if (_NewPlayerForm == null)
                 _NewPlayerForm = new FrmNewPlayer();
             _NewPlayerForm.ShowDialog();
        }
  
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable lcLogout = clsDBConnection.SProcTable("Logout", new Dictionary<string, object>
                { ["prExistingPlayerName"] = _Admin });

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
        }
        private void tmAdminScreenTimer_Tick(object sender, EventArgs e)
        {
            UpdateOnlinePlayersList();
            UpdateCurrentGamesList();
        }
    }
}
