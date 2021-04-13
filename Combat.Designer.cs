
namespace BattleBuddy
{
    partial class Combat
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
            this.dataGridCombat = new System.Windows.Forms.DataGridView();
            this.lblRound = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.txtBoxHealth = new System.Windows.Forms.TextBox();
            this.btnHeal = new System.Windows.Forms.Button();
            this.btnDamage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCombat)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCombat
            // 
            this.dataGridCombat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridCombat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCombat.Location = new System.Drawing.Point(12, 12);
            this.dataGridCombat.Name = "dataGridCombat";
            this.dataGridCombat.ReadOnly = true;
            this.dataGridCombat.Size = new System.Drawing.Size(384, 579);
            this.dataGridCombat.TabIndex = 0;
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Location = new System.Drawing.Point(402, 20);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(45, 13);
            this.lblRound.TabIndex = 1;
            this.lblRound.Text = "Round: ";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Location = new System.Drawing.Point(402, 63);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(32, 13);
            this.lblTurn.TabIndex = 2;
            this.lblTurn.Text = "Turn:";
            // 
            // txtBoxHealth
            // 
            this.txtBoxHealth.Location = new System.Drawing.Point(405, 151);
            this.txtBoxHealth.Name = "txtBoxHealth";
            this.txtBoxHealth.Size = new System.Drawing.Size(83, 20);
            this.txtBoxHealth.TabIndex = 3;
            // 
            // btnHeal
            // 
            this.btnHeal.Location = new System.Drawing.Point(405, 121);
            this.btnHeal.Name = "btnHeal";
            this.btnHeal.Size = new System.Drawing.Size(83, 23);
            this.btnHeal.TabIndex = 4;
            this.btnHeal.Text = "Heal";
            this.btnHeal.UseVisualStyleBackColor = true;
            this.btnHeal.Click += new System.EventHandler(this.btnHeal_Click);
            // 
            // btnDamage
            // 
            this.btnDamage.Location = new System.Drawing.Point(405, 177);
            this.btnDamage.Name = "btnDamage";
            this.btnDamage.Size = new System.Drawing.Size(82, 23);
            this.btnDamage.TabIndex = 5;
            this.btnDamage.Text = "Damage";
            this.btnDamage.UseVisualStyleBackColor = true;
            this.btnDamage.Click += new System.EventHandler(this.btnDamage_Click);
            // 
            // Combat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 608);
            this.Controls.Add(this.btnDamage);
            this.Controls.Add(this.btnHeal);
            this.Controls.Add(this.txtBoxHealth);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.dataGridCombat);
            this.Name = "Combat";
            this.Text = "Combat";
            this.Load += new System.EventHandler(this.Combat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCombat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCombat;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.TextBox txtBoxHealth;
        private System.Windows.Forms.Button btnHeal;
        private System.Windows.Forms.Button btnDamage;
    }
}