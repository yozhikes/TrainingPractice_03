namespace TrainingPractice_03.Forms
{
    partial class RemainsForm
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
            this.sortBtn = new System.Windows.Forms.Button();
            this.id_fuelTxt = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.updBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.startVolumeTxt = new System.Windows.Forms.TextBox();
            this.del_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.volumeSaleTxt = new System.Windows.Forms.TextBox();
            this.dateTxt = new System.Windows.Forms.MaskedTextBox();
            this.expBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.bD_GasStationDataSet = new TrainingPractice_03.BD_GasStationDataSet();
            this.bDGasStationDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_GasStationFuelData = new TrainingPractice_03.BD_GasStationFuelData();
            this.fuelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fuelTableAdapter = new TrainingPractice_03.BD_GasStationFuelDataTableAdapters.fuelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bD_GasStationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDGasStationDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_GasStationFuelData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sortBtn
            // 
            this.sortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortBtn.Location = new System.Drawing.Point(123, 153);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(216, 62);
            this.sortBtn.TabIndex = 44;
            this.sortBtn.Text = "Сортировка";
            this.sortBtn.UseVisualStyleBackColor = true;
            // 
            // id_fuelTxt
            // 
            this.id_fuelTxt.DataSource = this.fuelBindingSource;
            this.id_fuelTxt.DisplayMember = "fuel_id";
            this.id_fuelTxt.FormattingEnabled = true;
            this.id_fuelTxt.Location = new System.Drawing.Point(265, 300);
            this.id_fuelTxt.Name = "id_fuelTxt";
            this.id_fuelTxt.Size = new System.Drawing.Size(231, 21);
            this.id_fuelTxt.TabIndex = 43;
            this.id_fuelTxt.ValueMember = "fuel_id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(49, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 24);
            this.label5.TabIndex = 42;
            this.label5.Text = "Объём на начало дня (л)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(49, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 41;
            this.label4.Text = "Дата";
            // 
            // updBtn
            // 
            this.updBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updBtn.Location = new System.Drawing.Point(529, 125);
            this.updBtn.Name = "updBtn";
            this.updBtn.Size = new System.Drawing.Size(216, 62);
            this.updBtn.TabIndex = 35;
            this.updBtn.Text = "Обновить";
            this.updBtn.UseVisualStyleBackColor = true;
            this.updBtn.Click += new System.EventHandler(this.updBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(49, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "Код вида топлива";
            // 
            // startVolumeTxt
            // 
            this.startVolumeTxt.Location = new System.Drawing.Point(339, 393);
            this.startVolumeTxt.Name = "startVolumeTxt";
            this.startVolumeTxt.Size = new System.Drawing.Size(157, 20);
            this.startVolumeTxt.TabIndex = 33;
            // 
            // del_btn
            // 
            this.del_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.del_btn.Location = new System.Drawing.Point(773, 32);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(216, 62);
            this.del_btn.TabIndex = 32;
            this.del_btn.Text = "Удалить";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_btn.Location = new System.Drawing.Point(529, 32);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(216, 62);
            this.add_btn.TabIndex = 30;
            this.add_btn.Text = "Добавить";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(452, 237);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(49, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 46;
            this.label1.Text = "Объём продажи (л)";
            // 
            // volumeSaleTxt
            // 
            this.volumeSaleTxt.Location = new System.Drawing.Point(339, 445);
            this.volumeSaleTxt.Name = "volumeSaleTxt";
            this.volumeSaleTxt.Size = new System.Drawing.Size(157, 20);
            this.volumeSaleTxt.TabIndex = 45;
            // 
            // dateTxt
            // 
            this.dateTxt.Location = new System.Drawing.Point(265, 344);
            this.dateTxt.Mask = "00-00-0000";
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.Size = new System.Drawing.Size(227, 20);
            this.dateTxt.TabIndex = 47;
            // 
            // expBtn
            // 
            this.expBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expBtn.Location = new System.Drawing.Point(773, 125);
            this.expBtn.Name = "expBtn";
            this.expBtn.Size = new System.Drawing.Size(216, 62);
            this.expBtn.TabIndex = 48;
            this.expBtn.Text = "Экспорт";
            this.expBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb5);
            this.groupBox1.Controls.Add(this.rb4);
            this.groupBox1.Controls.Add(this.rb3);
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Controls.Add(this.sortBtn);
            this.groupBox1.Location = new System.Drawing.Point(529, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 221);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировать по:";
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb5.Location = new System.Drawing.Point(136, 105);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(193, 28);
            this.rb5.TabIndex = 49;
            this.rb5.TabStop = true;
            this.rb5.Text = "объёму продажи";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb4.Location = new System.Drawing.Point(209, 60);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(245, 28);
            this.rb4.TabIndex = 48;
            this.rb4.TabStop = true;
            this.rb4.Text = "объёму на начало дня";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb3.Location = new System.Drawing.Point(27, 60);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(75, 28);
            this.rb3.TabIndex = 47;
            this.rb3.TabStop = true;
            this.rb3.Text = "дате";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb2.Location = new System.Drawing.Point(209, 19);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(225, 28);
            this.rb2.TabIndex = 46;
            this.rb2.TabStop = true;
            this.rb2.Text = "коду вида толплива";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb1.Location = new System.Drawing.Point(27, 20);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(134, 28);
            this.rb1.TabIndex = 45;
            this.rb1.TabStop = true;
            this.rb1.Text = "коду учёта";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // bD_GasStationDataSet
            // 
            this.bD_GasStationDataSet.DataSetName = "BD_GasStationDataSet";
            this.bD_GasStationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bDGasStationDataSetBindingSource
            // 
            this.bDGasStationDataSetBindingSource.DataSource = this.bD_GasStationDataSet;
            this.bDGasStationDataSetBindingSource.Position = 0;
            // 
            // bD_GasStationFuelData
            // 
            this.bD_GasStationFuelData.DataSetName = "BD_GasStationFuelData";
            this.bD_GasStationFuelData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fuelBindingSource
            // 
            this.fuelBindingSource.DataMember = "fuel";
            this.fuelBindingSource.DataSource = this.bD_GasStationFuelData;
            // 
            // fuelTableAdapter
            // 
            this.fuelTableAdapter.ClearBeforeFill = true;
            // 
            // RemainsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 513);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.expBtn);
            this.Controls.Add(this.dateTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.volumeSaleTxt);
            this.Controls.Add(this.id_fuelTxt);
            this.Controls.Add(this.updBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startVolumeTxt);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RemainsForm";
            this.Text = "RemainsForm";
            this.Load += new System.EventHandler(this.RemainsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bD_GasStationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDGasStationDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_GasStationFuelData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.ComboBox id_fuelTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button updBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox startVolumeTxt;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox volumeSaleTxt;
        private System.Windows.Forms.MaskedTextBox dateTxt;
        private System.Windows.Forms.Button expBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb4;
        private BD_GasStationDataSet bD_GasStationDataSet;
        private System.Windows.Forms.BindingSource bDGasStationDataSetBindingSource;
        private BD_GasStationFuelData bD_GasStationFuelData;
        private System.Windows.Forms.BindingSource fuelBindingSource;
        private BD_GasStationFuelDataTableAdapters.fuelTableAdapter fuelTableAdapter;
    }
}