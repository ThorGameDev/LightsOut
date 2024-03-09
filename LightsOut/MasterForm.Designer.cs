namespace LightsOut
{
    partial class MasterForm
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
            this.output_existingGames = new System.Windows.Forms.ListBox();
            this.input_newGameName = new System.Windows.Forms.TextBox();
            this.PlayGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.input_gameSize = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.GetHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_gameSize)).BeginInit();
            this.SuspendLayout();
            // 
            // output_existingGames
            // 
            this.output_existingGames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.output_existingGames.FormattingEnabled = true;
            this.output_existingGames.Location = new System.Drawing.Point(41, 94);
            this.output_existingGames.Name = "output_existingGames";
            this.output_existingGames.Size = new System.Drawing.Size(125, 95);
            this.output_existingGames.TabIndex = 0;
            this.output_existingGames.SelectedIndexChanged += new System.EventHandler(this.output_existingGames_SelectedIndexChanged);
            // 
            // input_newGameName
            // 
            this.input_newGameName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.input_newGameName.Location = new System.Drawing.Point(41, 226);
            this.input_newGameName.Name = "input_newGameName";
            this.input_newGameName.Size = new System.Drawing.Size(125, 20);
            this.input_newGameName.TabIndex = 2;
            // 
            // PlayGame
            // 
            this.PlayGame.Location = new System.Drawing.Point(41, 269);
            this.PlayGame.Name = "PlayGame";
            this.PlayGame.Size = new System.Drawing.Size(125, 23);
            this.PlayGame.TabIndex = 3;
            this.PlayGame.Text = "Play Game";
            this.PlayGame.UseVisualStyleBackColor = true;
            this.PlayGame.Click += new System.EventHandler(this.PlayGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Existing Games";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Play Game with name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 46);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lights Out";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(64, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 207);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(-59, 58);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(179, 207);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Location = new System.Drawing.Point(143, -16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(86, 104);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(12, 142);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(115, 104);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // input_gameSize
            // 
            this.input_gameSize.Location = new System.Drawing.Point(118, 248);
            this.input_gameSize.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.input_gameSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.input_gameSize.Name = "input_gameSize";
            this.input_gameSize.Size = new System.Drawing.Size(48, 20);
            this.input_gameSize.TabIndex = 11;
            this.input_gameSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Board Size";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // GetHelp
            // 
            this.GetHelp.Location = new System.Drawing.Point(192, 281);
            this.GetHelp.Name = "GetHelp";
            this.GetHelp.Size = new System.Drawing.Size(22, 23);
            this.GetHelp.TabIndex = 13;
            this.GetHelp.Text = "?";
            this.GetHelp.UseVisualStyleBackColor = true;
            this.GetHelp.Click += new System.EventHandler(this.GetHelp_Click);
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 304);
            this.Controls.Add(this.GetHelp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.input_gameSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayGame);
            this.Controls.Add(this.input_newGameName);
            this.Controls.Add(this.output_existingGames);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "MasterForm";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.StartGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_gameSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox output_existingGames;
        private System.Windows.Forms.TextBox input_newGameName;
        private System.Windows.Forms.Button PlayGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.NumericUpDown input_gameSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GetHelp;
    }
}

