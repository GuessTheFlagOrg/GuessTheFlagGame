using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheFlagGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            string playerName = txtPlayerName.Text.Trim();

            if (string.IsNullOrWhiteSpace(playerName))
            {
                MessageBox.Show("Please enter your name before starting!", "Missing Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Open GameForm and pass the player's name
            GameForm gameForm = new GameForm(playerName);
            gameForm.Show();

            this.Hide(); // hide the welcome form
        }
    }
}
