
namespace OperatingSystems
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Process = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPUBurstTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurnaroundTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaitingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.FCFS = new System.Windows.Forms.RadioButton();
            this.SJF = new System.Windows.Forms.RadioButton();
            this.PRI = new System.Windows.Forms.RadioButton();
            this.PP = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.RR = new System.Windows.Forms.RadioButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Process_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SJFP = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ResponseTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageResponseTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Process,
            this.CPUBurstTime,
            this.Priority,
            this.ArrivalTime,
            this.TurnaroundTime,
            this.WaitingTime,
            this.ResponseTime});
            this.dataGridView1.Location = new System.Drawing.Point(12, 247);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(673, 444);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Process
            // 
            this.Process.HeaderText = "Process";
            this.Process.MinimumWidth = 6;
            this.Process.Name = "Process";
            this.Process.ReadOnly = true;
            // 
            // CPUBurstTime
            // 
            this.CPUBurstTime.HeaderText = "CPU-Burst Time";
            this.CPUBurstTime.MinimumWidth = 6;
            this.CPUBurstTime.Name = "CPUBurstTime";
            this.CPUBurstTime.ReadOnly = true;
            // 
            // Priority
            // 
            this.Priority.HeaderText = "Priority";
            this.Priority.MinimumWidth = 6;
            this.Priority.Name = "Priority";
            this.Priority.ReadOnly = true;
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.HeaderText = "Arrival Time";
            this.ArrivalTime.MinimumWidth = 6;
            this.ArrivalTime.Name = "ArrivalTime";
            this.ArrivalTime.ReadOnly = true;
            // 
            // TurnaroundTime
            // 
            this.TurnaroundTime.HeaderText = "Turnaround Time";
            this.TurnaroundTime.MinimumWidth = 6;
            this.TurnaroundTime.Name = "TurnaroundTime";
            // 
            // WaitingTime
            // 
            this.WaitingTime.HeaderText = "Waiting Time";
            this.WaitingTime.MinimumWidth = 6;
            this.WaitingTime.Name = "WaitingTime";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(692, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(182, 30);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(73, 22);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "CPU-Burst Time:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(273, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Priority:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(448, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Arrival Time:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(350, 29);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(76, 22);
            this.numericUpDown2.TabIndex = 11;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(592, 30);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(71, 22);
            this.numericUpDown3.TabIndex = 12;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // FCFS
            // 
            this.FCFS.AutoSize = true;
            this.FCFS.Checked = true;
            this.FCFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FCFS.Location = new System.Drawing.Point(1007, 20);
            this.FCFS.Name = "FCFS";
            this.FCFS.Size = new System.Drawing.Size(216, 28);
            this.FCFS.TabIndex = 13;
            this.FCFS.TabStop = true;
            this.FCFS.Text = "First Come First Serve";
            this.FCFS.UseVisualStyleBackColor = true;
            this.FCFS.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // SJF
            // 
            this.SJF.AutoSize = true;
            this.SJF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SJF.Location = new System.Drawing.Point(1007, 54);
            this.SJF.Name = "SJF";
            this.SJF.Size = new System.Drawing.Size(317, 28);
            this.SJF.TabIndex = 14;
            this.SJF.Text = "Non-Preemptive Shortest Job First";
            this.SJF.UseVisualStyleBackColor = true;
            this.SJF.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // PRI
            // 
            this.PRI.AutoSize = true;
            this.PRI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRI.Location = new System.Drawing.Point(1007, 122);
            this.PRI.Name = "PRI";
            this.PRI.Size = new System.Drawing.Size(229, 28);
            this.PRI.TabIndex = 15;
            this.PRI.Text = "Non-Preemptive Priority";
            this.PRI.UseVisualStyleBackColor = true;
            this.PRI.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // PP
            // 
            this.PP.AutoSize = true;
            this.PP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PP.Location = new System.Drawing.Point(1007, 156);
            this.PP.Name = "PP";
            this.PP.Size = new System.Drawing.Size(187, 28);
            this.PP.TabIndex = 16;
            this.PP.Text = "Preemptive Priority";
            this.PP.UseVisualStyleBackColor = true;
            this.PP.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 37);
            this.button2.TabIndex = 17;
            this.button2.Text = "Add Process";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(812, 30);
            this.numericUpDown4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(68, 22);
            this.numericUpDown4.TabIndex = 19;
            this.numericUpDown4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(694, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Quantum:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // RR
            // 
            this.RR.AutoSize = true;
            this.RR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RR.Location = new System.Drawing.Point(1007, 190);
            this.RR.Name = "RR";
            this.RR.Size = new System.Drawing.Size(143, 28);
            this.RR.TabIndex = 20;
            this.RR.Text = "Round Robin";
            this.RR.UseVisualStyleBackColor = true;
            this.RR.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Process_Type,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.AverageResponseTime});
            this.dataGridView2.Location = new System.Drawing.Point(692, 247);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(646, 442);
            this.dataGridView2.TabIndex = 21;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Process_Type
            // 
            this.Process_Type.HeaderText = "Process_Type";
            this.Process_Type.MinimumWidth = 6;
            this.Process_Type.Name = "Process_Type";
            this.Process_Type.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Average Turnaround Time";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Average Waiting Time";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 22;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(183, 185);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 36);
            this.button3.TabIndex = 23;
            this.button3.Text = "Clear Process";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SJFP
            // 
            this.SJFP.AutoSize = true;
            this.SJFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SJFP.Location = new System.Drawing.Point(1007, 88);
            this.SJFP.Name = "SJFP";
            this.SJFP.Size = new System.Drawing.Size(275, 28);
            this.SJFP.TabIndex = 24;
            this.SJFP.TabStop = true;
            this.SJFP.Text = "Preemptive Shortest Job First";
            this.SJFP.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(16, 125);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(217, 28);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "Reverse Priority Order";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ResponseTime
            // 
            this.ResponseTime.HeaderText = "Response Time";
            this.ResponseTime.MinimumWidth = 6;
            this.ResponseTime.Name = "ResponseTime";
            // 
            // AverageResponseTime
            // 
            this.AverageResponseTime.HeaderText = "Average Response Time";
            this.AverageResponseTime.MinimumWidth = 6;
            this.AverageResponseTime.Name = "AverageResponseTime";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1351, 699);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.SJFP);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.RR);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PP);
            this.Controls.Add(this.PRI);
            this.Controls.Add(this.SJF);
            this.Controls.Add(this.FCFS);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.RadioButton FCFS;
        private System.Windows.Forms.RadioButton SJF;
        private System.Windows.Forms.RadioButton PRI;
        private System.Windows.Forms.RadioButton PP;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RR;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Process_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Process;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPUBurstTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurnaroundTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaitingTime;
        private System.Windows.Forms.RadioButton SJFP;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResponseTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageResponseTime;
    }
}

