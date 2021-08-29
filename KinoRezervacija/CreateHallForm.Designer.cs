
namespace KinoRezervacija
{
    partial class CreateHallForm
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
            this.HallTypeCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateHallBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HallTypeCB
            // 
            this.HallTypeCB.FormattingEnabled = true;
            this.HallTypeCB.Location = new System.Drawing.Point(22, 30);
            this.HallTypeCB.Name = "HallTypeCB";
            this.HallTypeCB.Size = new System.Drawing.Size(162, 23);
            this.HallTypeCB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Size of Hall";
            // 
            // CreateHallBtn
            // 
            this.CreateHallBtn.Location = new System.Drawing.Point(22, 60);
            this.CreateHallBtn.Name = "CreateHallBtn";
            this.CreateHallBtn.Size = new System.Drawing.Size(79, 23);
            this.CreateHallBtn.TabIndex = 2;
            this.CreateHallBtn.Text = "Create hall";
            this.CreateHallBtn.UseVisualStyleBackColor = true;
            this.CreateHallBtn.Click += new System.EventHandler(this.CreateHallBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(105, 59);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(79, 23);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // CreateHallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 102);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.CreateHallBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HallTypeCB);
            this.Name = "CreateHallForm";
            this.Text = "CreateHallForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox HallTypeCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateHallBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}