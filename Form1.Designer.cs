
namespace BattleBuddy
{
    partial class FormDataSelect
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
            this.lblSelectBestiaryTitle = new System.Windows.Forms.Label();
            this.checkBoxMM = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.checkBoxHomebrew = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblSelectBestiaryTitle
            // 
            this.lblSelectBestiaryTitle.AutoSize = true;
            this.lblSelectBestiaryTitle.Location = new System.Drawing.Point(67, 51);
            this.lblSelectBestiaryTitle.Name = "lblSelectBestiaryTitle";
            this.lblSelectBestiaryTitle.Size = new System.Drawing.Size(80, 13);
            this.lblSelectBestiaryTitle.TabIndex = 0;
            this.lblSelectBestiaryTitle.Text = "Select Bestiary:";
            // 
            // checkBoxMM
            // 
            this.checkBoxMM.AutoSize = true;
            this.checkBoxMM.Location = new System.Drawing.Point(56, 94);
            this.checkBoxMM.Name = "checkBoxMM";
            this.checkBoxMM.Size = new System.Drawing.Size(102, 17);
            this.checkBoxMM.TabIndex = 1;
            this.checkBoxMM.Text = "Monster Manual";
            this.checkBoxMM.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(51, 239);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(107, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // checkBoxHomebrew
            // 
            this.checkBoxHomebrew.AutoSize = true;
            this.checkBoxHomebrew.Location = new System.Drawing.Point(56, 117);
            this.checkBoxHomebrew.Name = "checkBoxHomebrew";
            this.checkBoxHomebrew.Size = new System.Drawing.Size(77, 17);
            this.checkBoxHomebrew.TabIndex = 3;
            this.checkBoxHomebrew.Text = "Homebrew";
            this.checkBoxHomebrew.UseVisualStyleBackColor = true;
            // 
            // FormDataSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 293);
            this.Controls.Add(this.checkBoxHomebrew);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.checkBoxMM);
            this.Controls.Add(this.lblSelectBestiaryTitle);
            this.Name = "FormDataSelect";
            this.Text = "Select Bestiary";
            this.Load += new System.EventHandler(this.FormDataSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectBestiaryTitle;
        private System.Windows.Forms.CheckBox checkBoxMM;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox checkBoxHomebrew;
    }
}

