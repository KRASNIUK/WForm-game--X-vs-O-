using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_vs_O
{
    partial class Game2v
    {
        string pathX_gray = @"D:\# I\#My programm\C#\forms\X vs O\#Image\Big_Game_ X_vs_O\X_gray.png";
        string pathO_gray = @"D:\# I\#My programm\C#\forms\X vs O\#Image\Big_Game_ X_vs_O\O_gray.png";
        string pathX_black = @"D:\# I\#My programm\C#\forms\X vs O\#Image\Big_Game_ X_vs_O\X_black.png";
        string pathO_black = @"D:\# I\#My programm\C#\forms\X vs O\#Image\Big_Game_ X_vs_O\O_black.png";
        string pathX_red = @"D:\# I\#My programm\C#\forms\X vs O\#Image\Big_Game_ X_vs_O\X_red.png";
        string pathO_red = @"D:\# I\#My programm\C#\forms\X vs O\#Image\Big_Game_ X_vs_O\O_red.png";

        PictureBox[,] pictureBoxes_Pull = new PictureBox[19, 19];
        List<Indexes> fastClear_pictureBoxes = new List<Indexes>() { };
        Indexes[] winersCells = new Indexes[5];

        bool isRedFor_blink;

        void ConstructorDesignOfGame()
        {
            isRedFor_blink = false;

            


        }


        private void initialize_pictureBoxes_Pull(object sender)
        {
            int i, j;
            givIndexes(sender, out i, out j);

            pictureBoxes_Pull[i, j] = (PictureBox)sender;

            Indexes item;
            item.i = i;
            item.j = j;

            fastClear_pictureBoxes.Add(item);

            counterFor_logicalDrow--;

        }
        private void changePictereOn_Gray(object sender)
        {

            // Вставляю в PictureBox серый крестик (X_or_O = true) или серый нолик (X_or_O = false)
            if (((PictureBox)sender).Image == null)
            {
                if (X_or_O)
                {
                    ((PictureBox)sender).Image = Image.FromFile(pathX_gray);
                }
                else
                {
                    ((PictureBox)sender).Image = Image.FromFile(pathO_gray);
                }

            }
        }
        private void clearCell(object sender)
        {

            int i, j;
            givIndexes(sender, out i, out j);

            if (logicalPull[i, j] == 0)
            {
                ((PictureBox)sender).Image = null;
            }
        }
        private void changePictereOn_Black(object sender)
        {
            string path;
            if (X_or_O)
            {

                path = pathX_black;
            }
            else
            {
                path = pathO_black;
            }

            ((PictureBox)sender).Image = Image.FromFile(path);

        }
        private void blinking(bool isRed)
        {
            if (!timerBlink.Enabled)
            {
                timerBlink.Enabled = true;
            }


            string path;

            if (logicalPull[winersCells[0].i, winersCells[0].j] == 1)
            {
                if (isRed)
                    path = pathX_red;
                else 
                    path = pathX_black;
            }
            else
            {
                if (isRed)
                    path = pathO_red;
                else
                    path = pathO_black;
            }

            for (int i = 0; i < 5; i++) {
                pictureBoxes_Pull[winersCells[i].i, winersCells[i].j].Image = Image.FromFile(path);
            }

        }
        private bool isEndBattle()
        {
            if (Data.MaxScore == Data.Score1)
            {
                panelEndBattle.Visible = true;
                labelWinnerName.Text = Data.nickName1;
                return true;
            }
            else if (Data.MaxScore == Data.Score2)
            {
                panelEndBattle.Visible = true;
                labelWinnerName.Text = Data.nickName2;
                return true;
            }
            return false;
        }
    }
}
