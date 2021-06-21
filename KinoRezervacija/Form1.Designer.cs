
namespace KinoRezervacija
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addMovieBtn = new System.Windows.Forms.Button();
            this.MovieLB = new System.Windows.Forms.ListBox();
            this.BuyTicketBtn = new System.Windows.Forms.Button();
            this.MovieDetailsRTX = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.FilterCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SortCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AscendCheckB = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addMovieBtn
            // 
            this.addMovieBtn.Location = new System.Drawing.Point(12, 363);
            this.addMovieBtn.Name = "addMovieBtn";
            this.addMovieBtn.Size = new System.Drawing.Size(133, 29);
            this.addMovieBtn.TabIndex = 0;
            this.addMovieBtn.Text = "add movie to cinema";
            this.addMovieBtn.UseVisualStyleBackColor = true;
            this.addMovieBtn.Click += new System.EventHandler(this.addMovieBtn_Click);
            // 
            // MovieLB
            // 
            this.MovieLB.FormattingEnabled = true;
            this.MovieLB.ItemHeight = 15;
            this.MovieLB.Location = new System.Drawing.Point(12, 53);
            this.MovieLB.Name = "MovieLB";
            this.MovieLB.Size = new System.Drawing.Size(502, 304);
            this.MovieLB.TabIndex = 1;
            this.MovieLB.SelectedIndexChanged += new System.EventHandler(this.MovieLB_SelectedIndexChanged);
            // 
            // BuyTicketBtn
            // 
            this.BuyTicketBtn.Location = new System.Drawing.Point(520, 363);
            this.BuyTicketBtn.Name = "BuyTicketBtn";
            this.BuyTicketBtn.Size = new System.Drawing.Size(268, 29);
            this.BuyTicketBtn.TabIndex = 2;
            this.BuyTicketBtn.Text = "Buy Ticket";
            this.BuyTicketBtn.UseVisualStyleBackColor = true;
            this.BuyTicketBtn.Click += new System.EventHandler(this.BuyTicketBtn_Click);
            // 
            // MovieDetailsRTX
            // 
            this.MovieDetailsRTX.Location = new System.Drawing.Point(520, 12);
            this.MovieDetailsRTX.Name = "MovieDetailsRTX";
            this.MovieDetailsRTX.Size = new System.Drawing.Size(268, 345);
            this.MovieDetailsRTX.TabIndex = 4;
            this.MovieDetailsRTX.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(224, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cinema";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "add hall";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FilterCB
            // 
            this.FilterCB.FormattingEnabled = true;
            this.FilterCB.Location = new System.Drawing.Point(12, 27);
            this.FilterCB.Name = "FilterCB";
            this.FilterCB.Size = new System.Drawing.Size(150, 23);
            this.FilterCB.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Filter by Genre";
            // 
            // SortCB
            // 
            this.SortCB.FormattingEnabled = true;
            this.SortCB.Location = new System.Drawing.Point(393, 27);
            this.SortCB.Name = "SortCB";
            this.SortCB.Size = new System.Drawing.Size(121, 23);
            this.SortCB.TabIndex = 9;
            this.SortCB.SelectedIndexChanged += new System.EventHandler(this.SortCB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sort by";
            // 
            // AscendCheckB
            // 
            this.AscendCheckB.AutoSize = true;
            this.AscendCheckB.Checked = true;
            this.AscendCheckB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AscendCheckB.Location = new System.Drawing.Point(361, 31);
            this.AscendCheckB.Name = "AscendCheckB";
            this.AscendCheckB.Size = new System.Drawing.Size(15, 14);
            this.AscendCheckB.TabIndex = 11;
            this.AscendCheckB.UseVisualStyleBackColor = true;
            this.AscendCheckB.CheckStateChanged += new System.EventHandler(this.AscendCheckB_CheckStateChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ascend";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 402);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AscendCheckB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SortCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilterCB);
            this.Controls.Add(this.MovieDetailsRTX);
            this.Controls.Add(this.BuyTicketBtn);
            this.Controls.Add(this.MovieLB);
            this.Controls.Add(this.addMovieBtn);
            this.Name = "Form1";
            this.Text = "W";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addMovieBtn;
        private System.Windows.Forms.ListBox MovieLB;
        private System.Windows.Forms.Button BuyTicketBtn;
        private System.Windows.Forms.RichTextBox MovieDetailsRTX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox FilterCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SortCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button M;
        private System.Windows.Forms.Button A;
        private System.Windows.Forms.CheckBox AscendCheckB;
        private System.Windows.Forms.Label label4;
    }
}

