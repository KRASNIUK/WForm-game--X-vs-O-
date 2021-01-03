using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_vs_O
{
    class Data
    {
        internal static bool IsGame1v = true;


        internal static string nickName1 = "Мартыненко";
        internal static bool areTwoPlayers = true;
        internal static string nickName2 = "Краснюк";

        internal static byte MaxScore = 1;
        internal static int Complexity = 0;

        internal static byte Score1;
        internal static byte Score2;

        #region Game1v
        internal static byte i0_win = 3;
        internal static byte j0_win = 3;
        internal static byte i1_win = 3;
        internal static byte j1_win = 3;
        internal static byte i2_win = 3;
        internal static byte j2_win = 3;

        internal static bool timerBlink = false;
        internal static byte timerBlikCounter = 0;
        #endregion

        #region bot
        internal static byte[,] CombinationArr1 = { { 2, 2, 2 },
                                                   { 2, 1, 2 },
                                                   { 2, 2, 2 } };

        internal static byte[,,] CombinationArr2 = { { { 2, 2, 2 },
                                                      { 2, 0, 2 },
                                                      { 2, 1, 2 } }, { { 2, 2, 2 },
                                                                       { 1, 0, 2 },
                                                                       { 2, 2, 2 } }, { { 2, 1, 2 },
                                                                                        { 2, 0, 2 },
                                                                                        { 2, 2, 2 } }, { { 2, 2, 2 },
                                                                                                         { 2, 0, 1 },
                                                                                                         { 2, 2, 2 } } };

        internal static byte[,] CombinationArr20_Moves = { { 0, 0 } };
        internal static byte[,] CombinationArr21_Moves = { { 0, 2 } };
        internal static byte[,] CombinationArr22_Moves = { { 2, 2 } };
        internal static byte[,] CombinationArr23_Moves = { { 2, 0 } };








        internal static bool areArrEquals(byte[,] arr1, byte[,] arr2)
        {
            bool isEquals = true;
            for (int i = 0; i < 3 && isEquals; i++)
            {
                for (int j = 0; j < 3 && isEquals; j++)
                {
                    if (arr1[i, j] == arr2[i, j])
                    {
                        isEquals = true;
                    }
                    else
                    {
                        isEquals = false;
                    }
                }
            }
            return isEquals;
        }

        #endregion

        



    }



}
