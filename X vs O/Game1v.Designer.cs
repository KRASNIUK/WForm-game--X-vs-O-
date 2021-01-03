namespace X_vs_O
{
    partial class Game1v 
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game1v));
            this.pictureBoxPull00 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPull22 = new System.Windows.Forms.PictureBox();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonAgain = new System.Windows.Forms.Button();
            this.labelScore1 = new System.Windows.Forms.Label();
            this.labelScore2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelMove = new System.Windows.Forms.Label();
            this.labelNickName2 = new System.Windows.Forms.Label();
            this.labelNickName1 = new System.Windows.Forms.Label();
            this.labelMaxScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelEndBattle = new System.Windows.Forms.Panel();
            this.labelWinnerName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxPull01 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPull02 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPull20 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPull11 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPull10 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPull21 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPull12 = new System.Windows.Forms.PictureBox();
            this.timerWait = new System.Windows.Forms.Timer(this.components);
            this.timerBlink = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPull00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPull22)).BeginInit();
            this.panelEndBattle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPull01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPull02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPull20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPull11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPull10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPull21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPull12)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPull00
            // 
            this.pictureBoxPull00.BackColor = System.Drawing.Color.White;
            this.pictureBoxPull00.ImageLocation = "";
            this.pictureBoxPull00.InitialImage = null;
            this.pictureBoxPull00.Location = new System.Drawing.Point(167, 140);
            this.pictureBoxPull00.Name = "pictureBoxPull00";
            this.pictureBoxPull00.Size = new System.Drawing.Size(104, 88);
            this.pictureBoxPull00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxPull00.TabIndex = 9;
            this.pictureBoxPull00.TabStop = false;
            this.pictureBoxPull00.MouseEnter += new System.EventHandler(this.pictureBoxPull_MouseEnter);
            this.pictureBoxPull00.MouseLeave += new System.EventHandler(this.pictureBoxPull_MouseLeave);
            this.pictureBoxPull00.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPull_MouseDown);
            // 
            // pictureBoxPull22
            // 
            this.pictureBoxPull22.BackColor = System.Drawing.Color.White;
            this.pictureBoxPull22.Location = new System.Drawing.Point(401, 360);
            this.pictureBoxPull22.Name = "pictureBoxPull22";
            this.pictureBoxPull22.Size = new System.Drawing.Size(107, 101);
            this.pictureBoxPull22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxPull22.TabIndex = 17;
            this.pictureBoxPull22.TabStop = false;
            this.pictureBoxPull22.MouseEnter += new System.EventHandler(this.pictureBoxPull_MouseEnter);
            this.pictureBoxPull22.MouseLeave += new System.EventHandler(this.pictureBoxPull_MouseLeave);
            this.pictureBoxPull22.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPull_MouseDown);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonMenu.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.buttonMenu.Location = new System.Drawing.Point(353, 513);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(176, 66);
            this.buttonMenu.TabIndex = 18;
            this.buttonMenu.Text = "Выход в меню";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // buttonAgain
            // 
            this.buttonAgain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAgain.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.buttonAgain.Location = new System.Drawing.Point(167, 513);
            this.buttonAgain.Name = "buttonAgain";
            this.buttonAgain.Size = new System.Drawing.Size(176, 66);
            this.buttonAgain.TabIndex = 19;
            this.buttonAgain.Text = "Заново";
            this.buttonAgain.UseVisualStyleBackColor = false;
            this.buttonAgain.Click += new System.EventHandler(this.buttonAgain_Click);
            // 
            // labelScore1
            // 
            this.labelScore1.AutoSize = true;
            this.labelScore1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelScore1.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.labelScore1.Location = new System.Drawing.Point(287, 27);
            this.labelScore1.Name = "labelScore1";
            this.labelScore1.Size = new System.Drawing.Size(39, 35);
            this.labelScore1.TabIndex = 21;
            this.labelScore1.Text = "0 ";
            // 
            // labelScore2
            // 
            this.labelScore2.AutoSize = true;
            this.labelScore2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelScore2.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.labelScore2.Location = new System.Drawing.Point(353, 27);
            this.labelScore2.Name = "labelScore2";
            this.labelScore2.Size = new System.Drawing.Size(39, 35);
            this.labelScore2.TabIndex = 22;
            this.labelScore2.Text = "0 ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.label3.Location = new System.Drawing.Point(332, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 33);
            this.label3.TabIndex = 23;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(248, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 37);
            this.label4.TabIndex = 24;
            this.label4.Text = "Ходит:";
            // 
            // labelMove
            // 
            this.labelMove.AutoSize = true;
            this.labelMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMove.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.labelMove.Location = new System.Drawing.Point(332, 72);
            this.labelMove.Name = "labelMove";
            this.labelMove.Size = new System.Drawing.Size(111, 33);
            this.labelMove.TabIndex = 25;
            this.labelMove.Text = "nickName";
            // 
            // labelNickName2
            // 
            this.labelNickName2.AutoSize = true;
            this.labelNickName2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNickName2.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.labelNickName2.Location = new System.Drawing.Point(404, 29);
            this.labelNickName2.Name = "labelNickName2";
            this.labelNickName2.Size = new System.Drawing.Size(29, 33);
            this.labelNickName2.TabIndex = 26;
            this.labelNickName2.Text = "2";
            // 
            // labelNickName1
            // 
            this.labelNickName1.AutoSize = true;
            this.labelNickName1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNickName1.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.labelNickName1.Location = new System.Drawing.Point(252, 29);
            this.labelNickName1.Name = "labelNickName1";
            this.labelNickName1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelNickName1.Size = new System.Drawing.Size(29, 33);
            this.labelNickName1.TabIndex = 27;
            this.labelNickName1.Text = "1";
            // 
            // labelMaxScore
            // 
            this.labelMaxScore.AutoSize = true;
            this.labelMaxScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMaxScore.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxScore.Location = new System.Drawing.Point(323, 4);
            this.labelMaxScore.Name = "labelMaxScore";
            this.labelMaxScore.Size = new System.Drawing.Size(30, 23);
            this.labelMaxScore.TabIndex = 28;
            this.labelMaxScore.Text = "(3)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(297, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 26);
            this.label1.TabIndex = 29;
            this.label1.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(359, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 26);
            this.label2.TabIndex = 30;
            this.label2.Text = "o";
            // 
            // panelEndBattle
            // 
            this.panelEndBattle.BackColor = System.Drawing.Color.White;
            this.panelEndBattle.Controls.Add(this.labelWinnerName);
            this.panelEndBattle.Controls.Add(this.label5);
            this.panelEndBattle.Location = new System.Drawing.Point(579, 140);
            this.panelEndBattle.Name = "panelEndBattle";
            this.panelEndBattle.Size = new System.Drawing.Size(392, 349);
            this.panelEndBattle.TabIndex = 31;
            // 
            // labelWinnerName
            // 
            this.labelWinnerName.AutoSize = true;
            this.labelWinnerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelWinnerName.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.labelWinnerName.Location = new System.Drawing.Point(126, 135);
            this.labelWinnerName.Margin = new System.Windows.Forms.Padding(44, 67, 45, 0);
            this.labelWinnerName.Name = "labelWinnerName";
            this.labelWinnerName.Size = new System.Drawing.Size(111, 33);
            this.labelWinnerName.TabIndex = 27;
            this.labelWinnerName.Text = "nickName";
            this.labelWinnerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(124, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 47);
            this.label5.TabIndex = 26;
            this.label5.Text = "Победил:";
            // 
            // pictureBoxPull01
            // 
            this.pictureBoxPull01.BackColor = System.Drawing.Color.White;
            this.pictureBoxPull01.Location = new System.Drawing.Point(287, 140);
            this.pictureBoxPull01.Name = "pictureBoxPull01";
            this.pictureBoxPull01.Size = new System.Drawing.Size(101, 88);
            this.pictureBoxPull01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxPull01.TabIndex = 10;
            this.pictureBoxPull01.TabStop = false;
            this.pictureBoxPull01.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPull_MouseDown);
            this.pictureBoxPull01.MouseEnter += new System.EventHandler(this.pictureBoxPull_MouseEnter);
            this.pictureBoxPull01.MouseLeave += new System.EventHandler(this.pictureBoxPull_MouseLeave);
            // 
            // pictureBoxPull02
            // 
            this.pictureBoxPull02.BackColor = System.Drawing.Color.White;
            this.pictureBoxPull02.Location = new System.Drawing.Point(401, 140);
            this.pictureBoxPull02.Name = "pictureBoxPull02";
            this.pictureBoxPull02.Size = new System.Drawing.Size(107, 88);
            this.pictureBoxPull02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxPull02.TabIndex = 11;
            this.pictureBoxPull02.TabStop = false;
            this.pictureBoxPull02.MouseEnter += new System.EventHandler(this.pictureBoxPull_MouseEnter);
            this.pictureBoxPull02.MouseLeave += new System.EventHandler(this.pictureBoxPull_MouseLeave);
            this.pictureBoxPull02.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPull_MouseDown);
            // 
            // pictureBoxPull20
            // 
            this.pictureBoxPull20.BackColor = System.Drawing.Color.White;
            this.pictureBoxPull20.Location = new System.Drawing.Point(167, 360);
            this.pictureBoxPull20.Name = "pictureBoxPull20";
            this.pictureBoxPull20.Size = new System.Drawing.Size(104, 101);
            this.pictureBoxPull20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxPull20.TabIndex = 15;
            this.pictureBoxPull20.TabStop = false;
            this.pictureBoxPull20.MouseEnter += new System.EventHandler(this.pictureBoxPull_MouseEnter);
            this.pictureBoxPull20.MouseLeave += new System.EventHandler(this.pictureBoxPull_MouseLeave);
            this.pictureBoxPull20.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPull_MouseDown);
            // 
            // pictureBoxPull11
            // 
            this.pictureBoxPull11.BackColor = System.Drawing.Color.White;
            this.pictureBoxPull11.Location = new System.Drawing.Point(287, 243);
            this.pictureBoxPull11.Name = "pictureBoxPull11";
            this.pictureBoxPull11.Size = new System.Drawing.Size(101, 102);
            this.pictureBoxPull11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxPull11.TabIndex = 13;
            this.pictureBoxPull11.TabStop = false;
            this.pictureBoxPull11.MouseEnter += new System.EventHandler(this.pictureBoxPull_MouseEnter);
            this.pictureBoxPull11.MouseLeave += new System.EventHandler(this.pictureBoxPull_MouseLeave);
            this.pictureBoxPull11.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPull_MouseDown);
            // 
            // pictureBoxPull10
            // 
            this.pictureBoxPull10.BackColor = System.Drawing.Color.White;
            this.pictureBoxPull10.Location = new System.Drawing.Point(167, 246);
            this.pictureBoxPull10.Name = "pictureBoxPull10";
            this.pictureBoxPull10.Size = new System.Drawing.Size(104, 99);
            this.pictureBoxPull10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxPull10.TabIndex = 12;
            this.pictureBoxPull10.TabStop = false;
            this.pictureBoxPull10.MouseEnter += new System.EventHandler(this.pictureBoxPull_MouseEnter);
            this.pictureBoxPull10.MouseLeave += new System.EventHandler(this.pictureBoxPull_MouseLeave);
            this.pictureBoxPull10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPull_MouseDown);
            // 
            // pictureBoxPull21
            // 
            this.pictureBoxPull21.BackColor = System.Drawing.Color.White;
            this.pictureBoxPull21.Location = new System.Drawing.Point(287, 360);
            this.pictureBoxPull21.Name = "pictureBoxPull21";
            this.pictureBoxPull21.Size = new System.Drawing.Size(101, 101);
            this.pictureBoxPull21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxPull21.TabIndex = 16;
            this.pictureBoxPull21.TabStop = false;
            this.pictureBoxPull21.MouseEnter += new System.EventHandler(this.pictureBoxPull_MouseEnter);
            this.pictureBoxPull21.MouseLeave += new System.EventHandler(this.pictureBoxPull_MouseLeave);
            this.pictureBoxPull21.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPull_MouseDown);
            // 
            // pictureBoxPull12
            // 
            this.pictureBoxPull12.BackColor = System.Drawing.Color.White;
            this.pictureBoxPull12.Location = new System.Drawing.Point(401, 243);
            this.pictureBoxPull12.Name = "pictureBoxPull12";
            this.pictureBoxPull12.Size = new System.Drawing.Size(107, 102);
            this.pictureBoxPull12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxPull12.TabIndex = 14;
            this.pictureBoxPull12.TabStop = false;
            this.pictureBoxPull12.MouseEnter += new System.EventHandler(this.pictureBoxPull_MouseEnter);
            this.pictureBoxPull12.MouseLeave += new System.EventHandler(this.pictureBoxPull_MouseLeave);
            this.pictureBoxPull12.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPull_MouseDown);
            // 
            // timerWait
            // 
            this.timerWait.Interval = 2000;
            this.timerWait.Tick += new System.EventHandler(this.timerWait_Tick);
            // 
            // timerBlink
            // 
            this.timerBlink.Interval = 500;
            this.timerBlink.Tick += new System.EventHandler(this.timerBlink_Tick);
            // 
            // Game1v
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(702, 621);
            this.ControlBox = false;
            this.Controls.Add(this.panelEndBattle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMaxScore);
            this.Controls.Add(this.labelNickName1);
            this.Controls.Add(this.labelNickName2);
            this.Controls.Add(this.labelMove);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelScore2);
            this.Controls.Add(this.labelScore1);
            this.Controls.Add(this.buttonAgain);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.pictureBoxPull20);
            this.Controls.Add(this.pictureBoxPull22);
            this.Controls.Add(this.pictureBoxPull00);
            this.Controls.Add(this.pictureBoxPull02);
            this.Controls.Add(this.pictureBoxPull21);
            this.Controls.Add(this.pictureBoxPull10);
            this.Controls.Add(this.pictureBoxPull11);
            this.Controls.Add(this.pictureBoxPull01);
            this.Controls.Add(this.pictureBoxPull12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game1v";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPull00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPull22)).EndInit();
            this.panelEndBattle.ResumeLayout(false);
            this.panelEndBattle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPull01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPull02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPull20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPull11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPull10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPull21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPull12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxPull00;
        private System.Windows.Forms.PictureBox pictureBoxPull22;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonAgain;
        private System.Windows.Forms.Label labelScore1;
        private System.Windows.Forms.Label labelScore2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelMove;
        private System.Windows.Forms.Label labelNickName2;
        private System.Windows.Forms.Label labelNickName1;
        private System.Windows.Forms.Label labelMaxScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelEndBattle;
        private System.Windows.Forms.Label labelWinnerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxPull01;
        private System.Windows.Forms.PictureBox pictureBoxPull02;
        private System.Windows.Forms.PictureBox pictureBoxPull20;
        private System.Windows.Forms.PictureBox pictureBoxPull11;
        private System.Windows.Forms.PictureBox pictureBoxPull10;
        private System.Windows.Forms.PictureBox pictureBoxPull21;
        private System.Windows.Forms.PictureBox pictureBoxPull12;
        private System.Windows.Forms.Timer timerWait;
        private System.Windows.Forms.Timer timerBlink;
    }
}

