using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;







namespace WindowsFormsApp1
{
public partial class Form1 : Form
{
    public class Jobids
    {
        public string JobId { get; set; }
    }

    public BindingSource Datasource { get; set; } = new BindingSource();

    private string AgentFilePath;

    private string ResultsFilePath;

    List<string> jobsid = new List<string>();
    List<BindingSource> results = new List<BindingSource>();
   


    string[] resultsArray;
    public Form1()
    {
        InitializeComponent();
        dataGridViewJobs.DataSource = Datasource;
        dataGridViewJobs.Refresh();
        // this.dataGridViewJobs.DefaultCellStyle.ForeColor = Color.Blue;
        //this.dataGridViewJobs.DefaultCellStyle.BackColor = Color.Beige;
        // this.dataGridViewJobs.DefaultCellStyle.SelectionForeColor = Color.Yellow;
        // this.dataGridViewJobs.DefaultCellStyle.SelectionBackColor = Color.Black;

    }

    private void AgentButton_Click(object sender, EventArgs e)
    {

        if (OpenFileDialogAgentResult.ShowDialog() == DialogResult.OK)
        {
            string path = OpenFileDialogAgentResult.FileName;
            AgentText.Text = path;

            AgentFilePath = path;
        }
    }




    private void ResultButton_Click(object sender, EventArgs e)
    {
        if (OpenFileDialogAgentResult.ShowDialog() == DialogResult.OK)
        {
            string path = OpenFileDialogAgentResult.FileName;
            ResultText.Text = path;
            ResultsFilePath = path;
            var lines = File.ReadAllLines(path);
            resultsArray = lines;
               
            //var linesWithTheJobId = lines.Select(x => x.Contains("jobidddfsdfsd")).ToList();

        }
    }

    

    private void ReadResultsFile(string path)
    {
        var lines = File.ReadAllLines(path);
        //var linesWithTheJobId = lines.Select(x => x.Contains("jobidddfsdfsd")).ToList();
    }

  

    private void Submit_Click(object sender, EventArgs e)
    {
        if (AgentText.Text != "" && ResultText.Text == "")
        {

            try
            {

                //string strRegex = @"JobId:\x20[0-9a-f]{8}-[0-9a-f]{4}-[1-5][0-9a-f]{3}-[89ab][0-9a-f]{3}-[0-9a-f]{12}";
                Regex myRegex = new Regex(@"JobId:\x20[0-9a-f]{8}-[0-9a-f]{4}-[1-5][0-9a-f]{3}-[89ab][0-9a-f]{3}-[0-9a-f]{12}", RegexOptions.None);
                using (System.IO.StreamReader reader = new System.IO.StreamReader(AgentFilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Match match = myRegex.Match(line);
                        if (match.Success)
                        {
                            string valueWithJobId = match.Groups[0].Value;
                            string[] jobid = valueWithJobId.Split(' ');

                            if(!jobsid.Exists(x => x == jobid[1]))
                            {
                                jobsid.Add(jobid[1]);
                            }

                              


                        }
                    }

                }

                Datasource.Clear();
                dataGridViewJobs.AutoResizeColumns();

                Datasource.DataSource = jobsid.Select(item => new Jobids() { JobId = item }).ToList();

                dataGridViewJobs.DataSource = Datasource;
                dataGridViewJobs.Columns["JobId"].Width = 400;
                dataGridViewJobs.Columns["JobId"].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                this.dataGridViewJobs.Columns["JobId"].DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
                this.dataGridViewJobs.EnableHeadersVisualStyles = false;
                this.dataGridViewJobs.Columns["JobId"].HeaderCell.Style.BackColor = Color.LightGray;


            }
            catch (Exception ex)
            {
                var tmp = ex.Message;
            }
        }

        else if (AgentText.Text != "" && ResultText.Text != "")
        {

            if (jobsid.Count == 0)
            {
                try
                {
                    //string strRegex = @"JobId:\x20[0-9a-f]{8}-[0-9a-f]{4}-[1-5][0-9a-f]{3}-[89ab][0-9a-f]{3}-[0-9a-f]{12}";
                    Regex myRegex = new Regex(@"JobId:\x20[0-9a-f]{8}-[0-9a-f]{4}-[1-5][0-9a-f]{3}-[89ab][0-9a-f]{3}-[0-9a-f]{12}", RegexOptions.None);

                    System.IO.StreamReader readerResult = new System.IO.StreamReader(ResultsFilePath);

                    using (System.IO.StreamReader readerAgent = new System.IO.StreamReader(AgentFilePath))
                    {
                        string line;
                        while ((line = readerAgent.ReadLine()) != null)
                        {
                            Match match = myRegex.Match(line);
                            if (match.Success)
                            {
                                string valueWithJobId = match.Groups[0].Value;
                                string[] jobid = valueWithJobId.Split(' ');
                                    if (!jobsid.Exists(x => x == jobid[1]))
                                    {
                                        jobsid.Add(jobid[1]);

                                        BindingSource ResultsSource = new BindingSource();

                                        //jobsid.Select(item => new Jobids() { JobId = item }).ToList();

                                        // ResultsSource.DataSource = resultsArray.Select(item => jobid[1] = item).ToList();

                                        ResultsSource.Clear();


                                        var linesWithTheJobId = resultsArray
                                            .Where(x => x.Contains(jobid[1]))
                                            .Select(s=> new { Result = s}).ToList();
                                        //Print(linesWithTheJobId);


                                        ResultsSource.DataSource = linesWithTheJobId;

                                        results.Add(ResultsSource);


                                        

                                        // for (int i = 0; i < resultsArray.Length; i++)
                                        // {
                                        //if(resultsArray[i].Contains(jobid[1]))
                                        // {

                                        // }

                                        // results.Add(ResultsSource);

                                        //ResultsSource.Clear();

                                        //dataGridViewResults.DataSource = ResultsSource;


                                        //Console.Write(results);
                                    }
                                    
                            }

                        }
                    }


                        Datasource.Clear();
                        dataGridViewJobs.AutoResizeColumns();

                        Datasource.DataSource = jobsid.Select(item => new Jobids() { JobId = item }).ToList();

                        dataGridViewJobs.DataSource = Datasource;
                        dataGridViewJobs.Columns["JobId"].Width = 400;
                        dataGridViewJobs.Columns["JobId"].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                        this.dataGridViewJobs.Columns["JobId"].DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
                        this.dataGridViewJobs.EnableHeadersVisualStyles = false;
                        this.dataGridViewJobs.Columns["JobId"].HeaderCell.Style.BackColor = Color.LightGray;


                    }
                catch (Exception ex)
                {
                    var tmp = ex.Message;
                }
            }

            else
            {

            }
        }

    }

        
    private void dataGridViewJobs_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        int rowIndex = e.RowIndex;

            //BindingSource vaueToDisplay = new BindingSource();

            //vaueToDisplay = results[rowIndex];






            //dataGridViewResults.DataSource = vaueToDisplay.DataSource;

            dataGridViewResults.DataSource = results[rowIndex].DataSource;

            dataGridViewResults.Columns["Result"].Width = 400;
            dataGridViewResults.Columns["Result"].DefaultCellStyle.BackColor = Color.LightSkyBlue;
            this.dataGridViewResults.Columns["Result"].DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            this.dataGridViewResults.EnableHeadersVisualStyles = false;
            this.dataGridViewResults.Columns["Result"].HeaderCell.Style.BackColor = Color.LightGray;


        }

     
    }
}