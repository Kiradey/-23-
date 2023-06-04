namespace задание_23_бл_схемы
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Generate = new System.Windows.Forms.Button();
            this.LastDiap = new System.Windows.Forms.TextBox();
            this.StartDiap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MassSize = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ColumnSorting = new System.Windows.Forms.RadioButton();
            this.RowsSorting = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Low = new System.Windows.Forms.RadioButton();
            this.High = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Generate);
            this.groupBox1.Controls.Add(this.LastDiap);
            this.groupBox1.Controls.Add(this.StartDiap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.MassSize);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите размерность массива n*n";
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(80, 150);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(125, 29);
            this.Generate.TabIndex = 6;
            this.Generate.Text = "Сгенерировать";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // LastDiap
            // 
            this.LastDiap.Location = new System.Drawing.Point(192, 109);
            this.LastDiap.Name = "LastDiap";
            this.LastDiap.Size = new System.Drawing.Size(87, 27);
            this.LastDiap.TabIndex = 5;
            this.LastDiap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LastDiap_KeyPress);
            // 
            // StartDiap
            // 
            this.StartDiap.Location = new System.Drawing.Point(43, 109);
            this.StartDiap.Name = "StartDiap";
            this.StartDiap.Size = new System.Drawing.Size(87, 27);
            this.StartDiap.TabIndex = 4;
            this.StartDiap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StartDiap_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "ДО:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ОТ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите диапазон генерации чисел";
            // 
            // MassSize
            // 
            this.MassSize.Location = new System.Drawing.Point(80, 26);
            this.MassSize.Name = "MassSize";
            this.MassSize.Size = new System.Drawing.Size(125, 27);
            this.MassSize.TabIndex = 0;
            this.MassSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MassSize_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(394, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 185);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выберите тип сортировки:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сортировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ColumnSorting);
            this.groupBox4.Controls.Add(this.RowsSorting);
            this.groupBox4.Location = new System.Drawing.Point(6, 87);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(273, 54);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ось:";
            // 
            // ColumnSorting
            // 
            this.ColumnSorting.AutoSize = true;
            this.ColumnSorting.Location = new System.Drawing.Point(136, 26);
            this.ColumnSorting.Name = "ColumnSorting";
            this.ColumnSorting.Size = new System.Drawing.Size(121, 24);
            this.ColumnSorting.TabIndex = 1;
            this.ColumnSorting.TabStop = true;
            this.ColumnSorting.Text = "По столбцам";
            this.ColumnSorting.UseVisualStyleBackColor = true;
            // 
            // RowsSorting
            // 
            this.RowsSorting.AutoSize = true;
            this.RowsSorting.Location = new System.Drawing.Point(19, 26);
            this.RowsSorting.Name = "RowsSorting";
            this.RowsSorting.Size = new System.Drawing.Size(111, 24);
            this.RowsSorting.TabIndex = 0;
            this.RowsSorting.TabStop = true;
            this.RowsSorting.Text = "По строкам";
            this.RowsSorting.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Low);
            this.groupBox3.Controls.Add(this.High);
            this.groupBox3.Location = new System.Drawing.Point(6, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 55);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Направление:";
            // 
            // Low
            // 
            this.Low.AutoSize = true;
            this.Low.Location = new System.Drawing.Point(144, 26);
            this.Low.Name = "Low";
            this.Low.Size = new System.Drawing.Size(101, 24);
            this.Low.TabIndex = 1;
            this.Low.TabStop = true;
            this.Low.Text = "Убывание";
            this.Low.UseVisualStyleBackColor = true;
            // 
            // High
            // 
            this.High.AutoSize = true;
            this.High.Location = new System.Drawing.Point(19, 26);
            this.High.Name = "High";
            this.High.Size = new System.Drawing.Size(119, 24);
            this.High.TabIndex = 0;
            this.High.TabStop = true;
            this.High.Text = "Возрастание";
            this.High.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(285, 181);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Location = new System.Drawing.Point(394, 220);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(285, 181);
            this.dataGridView2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 416);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Программа сортирует сгенерированный массив по желанию пользователя";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button Generate;
        private TextBox LastDiap;
        private TextBox StartDiap;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox MassSize;
        private GroupBox groupBox2;
        private Button button1;
        private GroupBox groupBox4;
        private RadioButton ColumnSorting;
        private RadioButton RowsSorting;
        private GroupBox groupBox3;
        private RadioButton Low;
        private RadioButton High;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
    }
}