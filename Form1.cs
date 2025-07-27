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

        private void btnStartGame_Click_1(object sender, EventArgs e)
        {
            string player1Name = txtPlayer1Name.Text.Trim();
            string player2Name = txtPlayer2Name.Text.Trim();

            if (string.IsNullOrWhiteSpace(player1Name) || string.IsNullOrWhiteSpace(player2Name))
            {
                MessageBox.Show("Please enter both player names!", "Missing Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GameForm gameForm = new GameForm(player1Name, player2Name);
            this.Hide();
            gameForm.FormClosed += (s, args) => this.Close();
            gameForm.Show();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            // You can leave this empty if you don’t need it
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.White;
            StyleLabels();
            StyleTextBoxes();
            StyleButtons();
        }

        private void StyleLabels()
        {
            lblPlayer1.Font = new Font("Segoe UI", 10F);
            lblPlayer1.ForeColor = Color.DarkSlateGray;

            lblPlayer2.Font = new Font("Segoe UI", 10F);
            lblPlayer2.ForeColor = Color.DarkSlateGray;
        }

        private void StyleTextBoxes()
        {
            txtPlayer1Name.Font = new Font("Segoe UI", 10F);
            txtPlayer1Name.BackColor = Color.WhiteSmoke;
            txtPlayer1Name.ForeColor = Color.Black;

            txtPlayer2Name.Font = new Font("Segoe UI", 10F);
            txtPlayer2Name.BackColor = Color.WhiteSmoke;
            txtPlayer2Name.ForeColor = Color.Black;
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


    }

}
