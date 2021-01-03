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
    public partial class Game_bot : Game1v
    {
        Random rand1 = new Random(1);
        Random rand2 = new Random(2);

        public Game_bot()
        {
            InitializeComponent();
            this.Size = new Size(702, 621);

            timer.Enabled = true;

        }

        private void timer_Tick(object sender, EventArgs e)
        {

            if (x_or_O == false)
            {
                switch (Data.Complexity)
                {
                    case 0:
                        bot_Level0();
                        break;
                    case 1:
                        bot_Level1();
                        break;
                    case 2:
                        bot_Level2();
                        break;
                }
            }
        }

        private void bot_Level0()
        {
            byte iRand, jRand;

            do
            {
                iRand = Convert.ToByte(rand1.Next(0, 3));
                jRand = Convert.ToByte(rand2.Next(0, 3));

            } while (logicalPull[iRand, jRand] != 2);

            botMove(iRand, jRand);
        }
        private void bot_Level1()
        {
            if (wantWin())
            {
                if (hateLose())
                {
                    bot_Level0();
                }
            }
        }
        private void bot_Level2()
        {
            if (!wantWin())
            {
                return;
            }
            if (!hateLose())
            {
                return;
            }
            if (combinationCenter())
            {
                return;
            }
            if (combinationHateLose1())
            {
                
            }

            bot_Level0();

        }

        private bool wantWin()
        {
            for (int i = 0; i < 3; i++)
            {

                #region Проверка на 2 нолика по горизонтали. В ряду под номером (int)i
                {
                    // COUNTER
                    // -1 = в ряду есть крестик
                    // 0 = ряд пуст
                    // 1 = в ряду есть нолик
                    // 2 = в ряду есть 2 нолика (можно выиграть)

                    int counter = 0;
                    int saveJ_Null = -1;
                    for (int j = 0; j < 3; j++)
                    {
                        if (logicalPull[i, j] == 0)
                        {
                            counter++;
                        }
                        else if (logicalPull[i, j] == 1)
                        {
                            counter = -1;
                        }
                        else
                        {
                            saveJ_Null = j;
                        }
                    }

                    if (counter == 2)
                    {
                        botMove(Convert.ToByte(i), Convert.ToByte(saveJ_Null));
                        return false;
                    }
                }
                #endregion

                #region Проверка на 2 нолика по вертикили. В столбце под номером (int)i
                {
                    // COUNTER
                    // -1 = в столбце есть крестик
                    // 0 = столбец пуст
                    // 1 = в столбце есть нолик
                    // 2 = в столбце есть 2 нолика (можно выиграть)

                    int counter = 0;
                    int saveJ_Null = -1;
                    for (int j = 0; j < 3; j++)
                    {
                        if (logicalPull[j, i] == 0)
                        {
                            counter++;
                        }
                        else if (logicalPull[j, i] == 1)
                        {
                            counter = -1;
                        }
                        else
                        {
                            saveJ_Null = j;
                        }
                    }

                    if (counter == 2)
                    {
                        botMove(Convert.ToByte(saveJ_Null), Convert.ToByte(i));
                        return false;
                    }
                }
                #endregion

            }

            #region Проверка на 2 нолика по верхней диагонали
            {
                // COUNTER
                // -1 = в диагонали есть крестик
                // 0 = диагональ пуста
                // 1 = в диагонали есть нолик
                // 2 = в диагонали есть 2 нолика (можно выиграть)

                int counter = 0;
                int saveI_Null = -1;

                for (int i = 0; i < 3; i++)
                {
                    if (logicalPull[i, i] == 0)
                    {
                        counter++;
                    }
                    else if (logicalPull[i, i] == 1)
                    {
                        counter = -1;
                    }
                    else
                    {
                        saveI_Null = i;
                    }
                }

                if (counter == 2)
                {
                    botMove(Convert.ToByte(saveI_Null), Convert.ToByte(saveI_Null));
                    return false;
                }
            }
            #endregion

            #region Проверка на 2 нолика по нижней диагонали
            {
                // COUNTER
                // -1 = в диагонали есть крестик
                // 0 = диагональ пуста
                // 1 = в диагонали есть нолик
                // 2 = в диагонали есть 2 нолика (можно выиграть)

                int counter = 0;
                int saveI_Null = -1;
                int saveJ_Null = -1;
                int j;

                for (int i = 0; i < 3; i++)
                {
                    if (i == 0)
                        j = 2;
                    else if (i == 1)
                        j = 1;
                    else
                        j = 0;

                    if (logicalPull[i, j] == 0)
                    {
                        counter++;
                    }
                    else if (logicalPull[i, j] == 1)
                    {
                        counter = -1;
                    }
                    else
                    {
                        saveI_Null = i;
                        saveJ_Null = j;
                    }
                }


                if (counter == 2)
                {
                    botMove(Convert.ToByte(saveI_Null), Convert.ToByte(saveJ_Null));
                    return false;
                }
            }
            #endregion

            return true;
        }
        private bool hateLose()
        {
            for (int i = 0; i < 3; i++)
            {
                #region Проверка на 2 крестика по горизонтали. В ряду под номером (int)i
                {
                    // COUNTER
                    // -1 = в ряду есть нолик
                    // 0 = ряд пуст
                    // 1 = в ряду есть крестик
                    // 2 = в ряду есть 2 крестика (могу проиграть)

                    int counter = 0;
                    int saveJ_Null = -1;
                    for (int j = 0; j < 3; j++)
                    {
                        if (logicalPull[i, j] == 1)
                        {
                            counter++;
                        }
                        else if (logicalPull[i, j] == 0)
                        {
                            counter = -1;
                        }
                        else
                        {
                            saveJ_Null = j;
                        }
                    }

                    if (counter == 2)
                    {
                        botMove(Convert.ToByte(i), Convert.ToByte(saveJ_Null));
                        return false;
                    }
                }
                #endregion

                #region Проверка на 2 крестика по вертикили. В столбце под номером (int)i
                {
                    // COUNTER
                    // -1 = в столбце есть нолик
                    // 0 = столбец пуст
                    // 1 = в столбце есть крестик
                    // 2 = в столбце есть 2 крестика (могу проиграть)

                    int counter = 0;
                    int saveJ_Null = -1;
                    for (int j = 0; j < 3; j++)
                    {
                        if (logicalPull[j, i] == 1)
                        {
                            counter++;
                        }
                        else if (logicalPull[j, i] == 0)
                        {
                            counter = -1;
                        }
                        else
                        {
                            saveJ_Null = j;
                        }
                    }

                    if (counter == 2)
                    {
                        botMove(Convert.ToByte(saveJ_Null), Convert.ToByte(i));
                        return false;
                    }
                }
                #endregion
            }

            #region Проверка на 2 крестика по верхней диагонали
            {
                // COUNTER
                // -1 = в диагонали есть нолик
                // 0 = диагональ пуста
                // 1 = в диагонали есть крестик
                // 2 = в диагонали есть 2 крестика (могу проиграть)

                int counter = 0;
                int saveI_Null = -1;

                for (int i = 0; i < 3; i++)
                {
                    if (logicalPull[i, i] == 1)
                    {
                        counter++;
                    }
                    else if (logicalPull[i, i] == 0)
                    {
                        counter = -1;
                    }
                    else
                    {
                        saveI_Null = i;
                    }
                }

                if (counter == 2)
                {
                    botMove(Convert.ToByte(saveI_Null), Convert.ToByte(saveI_Null));
                    return false;
                }
            }
            #endregion

            #region Проверка на 2 крестика по нижней диагонали
            {
                // COUNTER
                // -1 = в диагонали есть нолик
                // 0 = диагональ пуста
                // 1 = в диагонали есть крестик
                // 2 = в диагонали есть 2 крестика (могу проиграть)

                int counter = 0;
                int saveI_Null = -1;
                int saveJ_Null = -1;
                int j;

                for (int i = 0; i < 3; i++)
                {
                    if (i == 0)
                        j = 2;
                    else if (i == 1)
                        j = 1;
                    else
                        j = 0;

                    if (logicalPull[i, j] == 1)
                    {
                        counter++;
                    }
                    else if (logicalPull[i, j] == 0)
                    {
                        counter = -1;
                    }
                    else
                    {
                        saveI_Null = i;
                        saveJ_Null = j;
                    }
                }


                if (counter == 2)
                {
                    botMove(Convert.ToByte(saveI_Null), Convert.ToByte(saveJ_Null));
                    return false;
                }
            }
            #endregion

            return true;
        }
        private bool combinationHateLose1()
        {
            if (Data.areArrEquals(logicalPull, Data.CombinationArr1))
            {
                int numRand = rand1.Next(0, 4);

                switch (numRand)
                {
                    case 0:
                        botMove(0, 0);
                        return true;
                    case 1:
                        botMove(0, 2);
                        return true;
                    case 2:
                        botMove(2, 0);
                        return true;
                    case 3:
                        botMove(2, 2);
                        return true;
                }
            }

            return false;

        }
        private bool combinationCenter()
        {

            if (logicalPull[1, 1] == 2)
            {
                botMove(1, 1);
                return true;
            }

            return false;
        }
    }
}
