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
    public partial class Game2v : Form
    {

        public Game2v()
        {
            InitializeComponent();

            ConstructorDesignOfGame();

            ConstructorLogicalOfGame();

            ConstructorDesignOfRegistration();


        }

  


        private void pictureBoxAll_MouseEnter(object sender, EventArgs e)
        {
            if (!isEndRound)
            {
                changePictereOn_Gray(sender);
            }
        }
        private void pictureBoxPull_MouseLeave(object sender, EventArgs e)
        {
            if (!isEndRound)
            {
                clearCell(sender);
            }
        }
        private void pictureBoxPull_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isEndRound)
            {
                int i, j;
                givIndexes(sender, out i, out j);

                if (logicalPull[i, j] == 0)
                {
                    initialize_pictureBoxes_Pull(sender);
                    
                    changePictereOn_Black(sender);
                    fulling_logicalPull(sender);

                    if(logicalWin(i, j))
                    {
                        if (X_or_O)                        
                            Data.Score1++;                        
                        else                        
                            Data.Score2++;
                        timingScore();

                        isEndRound = true;
                        blinking(isRedFor_blink);
                        isRedFor_blink = !isRedFor_blink;

                        preparationToRound();

                    }
                    else if (logicalDrow())
                    {
                        preparationToRound();
                    }

                    X_or_O = !X_or_O;

                    whoMove();
                }

                
            }
        }
        private void timerBlink_Tick(object sender, EventArgs e)
        {
            try
            {
                blinking(isRedFor_blink);
                isRedFor_blink = !isRedFor_blink;
            }
            catch { }
        }
        private void timerPreparation_Tick(object sender, EventArgs e)
        {
            preparationToRound();
        }
        private void buttonMenu_Click(object sender, EventArgs e)
        { 
            this.Close();
        }
        private void buttonAgain_Click(object sender, EventArgs e)
        {
            Data.Score1 = 0;
            Data.Score2 = 0;
            X_or_O = true;
            preparationToRound(false);
        }
    }
}
