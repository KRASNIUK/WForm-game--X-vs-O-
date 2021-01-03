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
        // Чтобы была смена х и о
        // true - x
        // false - o
        bool X_or_O = true;

        // 0 - null
        // 1 - x
        // -1 - o
        int[,] logicalPull = new int[19, 19];
        List<Indexes> fastClear_logicalPull = new List<Indexes>() { };

        int counterFor_logicalDrow;

        bool isEndRound;

        struct Indexes
        {
            public int i;
            public int j;
        }
        
            

        


        void ConstructorLogicalOfGame()
        {
            counterFor_logicalDrow = 19 * 19;
            isEndRound = false;

            timerBlink.Enabled = false;
            panelEndBattle.Visible = false;
            timerPreparation.Enabled = false;

            whoMove();
        }



        private void givIndexes(object sender, out int i, out int j)
        {

            // Узнаю порядковый номер PictureBox
            string name = ((PictureBox)sender).Name;

            string numString = "";
            numString += name[10];

            if (name.Length == 13)
            {
                numString += name[11];
                numString += name[12];
            }
            else if (name.Length == 12)
            {
                numString += name[11];
            }

            int num;
            int.TryParse(numString, out num);


            // Нахожу индексы нахождения PictureBox в массиве pictureBoxes_Pull 
            i = 0;
            j = 0;

            while (num > 18)
            {
                num -= 19;
                i++;
            }
            j = num;
        }

        private void fulling_logicalPull(object sender)
        {
            string name = ((PictureBox)sender).Name;

            int i, j;
            givIndexes(sender, out i, out j);

            if (X_or_O)
            {
                logicalPull[i, j] = 1;
            }            
            else
            {
                logicalPull[i, j] = -1;
            }

            Indexes item;
            item.i = i;
            item.j = j;

            fastClear_logicalPull.Add(item);

        }
        private bool recursionFor_logicalWin(ref int counterWin, Indexes cell, ref int i, Indexes vector, int index_X_Or_O)
        {
            if (counterWin == 0)
            {
                return true;
            }
            else
            {
                Indexes nextCell;
                nextCell.i = cell.i + vector.i <= 18 && cell.i + vector.i >= 0 ? cell.i + vector.i : -1;
                nextCell.j = cell.j + vector.j <= 18 && cell.j + vector.j >= 0 ? cell.j + vector.j : -1;

                if (nextCell.i == -1 || nextCell.j == -1)
                {
                    return false;
                }

                if (logicalPull[nextCell.i, nextCell.j] == index_X_Or_O)
                {
                    counterWin--;

                    winersCells[i] = nextCell;
                    i++;
                    return recursionFor_logicalWin(ref counterWin, nextCell, ref i, vector, index_X_Or_O);
                }
                else
                {
                    return false;
                }


            }
        }
        private bool logicalWin(int i, int j)
        {
            Indexes putCell = new Indexes();
            putCell.i = i;
            putCell.j = j;

            winersCells[0] = putCell;

            Indexes[] checkCells = new Indexes[8];

            checkCells[0].i = (putCell.i - 1 >= 0) ? putCell.i - 1 : -1;
            checkCells[0].j = (putCell.j - 1 >= 0) ? putCell.j - 1 : -1;

            checkCells[1].i = putCell.i;
            checkCells[1].j = (putCell.j - 1 >= 0) ? putCell.j - 1 : -1;

            checkCells[2].i = (putCell.i + 1 <= 18) ? putCell.i + 1 : -1;
            checkCells[2].j = (putCell.j - 1 >= 0) ? putCell.j - 1 : -1;

            checkCells[3].i = (putCell.i + 1 <= 18) ? putCell.i + 1 : -1;
            checkCells[3].j = putCell.j;

            checkCells[4].i = (putCell.i + 1 <= 18) ? putCell.i + 1 : -1;
            checkCells[4].j = (putCell.j + 1 <= 18) ? putCell.j + 1 : -1;

            checkCells[5].i = putCell.i;
            checkCells[5].j = (putCell.j + 1 <= 18) ? putCell.j + 1 : -1;

            checkCells[6].i = (putCell.i - 1 >= 0) ? putCell.i - 1 : -1;
            checkCells[6].j = (putCell.j + 1 <= 18) ? putCell.j + 1 : -1;

            checkCells[7].i = (putCell.i - 1 >= 0) ? putCell.i - 1 : -1;
            checkCells[7].j = putCell.j;

            for (int count = 0; count < 8; count++) {
                if (checkCells[count].i == -1 || checkCells[count].j == -1)
                {
                    continue;
                }
                if (logicalPull[checkCells[count].i, checkCells[count].j] == (X_or_O ? 1 : -1))
                {

                    Indexes vector_SideUp;
                    vector_SideUp.i = checkCells[count].i - putCell.i;
                    vector_SideUp.j = checkCells[count].j - putCell.j;

                    int counterWin = 4;
                    int counterFor_winersCells = 1;
                    if (recursionFor_logicalWin(ref counterWin, putCell, ref counterFor_winersCells, vector_SideUp, X_or_O ? 1 : -1))
                    {
                        return true;
                    }
                    else
                    {
                        Indexes vector_SideDown;
                        vector_SideDown.i = vector_SideUp.i * -1;
                        vector_SideDown.j = vector_SideUp.j * -1;

                        if (recursionFor_logicalWin(ref counterWin, putCell, ref counterFor_winersCells, vector_SideDown, X_or_O ? 1 : -1))
                        {
                            return true;
                        }
                        else
                        {
                            winersCells = new Indexes[5];
                        }
                    }

                }
            }

            return false;
        }
        private bool logicalDrow()
        {
            if (counterFor_logicalDrow == 0)
            {
                return true;
            }
            return false;
        }
        private void preparationToRound( bool action = true)
        {

            if (!timerPreparation.Enabled && action)
            {
                timerPreparation.Enabled = true;
                
            }
            else
            {
                if (!isEndBattle())
                {

                    foreach (Indexes I in fastClear_pictureBoxes)
                    {
                        pictureBoxes_Pull[I.i, I.j].Image = null;

                    }
                    fastClear_pictureBoxes.Clear();

                    foreach (Indexes I in fastClear_logicalPull)
                    {
                        logicalPull[I.i, I.j] = 0;
                    }
                    fastClear_logicalPull.Clear();

                    ConstructorLogicalOfGame();
                    ConstructorDesignOfGame();
                    ConstructorDesignOfRegistration();

                }
            }
        }
    }
}
