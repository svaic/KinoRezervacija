
namespace KinoRezervacija
{
    partial class AddMovie
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbRegisseur = new System.Windows.Forms.TextBox();
            this.listGenre = new System.Windows.Forms.ComboBox();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.listHalls = new System.Windows.Forms.ComboBox();
            this.CreatedMoviesBeforeCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Regisseur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Genre";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(113, 9);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(199, 27);
            this.tbName.TabIndex = 4;
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            // 
            // tbRegisseur
            // 
            this.tbRegisseur.Location = new System.Drawing.Point(113, 55);
            this.tbRegisseur.Name = "tbRegisseur";
            this.tbRegisseur.Size = new System.Drawing.Size(199, 27);
            this.tbRegisseur.TabIndex = 7;
            this.tbRegisseur.Validating += new System.ComponentModel.CancelEventHandler(this.tbRegisseur_Validating);
            // 
            // listGenre
            // 
            this.listGenre.FormattingEnabled = true;
            this.listGenre.Items.AddRange(new object[] {
            "Action",
            "Comedy",
            "Drama",
            "Documentary",
            "Fantasy"});
            this.listGenre.Location = new System.Drawing.Point(113, 155);
            this.listGenre.Name = "listGenre";
            this.listGenre.Size = new System.Drawing.Size(199, 28);
            this.listGenre.TabIndex = 8;
            this.listGenre.Validating += new System.ComponentModel.CancelEventHandler(this.listGenre_Validating);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(43, 303);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(94, 29);
            this.btnAddMovie.TabIndex = 9;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(176, 303);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // numPrice
            // 
            this.numPrice.Location = new System.Drawing.Point(113, 103);
            this.numPrice.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(199, 27);
            this.numPrice.TabIndex = 11;
            this.numPrice.Validating += new System.ComponentModel.CancelEventHandler(this.numPrice_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Hall";
            // 
            // listHalls
            // 
            this.listHalls.FormattingEnabled = true;
            this.listHalls.Location = new System.Drawing.Point(113, 200);
            this.listHalls.Name = "listHalls";
            this.listHalls.Size = new System.Drawing.Size(199, 28);
            this.listHalls.TabIndex = 13;
            this.listHalls.Validating += new System.ComponentModel.CancelEventHandler(this.listHalls_Validating);
            // 
            // CreatedMoviesBeforeCB
            // 
            this.CreatedMoviesBeforeCB.FormattingEnabled = true;
            this.CreatedMoviesBeforeCB.Location = new System.Drawing.Point(11, 265);
            this.CreatedMoviesBeforeCB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreatedMoviesBeforeCB.Name = "CreatedMoviesBeforeCB";
            this.CreatedMoviesBeforeCB.Size = new System.Drawing.Size(301, 28);
            this.CreatedMoviesBeforeCB.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Add an already created movie";
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 347);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CreatedMoviesBeforeCB);
            this.Controls.Add(this.listHalls);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.listGenre);
            this.Controls.Add(this.tbRegisseur);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddMovie";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbRegisseur;
        private System.Windows.Forms.ComboBox listGenre;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.ComboBox listHalls;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CreatedMoviesBeforeCB;
    }
}