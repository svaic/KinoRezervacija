
namespace KinoRezervacija
{
    partial class BillForm
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
            this.MenuCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.SelectedMenuTB = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.FoodCB = new System.Windows.Forms.ComboBox();
            this.FoodAdditionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddFoodBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.DrinkCB = new System.Windows.Forms.ComboBox();
            this.DrinkAdditionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddDrinkBtn = new System.Windows.Forms.Button();
            this.FoodLB = new System.Windows.Forms.Label();
            this.DrinkLB = new System.Windows.Forms.Label();
            this.BillTB = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MoveToBillBtn = new System.Windows.Forms.Button();
            this.ClearMenuBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuCB
            // 
            this.MenuCB.FormattingEnabled = true;
            this.MenuCB.Location = new System.Drawing.Point(129, 43);
            this.MenuCB.Name = "MenuCB";
            this.MenuCB.Size = new System.Drawing.Size(231, 23);
            this.MenuCB.TabIndex = 0;
            this.MenuCB.SelectedIndexChanged += new System.EventHandler(this.MenuCBSelectedItemChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(3, 150);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(83, 14);
            this.checkBox3.TabIndex = 11;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(3, 150);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(83, 14);
            this.checkBox4.TabIndex = 12;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(3, 170);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(83, 15);
            this.checkBox5.TabIndex = 13;
            this.checkBox5.Text = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // SelectedMenuTB
            // 
            this.SelectedMenuTB.Location = new System.Drawing.Point(15, 265);
            this.SelectedMenuTB.Name = "SelectedMenuTB";
            this.SelectedMenuTB.Size = new System.Drawing.Size(210, 156);
            this.SelectedMenuTB.TabIndex = 3;
            this.SelectedMenuTB.Text = "";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "current menus";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.FoodCB);
            this.flowLayoutPanel1.Controls.Add(this.FoodAdditionPanel);
            this.flowLayoutPanel1.Controls.Add(this.AddFoodBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 83);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(225, 136);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // FoodCB
            // 
            this.FoodCB.FormattingEnabled = true;
            this.FoodCB.Location = new System.Drawing.Point(3, 3);
            this.FoodCB.Name = "FoodCB";
            this.FoodCB.Size = new System.Drawing.Size(222, 23);
            this.FoodCB.TabIndex = 0;
            this.FoodCB.SelectedIndexChanged += new System.EventHandler(this.FoodChanged);
            // 
            // FoodAdditionPanel
            // 
            this.FoodAdditionPanel.Location = new System.Drawing.Point(3, 32);
            this.FoodAdditionPanel.Name = "FoodAdditionPanel";
            this.FoodAdditionPanel.Size = new System.Drawing.Size(222, 66);
            this.FoodAdditionPanel.TabIndex = 2;
            // 
            // AddFoodBtn
            // 
            this.AddFoodBtn.Location = new System.Drawing.Point(3, 104);
            this.AddFoodBtn.Name = "AddFoodBtn";
            this.AddFoodBtn.Size = new System.Drawing.Size(223, 32);
            this.AddFoodBtn.TabIndex = 3;
            this.AddFoodBtn.Text = "add food";
            this.AddFoodBtn.UseVisualStyleBackColor = true;
            this.AddFoodBtn.Click += new System.EventHandler(this.AddFoodBtn_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.DrinkCB);
            this.flowLayoutPanel3.Controls.Add(this.DrinkAdditionPanel);
            this.flowLayoutPanel3.Controls.Add(this.AddDrinkBtn);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(248, 83);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(225, 136);
            this.flowLayoutPanel3.TabIndex = 6;
            // 
            // DrinkCB
            // 
            this.DrinkCB.FormattingEnabled = true;
            this.DrinkCB.Location = new System.Drawing.Point(3, 3);
            this.DrinkCB.Name = "DrinkCB";
            this.DrinkCB.Size = new System.Drawing.Size(222, 23);
            this.DrinkCB.TabIndex = 0;
            this.DrinkCB.SelectedIndexChanged += new System.EventHandler(this.DrinkChanged);
            // 
            // DrinkAdditionPanel
            // 
            this.DrinkAdditionPanel.Location = new System.Drawing.Point(3, 32);
            this.DrinkAdditionPanel.Name = "DrinkAdditionPanel";
            this.DrinkAdditionPanel.Size = new System.Drawing.Size(222, 66);
            this.DrinkAdditionPanel.TabIndex = 2;
            // 
            // AddDrinkBtn
            // 
            this.AddDrinkBtn.Location = new System.Drawing.Point(3, 104);
            this.AddDrinkBtn.Name = "AddDrinkBtn";
            this.AddDrinkBtn.Size = new System.Drawing.Size(223, 32);
            this.AddDrinkBtn.TabIndex = 3;
            this.AddDrinkBtn.Text = "add drink";
            this.AddDrinkBtn.UseVisualStyleBackColor = true;
            this.AddDrinkBtn.Click += new System.EventHandler(this.AddDrinkBtn_Click);
            // 
            // FoodLB
            // 
            this.FoodLB.AutoSize = true;
            this.FoodLB.Location = new System.Drawing.Point(96, 69);
            this.FoodLB.Name = "FoodLB";
            this.FoodLB.Size = new System.Drawing.Size(34, 15);
            this.FoodLB.TabIndex = 7;
            this.FoodLB.Text = "Food";
            // 
            // DrinkLB
            // 
            this.DrinkLB.AutoSize = true;
            this.DrinkLB.Location = new System.Drawing.Point(354, 69);
            this.DrinkLB.Name = "DrinkLB";
            this.DrinkLB.Size = new System.Drawing.Size(35, 15);
            this.DrinkLB.TabIndex = 8;
            this.DrinkLB.Text = "Drink";
            // 
            // BillTB
            // 
            this.BillTB.Location = new System.Drawing.Point(261, 265);
            this.BillTB.Name = "BillTB";
            this.BillTB.Size = new System.Drawing.Size(216, 156);
            this.BillTB.TabIndex = 9;
            this.BillTB.Text = "";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(251, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Bill";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MoveToBillBtn
            // 
            this.MoveToBillBtn.Location = new System.Drawing.Point(223, 265);
            this.MoveToBillBtn.Name = "MoveToBillBtn";
            this.MoveToBillBtn.Size = new System.Drawing.Size(39, 23);
            this.MoveToBillBtn.TabIndex = 11;
            this.MoveToBillBtn.Text = ">>";
            this.MoveToBillBtn.UseVisualStyleBackColor = true;
            this.MoveToBillBtn.Click += new System.EventHandler(this.MoveToBillBtn_Click);
            // 
            // ClearMenuBtn
            // 
            this.ClearMenuBtn.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearMenuBtn.Location = new System.Drawing.Point(222, 292);
            this.ClearMenuBtn.Name = "ClearMenuBtn";
            this.ClearMenuBtn.Size = new System.Drawing.Size(40, 23);
            this.ClearMenuBtn.TabIndex = 12;
            this.ClearMenuBtn.Text = "Clear";
            this.ClearMenuBtn.UseVisualStyleBackColor = true;
            this.ClearMenuBtn.Click += new System.EventHandler(this.ClearMenuBtn_Click);
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 433);
            this.Controls.Add(this.ClearMenuBtn);
            this.Controls.Add(this.MoveToBillBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BillTB);
            this.Controls.Add(this.DrinkLB);
            this.Controls.Add(this.FoodLB);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SelectedMenuTB);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuCB);
            this.Name = "BillForm";
            this.Text = "BillForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MenuCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.RichTextBox SelectedMenuTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox FoodCB;
        private System.Windows.Forms.Button AddFoodBtn;
        private System.Windows.Forms.FlowLayoutPanel FoodAdditionPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.ComboBox DrinkCB;
        private System.Windows.Forms.FlowLayoutPanel DrinkAdditionPanel;
        private System.Windows.Forms.Button AddDrinkBtn;
        private System.Windows.Forms.Label FoodLB;
        private System.Windows.Forms.Label DrinkLB;
        private System.Windows.Forms.RichTextBox BillTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MoveToBillBtn;
        private System.Windows.Forms.Button ClearMenuBtn;
    }
}