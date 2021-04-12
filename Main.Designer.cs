
namespace BattleBuddy
{
    partial class Main
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
            this.dataGridActive = new System.Windows.Forms.DataGridView();
            this.DBTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridPlayerAdd = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridMonsterAdd = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblCombatTracker = new System.Windows.Forms.Label();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActive)).BeginInit();
            this.DBTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPlayerAdd)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMonsterAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridActive
            // 
            this.dataGridActive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridActive.Location = new System.Drawing.Point(12, 56);
            this.dataGridActive.Name = "dataGridActive";
            this.dataGridActive.Size = new System.Drawing.Size(167, 523);
            this.dataGridActive.TabIndex = 0;
            // 
            // DBTabControl
            // 
            this.DBTabControl.Controls.Add(this.tabPage1);
            this.DBTabControl.Controls.Add(this.tabPage2);
            this.DBTabControl.Location = new System.Drawing.Point(308, 34);
            this.DBTabControl.Name = "DBTabControl";
            this.DBTabControl.SelectedIndex = 0;
            this.DBTabControl.Size = new System.Drawing.Size(190, 545);
            this.DBTabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridPlayerAdd);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(182, 519);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Players";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridPlayerAdd
            // 
            this.dataGridPlayerAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPlayerAdd.Location = new System.Drawing.Point(0, 0);
            this.dataGridPlayerAdd.Name = "dataGridPlayerAdd";
            this.dataGridPlayerAdd.Size = new System.Drawing.Size(179, 567);
            this.dataGridPlayerAdd.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridMonsterAdd);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(182, 519);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Monsters";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridMonsterAdd
            // 
            this.dataGridMonsterAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMonsterAdd.Location = new System.Drawing.Point(1, 0);
            this.dataGridMonsterAdd.Name = "dataGridMonsterAdd";
            this.dataGridMonsterAdd.Size = new System.Drawing.Size(178, 564);
            this.dataGridMonsterAdd.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.btnAdd.Location = new System.Drawing.Point(185, 247);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "<< Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.btnRemove.Location = new System.Drawing.Point(185, 276);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(117, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove >>";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblCombatTracker
            // 
            this.lblCombatTracker.AutoSize = true;
            this.lblCombatTracker.Location = new System.Drawing.Point(48, 34);
            this.lblCombatTracker.Name = "lblCombatTracker";
            this.lblCombatTracker.Size = new System.Drawing.Size(63, 13);
            this.lblCombatTracker.TabIndex = 4;
            this.lblCombatTracker.Text = "Combatants";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(309, 9);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(102, 13);
            this.lblDatabase.TabIndex = 5;
            this.lblDatabase.Text = "Character Database";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(185, 468);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(117, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start Battle!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 642);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.lblCombatTracker);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.DBTabControl);
            this.Controls.Add(this.dataGridActive);
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActive)).EndInit();
            this.DBTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPlayerAdd)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMonsterAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridActive;
        private System.Windows.Forms.TabControl DBTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridPlayerAdd;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridMonsterAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblCombatTracker;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Button btnStart;
    }
}