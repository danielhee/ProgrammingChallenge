namespace ProgrammingChallenge
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAvgBankRate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAvgFCRate = new System.Windows.Forms.Label();
            this.lblTrend = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEnd);
            this.groupBox1.Controls.Add(this.lblStart);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(28, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(824, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Period";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(280, 43);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(66, 32);
            this.lblEnd.TabIndex = 9;
            this.lblEnd.Text = "End";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(22, 43);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(75, 32);
            this.lblStart.TabIndex = 8;
            this.lblStart.Text = "Start";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(561, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Query";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "MMM-yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(280, 78);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(204, 38);
            this.dateTimePicker2.TabIndex = 2;
            this.dateTimePicker2.Value = new System.DateTime(2018, 4, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MMM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(26, 78);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(204, 38);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2018, 4, 1, 0, 0, 0, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 387);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(936, 591);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Avg Bank Rate:";
            // 
            // lblAvgBankRate
            // 
            this.lblAvgBankRate.AutoSize = true;
            this.lblAvgBankRate.Location = new System.Drawing.Point(383, 235);
            this.lblAvgBankRate.Name = "lblAvgBankRate";
            this.lblAvgBankRate.Size = new System.Drawing.Size(0, 32);
            this.lblAvgBankRate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Avg Financial Coy Rate:";
            // 
            // lblAvgFCRate
            // 
            this.lblAvgFCRate.AutoSize = true;
            this.lblAvgFCRate.Location = new System.Drawing.Point(383, 289);
            this.lblAvgFCRate.Name = "lblAvgFCRate";
            this.lblAvgFCRate.Size = new System.Drawing.Size(0, 32);
            this.lblAvgFCRate.TabIndex = 5;
            // 
            // lblTrend
            // 
            this.lblTrend.AutoSize = true;
            this.lblTrend.Location = new System.Drawing.Point(260, 337);
            this.lblTrend.Name = "lblTrend";
            this.lblTrend.Size = new System.Drawing.Size(0, 32);
            this.lblTrend.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Overall Trend:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 1073);
            this.Controls.Add(this.lblTrend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAvgFCRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAvgBankRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAvgBankRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAvgFCRate;
        private System.Windows.Forms.Label lblTrend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
    }
}

