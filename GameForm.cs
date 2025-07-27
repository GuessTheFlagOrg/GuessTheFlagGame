using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace GuessTheFlagGame
{
    public partial class GameForm : Form
    {
        public GameForm(string p1, string p2)
        {
            InitializeComponent();


            player1Name = p1;
            player2Name = p2;

            lblPlayer1Score.Text = $"{player1Name}: 0";
            lblPlayer2Score.Text = $"{player2Name}: 0";

            // Optional safety: initialize timer (can skip if already handled in Load)
            questionTimer = new Timer();
            questionTimer.Interval = 1000;
            questionTimer.Tick += QuestionTimer_Tick;
        }

        Timer questionTimer;
        int timeLeft = 10;

        string player1Name;
        string player2Name;

        List<Question> questions = new List<Question>();
        int currentIndex = 0;
        int currentPlayer = 1;
        int scorePlayer1 = 0;
        int scorePlayer2 = 0;
        Random random = new Random();

        private void btnOption1_Click(object sender, EventArgs e) => CheckAnswer(btnOption1.Text);
        private void btnOption2_Click(object sender, EventArgs e) => CheckAnswer(btnOption2.Text);
        private void btnOption3_Click(object sender, EventArgs e) => CheckAnswer(btnOption3.Text);
        private void btnOption4_Click(object sender, EventArgs e) => CheckAnswer(btnOption4.Text);



        private void GameForm_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.WhiteSmoke;
            GenerateQuestions();

            StyleGameLabels();
            StyleGameButtons();




            this.BackColor = Color.FromArgb(240, 248, 255); // Light Blue background
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            GenerateQuestions();

            this.BackColor = Color.FromArgb(240, 248, 255); // Light blue background
            StyleButtons();  // Style all buttons
            StyleLabels();   // Style any labels (you will define this next)

            // Initialize timer
            questionTimer = new Timer();
            questionTimer.Interval = 1000; // 1 second
            questionTimer.Tick += QuestionTimer_Tick;

            ShowQuestion();
        }

        private void StyleLabels()
        {
            lblTimer.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblTimer.ForeColor = Color.Red;

            // You can also style other labels here:
            // lblQuestion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            // lblQuestion.ForeColor = Color.DarkSlateBlue;
        }



        void GenerateQuestions()
        {
            string flagsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "flags");
            string[] allFlagFiles = Directory.GetFiles(flagsPath, "*.png");
            string[] flagFiles = allFlagFiles.OrderBy(x => random.Next()).Take(10).ToArray();

            var allCountryNames = new List<string>();

            foreach (var file in allFlagFiles)
            {
                string code = Path.GetFileNameWithoutExtension(file).ToLower();
                string name = ConvertCodeToName(code);
                allCountryNames.Add(name);
            }

            foreach (var file in flagFiles)
            {
                string code = Path.GetFileNameWithoutExtension(file).ToLower();
                string correctAnswer = ConvertCodeToName(code);

                var wrongOptions = allCountryNames
                    .Where(c => c != correctAnswer)
                    .OrderBy(x => random.Next())
                    .Take(3)
                    .ToList();

                wrongOptions.Add(correctAnswer);
                wrongOptions = wrongOptions.OrderBy(x => random.Next()).ToList();

                questions.Add(new Question
                {
                    ImageFile = Path.GetFileName(file),
                    CorrectAnswer = correctAnswer,
                    Options = wrongOptions
                });
            }

            questions = questions.OrderBy(q => random.Next()).ToList();
        }


        string ConvertCodeToName(string code)
        {
            // Try converting 2-letter ISO code to full name
            if (code.Length == 2)
            {
                try
                {
                    var region = new System.Globalization.RegionInfo(code.ToUpper());
                    return region.EnglishName;
                }
                catch
                {
                    // fallback if invalid ISO code
                    return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(code);
                }
            }

            // fallback for invalid names
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(code);
        }



        void ShowQuestion()
        {
            var q = questions[currentIndex];
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "flags", q.ImageFile);
            pictureBoxFlag.Image = Image.FromFile(path);

            btnOption1.Text = q.Options[0];
            btnOption2.Text = q.Options[1];
            btnOption3.Text = q.Options[2];
            btnOption4.Text = q.Options[3];

            lblTurn.Text = $"Player {currentPlayer}'s turn";
            lblTurn.ForeColor = currentPlayer == 1 ? Color.Green : Color.Blue;

            // Start countdown
            timeLeft = 10;
            lblTimer.Text = $"Time Left: {timeLeft}s";
            questionTimer.Start();

            ResetButtonColors();
        }


        private void StyleButtons()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = Color.FromArgb(0, 120, 215); // Blue
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    btn.FlatAppearance.BorderSize = 0;
                }
            }
        }


        private void ResetButtonColors()
        {
            btnOption1.BackColor = SystemColors.Control;
            btnOption2.BackColor = SystemColors.Control;
            btnOption3.BackColor = SystemColors.Control;
            btnOption4.BackColor = SystemColors.Control;
        }

        private void ProceedToNextQuestion()
        {
            currentIndex++;
            if (currentIndex >= questions.Count)
            {
                string result = $"{player1Name}: {scorePlayer1}\n{player2Name}: {scorePlayer2}";

                btnOption1.Enabled = false;
                btnOption2.Enabled = false;
                btnOption3.Enabled = false;
                btnOption4.Enabled = false;
                btnRestart.Visible = true;
                lblTimer.Text = "";
                return;
            }

            currentPlayer = currentPlayer == 1 ? 2 : 1;
            ShowQuestion();
        }

        private void UpdateScoreLabels()
        {
            lblPlayer1Score.Text = $"{player1Name}: {scorePlayer1}";
            lblPlayer2Score.Text = $"{player2Name}: {scorePlayer2}";
        }


        private void DisableAllButtons()
        {
            btnOption1.Enabled = false;
            btnOption2.Enabled = false;
            btnOption3.Enabled = false;
            btnOption4.Enabled = false;
        }


        private void CheckAnswer(string selectedAnswer)
        {
            string correctAnswer = questions[currentIndex].CorrectAnswer;

            if (selectedAnswer == correctAnswer)
            {
                if (currentPlayer == 1)
                    scorePlayer1++;
                else
                    scorePlayer2++;

                UpdateScoreLabels();
            }
            else
            {
                PlayLaughSound(); // 😆 play laugh if the answer is wrong
            }

            // ✅ End game immediately after 4 wins
            if (scorePlayer1 == 4 || scorePlayer2 == 4)
            {
                ShowWinner();
                DisableAllButtons();
                return;
            }

            // Continue to next question
            currentIndex++;
            if (currentIndex >= questions.Count)
            {
                ShowWinner();
                DisableAllButtons();
                return;
            }

            currentPlayer = (currentPlayer == 1) ? 2 : 1;
            ShowQuestion();
        }

        private void PlayLaughSound()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "laugh.wav");

            if (File.Exists(path))
            {
                SoundPlayer player = new SoundPlayer(path);
                player.Play();
            }
            else
            {
                MessageBox.Show("Laugh sound file not found at:\n" + path);
            }
        }



        private void QuestionTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            lblTimer.Text = $"Time Left: {timeLeft}s";

            if (timeLeft <= 0)
            {
                questionTimer.Stop();
                btnOption1.BackColor = Color.LightCoral;
                btnOption2.BackColor = Color.LightCoral;
                btnOption3.BackColor = Color.LightCoral;
                btnOption4.BackColor = Color.LightCoral;

                Timer delay = new Timer();
                delay.Interval = 700;
                delay.Tick += (s, ev) =>
                {
                    delay.Stop();
                    ProceedToNextQuestion();
                };
                delay.Start();
            }
        }




        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Do nothing or remove this handler if unused
        }



        private void StyleGameLabels()
        {
            lblPlayer1Score.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPlayer1Score.ForeColor = Color.DarkBlue;

            lblPlayer2Score.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPlayer2Score.ForeColor = Color.DarkRed;

            lblTurn.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblTurn.ForeColor = Color.Green;

            lblTimer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTimer.ForeColor = Color.Black;
        }

        private void StyleGameButtons()
        {
            btnRestart.BackColor = Color.MediumSeaGreen;
            btnRestart.ForeColor = Color.White;
            btnRestart.FlatStyle = FlatStyle.Flat;
            btnRestart.FlatAppearance.BorderSize = 0;
            btnRestart.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRestart.Cursor = Cursors.Hand;
        }







        private void btnRestart_Click(object sender, EventArgs e)
        {
            currentIndex = 0;
            scorePlayer1 = 0;
            scorePlayer2 = 0;
            currentPlayer = 1;

            lblPlayer1Score.Text = $"{player1Name}: 0";
            lblPlayer2Score.Text = $"{player2Name}: 0";
            lblTurn.Text = $"Player {currentPlayer}'s turn";
            lblTurn.ForeColor = Color.Green;

            btnRestart.Visible = false;

            GenerateQuestions(); // reload questions
            ShowQuestion();
            btnOption1.Enabled = true;
            btnOption2.Enabled = true;
            btnOption3.Enabled = true;
            btnOption4.Enabled = true;


        }






        private void ShowWinner()
        {
            string message;
            string title = "🏁 GAME OVER 🏁";

            if (scorePlayer1 > scorePlayer2)
                message = $"🎉 {player1Name.ToUpper()} WINS THE GAME! 🏆\n\nFinal Score:\n{player1Name}: {scorePlayer1}\n{player2Name}: {scorePlayer2}";
            else if (scorePlayer2 > scorePlayer1)
                message = $"🎉 {player2Name.ToUpper()} WINS THE GAME! 🏆\n\nFinal Score:\n{player1Name}: {scorePlayer1}\n{player2Name}: {scorePlayer2}";
            else
                message = $"🤝 IT'S A TIE!\n\nFinal Score:\n{player1Name}: {scorePlayer1}\n{player2Name}: {scorePlayer2}";

            // ✅ Play winner sound
            PlayWinnerMusic();

            // 🎵 Optional: Windows ding
            SystemSounds.Exclamation.Play();

            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnRestart.Visible = true;
            questionTimer.Stop();
            DisableAllButtons();
            lblTimer.Text = "";
        }

        private void PlayWinnerMusic()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "winner.wav");

            if (File.Exists(path))
            {
                SoundPlayer player = new SoundPlayer(path);
                player.Play(); // Use .PlaySync() to wait until it finishes
            }
            else
            {
                MessageBox.Show("Winner music file not found at:\n" + path);
            }
        }


    }
}

    
