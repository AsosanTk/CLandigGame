
namespace CLandigGame
{
    partial class ScreenForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ShipPicBox = new System.Windows.Forms.PictureBox();
            this.ShipMotion = new System.Windows.Forms.Timer(this.components);
            this.StatusLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ShipPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ShipPicBox
            // 
            this.ShipPicBox.BackColor = System.Drawing.Color.Transparent;
            this.ShipPicBox.BackgroundImage = global::CLandigGame.Properties.Resources.Lander;
            this.ShipPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ShipPicBox.Location = new System.Drawing.Point(303, 199);
            this.ShipPicBox.Name = "ShipPicBox";
            this.ShipPicBox.Size = new System.Drawing.Size(64, 64);
            this.ShipPicBox.TabIndex = 0;
            this.ShipPicBox.TabStop = false;
            // 
            // ShipMotion
            // 
            this.ShipMotion.Interval = 10;
            this.ShipMotion.Tick += new System.EventHandler(this.ShipMotion_Tick);
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StatusLabel.Location = new System.Drawing.Point(688, 291);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StatusLabel.Size = new System.Drawing.Size(100, 60);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "Score";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(524, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 66);
            this.button1.TabIndex = 4;
            this.button1.Text = "Lv.1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(704, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 66);
            this.button2.TabIndex = 5;
            this.button2.Text = "Lv.3";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Goldenrod;
            this.button3.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(614, 372);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 66);
            this.button3.TabIndex = 6;
            this.button3.Text = "Lv.2";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PaleGreen;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Location = new System.Drawing.Point(614, 322);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(63, 29);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "↔0.3";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Wheat;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox2.Location = new System.Drawing.Point(545, 322);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(63, 29);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "↕0.3";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CLandigGame.Properties.Resources.ScreenForm;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ShipPicBox);
            this.Name = "ScreenForm";
            this.Text = "Landing Game";
            this.Load += new System.EventHandler(this.ScreenForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ScreenForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ScreenForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ShipPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ShipPicBox;
        private System.Windows.Forms.Timer ShipMotion;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

