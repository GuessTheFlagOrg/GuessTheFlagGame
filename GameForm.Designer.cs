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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblScore = new System.Windows.Forms.Label();
            this.picFlag = new System.Windows.Forms.PictureBox();
            this.btnOption1 = new System.Windows.Forms.Button();
            this.btnOption2 = new System.Windows.Forms.Button();
            this.btnOption3 = new System.Windows.Forms.Button();
            this.btnOption4 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnOption4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnOption3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnOption2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblScore, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.picFlag, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnOption1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblScore, 2);
            this.lblScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScore.Location = new System.Drawing.Point(3, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(794, 40);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score: 0";
            // 
            // picFlag
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.picFlag, 2);
            this.picFlag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picFlag.Location = new System.Drawing.Point(3, 43);
            this.picFlag.Name = "picFlag";
            this.picFlag.Size = new System.Drawing.Size(794, 199);
            this.picFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFlag.TabIndex = 1;
            this.picFlag.TabStop = false;
            // 
            // btnOption1
            // 
            this.btnOption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOption1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOption1.Location = new System.Drawing.Point(3, 248);
            this.btnOption1.Name = "btnOption1";
            this.btnOption1.Size = new System.Drawing.Size(394, 96);
            this.btnOption1.TabIndex = 2;
            this.btnOption1.UseVisualStyleBackColor = false;
            // 
            // btnOption2
            // 
            this.btnOption2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOption2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOption2.Location = new System.Drawing.Point(403, 248);
            this.btnOption2.Name = "btnOption2";
            this.btnOption2.Size = new System.Drawing.Size(394, 96);
            this.btnOption2.TabIndex = 4;
            this.btnOption2.UseVisualStyleBackColor = false;
            // 
            // btnOption3
            // 
            this.btnOption3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOption3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOption3.Location = new System.Drawing.Point(3, 350);
            this.btnOption3.Name = "btnOption3";
            this.btnOption3.Size = new System.Drawing.Size(394, 97);
            this.btnOption3.TabIndex = 5;
            this.btnOption3.UseVisualStyleBackColor = false;
            // 
            // btnOption4
            // 
            this.btnOption4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOption4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOption4.Location = new System.Drawing.Point(403, 350);
            this.btnOption4.Name = "btnOption4";
            this.btnOption4.Size = new System.Drawing.Size(394, 97);
            this.btnOption4.TabIndex = 6;
            this.btnOption4.UseVisualStyleBackColor = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFlag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox picFlag;
        private System.Windows.Forms.Button btnOption4;
        private System.Windows.Forms.Button btnOption3;
        private System.Windows.Forms.Button btnOption2;
        private System.Windows.Forms.Button btnOption1;
    }
}