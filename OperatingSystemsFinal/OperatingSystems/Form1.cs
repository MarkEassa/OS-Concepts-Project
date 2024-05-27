using OperatingSystems.Scheduler;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OperatingSystems
{

    public partial class Form1 : Form
    {
        int AddRowInProcess = 1, AddRowInAnswer = 1;
        double AverageTurnaroundTime = 0, AverageWaitingTime = 0, _AverageResponseTime = 0;
        string check;
        bool ReversePriority = false;
        Scheduler.Scheduler scheduler = new FirstComeFirstServe();
        List<Process> p = new List<Process>();

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Init()
        {
            AverageTurnaroundTime = 0; 
            AverageWaitingTime = 0;
            _AverageResponseTime = 0;
            ReversePriority = false;
            p.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Process process = new Process(
                    name: dataGridView1[0, i].Value.ToString(),
                    burstTime: int.Parse(dataGridView1[1, i].Value.ToString()),
                    priority: int.Parse(dataGridView1[2, i].Value.ToString()),
                    arrivalTime: int.Parse(dataGridView1[3, i].Value.ToString()));
                p.Add(process);
            }
            if (checkBox1.Checked)
                ReversePriority = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            { 
                MessageBox.Show("There must be >= 1 processes.");
                return;
            }

            Init();

            if (FCFS.Checked)
            {
                scheduler = new FirstComeFirstServe();
                check = FCFS.Text;
            }

            if (SJF.Checked)
            {
                scheduler = new ShortestJobFirst(false);
                check = SJF.Text;
            }

            if (SJFP.Checked)
            {
                scheduler = new ShortestJobFirst(true);
                check = SJFP.Text;
            }

            if (PRI.Checked)
            {
                scheduler = new Priority(false, !ReversePriority);
                check = PRI.Text;
            }

            if (PP.Checked)
            {
                scheduler = new Priority(true, !ReversePriority);
                check = PP.Text;
            }

            if (RR.Checked)
            {
                int quantum = (int)numericUpDown4.Value;
                scheduler = new RoundRobin(quantum);
                check = RR.Text;
            }

            scheduler.Run(p);
            var dict = scheduler.Profile(p);
            var (turnaround, waiting, response) = Scheduler.Scheduler.AveragesFromProfile(dict);
            AverageTurnaroundTime = turnaround;
            AverageWaitingTime = waiting;
            _AverageResponseTime = response;
            
            int j = 0;
            foreach (var proc in dict.Keys)
            {
                var (turn, wait, resp) = dict[proc];
                dataGridView1[4, j].Value = turn;
                dataGridView1[5, j].Value = wait;
                dataGridView1[6, j].Value = resp;
                j++;
            }


            dataGridView2.Rows.Add(AddRowInAnswer + ")" + check, AverageTurnaroundTime, AverageWaitingTime, _AverageResponseTime);
            AddRowInAnswer++;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("p" + AddRowInProcess, (int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value);
            AddRowInProcess++;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddRowInProcess = 1;
            dataGridView1.Rows.Clear();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
