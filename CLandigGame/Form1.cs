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
        double latitude, speedx, ax;
        bool engineOn = false;
        bool enginexlOn = false;
        bool enginexrOn = false;
        int score = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            hold = 1.0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hold = 0.6;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hold = 0.3;
        }

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
                engineOn = true;
            } else if (e.KeyData == Keys.Left)
            {
                enginexlOn = true;
            }
            else if (e.KeyData == Keys.Right)
            {
                enginexrOn = true;
            }
        }

        private void ScreenForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Down)
            {
                engineOn = false;
            } else if (e.KeyData == Keys.Space)
            {
                ShipPicBox.Image = Properties.Resources.Lander;
                ShipPicBox.Top = 0;

                altitude = ShipPicBox.Height;

                speed = 0.0;
                speedx = 0.0;
                score = 0;
                engineOn = false;
                enginexlOn = false;
                enginexrOn = false;
                StatusLabel.Text = "Score";

                ShipMotion.Start();
            } else if (e.KeyData == Keys.Left)
            {
                enginexlOn = false;
            } else if (e.KeyData == Keys.Right)
            {
                enginexrOn = false;
            }
            e.Handled = true;
        }

        //

        private void ScreenForm_Load(object sender, EventArgs e)
        {
            descend = 0.03; // 下降
            ascend = 0.08; // 上昇
            ax = 0.03;
            hold = 0.6; // 着陸速度許容値
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
            latitude += speedx;
            textBox1.Text = "↔"+altitude;
            textBox2.Text = "↕" + latitude;

            if (engineOn)
            {
                speed -= ascend;
            }
            if (enginexlOn)
            {
                speedx -= ax;
            }
            if (enginexrOn)
            {

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
                    StatusLabel.Text = "Failed";
                    ShipPicBox.Image = Properties.Resources.Bombing;

                    player = new System.Media.SoundPlayer(Properties.Resources.explosion);
                    player.Play();
                }

                altitude = ClientSize.Height;
            }

            

            ShipPicBox.Top = Convert.ToInt32(altitude) - ShipPicBox.Height;
            ShipPicBox.Left = Convert.ToInt32(latitude) - ShipPicBox.Width;
        }








    }


}
