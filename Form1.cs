using System.Media;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GuessTheFlagGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    


        private void lblTitle_Click(object sender, EventArgs e)
        {
            // You can leave this empty if you don’t need it
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.White;
            
            StyleTextBoxes();
            StyleButtons();
        }



        private void StyleTextBoxes()
        {
            txtPlayer1.Font = new Font("Segoe UI", 10F);
            txtPlayer1.BackColor = Color.WhiteSmoke;
            txtPlayer1.ForeColor = Color.Black;

            txtPlayer2.Font = new Font("Segoe UI", 10F);
            txtPlayer2.BackColor = Color.WhiteSmoke;
            txtPlayer2.ForeColor = Color.Black;
        }

        private void StyleButtons()
        {
            btnStartGame.BackColor = Color.MediumSeaGreen;
            btnStartGame.ForeColor = Color.White;
            btnStartGame.FlatStyle = FlatStyle.Flat;
            btnStartGame.FlatAppearance.BorderSize = 0;
            btnStartGame.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnStartGame.Cursor = Cursors.Hand;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnStartGame_Click_1(object sender, EventArgs e)
        {
            string player1 = txtPlayer1.Text.Trim();
            string player2 = txtPlayer2.Text.Trim();

            if (string.IsNullOrWhiteSpace(player1) || string.IsNullOrWhiteSpace(player2))
            {
                MessageBox.Show("Please enter both player names.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SoundPlayer player = new SoundPlayer("gamestart.wav");
            player.Play(); // or .PlaySync() if you want to wait


            GameForm gameForm = new GameForm(player1, player2);
            gameForm.Show();
            this.Hide(); // Optional: hides the start screen
        }
    }

}
