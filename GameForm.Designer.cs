namespace GuessTheFlagGame
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOption4 = new System.Windows.Forms.Button();
            this.btnOption3 = new System.Windows.Forms.Button();
            this.btnOption2 = new System.Windows.Forms.Button();
            this.lblPlayer1Score = new System.Windows.Forms.Label();
            this.lblPlayer2Score = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.pictureBoxFlag = new System.Windows.Forms.PictureBox();
            this.btnOption1 = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnOption4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnOption3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnOption2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPlayer1Score, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPlayer2Score, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTurn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxFlag, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnOption1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnRestart, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblTimer, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.314928F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.777778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.555555F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btnOption4
            // 
            this.btnOption4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOption4.Location = new System.Drawing.Point(403, 360);
            this.btnOption4.Name = "btnOption4";
            this.btnOption4.Size = new System.Drawing.Size(394, 42);
            this.btnOption4.TabIndex = 7;
            this.btnOption4.UseVisualStyleBackColor = true;
            this.btnOption4.Click += new System.EventHandler(this.btnOption4_Click);
            // 
            // btnOption3
            // 
            this.btnOption3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOption3.Location = new System.Drawing.Point(3, 360);
            this.btnOption3.Name = "btnOption3";
            this.btnOption3.Size = new System.Drawing.Size(394, 42);
            this.btnOption3.TabIndex = 6;
            this.btnOption3.UseVisualStyleBackColor = true;
            this.btnOption3.Click += new System.EventHandler(this.btnOption3_Click);
            // 
            // btnOption2
            // 
            this.btnOption2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOption2.Location = new System.Drawing.Point(403, 310);
            this.btnOption2.Name = "btnOption2";
            this.btnOption2.Size = new System.Drawing.Size(394, 44);
            this.btnOption2.TabIndex = 5;
            this.btnOption2.UseVisualStyleBackColor = true;
            this.btnOption2.Click += new System.EventHandler(this.btnOption2_Click);
            // 
            // lblPlayer1Score
            // 
            this.lblPlayer1Score.AutoSize = true;
            this.lblPlayer1Score.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlayer1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Score.Location = new System.Drawing.Point(3, 0);
            this.lblPlayer1Score.Name = "lblPlayer1Score";
            this.lblPlayer1Score.Size = new System.Drawing.Size(394, 28);
            this.lblPlayer1Score.TabIndex = 0;
            this.lblPlayer1Score.Text = "Player 1: 0";
            this.lblPlayer1Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer2Score
            // 
            this.lblPlayer2Score.AutoSize = true;
            this.lblPlayer2Score.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlayer2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Score.Location = new System.Drawing.Point(403, 0);
            this.lblPlayer2Score.Name = "lblPlayer2Score";
            this.lblPlayer2Score.Size = new System.Drawing.Size(394, 28);
            this.lblPlayer2Score.TabIndex = 1;
            this.lblPlayer2Score.Text = "Player 2: 0";
            this.lblPlayer2Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblTurn, 2);
            this.lblTurn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTurn.Location = new System.Drawing.Point(3, 28);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(794, 26);
            this.lblTurn.TabIndex = 2;
            this.lblTurn.Text = "turn";
            this.lblTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxFlag
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBoxFlag, 2);
            this.pictureBoxFlag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxFlag.Location = new System.Drawing.Point(3, 57);
            this.pictureBoxFlag.Name = "pictureBoxFlag";
            this.pictureBoxFlag.Size = new System.Drawing.Size(794, 247);
            this.pictureBoxFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFlag.TabIndex = 3;
            this.pictureBoxFlag.TabStop = false;
            // 
            // btnOption1
            // 
            this.btnOption1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOption1.Location = new System.Drawing.Point(3, 310);
            this.btnOption1.Name = "btnOption1";
            this.btnOption1.Size = new System.Drawing.Size(394, 44);
            this.btnOption1.TabIndex = 4;
            this.btnOption1.UseVisualStyleBackColor = true;
            this.btnOption1.Click += new System.EventHandler(this.btnOption1_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRestart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRestart.Location = new System.Drawing.Point(3, 408);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(394, 39);
            this.btnRestart.TabIndex = 8;
            this.btnRestart.Text = "Restart Game";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(403, 405);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(394, 45);
            this.lblTimer.TabIndex = 9;
            this.lblTimer.Text = "Time Left: 10s";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameForm";
            this.Text = "World Flag Challenge";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPlayer1Score;
        private System.Windows.Forms.Label lblPlayer2Score;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.PictureBox pictureBoxFlag;
        private System.Windows.Forms.Button btnOption4;
        private System.Windows.Forms.Button btnOption3;
        private System.Windows.Forms.Button btnOption2;
        private System.Windows.Forms.Button btnOption1;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblTimer;
    }
}