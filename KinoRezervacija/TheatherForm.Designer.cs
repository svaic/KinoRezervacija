
namespace KinoRezervacija
{
    partial class TheatherForm
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
            this.CinemaNameLB = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.FilterCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SortCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AscendCheckB = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ShowBillBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addMovieBtn
            // 
            this.addMovieBtn.Location = new System.Drawing.Point(14, 484);
            this.addMovieBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addMovieBtn.Name = "addMovieBtn";
            this.addMovieBtn.Size = new System.Drawing.Size(152, 39);
            this.addMovieBtn.TabIndex = 0;
            this.addMovieBtn.Text = "Add A Movie";
            this.addMovieBtn.UseVisualStyleBackColor = true;
            this.addMovieBtn.Click += new System.EventHandler(this.addMovieBtn_Click);
            // 
            // MovieLB
            // 
            this.MovieLB.FormattingEnabled = true;
            this.MovieLB.ItemHeight = 20;
            this.MovieLB.Location = new System.Drawing.Point(14, 71);
            this.MovieLB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MovieLB.Name = "MovieLB";
            this.MovieLB.Size = new System.Drawing.Size(573, 404);
            this.MovieLB.TabIndex = 1;
            this.MovieLB.SelectedIndexChanged += new System.EventHandler(this.MovieLB_SelectedIndexChanged);
            // 
            // BuyTicketBtn
            // 
            this.BuyTicketBtn.Location = new System.Drawing.Point(520, 363);
            this.BuyTicketBtn.Name = "BuyTicketBtn";
            this.BuyTicketBtn.Size = new System.Drawing.Size(306, 39);
            this.BuyTicketBtn.TabIndex = 2;
            this.BuyTicketBtn.Text = "Buy Ticket";
            this.BuyTicketBtn.UseVisualStyleBackColor = true;
            this.BuyTicketBtn.Click += new System.EventHandler(this.BuyTicketBtn_Click);
            // 
            // MovieDetailsRTX
            // 
            this.MovieDetailsRTX.Location = new System.Drawing.Point(594, 16);
            this.MovieDetailsRTX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MovieDetailsRTX.Name = "MovieDetailsRTX";
            this.MovieDetailsRTX.Size = new System.Drawing.Size(268, 345);
            this.MovieDetailsRTX.TabIndex = 4;
            this.MovieDetailsRTX.Text = "";
            // 
            // CinemaNameLB
            // 
            this.CinemaNameLB.AutoSize = true;
            this.CinemaNameLB.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CinemaNameLB.Location = new System.Drawing.Point(237, 12);
            this.CinemaNameLB.Name = "CinemaNameLB";
            this.CinemaNameLB.Size = new System.Drawing.Size(132, 46);
            this.CinemaNameLB.TabIndex = 6;
            this.CinemaNameLB.Text = "Cinema";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 484);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 39);
            this.button2.TabIndex = 7;
            this.button2.Text = "add hall";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FilterCB
            // 
            this.FilterCB.FormattingEnabled = true;
            this.FilterCB.Location = new System.Drawing.Point(14, 36);
            this.FilterCB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FilterCB.Name = "FilterCB";
            this.FilterCB.Size = new System.Drawing.Size(171, 28);
            this.FilterCB.TabIndex = 5;
            this.FilterCB.SelectionChangeCommitted += new System.EventHandler(this.FilterChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Filter by Genre";
            // 
            // SortCB
            // 
            this.SortCB.FormattingEnabled = true;
            this.SortCB.Location = new System.Drawing.Point(449, 36);
            this.SortCB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SortCB.Name = "SortCB";
            this.SortCB.Size = new System.Drawing.Size(138, 28);
            this.SortCB.TabIndex = 9;
            this.SortCB.SelectedIndexChanged += new System.EventHandler(this.SortCB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sort by";
            // 
            // AscendCheckB
            // 
            this.AscendCheckB.AutoSize = true;
            this.AscendCheckB.Checked = true;
            this.AscendCheckB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AscendCheckB.Location = new System.Drawing.Point(413, 41);
            this.AscendCheckB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AscendCheckB.Name = "AscendCheckB";
            this.AscendCheckB.Size = new System.Drawing.Size(18, 17);
            this.AscendCheckB.TabIndex = 11;
            this.AscendCheckB.UseVisualStyleBackColor = true;
            this.AscendCheckB.CheckStateChanged += new System.EventHandler(this.AscendCheckB_CheckStateChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ascend";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Food and Drinks";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowBillBtn
            // 
            this.ShowBillBtn.Location = new System.Drawing.Point(520, 363);
            this.ShowBillBtn.Name = "ShowBillBtn";
            this.ShowBillBtn.Size = new System.Drawing.Size(268, 29);
            this.ShowBillBtn.TabIndex = 14;
            this.ShowBillBtn.Text = "Show Bill";
            this.ShowBillBtn.UseVisualStyleBackColor = true;
            this.ShowBillBtn.Click += new System.EventHandler(this.ShowBillBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(258, 363);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 29);
            this.button3.TabIndex = 15;
            this.button3.Text = "Remove Movie";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // TheatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 402);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AscendCheckB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SortCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CinemaNameLB);
            this.Controls.Add(this.FilterCB);
            this.Controls.Add(this.MovieDetailsRTX);
            this.Controls.Add(this.BuyTicketBtn);
            this.Controls.Add(this.MovieLB);
            this.Controls.Add(this.addMovieBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TheatherForm";
            this.Text = "W";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addMovieBtn;
        private System.Windows.Forms.ListBox MovieLB;
        private System.Windows.Forms.Button BuyTicketBtn;
        private System.Windows.Forms.RichTextBox MovieDetailsRTX;
        private System.Windows.Forms.Label CinemaNameLB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox FilterCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SortCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button M;
        private System.Windows.Forms.Button A;
        private System.Windows.Forms.CheckBox AscendCheckB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ShowBillBtn;
        private System.Windows.Forms.Button button3;
    }
}

