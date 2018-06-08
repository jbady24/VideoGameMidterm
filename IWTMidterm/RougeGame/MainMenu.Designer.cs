namespace RougeGame
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenuGroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mainMenuGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuGroupBox
            // 
            this.mainMenuGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.mainMenuGroupBox.Controls.Add(this.button1);
            this.mainMenuGroupBox.Controls.Add(this.playBtn);
            this.mainMenuGroupBox.Controls.Add(this.label1);
            this.mainMenuGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenuGroupBox.Location = new System.Drawing.Point(0, 0);
            this.mainMenuGroupBox.Name = "mainMenuGroupBox";
            this.mainMenuGroupBox.Size = new System.Drawing.Size(559, 425);
            this.mainMenuGroupBox.TabIndex = 0;
            this.mainMenuGroupBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Font = new System.Drawing.Font("Pristina", 24F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(212, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "QUIT";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.Color.Firebrick;
            this.playBtn.Font = new System.Drawing.Font("Pristina", 24F, System.Drawing.FontStyle.Bold);
            this.playBtn.Location = new System.Drawing.Point(216, 179);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(119, 47);
            this.playBtn.TabIndex = 11;
            this.playBtn.Text = "PLAY";
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pristina", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "MAIN MENU";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RougeGame.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(559, 425);
            this.Controls.Add(this.mainMenuGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.button1_Click);
            this.mainMenuGroupBox.ResumeLayout(false);
            this.mainMenuGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mainMenuGroupBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Label label1;
    }
}