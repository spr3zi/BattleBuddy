
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
            this.lblRoundCount = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblTurnOrder = new System.Windows.Forms.Label();
            this.btnEndFight = new System.Windows.Forms.Button();
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
            this.dataGridCombat.Size = new System.Drawing.Size(367, 579);
            this.dataGridCombat.TabIndex = 0;
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Location = new System.Drawing.Point(391, 20);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(45, 13);
            this.lblRound.TabIndex = 1;
            this.lblRound.Text = "Round: ";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Location = new System.Drawing.Point(391, 63);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(32, 13);
            this.lblTurn.TabIndex = 2;
            this.lblTurn.Text = "Turn:";
            // 
            // txtBoxHealth
            // 
            this.txtBoxHealth.Location = new System.Drawing.Point(394, 260);
            this.txtBoxHealth.Name = "txtBoxHealth";
            this.txtBoxHealth.Size = new System.Drawing.Size(104, 20);
            this.txtBoxHealth.TabIndex = 3;
            // 
            // btnHeal
            // 
            this.btnHeal.Location = new System.Drawing.Point(394, 230);
            this.btnHeal.Name = "btnHeal";
            this.btnHeal.Size = new System.Drawing.Size(104, 23);
            this.btnHeal.TabIndex = 4;
            this.btnHeal.Text = "Heal";
            this.btnHeal.UseVisualStyleBackColor = true;
            this.btnHeal.Click += new System.EventHandler(this.btnHeal_Click);
            // 
            // btnDamage
            // 
            this.btnDamage.Location = new System.Drawing.Point(394, 286);
            this.btnDamage.Name = "btnDamage";
            this.btnDamage.Size = new System.Drawing.Size(104, 23);
            this.btnDamage.TabIndex = 5;
            this.btnDamage.Text = "Damage";
            this.btnDamage.UseVisualStyleBackColor = true;
            this.btnDamage.Click += new System.EventHandler(this.btnDamage_Click);
            // 
            // lblRoundCount
            // 
            this.lblRoundCount.AutoSize = true;
            this.lblRoundCount.Location = new System.Drawing.Point(440, 20);
            this.lblRoundCount.Name = "lblRoundCount";
            this.lblRoundCount.Size = new System.Drawing.Size(13, 13);
            this.lblRoundCount.TabIndex = 6;
            this.lblRoundCount.Text = "1";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(394, 119);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(104, 23);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblTurnOrder
            // 
            this.lblTurnOrder.AutoSize = true;
            this.lblTurnOrder.Location = new System.Drawing.Point(401, 89);
            this.lblTurnOrder.Name = "lblTurnOrder";
            this.lblTurnOrder.Size = new System.Drawing.Size(29, 13);
            this.lblTurnOrder.TabIndex = 8;
            this.lblTurnOrder.Text = "Turn";
            // 
            // btnEndFight
            // 
            this.btnEndFight.Location = new System.Drawing.Point(394, 561);
            this.btnEndFight.Name = "btnEndFight";
            this.btnEndFight.Size = new System.Drawing.Size(104, 23);
            this.btnEndFight.TabIndex = 9;
            this.btnEndFight.Text = "End Battle";
            this.btnEndFight.UseVisualStyleBackColor = true;
            this.btnEndFight.Click += new System.EventHandler(this.btnEndFight_Click);
            // 
            // Combat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 596);
            this.Controls.Add(this.btnEndFight);
            this.Controls.Add(this.lblTurnOrder);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblRoundCount);
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
        private System.Windows.Forms.Label lblRoundCount;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblTurnOrder;
        private System.Windows.Forms.Button btnEndFight;
    }
}