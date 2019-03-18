namespace WinFormUI
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SelectedRowFilter = new System.Windows.Forms.Button();
            this.ResetFiltersButton = new System.Windows.Forms.Button();
            this.SpecializationFilterButton = new System.Windows.Forms.Button();
            this.SpecializationFilterTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChiefPositionFilterTextBox = new System.Windows.Forms.TextBox();
            this.ChiefPositionFilterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(280, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(705, 763);
            this.dataGridView2.TabIndex = 1;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(12, 752);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(75, 23);
            this.OpenFileButton.TabIndex = 2;
            this.OpenFileButton.Text = "Open";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(129, 752);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 3;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(87, 585);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(129, 723);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 723);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SelectedRowFilter
            // 
            this.SelectedRowFilter.Location = new System.Drawing.Point(71, 410);
            this.SelectedRowFilter.Name = "SelectedRowFilter";
            this.SelectedRowFilter.Size = new System.Drawing.Size(133, 64);
            this.SelectedRowFilter.TabIndex = 7;
            this.SelectedRowFilter.Text = "Filter by selected row\'s specialization";
            this.SelectedRowFilter.UseVisualStyleBackColor = true;
            this.SelectedRowFilter.Click += new System.EventHandler(this.SelectedRowFilter_Click);
            // 
            // ResetFiltersButton
            // 
            this.ResetFiltersButton.Location = new System.Drawing.Point(71, 480);
            this.ResetFiltersButton.Name = "ResetFiltersButton";
            this.ResetFiltersButton.Size = new System.Drawing.Size(133, 54);
            this.ResetFiltersButton.TabIndex = 8;
            this.ResetFiltersButton.Text = "ResetFilters";
            this.ResetFiltersButton.UseVisualStyleBackColor = true;
            this.ResetFiltersButton.Click += new System.EventHandler(this.ResetFiltersButton_Click);
            // 
            // SpecializationFilterButton
            // 
            this.SpecializationFilterButton.Location = new System.Drawing.Point(15, 338);
            this.SpecializationFilterButton.Name = "SpecializationFilterButton";
            this.SpecializationFilterButton.Size = new System.Drawing.Size(108, 56);
            this.SpecializationFilterButton.TabIndex = 9;
            this.SpecializationFilterButton.Text = "Filter by Specialization";
            this.SpecializationFilterButton.UseVisualStyleBackColor = true;
            this.SpecializationFilterButton.Click += new System.EventHandler(this.SpecializationFilterButton_Click);
            // 
            // SpecializationFilterTextBox
            // 
            this.SpecializationFilterTextBox.Location = new System.Drawing.Point(152, 308);
            this.SpecializationFilterTextBox.Name = "SpecializationFilterTextBox";
            this.SpecializationFilterTextBox.Size = new System.Drawing.Size(100, 22);
            this.SpecializationFilterTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Specialization Filter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "ChiefPosition Filter:";
            // 
            // ChiefPositionFilterTextBox
            // 
            this.ChiefPositionFilterTextBox.Location = new System.Drawing.Point(152, 200);
            this.ChiefPositionFilterTextBox.Name = "ChiefPositionFilterTextBox";
            this.ChiefPositionFilterTextBox.Size = new System.Drawing.Size(100, 22);
            this.ChiefPositionFilterTextBox.TabIndex = 12;
            // 
            // ChiefPositionFilterButton
            // 
            this.ChiefPositionFilterButton.Location = new System.Drawing.Point(12, 220);
            this.ChiefPositionFilterButton.Name = "ChiefPositionFilterButton";
            this.ChiefPositionFilterButton.Size = new System.Drawing.Size(108, 56);
            this.ChiefPositionFilterButton.TabIndex = 14;
            this.ChiefPositionFilterButton.Text = "Filter by Chief Position";
            this.ChiefPositionFilterButton.UseVisualStyleBackColor = true;
            this.ChiefPositionFilterButton.Click += new System.EventHandler(this.ChiefPositionFilterButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 787);
            this.Controls.Add(this.ChiefPositionFilterButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChiefPositionFilterTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SpecializationFilterTextBox);
            this.Controls.Add(this.SpecializationFilterButton);
            this.Controls.Add(this.ResetFiltersButton);
            this.Controls.Add(this.SelectedRowFilter);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button SelectedRowFilter;
        private System.Windows.Forms.Button ResetFiltersButton;
        private System.Windows.Forms.Button SpecializationFilterButton;
        private System.Windows.Forms.TextBox SpecializationFilterTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ChiefPositionFilterTextBox;
        private System.Windows.Forms.Button ChiefPositionFilterButton;
    }
}

