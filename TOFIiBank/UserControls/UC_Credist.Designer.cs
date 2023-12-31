﻿namespace TOFIiBank.UserControls
{
    partial class UC_Credist
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.outPutInfoData = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.creditNumber = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.monthsNumeric = new System.Windows.Forms.NumericUpDown();
            this.summNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minMonths = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxMonths = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.creditNumberComboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.monthsUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.sumUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.receiverAccauntComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.summNumeric)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthsUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1698, 52);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(810, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кредиты";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1174, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(524, 811);
            this.panel2.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.receiverAccauntComboBox);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.creditNumberComboBox2);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.sumUpDown2);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.monthsUpDown2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 452);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(522, 357);
            this.panel5.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.outPutInfoData);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.creditNumber);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.monthsNumeric);
            this.panel3.Controls.Add(this.summNumeric);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(522, 452);
            this.panel3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outPutInfoData
            // 
            this.outPutInfoData.AutoSize = true;
            this.outPutInfoData.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outPutInfoData.Location = new System.Drawing.Point(15, 400);
            this.outPutInfoData.Name = "outPutInfoData";
            this.outPutInfoData.Size = new System.Drawing.Size(0, 19);
            this.outPutInfoData.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(204, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Номер кредита";
            // 
            // creditNumber
            // 
            this.creditNumber.FormattingEnabled = true;
            this.creditNumber.Location = new System.Drawing.Point(217, 99);
            this.creditNumber.Name = "creditNumber";
            this.creditNumber.Size = new System.Drawing.Size(120, 24);
            this.creditNumber.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(176, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Количество месяцев";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(237, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Сумма";
            // 
            // monthsNumeric
            // 
            this.monthsNumeric.Location = new System.Drawing.Point(217, 230);
            this.monthsNumeric.Name = "monthsNumeric";
            this.monthsNumeric.Size = new System.Drawing.Size(120, 22);
            this.monthsNumeric.TabIndex = 3;
            // 
            // summNumeric
            // 
            this.summNumeric.Location = new System.Drawing.Point(217, 163);
            this.summNumeric.Name = "summNumeric";
            this.summNumeric.Size = new System.Drawing.Size(120, 22);
            this.summNumeric.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(176, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Кредитный калькулятор";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 52);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1174, 811);
            this.panel4.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.percentage,
            this.name,
            this.minSum,
            this.maxSum,
            this.minMonths,
            this.maxMonths});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 80;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F);
            this.dataGridView1.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(15);
            this.dataGridView1.RowTemplate.Height = 90;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(1174, 811);
            this.dataGridView1.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.HeaderText = "Номер кредита";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // percentage
            // 
            this.percentage.HeaderText = "Процентная ставка";
            this.percentage.MinimumWidth = 6;
            this.percentage.Name = "percentage";
            this.percentage.ReadOnly = true;
            // 
            // name
            // 
            this.name.FillWeight = 42.35293F;
            this.name.HeaderText = "Название кредита";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // minSum
            // 
            this.minSum.HeaderText = "Минимальная сумма";
            this.minSum.MinimumWidth = 6;
            this.minSum.Name = "minSum";
            this.minSum.ReadOnly = true;
            // 
            // maxSum
            // 
            this.maxSum.HeaderText = "Максимальная сумма";
            this.maxSum.MinimumWidth = 6;
            this.maxSum.Name = "maxSum";
            this.maxSum.ReadOnly = true;
            // 
            // minMonths
            // 
            this.minMonths.HeaderText = "Минимально месяцев";
            this.minMonths.MinimumWidth = 6;
            this.minMonths.Name = "minMonths";
            this.minMonths.ReadOnly = true;
            // 
            // maxMonths
            // 
            this.maxMonths.HeaderText = "Максимально месяцев";
            this.maxMonths.MinimumWidth = 6;
            this.maxMonths.Name = "maxMonths";
            this.maxMonths.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(214, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Взять кредит";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(205, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Номер кредита";
            // 
            // creditNumberComboBox2
            // 
            this.creditNumberComboBox2.FormattingEnabled = true;
            this.creditNumberComboBox2.Location = new System.Drawing.Point(218, 153);
            this.creditNumberComboBox2.Name = "creditNumberComboBox2";
            this.creditNumberComboBox2.Size = new System.Drawing.Size(120, 24);
            this.creditNumberComboBox2.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(177, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "Количество месяцев";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(238, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "Сумма";
            // 
            // monthsUpDown2
            // 
            this.monthsUpDown2.Location = new System.Drawing.Point(218, 284);
            this.monthsUpDown2.Name = "monthsUpDown2";
            this.monthsUpDown2.Size = new System.Drawing.Size(120, 22);
            this.monthsUpDown2.TabIndex = 11;
            // 
            // sumUpDown2
            // 
            this.sumUpDown2.Location = new System.Drawing.Point(218, 217);
            this.sumUpDown2.Name = "sumUpDown2";
            this.sumUpDown2.Size = new System.Drawing.Size(120, 22);
            this.sumUpDown2.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(159, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(236, 23);
            this.label10.TabIndex = 17;
            this.label10.Text = "Номер счёта получателя";
            // 
            // receiverAccauntComboBox
            // 
            this.receiverAccauntComboBox.FormattingEnabled = true;
            this.receiverAccauntComboBox.Location = new System.Drawing.Point(218, 100);
            this.receiverAccauntComboBox.Name = "receiverAccauntComboBox";
            this.receiverAccauntComboBox.Size = new System.Drawing.Size(120, 24);
            this.receiverAccauntComboBox.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 10;
            this.button2.Text = "Взять";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UC_Credist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Credist";
            this.Size = new System.Drawing.Size(1698, 863);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.summNumeric)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthsUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn minSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn minMonths;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxMonths;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label outPutInfoData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox creditNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown monthsNumeric;
        private System.Windows.Forms.NumericUpDown summNumeric;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox receiverAccauntComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox creditNumberComboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown sumUpDown2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown monthsUpDown2;
    }
}
