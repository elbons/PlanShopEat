namespace PlanShopEat
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
            this.listBoxFoodChoices = new System.Windows.Forms.ListBox();
            this.labelFilter = new System.Windows.Forms.Label();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.groupBoxDishes = new System.Windows.Forms.GroupBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxWeekMenu = new System.Windows.Forms.GroupBox();
            this.labelMonday = new System.Windows.Forms.Label();
            this.listBoxMonday = new System.Windows.Forms.ListBox();
            this.labelTuesday = new System.Windows.Forms.Label();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.labelWednesday = new System.Windows.Forms.Label();
            this.listBoxWednesday = new System.Windows.Forms.ListBox();
            this.labelThurday = new System.Windows.Forms.Label();
            this.listBoxThurday = new System.Windows.Forms.ListBox();
            this.labelFriday = new System.Windows.Forms.Label();
            this.listBoxFriday = new System.Windows.Forms.ListBox();
            this.labelSaturday = new System.Windows.Forms.Label();
            this.listBoxSaturday = new System.Windows.Forms.ListBox();
            this.labelSunday = new System.Windows.Forms.Label();
            this.listBoxSunday = new System.Windows.Forms.ListBox();
            this.buttonPrintMenu = new System.Windows.Forms.Button();
            this.groupBoxDishes.SuspendLayout();
            this.groupBoxWeekMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxFoodChoices
            // 
            this.listBoxFoodChoices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listBoxFoodChoices.FormattingEnabled = true;
            this.listBoxFoodChoices.ItemHeight = 16;
            this.listBoxFoodChoices.Location = new System.Drawing.Point(13, 56);
            this.listBoxFoodChoices.Name = "listBoxFoodChoices";
            this.listBoxFoodChoices.Size = new System.Drawing.Size(280, 420);
            this.listBoxFoodChoices.TabIndex = 0;
            // 
            // labelFilter
            // 
            this.labelFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(10, 31);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(39, 17);
            this.labelFilter.TabIndex = 1;
            this.labelFilter.Text = "Filter";
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxFilter.Location = new System.Drawing.Point(51, 28);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(242, 22);
            this.textBoxFilter.TabIndex = 3;
            // 
            // groupBoxDishes
            // 
            this.groupBoxDishes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDishes.Controls.Add(this.labelCategory);
            this.groupBoxDishes.Controls.Add(this.comboBoxCategory);
            this.groupBoxDishes.Controls.Add(this.labelFilter);
            this.groupBoxDishes.Controls.Add(this.listBoxFoodChoices);
            this.groupBoxDishes.Controls.Add(this.textBoxFilter);
            this.groupBoxDishes.Location = new System.Drawing.Point(801, 12);
            this.groupBoxDishes.Name = "groupBoxDishes";
            this.groupBoxDishes.Size = new System.Drawing.Size(502, 492);
            this.groupBoxDishes.TabIndex = 4;
            this.groupBoxDishes.TabStop = false;
            this.groupBoxDishes.Text = "Dishes";
            // 
            // labelCategory
            // 
            this.labelCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(312, 56);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(65, 17);
            this.labelCategory.TabIndex = 5;
            this.labelCategory.Text = "Category";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(315, 76);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(181, 24);
            this.comboBoxCategory.TabIndex = 4;
            // 
            // groupBoxWeekMenu
            // 
            this.groupBoxWeekMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxWeekMenu.Controls.Add(this.labelMonday);
            this.groupBoxWeekMenu.Controls.Add(this.listBoxMonday);
            this.groupBoxWeekMenu.Controls.Add(this.labelTuesday);
            this.groupBoxWeekMenu.Controls.Add(this.listBox5);
            this.groupBoxWeekMenu.Controls.Add(this.labelWednesday);
            this.groupBoxWeekMenu.Controls.Add(this.listBoxWednesday);
            this.groupBoxWeekMenu.Controls.Add(this.labelThurday);
            this.groupBoxWeekMenu.Controls.Add(this.listBoxThurday);
            this.groupBoxWeekMenu.Controls.Add(this.labelFriday);
            this.groupBoxWeekMenu.Controls.Add(this.listBoxFriday);
            this.groupBoxWeekMenu.Controls.Add(this.labelSaturday);
            this.groupBoxWeekMenu.Controls.Add(this.listBoxSaturday);
            this.groupBoxWeekMenu.Controls.Add(this.labelSunday);
            this.groupBoxWeekMenu.Controls.Add(this.listBoxSunday);
            this.groupBoxWeekMenu.Location = new System.Drawing.Point(12, 12);
            this.groupBoxWeekMenu.Name = "groupBoxWeekMenu";
            this.groupBoxWeekMenu.Size = new System.Drawing.Size(361, 492);
            this.groupBoxWeekMenu.TabIndex = 5;
            this.groupBoxWeekMenu.TabStop = false;
            this.groupBoxWeekMenu.Text = "Weekly Menu";
            // 
            // labelMonday
            // 
            this.labelMonday.AutoSize = true;
            this.labelMonday.Location = new System.Drawing.Point(4, 145);
            this.labelMonday.Name = "labelMonday";
            this.labelMonday.Size = new System.Drawing.Size(58, 17);
            this.labelMonday.TabIndex = 13;
            this.labelMonday.Text = "Monday";
            // 
            // listBoxMonday
            // 
            this.listBoxMonday.FormattingEnabled = true;
            this.listBoxMonday.ItemHeight = 16;
            this.listBoxMonday.Location = new System.Drawing.Point(6, 165);
            this.listBoxMonday.Name = "listBoxMonday";
            this.listBoxMonday.Size = new System.Drawing.Size(120, 84);
            this.listBoxMonday.TabIndex = 12;
            // 
            // labelTuesday
            // 
            this.labelTuesday.AutoSize = true;
            this.labelTuesday.Location = new System.Drawing.Point(3, 262);
            this.labelTuesday.Name = "labelTuesday";
            this.labelTuesday.Size = new System.Drawing.Size(63, 17);
            this.labelTuesday.TabIndex = 11;
            this.labelTuesday.Text = "Tuesday";
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 16;
            this.listBox5.Location = new System.Drawing.Point(7, 282);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(120, 84);
            this.listBox5.TabIndex = 10;
            // 
            // labelWednesday
            // 
            this.labelWednesday.AutoSize = true;
            this.labelWednesday.Location = new System.Drawing.Point(3, 382);
            this.labelWednesday.Name = "labelWednesday";
            this.labelWednesday.Size = new System.Drawing.Size(83, 17);
            this.labelWednesday.TabIndex = 9;
            this.labelWednesday.Text = "Wednesday";
            // 
            // listBoxWednesday
            // 
            this.listBoxWednesday.FormattingEnabled = true;
            this.listBoxWednesday.ItemHeight = 16;
            this.listBoxWednesday.Location = new System.Drawing.Point(6, 402);
            this.listBoxWednesday.Name = "listBoxWednesday";
            this.listBoxWednesday.Size = new System.Drawing.Size(120, 84);
            this.listBoxWednesday.TabIndex = 8;
            // 
            // labelThurday
            // 
            this.labelThurday.AutoSize = true;
            this.labelThurday.Location = new System.Drawing.Point(163, 28);
            this.labelThurday.Name = "labelThurday";
            this.labelThurday.Size = new System.Drawing.Size(68, 17);
            this.labelThurday.TabIndex = 7;
            this.labelThurday.Text = "Thursday";
            // 
            // listBoxThurday
            // 
            this.listBoxThurday.FormattingEnabled = true;
            this.listBoxThurday.ItemHeight = 16;
            this.listBoxThurday.Location = new System.Drawing.Point(166, 48);
            this.listBoxThurday.Name = "listBoxThurday";
            this.listBoxThurday.Size = new System.Drawing.Size(120, 84);
            this.listBoxThurday.TabIndex = 6;
            // 
            // labelFriday
            // 
            this.labelFriday.AutoSize = true;
            this.labelFriday.Location = new System.Drawing.Point(159, 145);
            this.labelFriday.Name = "labelFriday";
            this.labelFriday.Size = new System.Drawing.Size(47, 17);
            this.labelFriday.TabIndex = 5;
            this.labelFriday.Text = "Friday";
            // 
            // listBoxFriday
            // 
            this.listBoxFriday.FormattingEnabled = true;
            this.listBoxFriday.ItemHeight = 16;
            this.listBoxFriday.Location = new System.Drawing.Point(162, 165);
            this.listBoxFriday.Name = "listBoxFriday";
            this.listBoxFriday.Size = new System.Drawing.Size(120, 84);
            this.listBoxFriday.TabIndex = 4;
            // 
            // labelSaturday
            // 
            this.labelSaturday.AutoSize = true;
            this.labelSaturday.Location = new System.Drawing.Point(159, 262);
            this.labelSaturday.Name = "labelSaturday";
            this.labelSaturday.Size = new System.Drawing.Size(65, 17);
            this.labelSaturday.TabIndex = 3;
            this.labelSaturday.Text = "Saturday";
            // 
            // listBoxSaturday
            // 
            this.listBoxSaturday.FormattingEnabled = true;
            this.listBoxSaturday.ItemHeight = 16;
            this.listBoxSaturday.Location = new System.Drawing.Point(162, 282);
            this.listBoxSaturday.Name = "listBoxSaturday";
            this.listBoxSaturday.Size = new System.Drawing.Size(120, 84);
            this.listBoxSaturday.TabIndex = 2;
            // 
            // labelSunday
            // 
            this.labelSunday.AutoSize = true;
            this.labelSunday.Location = new System.Drawing.Point(9, 28);
            this.labelSunday.Name = "labelSunday";
            this.labelSunday.Size = new System.Drawing.Size(56, 17);
            this.labelSunday.TabIndex = 1;
            this.labelSunday.Text = "Sunday";
            // 
            // listBoxSunday
            // 
            this.listBoxSunday.FormattingEnabled = true;
            this.listBoxSunday.ItemHeight = 16;
            this.listBoxSunday.Location = new System.Drawing.Point(6, 48);
            this.listBoxSunday.Name = "listBoxSunday";
            this.listBoxSunday.Size = new System.Drawing.Size(120, 84);
            this.listBoxSunday.TabIndex = 0;
            // 
            // buttonPrintMenu
            // 
            this.buttonPrintMenu.Location = new System.Drawing.Point(540, 344);
            this.buttonPrintMenu.Name = "buttonPrintMenu";
            this.buttonPrintMenu.Size = new System.Drawing.Size(120, 34);
            this.buttonPrintMenu.TabIndex = 14;
            this.buttonPrintMenu.Text = "Print Menu";
            this.buttonPrintMenu.UseVisualStyleBackColor = true;
            this.buttonPrintMenu.Click += new System.EventHandler(this.buttonPrintMenu_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 516);
            this.Controls.Add(this.buttonPrintMenu);
            this.Controls.Add(this.groupBoxWeekMenu);
            this.Controls.Add(this.groupBoxDishes);
            this.Name = "Main";
            this.Text = "PlanShopEat";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBoxDishes.ResumeLayout(false);
            this.groupBoxDishes.PerformLayout();
            this.groupBoxWeekMenu.ResumeLayout(false);
            this.groupBoxWeekMenu.PerformLayout();
            this.ResumeLayout(false);

      }

        #endregion

        private System.Windows.Forms.ListBox listBoxFoodChoices;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.GroupBox groupBoxDishes;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxWeekMenu;
        private System.Windows.Forms.Label labelMonday;
        private System.Windows.Forms.ListBox listBoxMonday;
        private System.Windows.Forms.Label labelTuesday;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.Label labelWednesday;
        private System.Windows.Forms.ListBox listBoxWednesday;
        private System.Windows.Forms.Label labelThurday;
        private System.Windows.Forms.ListBox listBoxThurday;
        private System.Windows.Forms.Label labelFriday;
        private System.Windows.Forms.ListBox listBoxFriday;
        private System.Windows.Forms.Label labelSaturday;
        private System.Windows.Forms.ListBox listBoxSaturday;
        private System.Windows.Forms.Label labelSunday;
        private System.Windows.Forms.ListBox listBoxSunday;
        private System.Windows.Forms.Button buttonPrintMenu;
    }
}

