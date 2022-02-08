using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLandigGame
{
    public partial class ScreenForm : Form
    {

        //
        double altitude, speed, descend, ascend, hold;
        bool engineOn = false;
        int score = 0;
        System.Media.SoundPlayer player;

        /* private void EngineButton_MouseDown(object sender, MouseEventArgs e)
        {
            engineOn = true;
        }

        private void EngineButton_MouseUp(object sender, MouseEventArgs e)
        {
            engineOn = false;
        }

        private void EngineButton_MouseHover(object sender, EventArgs e)
        {
            EngineButton.BackColor = Color.OrangeRed;
        }*/

        private void ScreenForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Down)
            {
                engineOn = false;
            }
        }

        private void ScreenForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Down)
            {
                engineOn = true;
            } else if (e.KeyData == Keys.Space)
            {
                ShipPicBox.Image = Properties.Resources.Lander;
                ShipPicBox.Top = 0;

                altitude = ShipPicBox.Height;

                speed = 0.0;
                score = 0;
                engineOn = false;
                StatusLabel.Text = "Score";

                ShipMotion.Start();
            }
        }

        //

        private void ScreenForm_Load(object sender, EventArgs e)
        {
            descend = 0.03; // 下降
            ascend = 0.08; // 上昇
            hold = 0.6; // 着陸速度許容値
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            


        }



        public ScreenForm()
        {
            InitializeComponent();
        }

        private void ShipMotion_Tick(object sender, EventArgs e)
        {
            score++;
            speed += descend;
            altitude += speed;

            if (engineOn)
            {
                speed -= ascend;
            }

            if (altitude >= ClientSize.Height)
            {
                ShipMotion.Stop();
                
                if (speed < hold)
                {
                    StatusLabel.Text = score.ToString();
                }
                else
                {
                    StatusLabel.Text = "You Gonna Fail, OK?";
                    ShipPicBox.Image = Properties.Resources.Bombing;

                    player = new System.Media.SoundPlayer(Properties.Resources.explosion);
                    player.Play();
                }

                altitude = ClientSize.Height;
            }

            

            ShipPicBox.Top = Convert.ToInt32(altitude) - ShipPicBox.Height;
        }








    }


}
