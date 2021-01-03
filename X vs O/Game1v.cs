using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_vs_O
{
    public partial class Game1v : Form
    {
        string pathX_gray = @"D:\# I\#My programm\C#\forms\X vs O\#Image\X_gray.png";
        string pathO_gray = @"D:\# I\#My programm\C#\forms\X vs O\#Image\O_gray.png";
        string pathX_black = @"D:\# I\#My programm\C#\forms\X vs O\#Image\X_black.png";
        string pathO_black = @"D:\# I\#My programm\C#\forms\X vs O\#Image\O_black.png";
        string pathX_red = @"D:\# I\#My programm\C#\forms\X vs O\#Image\X_red.png";
        string pathO_red = @"D:\# I\#My programm\C#\forms\X vs O\#Image\O_red.png";


        bool isEndRound = false;


        // Чтобы была смена х и о
        // true - x
        // false - o
        bool X_or_O;
        protected bool x_or_O
        {
            get
            {
                return X_or_O;
            }
        }

        //1 - x
        //0 - o
        //2 - null
        protected byte[,] logicalPull = { { 2, 2, 2 }, { 2, 2, 2 }, { 2, 2, 2 } };
        
        
        PictureBox[,] pictureBoxes = new PictureBox[3, 3];


        public Game1v()
        {
            InitializeComponent();

            #region Инициализация

            Data.Score1 = 0;
            Data.Score2 = 0;

            X_or_O = true;

            pictureBoxes[0, 0] = pictureBoxPull00;
            pictureBoxes[0, 1] = pictureBoxPull01;
            pictureBoxes[0, 2] = pictureBoxPull02;
            pictureBoxes[1, 0] = pictureBoxPull10;
            pictureBoxes[1, 1] = pictureBoxPull11;
            pictureBoxes[1, 2] = pictureBoxPull12;
            pictureBoxes[2, 0] = pictureBoxPull20;
            pictureBoxes[2, 1] = pictureBoxPull21;
            pictureBoxes[2, 2] = pictureBoxPull22;
            #endregion

            #region Дизайн
            panelEndBattle.Visible = false;
            panelEndBattle.Location = new Point(155, 140);



            labelNickName1.Text = Data.nickName1;
            if (Data.areTwoPlayers)
                labelNickName2.Text = Data.nickName2;
            else
                Data.nickName2 = "Mr_BOT";
                labelNickName2.Text = Data.nickName2;

            labelMaxScore.Text = String.Format("({0})", Data.MaxScore);
            labelMove.Text = Data.nickName1 + " (x)";

            this.Size = new Size(702, 621);



            labelNickName1.Location = new Point(252, 29);
            while (labelNickName1.Width + labelNickName1.Location.X > labelScore1.Location.X)
            {
                labelNickName1.Location = new Point(labelNickName1.Location.X - 2, labelNickName1.Location.Y);
            }
            #endregion

        }
        

        #region Оформление
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Data.i0_win = 3; Data.j0_win = 3;
            Data.i1_win = 3; Data.j1_win = 3;
            Data.i2_win = 3; Data.j2_win = 3;

            Data.timerBlikCounter = 0;
            Data.timerBlink = false;

            this.Close();
        }
        private void buttonAgain_Click(object sender, EventArgs e)
        {
            X_or_O = true;

            Data.Score1 = 0;
            Data.Score2 = 0;
            preparationToNewRound();
        }
        private void whoMove()
        {
            if (X_or_O)
            {
                labelMove.Text = Data.nickName1 + " (X)";
            }
            else
            {
                labelMove.Text = Data.nickName2 + " (O)";
            }
        }
        #endregion



        #region Логика дизайна игры
        private void changePictereOn_Gray(object sender, EventArgs e)
        {

            string name = ((PictureBox)sender).Name;

            byte i, j;
            byte.TryParse("" + name[14], out i);
            byte.TryParse("" + name[15], out j);

            if (pictureBoxes[i, j].Image == null)
            {
                string path;
                if (X_or_O)
                {
                    path = pathX_gray;
                }
                else
                {
                    path = pathO_gray;
                }

                pictureBoxes[i, j].Image = Image.FromFile(path);
            }
        }

        private void clearCell(object sender, EventArgs e)
        {
            string name = ((PictureBox)sender).Name;

            byte i, j;
            byte.TryParse("" + name[14], out i);
            byte.TryParse("" + name[15], out j);

            if (logicalPull[i, j] == 2)
            {
                pictureBoxes[i, j].Image = null;
            }
        }

        private void changePictereOn_Black(object sender, EventArgs e)
        {
            string name = ((PictureBox)sender).Name;

            byte i, j;
            byte.TryParse("" + name[14], out i);
            byte.TryParse("" + name[15], out j);

            string path;
            if (X_or_O)
            {
                path = pathX_black;
            }
            else
            {
                path = pathO_black;
            }

            pictureBoxes[i, j].Image = Image.FromFile(path);
        }

        private void change3PictureOn_Red_Black(bool isRed = true)
        {
            
            string path1, path2;
            if (logicalPull[Data.i0_win, Data.j0_win] == 1)
            {
                path1 = pathX_red;
                path2 = pathX_black;
            }
            else
            {
                path1 = pathO_red;
                path2 = pathO_black;
            }


            if (isRed)
            {
                pictureBoxes[Data.i0_win, Data.j0_win].Image = Image.FromFile(path1);
                pictureBoxes[Data.i1_win, Data.j1_win].Image = Image.FromFile(path1);
                pictureBoxes[Data.i2_win, Data.j2_win].Image = Image.FromFile(path1);
            }
            else
            {
                pictureBoxes[Data.i0_win, Data.j0_win].Image = Image.FromFile(path2);
                pictureBoxes[Data.i1_win, Data.j1_win].Image = Image.FromFile(path2);
                pictureBoxes[Data.i2_win, Data.j2_win].Image = Image.FromFile(path2);
            }
        }

        #endregion
        //
        //
        //
        #region Логика игры
        private void fulling_logicalPull(object sender, MouseEventArgs e)
        {
            string name = ((PictureBox)sender).Name;

            byte i, j;
            byte.TryParse("" + name[14], out i);
            byte.TryParse("" + name[15], out j);

            if (X_or_O)
            {
                logicalPull[i, j] = 1;

            }
            else
            {
                logicalPull[i, j] = 0;
            }

            X_or_O = !X_or_O;
        }

        private void logicalWinDrow()
        {
            #region Win
            for (byte i = 0; i < 3; i++)
            {
                if (logicalPull[i, 0] == logicalPull[i, 1] && logicalPull[i, 0] == logicalPull[i, 2] && logicalPull[i, 0] != 2)
                {
                    Data.i0_win = i; Data.j0_win = 0;
                    Data.i1_win = i; Data.j1_win = 1;
                    Data.i2_win = i; Data.j2_win = 2;

                    if (logicalPull[i, 0] == 1)
                    {
                        Data.Score1++;
                        labelScore1.Text = Convert.ToString(Data.Score1);
                    }
                    else if (logicalPull[i, 0] == 0)
                    {
                        Data.Score2++;
                        labelScore2.Text = Convert.ToString(Data.Score2);
                    }

                    change3PictureOn_Red_Black(true);

                    isEndRound = true;
                }
                else if (logicalPull[0, i] == logicalPull[1, i] && logicalPull[0, i] == logicalPull[2, i] && logicalPull[0, i] != 2)
                {
                    Data.i0_win = 0; Data.j0_win = i;
                    Data.i1_win = 1; Data.j1_win = i;
                    Data.i2_win = 2; Data.j2_win = i;

                    if (logicalPull[0, i] == 1)
                    {
                        Data.Score1++;
                        labelScore1.Text = Convert.ToString(Data.Score1);
                    }
                    else if (logicalPull[0, i] == 0)
                    {
                        Data.Score2++;
                        labelScore2.Text = Convert.ToString(Data.Score2);
                    }

                    change3PictureOn_Red_Black(true);

                    isEndRound = true;
                }
            }

            if (logicalPull[0, 0] == logicalPull[1, 1] && logicalPull[0, 0] == logicalPull[2, 2] && logicalPull[0, 0] != 2)
            {
                Data.i0_win = 0; Data.j0_win = 0;
                Data.i1_win = 1; Data.j1_win = 1;
                Data.i2_win = 2; Data.j2_win = 2;

                if (logicalPull[0, 0] == 1)
                {
                    Data.Score1++;
                    labelScore1.Text = Convert.ToString(Data.Score1);
                }
                else if (logicalPull[0, 0] == 0)
                {
                    Data.Score2++;
                    labelScore2.Text = Convert.ToString(Data.Score2);
                }

                change3PictureOn_Red_Black(true);

                isEndRound = true;
            }
            else if (logicalPull[2, 0] == logicalPull[1, 1] && logicalPull[2, 0] == logicalPull[0, 2] && logicalPull[2, 0] != 2)
            {
                Data.i0_win = 2; Data.j0_win = 0;
                Data.i1_win = 1; Data.j1_win = 1;
                Data.i2_win = 0; Data.j2_win = 2;

                if (logicalPull[2, 0] == 1)
                {
                    Data.Score1++;
                    labelScore1.Text = Convert.ToString(Data.Score1);
                }
                else if (logicalPull[2, 0] == 0)
                {
                    Data.Score2++;
                    labelScore2.Text = Convert.ToString(Data.Score2);
                }

                change3PictureOn_Red_Black(true);

                isEndRound = true;
            }
            #endregion

            if (isEndRound)
            {
                timerWait.Enabled = true;
                timerBlink.Enabled = true;
            }
            else
            {
                bool isDrow = true;
                #region Drow

                for (byte i = 0; i < 3; i++)
                {
                    for (byte j = 0; j < 3; j++)
                    {
                        if (logicalPull[i, j] == 2)
                        {
                            isDrow = false;
                        }
                    }
                }
                #endregion

                if (isDrow)
                {
                    isEndRound = true;
                    preparationToNewRound();
                }
            }


        }

        private void preparationToNewRound()
        {
            Data.i0_win = 3; Data.j0_win = 3;
            Data.i1_win = 3; Data.j1_win = 3;
            Data.i2_win = 3; Data.j2_win = 3;

            Data.timerBlikCounter = 0;
            Data.timerBlink = false;

            for (byte i = 0; i < 3; i++)
            {
                for (byte j = 0; j < 3; j++)
                {
                    logicalPull[i, j] = 2;
                    pictureBoxes[i, j].Image = null;
                }
            }

            isEndRound = false;

            labelScore1.Text = Convert.ToString(Data.Score1);
            labelScore2.Text = Convert.ToString(Data.Score2);

            panelEndBattle.Visible = false;

            whoMove();


        }

        private void endBattle()
        {
            panelEndBattle.Visible = true;
            if (Data.Score1 == Data.MaxScore)
            {
                labelWinnerName.Text = Data.nickName1;
            }
            else
            {
                labelWinnerName.Text = Data.nickName2;
            }
            
        }
        #endregion
       

        private void pictureBoxPull_MouseEnter(object sender, EventArgs e)
        {
            if (!isEndRound)
            {
                changePictereOn_Gray(sender, e);
            }
        }
        private void pictureBoxPull_MouseLeave(object sender, EventArgs e)
        {
            if (!isEndRound)
            {
                clearCell(sender, e);
            }
        }
        private void pictureBoxPull_MouseDown(object sender, MouseEventArgs e)
        {
            string name = ((PictureBox)sender).Name;

            byte i, j;
            byte.TryParse("" + name[14], out i);
            byte.TryParse("" + name[15], out j);

            if (logicalPull[i, j] == 2)
            {
                if (!isEndRound)
                {
                    changePictereOn_Black(sender, e);
                    fulling_logicalPull(sender, e);
                    whoMove();
                    logicalWinDrow();
                }
            }

        }
        private void timerBlink_Tick(object sender, EventArgs e)
        {
            if (Data.timerBlikCounter != 2)
            {
                try
                {
                    change3PictureOn_Red_Black(Data.timerBlink);
                    Data.timerBlink = !Data.timerBlink;
                    Data.timerBlikCounter++;
                }
                catch { }
            }
        }
        private void timerWait_Tick(object sender, EventArgs e)
        {
            timerWait.Enabled = false;
            timerBlink.Enabled = false;

            if (Data.Score1 == Data.MaxScore || Data.Score2 == Data.MaxScore)
                endBattle();
            else
                preparationToNewRound();
            
        }

        protected void botMove(byte i, byte j)
        {
            object sender = pictureBoxes[i, j];
            MouseEventArgs e = new MouseEventArgs(Button.MouseButtons, 1, 1, 1, 1);
            if (X_or_O == false)
            {
                pictureBoxPull_MouseDown(sender, e);
            }
        }

        
    }
}
