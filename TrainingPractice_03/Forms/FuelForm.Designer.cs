namespace TrainingPractice_03.Forms
{
    partial class FuelForm
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
            this.updBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.del_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.filter_txt = new System.Windows.Forms.TextBox();
            this.more_radio = new System.Windows.Forms.RadioButton();
            this.less_radio = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.id_guideTxt = new System.Windows.Forms.ComboBox();
            this.supplierdirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDGasStationDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_GasStationDataSet = new TrainingPractice_03.BD_GasStationDataSet();
            this.supplierdirTableAdapter = new TrainingPractice_03.BD_GasStationDataSetTableAdapters.supplierdirTableAdapter();
            this.clrFilter_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierdirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDGasStationDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_GasStationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // updBtn
            // 
            this.updBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updBtn.Location = new System.Drawing.Point(497, 23);
            this.updBtn.Name = "updBtn";
            this.updBtn.Size = new System.Drawing.Size(216, 62);
            this.updBtn.TabIndex = 17;
            this.updBtn.Text = "Обновить";
            this.updBtn.UseVisualStyleBackColor = true;
            this.updBtn.Click += new System.EventHandler(this.updBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Название";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(237, 292);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(227, 20);
            this.nameTxt.TabIndex = 15;
            // 
            // del_btn
            // 
            this.del_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.del_btn.Location = new System.Drawing.Point(497, 268);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(216, 62);
            this.del_btn.TabIndex = 12;
            this.del_btn.Text = "Удалить";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_btn.Location = new System.Drawing.Point(497, 189);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(216, 62);
            this.edit_btn.TabIndex = 11;
            this.edit_btn.Text = "Изменить";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_btn.Location = new System.Drawing.Point(497, 105);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(216, 62);
            this.add_btn.TabIndex = 10;
            this.add_btn.Text = "Добавить";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(452, 237);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Фильтр по цене";
            // 
            // filter_txt
            // 
            this.filter_txt.Location = new System.Drawing.Point(233, 473);
            this.filter_txt.Name = "filter_txt";
            this.filter_txt.Size = new System.Drawing.Size(100, 20);
            this.filter_txt.TabIndex = 20;
            this.filter_txt.TextChanged += new System.EventHandler(this.filter_txt_TextChanged);
            // 
            // more_radio
            // 
            this.more_radio.AutoSize = true;
            this.more_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.more_radio.Location = new System.Drawing.Point(362, 452);
            this.more_radio.Name = "more_radio";
            this.more_radio.Size = new System.Drawing.Size(98, 28);
            this.more_radio.TabIndex = 21;
            this.more_radio.TabStop = true;
            this.more_radio.Text = "Больше";
            this.more_radio.UseVisualStyleBackColor = true;
            this.more_radio.CheckedChanged += new System.EventHandler(this.more_radio_CheckedChanged);
            // 
            // less_radio
            // 
            this.less_radio.AutoSize = true;
            this.less_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.less_radio.Location = new System.Drawing.Point(362, 486);
            this.less_radio.Name = "less_radio";
            this.less_radio.Size = new System.Drawing.Size(102, 28);
            this.less_radio.TabIndex = 22;
            this.less_radio.TabStop = true;
            this.less_radio.Text = "Меньше";
            this.less_radio.UseVisualStyleBackColor = true;
            this.less_radio.CheckedChanged += new System.EventHandler(this.less_radio_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(21, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Цена";
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(237, 338);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(227, 20);
            this.priceTxt.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(21, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "Код поставщика";
            // 
            // id_guideTxt
            // 
            this.id_guideTxt.DataSource = this.supplierdirBindingSource;
            this.id_guideTxt.DisplayMember = "sup_id";
            this.id_guideTxt.FormattingEnabled = true;
            this.id_guideTxt.Location = new System.Drawing.Point(233, 382);
            this.id_guideTxt.Name = "id_guideTxt";
            this.id_guideTxt.Size = new System.Drawing.Size(231, 21);
            this.id_guideTxt.TabIndex = 27;
            this.id_guideTxt.ValueMember = "sup_id";
            // 
            // supplierdirBindingSource
            // 
            this.supplierdirBindingSource.DataMember = "supplierdir";
            this.supplierdirBindingSource.DataSource = this.bDGasStationDataSetBindingSource;
            // 
            // bDGasStationDataSetBindingSource
            // 
            this.bDGasStationDataSetBindingSource.DataSource = this.bD_GasStationDataSet;
            this.bDGasStationDataSetBindingSource.Position = 0;
            // 
            // bD_GasStationDataSet
            // 
            this.bD_GasStationDataSet.DataSetName = "BD_GasStationDataSet";
            this.bD_GasStationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierdirTableAdapter
            // 
            this.supplierdirTableAdapter.ClearBeforeFill = true;
            // 
            // clrFilter_btn
            // 
            this.clrFilter_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clrFilter_btn.Location = new System.Drawing.Point(497, 452);
            this.clrFilter_btn.Name = "clrFilter_btn";
            this.clrFilter_btn.Size = new System.Drawing.Size(216, 62);
            this.clrFilter_btn.TabIndex = 28;
            this.clrFilter_btn.Text = "Показать все";
            this.clrFilter_btn.UseVisualStyleBackColor = true;
            this.clrFilter_btn.Click += new System.EventHandler(this.clrFilter_btn_Click);
            // 
            // FuelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 536);
            this.Controls.Add(this.clrFilter_btn);
            this.Controls.Add(this.id_guideTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.less_radio);
            this.Controls.Add(this.more_radio);
            this.Controls.Add(this.filter_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.updBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FuelForm";
            this.Text = "FuelForm";
            this.Load += new System.EventHandler(this.FuelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierdirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDGasStationDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_GasStationDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox filter_txt;
        private System.Windows.Forms.RadioButton more_radio;
        private System.Windows.Forms.RadioButton less_radio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox id_guideTxt;
        private System.Windows.Forms.BindingSource bDGasStationDataSetBindingSource;
        private BD_GasStationDataSet bD_GasStationDataSet;
        private System.Windows.Forms.BindingSource supplierdirBindingSource;
        private BD_GasStationDataSetTableAdapters.supplierdirTableAdapter supplierdirTableAdapter;
        private System.Windows.Forms.Button clrFilter_btn;
    }
}