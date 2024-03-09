namespace LightsOut
{
    partial class GameForm
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
            this.SaveAndQuit = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveAndQuit
            // 
            this.SaveAndQuit.Location = new System.Drawing.Point(12, 415);
            this.SaveAndQuit.Name = "SaveAndQuit";
            this.SaveAndQuit.Size = new System.Drawing.Size(100, 23);
            this.SaveAndQuit.TabIndex = 0;
            this.SaveAndQuit.Text = "Save And Quit";
            this.SaveAndQuit.UseVisualStyleBackColor = true;
            this.SaveAndQuit.Click += new System.EventHandler(this.SaveAndQuit_Click);
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(118, 415);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(68, 23);
            this.Quit.TabIndex = 1;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.SaveAndQuit);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveAndQuit;
        private System.Windows.Forms.Button Quit;
    }
}