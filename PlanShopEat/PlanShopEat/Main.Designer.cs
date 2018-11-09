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
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxDishes.SuspendLayout();
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
            this.listBoxFoodChoices.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
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
            // comboBoxCategory
            // 
            this.comboBoxCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(315, 76);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(181, 24);
            this.comboBoxCategory.TabIndex = 4;
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 516);
            this.Controls.Add(this.groupBoxDishes);
            this.Name = "Main";
            this.Text = "PlanShopEat";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBoxDishes.ResumeLayout(false);
            this.groupBoxDishes.PerformLayout();
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
    }
}

