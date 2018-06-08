namespace RougeGame
{
    partial class InformationScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.infoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.infoGroupBox.BackgroundImage = global::RougeGame.Properties.Resources.Background;
            this.infoGroupBox.Controls.Add(this.button1);
            this.infoGroupBox.Controls.Add(this.infoLabel);
            this.infoGroupBox.Controls.Add(this.label1);
            this.infoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoGroupBox.Location = new System.Drawing.Point(0, 0);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Size = new System.Drawing.Size(565, 464);
            this.infoGroupBox.TabIndex = 0;
            this.infoGroupBox.TabStop = false;
            this.infoGroupBox.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Font = new System.Drawing.Font("Pristina", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(206, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 57);
            this.button1.TabIndex = 5;
            this.button1.Text = "BEGIN QUEST";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(69, 152);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(37, 27);
            this.infoLabel.TabIndex = 4;
            this.infoLabel.Text = "info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pristina", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to Hazuki\'s Dungeon";
            // 
            // InformationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.infoGroupBox);
            this.Name = "InformationScreen";
            this.Size = new System.Drawing.Size(565, 464);
            this.infoGroupBox.ResumeLayout(false);
            this.infoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox infoGroupBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label label1;
    }
}
