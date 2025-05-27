namespace WinFormsApp1
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
            buttonAdd = new Button();
            textBoxName = new TextBox();
            textBoxAge = new TextBox();
            textBoxPalata = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView = new DataGridView();
            buttonDownload = new Button();
            buttonUpload = new Button();
            textBoxAgeFilter = new TextBox();
            label4 = new Label();
            buttonSearch = new Button();
            buttonGroup = new Button();
            labelGroup = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(659, 59);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(63, 61);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 1;
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(255, 61);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(125, 27);
            textBoxAge.TabIndex = 2;
            // 
            // textBoxPalata
            // 
            textBoxPalata.Location = new Point(467, 61);
            textBoxPalata.Name = "textBoxPalata";
            textBoxPalata.Size = new Size(125, 27);
            textBoxPalata.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 28);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 4;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(467, 28);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 5;
            label2.Text = "Палата";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(255, 28);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 6;
            label3.Text = "Возраст";
            // 
            // dataGridView
            // 
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = SystemColors.Control;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(63, 118);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(529, 311);
            dataGridView.TabIndex = 7;
            // 
            // buttonDownload
            // 
            buttonDownload.Location = new Point(659, 118);
            buttonDownload.Name = "buttonDownload";
            buttonDownload.Size = new Size(94, 29);
            buttonDownload.TabIndex = 8;
            buttonDownload.Text = "Загрузить";
            buttonDownload.UseVisualStyleBackColor = true;
            buttonDownload.Click += buttonDownload_Click;
            // 
            // buttonUpload
            // 
            buttonUpload.Location = new Point(659, 167);
            buttonUpload.Name = "buttonUpload";
            buttonUpload.Size = new Size(94, 29);
            buttonUpload.TabIndex = 9;
            buttonUpload.Text = "Выгрузить";
            buttonUpload.UseVisualStyleBackColor = true;
            buttonUpload.Click += buttonUpload_Click;
            // 
            // textBoxAgeFilter
            // 
            textBoxAgeFilter.Location = new Point(641, 234);
            textBoxAgeFilter.Name = "textBoxAgeFilter";
            textBoxAgeFilter.Size = new Size(125, 27);
            textBoxAgeFilter.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(641, 211);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 11;
            label4.Text = "Возраст";
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(659, 291);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 29);
            buttonSearch.TabIndex = 12;
            buttonSearch.Text = "Найти";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonGroup
            // 
            buttonGroup.Location = new Point(598, 340);
            buttonGroup.Name = "buttonGroup";
            buttonGroup.Size = new Size(213, 29);
            buttonGroup.TabIndex = 13;
            buttonGroup.Text = "Сгруппировать по палатам";
            buttonGroup.UseVisualStyleBackColor = true;
            buttonGroup.Click += buttonGroup_Click;
            // 
            // labelGroup
            // 
            labelGroup.AutoSize = true;
            labelGroup.Location = new Point(598, 381);
            labelGroup.Name = "labelGroup";
            labelGroup.Size = new Size(50, 20);
            labelGroup.TabIndex = 14;
            labelGroup.Text = "label5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 450);
            Controls.Add(labelGroup);
            Controls.Add(buttonGroup);
            Controls.Add(buttonSearch);
            Controls.Add(label4);
            Controls.Add(textBoxAgeFilter);
            Controls.Add(buttonUpload);
            Controls.Add(buttonDownload);
            Controls.Add(dataGridView);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPalata);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxName);
            Controls.Add(buttonAdd);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdd;
        private TextBox textBoxName;
        private TextBox textBoxAge;
        private TextBox textBoxPalata;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView;
        private Button buttonDownload;
        private Button buttonUpload;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBoxAgeFilter;
        private Button buttonSearch;
        private Button buttonGroup;
        private Label labelGroup;
    }
}
