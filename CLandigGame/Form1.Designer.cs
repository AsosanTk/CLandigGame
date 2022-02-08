
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
            this.StartButton = new System.Windows.Forms.Button();
            this.EngineButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ShipPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ShipPicBox
            // 
            this.ShipPicBox.BackColor = System.Drawing.Color.Transparent;
            this.ShipPicBox.BackgroundImage = global::CLandigGame.Properties.Resources.Lander;
            this.ShipPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ShipPicBox.Location = new System.Drawing.Point(237, 231);
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
            // StartButton
            // 
            /*this.StartButton.BackColor = System.Drawing.Color.Orange;
            this.StartButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StartButton.Location = new System.Drawing.Point(672, 222);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(100, 60);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);*/
            // 
            // EngineButton
            // 
            /*this.EngineButton.BackColor = System.Drawing.Color.OrangeRed;
            this.EngineButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EngineButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EngineButton.Location = new System.Drawing.Point(672, 301);
            this.EngineButton.Name = "EngineButton";
            this.EngineButton.Size = new System.Drawing.Size(100, 60);
            this.EngineButton.TabIndex = 2;
            this.EngineButton.Text = "Engine";
            this.EngineButton.UseVisualStyleBackColor = false;
            this.EngineButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EngineButton_MouseDown);
            this.EngineButton.MouseHover += new System.EventHandler(this.EngineButton_MouseHover);
            this.EngineButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EngineButton_MouseUp);*/
            // 
            // StatusLabel
            // 
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(672, 381);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StatusLabel.Size = new System.Drawing.Size(100, 60);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "スコア";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CLandigGame.Properties.Resources.ScreenForm;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.EngineButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ShipPicBox);
            this.Name = "ScreenForm";
            this.Text = "Landing Game";
            this.Load += new System.EventHandler(this.ScreenForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ScreenForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ScreenForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ShipPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ShipPicBox;
        private System.Windows.Forms.Timer ShipMotion;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button EngineButton;
        private System.Windows.Forms.Label StatusLabel;
    }
}

