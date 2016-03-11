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
            this.Gb_Shop = new System.Windows.Forms.GroupBox();
            this.LB_GoldNum = new System.Windows.Forms.Label();
            this.Lb_Gold = new System.Windows.Forms.Label();
            this.Bt_CloseShop = new System.Windows.Forms.Button();
            this.Gb_PlayerUpgrades = new System.Windows.Forms.GroupBox();
            this.Bt_GoldMultiplier = new System.Windows.Forms.Button();
            this.Bt_PickUpRange = new System.Windows.Forms.Button();
            this.Bt_Speed = new System.Windows.Forms.Button();
            this.Bt_Health = new System.Windows.Forms.Button();
            this.Lb_GoldMultiplierNum = new System.Windows.Forms.Label();
            this.Lb_GoldMultiplier = new System.Windows.Forms.Label();
            this.Lb_PickUpRangeNum = new System.Windows.Forms.Label();
            this.Lb_SpeedNum = new System.Windows.Forms.Label();
            this.Lb_HealthNum = new System.Windows.Forms.Label();
            this.Lb_Health = new System.Windows.Forms.Label();
            this.Lb_PickUpRange = new System.Windows.Forms.Label();
            this.Lb_Speed = new System.Windows.Forms.Label();
            this.Gb_GunUpgrades = new System.Windows.Forms.GroupBox();
            this.Bt_Firerate = new System.Windows.Forms.Button();
            this.Bt_BSpeed = new System.Windows.Forms.Button();
            this.Bt_Damage = new System.Windows.Forms.Button();
            this.Lb_FirerateNum = new System.Windows.Forms.Label();
            this.Lb_BSpeedNum = new System.Windows.Forms.Label();
            this.Lb_DamageNum = new System.Windows.Forms.Label();
            this.Lb_Damage = new System.Windows.Forms.Label();
            this.Lb_Firerate = new System.Windows.Forms.Label();
            this.Lb_BSpeed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Game)).BeginInit();
            this.Gb_Shop.SuspendLayout();
            this.Gb_PlayerUpgrades.SuspendLayout();
            this.Gb_GunUpgrades.SuspendLayout();
            this.SuspendLayout();
            // 
            // PB_Game
            // 
            this.PB_Game.BackColor = System.Drawing.Color.Silver;
            this.PB_Game.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_Game.Location = new System.Drawing.Point(0, 0);
            this.PB_Game.Name = "PB_Game";
            this.PB_Game.Size = new System.Drawing.Size(984, 711);
            this.PB_Game.TabIndex = 0;
            this.PB_Game.TabStop = false;
            this.PB_Game.Paint += new System.Windows.Forms.PaintEventHandler(this.PB_Game_Paint);
            this.PB_Game.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PB_Game_MouseDown);
            this.PB_Game.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PB_Game_MouseUp);
            // 
            // TM_Update
            // 
            this.TM_Update.Enabled = true;
            this.TM_Update.Interval = 10;
            this.TM_Update.Tick += new System.EventHandler(this.TM_Update_Tick);
            // 
            // Gb_Shop
            // 
            this.Gb_Shop.Controls.Add(this.LB_GoldNum);
            this.Gb_Shop.Controls.Add(this.Lb_Gold);
            this.Gb_Shop.Controls.Add(this.Bt_CloseShop);
            this.Gb_Shop.Controls.Add(this.Gb_PlayerUpgrades);
            this.Gb_Shop.Controls.Add(this.Gb_GunUpgrades);
            this.Gb_Shop.Enabled = false;
            this.Gb_Shop.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gb_Shop.Location = new System.Drawing.Point(350, 109);
            this.Gb_Shop.Name = "Gb_Shop";
            this.Gb_Shop.Size = new System.Drawing.Size(243, 371);
            this.Gb_Shop.TabIndex = 1;
            this.Gb_Shop.TabStop = false;
            this.Gb_Shop.Text = "Shop";
            this.Gb_Shop.Visible = false;
            // 
            // LB_GoldNum
            // 
            this.LB_GoldNum.AutoSize = true;
            this.LB_GoldNum.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_GoldNum.Location = new System.Drawing.Point(71, 338);
            this.LB_GoldNum.Name = "LB_GoldNum";
            this.LB_GoldNum.Size = new System.Drawing.Size(19, 19);
            this.LB_GoldNum.TabIndex = 13;
            this.LB_GoldNum.Text = "1";
            // 
            // Lb_Gold
            // 
            this.Lb_Gold.AutoSize = true;
            this.Lb_Gold.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Gold.Location = new System.Drawing.Point(12, 338);
            this.Lb_Gold.Name = "Lb_Gold";
            this.Lb_Gold.Size = new System.Drawing.Size(53, 19);
            this.Lb_Gold.TabIndex = 13;
            this.Lb_Gold.Text = "Gold:";
            // 
            // Bt_CloseShop
            // 
            this.Bt_CloseShop.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_CloseShop.Location = new System.Drawing.Point(158, 334);
            this.Bt_CloseShop.Name = "Bt_CloseShop";
            this.Bt_CloseShop.Size = new System.Drawing.Size(79, 26);
            this.Bt_CloseShop.TabIndex = 7;
            this.Bt_CloseShop.Text = "Close";
            this.Bt_CloseShop.UseVisualStyleBackColor = true;
            this.Bt_CloseShop.Click += new System.EventHandler(this.Bt_CloseShop_Click);
            // 
            // Gb_PlayerUpgrades
            // 
            this.Gb_PlayerUpgrades.Controls.Add(this.Bt_GoldMultiplier);
            this.Gb_PlayerUpgrades.Controls.Add(this.Bt_PickUpRange);
            this.Gb_PlayerUpgrades.Controls.Add(this.Bt_Speed);
            this.Gb_PlayerUpgrades.Controls.Add(this.Bt_Health);
            this.Gb_PlayerUpgrades.Controls.Add(this.Lb_GoldMultiplierNum);
            this.Gb_PlayerUpgrades.Controls.Add(this.Lb_GoldMultiplier);
            this.Gb_PlayerUpgrades.Controls.Add(this.Lb_PickUpRangeNum);
            this.Gb_PlayerUpgrades.Controls.Add(this.Lb_SpeedNum);
            this.Gb_PlayerUpgrades.Controls.Add(this.Lb_HealthNum);
            this.Gb_PlayerUpgrades.Controls.Add(this.Lb_Health);
            this.Gb_PlayerUpgrades.Controls.Add(this.Lb_PickUpRange);
            this.Gb_PlayerUpgrades.Controls.Add(this.Lb_Speed);
            this.Gb_PlayerUpgrades.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gb_PlayerUpgrades.Location = new System.Drawing.Point(6, 164);
            this.Gb_PlayerUpgrades.Name = "Gb_PlayerUpgrades";
            this.Gb_PlayerUpgrades.Size = new System.Drawing.Size(231, 160);
            this.Gb_PlayerUpgrades.TabIndex = 6;
            this.Gb_PlayerUpgrades.TabStop = false;
            this.Gb_PlayerUpgrades.Text = "Player Upgrades";
            // 
            // Bt_GoldMultiplier
            // 
            this.Bt_GoldMultiplier.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_GoldMultiplier.Location = new System.Drawing.Point(162, 122);
            this.Bt_GoldMultiplier.Name = "Bt_GoldMultiplier";
            this.Bt_GoldMultiplier.Size = new System.Drawing.Size(63, 23);
            this.Bt_GoldMultiplier.TabIndex = 12;
            this.Bt_GoldMultiplier.Text = "Upgrade";
            this.Bt_GoldMultiplier.UseVisualStyleBackColor = true;
            // 
            // Bt_PickUpRange
            // 
            this.Bt_PickUpRange.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_PickUpRange.Location = new System.Drawing.Point(162, 90);
            this.Bt_PickUpRange.Name = "Bt_PickUpRange";
            this.Bt_PickUpRange.Size = new System.Drawing.Size(63, 23);
            this.Bt_PickUpRange.TabIndex = 11;
            this.Bt_PickUpRange.Text = "Upgrade";
            this.Bt_PickUpRange.UseVisualStyleBackColor = true;
            // 
            // Bt_Speed
            // 
            this.Bt_Speed.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Speed.Location = new System.Drawing.Point(162, 61);
            this.Bt_Speed.Name = "Bt_Speed";
            this.Bt_Speed.Size = new System.Drawing.Size(63, 23);
            this.Bt_Speed.TabIndex = 10;
            this.Bt_Speed.Text = "Upgrade";
            this.Bt_Speed.UseVisualStyleBackColor = true;
            // 
            // Bt_Health
            // 
            this.Bt_Health.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Health.Location = new System.Drawing.Point(162, 32);
            this.Bt_Health.Name = "Bt_Health";
            this.Bt_Health.Size = new System.Drawing.Size(63, 23);
            this.Bt_Health.TabIndex = 9;
            this.Bt_Health.Text = "Upgrade";
            this.Bt_Health.UseVisualStyleBackColor = true;
            // 
            // Lb_GoldMultiplierNum
            // 
            this.Lb_GoldMultiplierNum.AutoSize = true;
            this.Lb_GoldMultiplierNum.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_GoldMultiplierNum.Location = new System.Drawing.Point(125, 123);
            this.Lb_GoldMultiplierNum.Name = "Lb_GoldMultiplierNum";
            this.Lb_GoldMultiplierNum.Size = new System.Drawing.Size(16, 18);
            this.Lb_GoldMultiplierNum.TabIndex = 7;
            this.Lb_GoldMultiplierNum.Text = "1";
            // 
            // Lb_GoldMultiplier
            // 
            this.Lb_GoldMultiplier.AutoSize = true;
            this.Lb_GoldMultiplier.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_GoldMultiplier.Location = new System.Drawing.Point(6, 123);
            this.Lb_GoldMultiplier.Name = "Lb_GoldMultiplier";
            this.Lb_GoldMultiplier.Size = new System.Drawing.Size(105, 18);
            this.Lb_GoldMultiplier.TabIndex = 6;
            this.Lb_GoldMultiplier.Text = "Gold Multiplier";
            // 
            // Lb_PickUpRangeNum
            // 
            this.Lb_PickUpRangeNum.AutoSize = true;
            this.Lb_PickUpRangeNum.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_PickUpRangeNum.Location = new System.Drawing.Point(125, 91);
            this.Lb_PickUpRangeNum.Name = "Lb_PickUpRangeNum";
            this.Lb_PickUpRangeNum.Size = new System.Drawing.Size(24, 18);
            this.Lb_PickUpRangeNum.TabIndex = 5;
            this.Lb_PickUpRangeNum.Text = "16";
            // 
            // Lb_SpeedNum
            // 
            this.Lb_SpeedNum.AutoSize = true;
            this.Lb_SpeedNum.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_SpeedNum.Location = new System.Drawing.Point(125, 62);
            this.Lb_SpeedNum.Name = "Lb_SpeedNum";
            this.Lb_SpeedNum.Size = new System.Drawing.Size(24, 18);
            this.Lb_SpeedNum.TabIndex = 4;
            this.Lb_SpeedNum.Text = "16";
            // 
            // Lb_HealthNum
            // 
            this.Lb_HealthNum.AutoSize = true;
            this.Lb_HealthNum.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_HealthNum.Location = new System.Drawing.Point(125, 33);
            this.Lb_HealthNum.Name = "Lb_HealthNum";
            this.Lb_HealthNum.Size = new System.Drawing.Size(24, 18);
            this.Lb_HealthNum.TabIndex = 3;
            this.Lb_HealthNum.Text = "16";
            // 
            // Lb_Health
            // 
            this.Lb_Health.AutoSize = true;
            this.Lb_Health.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Health.Location = new System.Drawing.Point(6, 33);
            this.Lb_Health.Name = "Lb_Health";
            this.Lb_Health.Size = new System.Drawing.Size(52, 18);
            this.Lb_Health.TabIndex = 0;
            this.Lb_Health.Text = "Health";
            // 
            // Lb_PickUpRange
            // 
            this.Lb_PickUpRange.AutoSize = true;
            this.Lb_PickUpRange.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_PickUpRange.Location = new System.Drawing.Point(6, 91);
            this.Lb_PickUpRange.Name = "Lb_PickUpRange";
            this.Lb_PickUpRange.Size = new System.Drawing.Size(98, 18);
            this.Lb_PickUpRange.TabIndex = 2;
            this.Lb_PickUpRange.Text = "Pickup Range";
            // 
            // Lb_Speed
            // 
            this.Lb_Speed.AutoSize = true;
            this.Lb_Speed.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Speed.Location = new System.Drawing.Point(6, 62);
            this.Lb_Speed.Name = "Lb_Speed";
            this.Lb_Speed.Size = new System.Drawing.Size(118, 18);
            this.Lb_Speed.TabIndex = 1;
            this.Lb_Speed.Text = "Movement speed";
            // 
            // Gb_GunUpgrades
            // 
            this.Gb_GunUpgrades.Controls.Add(this.Bt_Firerate);
            this.Gb_GunUpgrades.Controls.Add(this.Bt_BSpeed);
            this.Gb_GunUpgrades.Controls.Add(this.Bt_Damage);
            this.Gb_GunUpgrades.Controls.Add(this.Lb_FirerateNum);
            this.Gb_GunUpgrades.Controls.Add(this.Lb_BSpeedNum);
            this.Gb_GunUpgrades.Controls.Add(this.Lb_DamageNum);
            this.Gb_GunUpgrades.Controls.Add(this.Lb_Damage);
            this.Gb_GunUpgrades.Controls.Add(this.Lb_Firerate);
            this.Gb_GunUpgrades.Controls.Add(this.Lb_BSpeed);
            this.Gb_GunUpgrades.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gb_GunUpgrades.Location = new System.Drawing.Point(6, 32);
            this.Gb_GunUpgrades.Name = "Gb_GunUpgrades";
            this.Gb_GunUpgrades.Size = new System.Drawing.Size(231, 126);
            this.Gb_GunUpgrades.TabIndex = 3;
            this.Gb_GunUpgrades.TabStop = false;
            this.Gb_GunUpgrades.Text = "Gun Upgrades";
            // 
            // Bt_Firerate
            // 
            this.Bt_Firerate.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Firerate.Location = new System.Drawing.Point(162, 90);
            this.Bt_Firerate.Name = "Bt_Firerate";
            this.Bt_Firerate.Size = new System.Drawing.Size(63, 23);
            this.Bt_Firerate.TabIndex = 8;
            this.Bt_Firerate.Text = "Upgrade";
            this.Bt_Firerate.UseVisualStyleBackColor = true;
            // 
            // Bt_BSpeed
            // 
            this.Bt_BSpeed.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_BSpeed.Location = new System.Drawing.Point(162, 61);
            this.Bt_BSpeed.Name = "Bt_BSpeed";
            this.Bt_BSpeed.Size = new System.Drawing.Size(63, 23);
            this.Bt_BSpeed.TabIndex = 7;
            this.Bt_BSpeed.Text = "Upgrade";
            this.Bt_BSpeed.UseVisualStyleBackColor = true;
            // 
            // Bt_Damage
            // 
            this.Bt_Damage.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Damage.Location = new System.Drawing.Point(162, 31);
            this.Bt_Damage.Name = "Bt_Damage";
            this.Bt_Damage.Size = new System.Drawing.Size(63, 23);
            this.Bt_Damage.TabIndex = 6;
            this.Bt_Damage.Text = "Upgrade";
            this.Bt_Damage.UseVisualStyleBackColor = true;
            // 
            // Lb_FirerateNum
            // 
            this.Lb_FirerateNum.AutoSize = true;
            this.Lb_FirerateNum.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_FirerateNum.Location = new System.Drawing.Point(125, 91);
            this.Lb_FirerateNum.Name = "Lb_FirerateNum";
            this.Lb_FirerateNum.Size = new System.Drawing.Size(24, 18);
            this.Lb_FirerateNum.TabIndex = 5;
            this.Lb_FirerateNum.Text = "16";
            // 
            // Lb_BSpeedNum
            // 
            this.Lb_BSpeedNum.AutoSize = true;
            this.Lb_BSpeedNum.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_BSpeedNum.Location = new System.Drawing.Point(125, 62);
            this.Lb_BSpeedNum.Name = "Lb_BSpeedNum";
            this.Lb_BSpeedNum.Size = new System.Drawing.Size(24, 18);
            this.Lb_BSpeedNum.TabIndex = 4;
            this.Lb_BSpeedNum.Text = "16";
            // 
            // Lb_DamageNum
            // 
            this.Lb_DamageNum.AutoSize = true;
            this.Lb_DamageNum.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_DamageNum.Location = new System.Drawing.Point(125, 32);
            this.Lb_DamageNum.Name = "Lb_DamageNum";
            this.Lb_DamageNum.Size = new System.Drawing.Size(24, 18);
            this.Lb_DamageNum.TabIndex = 3;
            this.Lb_DamageNum.Text = "16";
            // 
            // Lb_Damage
            // 
            this.Lb_Damage.AutoSize = true;
            this.Lb_Damage.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Damage.Location = new System.Drawing.Point(6, 32);
            this.Lb_Damage.Name = "Lb_Damage";
            this.Lb_Damage.Size = new System.Drawing.Size(62, 18);
            this.Lb_Damage.TabIndex = 0;
            this.Lb_Damage.Text = "Damage";
            // 
            // Lb_Firerate
            // 
            this.Lb_Firerate.AutoSize = true;
            this.Lb_Firerate.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Firerate.Location = new System.Drawing.Point(6, 91);
            this.Lb_Firerate.Name = "Lb_Firerate";
            this.Lb_Firerate.Size = new System.Drawing.Size(62, 18);
            this.Lb_Firerate.TabIndex = 2;
            this.Lb_Firerate.Text = "Firerate";
            // 
            // Lb_BSpeed
            // 
            this.Lb_BSpeed.AutoSize = true;
            this.Lb_BSpeed.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_BSpeed.Location = new System.Drawing.Point(6, 62);
            this.Lb_BSpeed.Name = "Lb_BSpeed";
            this.Lb_BSpeed.Size = new System.Drawing.Size(90, 18);
            this.Lb_BSpeed.TabIndex = 1;
            this.Lb_BSpeed.Text = "Bullet Speed";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.Gb_Shop);
            this.Controls.Add(this.PB_Game);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Game)).EndInit();
            this.Gb_Shop.ResumeLayout(false);
            this.Gb_Shop.PerformLayout();
            this.Gb_PlayerUpgrades.ResumeLayout(false);
            this.Gb_PlayerUpgrades.PerformLayout();
            this.Gb_GunUpgrades.ResumeLayout(false);
            this.Gb_GunUpgrades.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Game;
        private System.Windows.Forms.Timer TM_Update;
        private System.Windows.Forms.GroupBox Gb_Shop;
        private System.Windows.Forms.Label Lb_Firerate;
        private System.Windows.Forms.Label Lb_BSpeed;
        private System.Windows.Forms.Label Lb_Damage;
        private System.Windows.Forms.GroupBox Gb_PlayerUpgrades;
        private System.Windows.Forms.Label Lb_PickUpRangeNum;
        private System.Windows.Forms.Label Lb_SpeedNum;
        private System.Windows.Forms.Label Lb_HealthNum;
        private System.Windows.Forms.Label Lb_Health;
        private System.Windows.Forms.Label Lb_PickUpRange;
        private System.Windows.Forms.Label Lb_Speed;
        private System.Windows.Forms.GroupBox Gb_GunUpgrades;
        private System.Windows.Forms.Label Lb_FirerateNum;
        private System.Windows.Forms.Label Lb_BSpeedNum;
        private System.Windows.Forms.Label Lb_DamageNum;
        private System.Windows.Forms.Label Lb_GoldMultiplierNum;
        private System.Windows.Forms.Label Lb_GoldMultiplier;
        private System.Windows.Forms.Button Bt_GoldMultiplier;
        private System.Windows.Forms.Button Bt_PickUpRange;
        private System.Windows.Forms.Button Bt_Speed;
        private System.Windows.Forms.Button Bt_Health;
        private System.Windows.Forms.Button Bt_Firerate;
        private System.Windows.Forms.Button Bt_BSpeed;
        private System.Windows.Forms.Button Bt_Damage;
        private System.Windows.Forms.Label LB_GoldNum;
        private System.Windows.Forms.Label Lb_Gold;
        private System.Windows.Forms.Button Bt_CloseShop;
    }
}

