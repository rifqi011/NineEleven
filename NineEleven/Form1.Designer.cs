namespace NineEleven
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            gameTimer = new System.Windows.Forms.Timer(components);
            buttonStart = new Button();
            label1 = new Label();
            labelScore = new Label();
            planePic = new PictureBox();
            towerBottomPic = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)planePic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)towerBottomPic).BeginInit();
            SuspendLayout();
            // 
            // gameTimer
            // 
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // buttonStart
            // 
            buttonStart.AutoSize = true;
            buttonStart.Font = new Font("Segoe UI", 12F);
            buttonStart.Location = new Point(339, 213);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(112, 42);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 410);
            label1.Name = "label1";
            label1.Size = new Size(143, 25);
            label1.TabIndex = 1;
            label1.Text = "Rifqi yg bikin, rill";
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Font = new Font("Segoe UI", 12F);
            labelScore.Location = new Point(669, 404);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(78, 32);
            labelScore.TabIndex = 2;
            labelScore.Text = "Score:";
            // 
            // planePic
            // 
            planePic.BackColor = Color.Transparent;
            planePic.BackgroundImageLayout = ImageLayout.None;
            planePic.Image = (Image)resources.GetObject("planePic.Image");
            planePic.Location = new Point(12, 163);
            planePic.Name = "planePic";
            planePic.Size = new Size(103, 63);
            planePic.SizeMode = PictureBoxSizeMode.Zoom;
            planePic.TabIndex = 3;
            planePic.TabStop = false;
            // 
            // towerBottomPic
            // 
            towerBottomPic.Image = (Image)resources.GetObject("towerBottomPic.Image");
            towerBottomPic.Location = new Point(512, 196);
            towerBottomPic.Name = "towerBottomPic";
            towerBottomPic.Size = new Size(100, 250);
            towerBottomPic.SizeMode = PictureBoxSizeMode.StretchImage;
            towerBottomPic.TabIndex = 5;
            towerBottomPic.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 444);
            Controls.Add(towerBottomPic);
            Controls.Add(planePic);
            Controls.Add(labelScore);
            Controls.Add(label1);
            Controls.Add(buttonStart);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "NineEleven";
            KeyDown += Form1_Keydown;
            ((System.ComponentModel.ISupportInitialize)planePic).EndInit();
            ((System.ComponentModel.ISupportInitialize)towerBottomPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private Button buttonStart;
        private Label label1;
        private Label labelScore;
        private PictureBox planePic;
        private PictureBox towerBottomPic;
    }
}
