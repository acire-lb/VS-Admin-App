using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Dat602_ConnectFour
{
    public partial class FrmGame : Form
    {
        private string _Me;
        private string _Opponent;
        private int _GameID;
        private int _EndGame;
        public FrmGame()
        {
            InitializeComponent();
        }
 
        public void StartGame(string prMe, string prOpponent)
        {
            _Me = prMe; 
            _Opponent = prOpponent;
          
            _GameID = Convert.ToInt32(clsDBConnection.DbFunction("CreateGame", new Dictionary<string, object>
            {
                ["prExistingPlayerName1"] = _Me,
                ["prExistingPlayerName2"] = _Opponent

            }));

            if (_GameID <= 1) // check if there is an error
            {
               
                MessageBox.Show("Already Existing in a Game");
            }
            else // success
            {
                MessageBox.Show("You are Challenged");
                Text = "Welcome " + _Me;
                lblOpponent.Text = _Me + " playing " + _Opponent;
                tmGameTimer.Interval = (1000) * (10);             // Timer will tick every 10 seconds
                tmGameTimer.Enabled = true;                       // Enable the timer
                tmGameTimer.Start();
                tmGameTimer.Start(); // start timer here.
                ShowDialog();
            }
        }
    
      
       
        private void btnExit_Click(object sender, EventArgs e)
        {
            
            _EndGame = Convert.ToInt32(clsDBConnection.DbFunction("ENDGAME", new Dictionary<string, object>
            {
                ["prExistingPlayerName1"] = _Me,
                ["prExistingPlayerName2"] = _Opponent

            }));
 
            if (_EndGame == 1)
            {
                MessageBox.Show("Would you Like to Leave this Game?", "EndGame", MessageBoxButtons.YesNo);
                tmGameTimer.Start();
                Close();
            }
           
        }
    }
}
