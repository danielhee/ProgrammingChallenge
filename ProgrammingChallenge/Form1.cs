using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace ProgrammingChallenge
{

    public partial class Form1 : Form
    {
        private const string URL = "https://eservices.mas.gov.sg/api/action/datastore/search.json";

        public Form1()
        {
            InitializeComponent();
            CreatingGrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void CreatingGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.Name = "MonthYear";
            column1.HeaderText = "Month-Year";
            column1.DataPropertyName = "end_of_month";
            dataGridView1.Columns.Add(column1);

            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.Name = "Banks Saving Deposits";
            column2.HeaderText = "Banks Saving Deposits";
            column2.DataPropertyName = "banks_savings_deposits";
            dataGridView1.Columns.Add(column2);

            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.Name = "Financial Coy Savings Deposits";
            column3.HeaderText = "Financial Coy Savings Deposits";
            column3.DataPropertyName = "fc_savings_deposits";
            dataGridView1.Columns.Add(column3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string param = string.Format("?resource_id=5f2b18a8-0883-4769-a635-879c63d3caac&fields=end_of_month,banks_savings_deposits,fc_savings_deposits&between[end_of_month]={0},{1}&sort=end_of_month asc",
                dateTimePicker1.Value.ToString("yyyy-MM"), 
                dateTimePicker2.Value.ToString("yyyy-MM"));

            if (InputValidation())
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(URL);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync(param).Result;  // Blocking call!
                if (response.IsSuccessStatusCode)
                {
                    using (HttpContent content = response.Content)
                    {
                        //reading the response
                        Task<string> result = content.ReadAsStringAsync();
                        string rawResult = result.Result;
                        string json = rawResult.Substring(rawResult.LastIndexOf("["), rawResult.Length - rawResult.LastIndexOf("[") - 2);

                        List<DataObject> myDeserializedObj = (List<DataObject>)JsonConvert.DeserializeObject(json, typeof(List<DataObject>));
                        dataGridView1.DataSource = myDeserializedObj;

                        ComputeAverageAndCompare();
                        DetermineTrend();
                    }
                }
            }
        }
            

        private void ComputeAverageAndCompare()
        {
            double bankRate = 0.0, fcRate = 0.0;

            foreach (DataGridViewRow Myrow in dataGridView1.Rows)
            {
                double tmpBankRate = Convert.ToDouble(Myrow.Cells[1].Value);
                double tmpFcRate = Convert.ToDouble(Myrow.Cells[2].Value);
                bankRate += tmpBankRate;
                fcRate += tmpFcRate;

                if (tmpFcRate > tmpBankRate)
                {
                    Myrow.Cells[2].Style.BackColor = Color.LightGreen;
                }
            }
            lblAvgBankRate.Text = Convert.ToString(Math.Round(bankRate / dataGridView1.Rows.Count, 2));
            lblAvgFCRate.Text = Convert.ToString(Math.Round(fcRate / dataGridView1.Rows.Count, 2));
            
        }

        private void DetermineTrend()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                //determine trend
                DataGridViewRow firstMth = dataGridView1.Rows[0];
                double firstMthRate = Convert.ToDouble(firstMth.Cells[1].Value);
                DataGridViewRow lastMth = dataGridView1.Rows[dataGridView1.Rows.Count - 1];
                double LastMthRate = Convert.ToDouble(lastMth.Cells[1].Value);
                if (firstMthRate > LastMthRate)
                {
                    lblTrend.Text = "Down";
                }
                else if (firstMthRate < LastMthRate)
                {
                    lblTrend.Text = "Up";
                }
                else
                {
                    lblTrend.Text = "Flat";
                }
            }
        }

        private bool InputValidation()
        { 
            if(dateTimePicker1.Value >dateTimePicker2.Value)
            {
                MessageBox.Show("Invalid period specified.","Error");
                return false;
            }
            return true;
        }
    }

    public class DataObject
    {
        public string end_of_month { get; set; }
        public string banks_savings_deposits { get; set; }
        public string fc_savings_deposits { get; set; }
    }
}
