
namespace KinoRezervacija
{
    partial class HallForm
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
            this.SeatsFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.HallNameLB = new System.Windows.Forms.Label();
            this.MovieTitleLB = new System.Windows.Forms.Label();
            this.PriceLB = new System.Windows.Forms.Label();
            this.BuyBtn = new System.Windows.Forms.Button();
            this.SinglePriceLB = new System.Windows.Forms.Label();
            this.GenreLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.SeatsFlowLayout.Location = new System.Drawing.Point(0, 88);
            this.SeatsFlowLayout.Name = "flowLayoutPanel1";
            this.SeatsFlowLayout.Size = new System.Drawing.Size(1070, 327);
            this.SeatsFlowLayout.TabIndex = 0;
            // 
            // HallNameLB
            // 
            this.HallNameLB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HallNameLB.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HallNameLB.Location = new System.Drawing.Point(12, 9);
            this.HallNameLB.Name = "HallNameLB";
            this.HallNameLB.Size = new System.Drawing.Size(1046, 45);
            this.HallNameLB.TabIndex = 1;
            this.HallNameLB.Text = "Hall";
            this.HallNameLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MovieTitleLB
            // 
            this.MovieTitleLB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovieTitleLB.Location = new System.Drawing.Point(0, 54);
            this.MovieTitleLB.Name = "MovieTitleLB";
            this.MovieTitleLB.Size = new System.Drawing.Size(1070, 31);
            this.MovieTitleLB.TabIndex = 2;
            this.MovieTitleLB.Text = "Movie Title";
            this.MovieTitleLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriceLB
            // 
            this.PriceLB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PriceLB.Location = new System.Drawing.Point(0, 418);
            this.PriceLB.Name = "PriceLB";
            this.PriceLB.Size = new System.Drawing.Size(1070, 48);
            this.PriceLB.TabIndex = 3;
            this.PriceLB.Text = "Count: 0 To pay: 0 ден";
            this.PriceLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BuyBtn
            // 
            this.BuyBtn.Location = new System.Drawing.Point(898, 418);
            this.BuyBtn.Name = "BuyBtn";
            this.BuyBtn.Size = new System.Drawing.Size(172, 48);
            this.BuyBtn.TabIndex = 4;
            this.BuyBtn.Text = "Buy";
            this.BuyBtn.UseVisualStyleBackColor = true;
            this.BuyBtn.Click += new System.EventHandler(this.BuyBtn_Click);
            // 
            // SinglePriceLB
            // 
            this.SinglePriceLB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SinglePriceLB.Location = new System.Drawing.Point(898, 54);
            this.SinglePriceLB.Name = "SinglePriceLB";
            this.SinglePriceLB.Size = new System.Drawing.Size(172, 31);
            this.SinglePriceLB.TabIndex = 5;
            this.SinglePriceLB.Text = "Price: 0";
            this.SinglePriceLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GenreLB
            // 
            this.GenreLB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GenreLB.Location = new System.Drawing.Point(0, 54);
            this.GenreLB.Name = "GenreLB";
            this.GenreLB.Size = new System.Drawing.Size(172, 31);
            this.GenreLB.TabIndex = 6;
            this.GenreLB.Text = "Genre: ";
            this.GenreLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HallForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1070, 464);
            this.Controls.Add(this.SeatsFlowLayout);
            this.Controls.Add(this.GenreLB);
            this.Controls.Add(this.SinglePriceLB);
            this.Controls.Add(this.BuyBtn);
            this.Controls.Add(this.PriceLB);
            this.Controls.Add(this.MovieTitleLB);
            this.Controls.Add(this.HallNameLB);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HallForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label HallNameLB;
        private System.Windows.Forms.Label MovieTitleLB;
        private System.Windows.Forms.Label PriceLB;
        private System.Windows.Forms.Button BuyBtn;
        private System.Windows.Forms.Label SinglePriceLB;
        private System.Windows.Forms.Label GenreLB;
        private System.Windows.Forms.FlowLayoutPanel SeatsFlowLayout;
    }
}