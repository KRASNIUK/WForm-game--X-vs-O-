using System;
using System.Drawing;
using System.Windows.Forms;

namespace X_vs_O
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            this.Size = panel1.Size;
            this.Height += 35;

            //
            //Инициализация обьектов панели1
            //
            radioButton1.Checked = true;


            //
            //Инициализация обьектов панели2
            //
            panel2.Location = new Point(0, 0);
            panel2.Visible = false;

            panelComplexity.Visible = false;
            panelComplexity.Location = new Point(50, 265);

            panelTwoPlayers.Visible = false;
            panelTwoPlayers.Location = new Point(50, 265);
            
            radioButton4.Checked = true;
        }


        #region Процедуры понели1

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Data.IsGame1v = true;
            }
            else if (radioButton2.Checked)
            {
                Data.IsGame1v = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;

            this.Size = panel2.Size;

            if (Data.IsGame1v)
                radioButton3.Enabled = true;
            else
                radioButton3.Enabled = false; 

            if (Data.areTwoPlayers)
            {
                panelTwoPlayers.Visible = true;
                panelComplexity.Visible = false;
            }
            else
            {
                panelTwoPlayers.Visible = false;
                panelComplexity.Visible = true;
            }



        }


        private void buttonEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Чтобы стиране произходтло только первый раз
        bool autoNickName1 = true;
        private void textBox3_Click(object sender, EventArgs e)
        {
            if (autoNickName1)
            {
                textBox3.Clear();
                Data.nickName1 = "";
                autoNickName1 = false;
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            Data.nickName1 = textBox3.Text;
            textBox1.Text = Data.nickName1;
        }

        #endregion




        #region Процедуры понели2

        private void buttonBack_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;

            this.Size = panel1.Size;

            panelComplexity.Visible = false;
            panelTwoPlayers.Visible = false;

            //Вписывание изменений
            textBox3.Text = Data.nickName1;
        }
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            Data.Score1 = 0;
            Data.Score2 = 0;

            if (Data.IsGame1v) {
                if (Data.areTwoPlayers)
                {
                    Game1v g1 = new Game1v();
                    g1.ShowDialog();
                }
                else
                {
                    Game_bot game_Bot1 = new Game_bot();
                    game_Bot1.ShowDialog();
                }
            }
            else
            {
                Game2v game2V_1 = new Game2v();
                game2V_1.ShowDialog();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton4.Checked == true)
            {
                panelTwoPlayers.Visible = true;
                panelComplexity.Visible = false;

                Data.areTwoPlayers = true;
            }
            else if(radioButton3.Checked == true)
            {
                panelComplexity.Visible = true;
                panelTwoPlayers.Visible = false;

                Data.areTwoPlayers = false;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            switch (trackBar1.Value)
            {
                case 0:
                    label9.Text = "Недотёпа";
                    break;
                case 1:
                    label9.Text = "Среднячёк";
                    break;
                case 2:
                    label9.Text = "Профи";
                    break;
            }

            Data.Complexity = trackBar1.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Data.MaxScore = (byte)numericUpDown1.Value;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (autoNickName1)
            {
                textBox1.Clear();
                Data.nickName1 = "";
                autoNickName1 = false;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Data.nickName1 = textBox1.Text;
        }

        bool autoNickName2 = true;
        private void textBox2_Click(object sender, EventArgs e)
        {
            if (autoNickName2)
            {
                textBox2.Clear();
                Data.nickName2 = "";
                autoNickName2 = false;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Data.nickName2 = textBox2.Text;
        }

        #endregion

       
    }
}
