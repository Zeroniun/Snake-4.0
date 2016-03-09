namespace Snake_4._0
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.PB_Game = new System.Windows.Forms.PictureBox();
            this.TM_Update = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Game)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_Game
            // 
            this.PB_Game.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_Game.Location = new System.Drawing.Point(0, 0);
            this.PB_Game.Name = "PB_Game";
            this.PB_Game.Size = new System.Drawing.Size(683, 557);
            this.PB_Game.TabIndex = 0;
            this.PB_Game.TabStop = false;
            this.PB_Game.Paint += new System.Windows.Forms.PaintEventHandler(this.PB_Game_Paint);
            this.PB_Game.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PB_Game_MouseDown);
            // 
            // TM_Update
            // 
            this.TM_Update.Enabled = true;
            this.TM_Update.Interval = 10;
            this.TM_Update.Tick += new System.EventHandler(this.TM_Update_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 557);
            this.Controls.Add(this.PB_Game);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Game)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Game;
        private System.Windows.Forms.Timer TM_Update;
    }
}

