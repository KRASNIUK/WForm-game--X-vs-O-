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
        Point mainLocation;

        void ConstructorDesignOfRegistration()
        {
            timingScore();

            labelNickName1.Text = Data.nickName1;
            labelNickName2.Text = Data.nickName2;

            labelMaxScore.Text = Convert.ToString(Data.MaxScore);

            labelNickName1.Location = new Point(420, 27);
            while (labelNickName1.Width + labelNickName1.Location.X > labelScore1.Location.X)
            {
                labelNickName1.Location = new Point(labelNickName1.Location.X - 2, labelNickName1.Location.Y);
            }
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
        private void timingScore()
        {
            labelScore1.Text = Convert.ToString(Data.Score1);
            labelScore2.Text = Convert.ToString(Data.Score2);
        }
        
    }
}
