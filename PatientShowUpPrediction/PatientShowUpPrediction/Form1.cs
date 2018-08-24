using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PatientShowUpPrediction
{
    

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class StringTable
        {
            public string[] ColumnNames { get; set; }
            public string[,] Values { get; set; }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ageBox_TextChanged(object sender, EventArgs e)
        {

        }

        private async void confirmBtn_Click(object sender, EventArgs e)
        {
            

            string age = ageBox.Text.ToString();
            string gender = genderBox.Text.ToString();
            string diabetes = diabetesBox.Text.ToString();
            string alcohol = alcoholismBox.Text.ToString();
            string hiper = hiperBox.Text.ToString();
            string handicap = handicapBox.Text.ToString();
            string smokes = smokesBox.Text.ToString();
            string school = scolarshipBox.Text.ToString();
            string tbc = tbcBox.Text.ToString();
            string sms = smsBox.Text.ToString();
            string awaitnum = awaitBox.Text.ToString();
            string day = dayBox.Text.ToString();

            
            bool somethingEmty = false;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text == "")
                        somethingEmty = true;
                }
            }
            if (somethingEmty)
                MessageBox.Show("Popunite sva polja!");
            else
            {
                using (var client = new HttpClient())
                {
                    var scoreRequest = new
                    {

                        Inputs = new Dictionary<String, StringTable>() {
                        {
                            "input1",
                            new StringTable()
                            {
                                ColumnNames = new string[] {"Age", "Gender", "AppointmentRegistration", "ApointmentData", "DayOfTheWeek", "Status", "Diabetes", "Alcoolism", "HiperTension", "Handcap", "Smokes", "Scholarship", "Tuberculosis", "Sms_Reminder", "AwaitingTime"},
                                Values = new string[,] {  { age, gender, "", "", day, "", diabetes, alcohol, hiper, handicap,smokes ,school, tbc, sms, awaitnum },
                                /*{ "0", "value", "", "", "value", "value", "0", "0", "0", "0", "0", "0", "0", "0", "0" },*/}
                            }
                        },
                    },
                        GlobalParameters = new Dictionary<string, string>()
                        {
                        }
                    };
                    const string apiKey = "JIKp0WJ6RDJPSX1PKq57+pePpASckKuSKnV3cONKxbKn9bFVVplOxJyV/J/XR+7f5PkMuxp5Ta7B4IL1kLSkoA==";
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
                    client.BaseAddress = new Uri("https://ussouthcentral.services.azureml.net/workspaces/e1b8a1845a89432d8f71e613c63a9a00/services/2aa7807764c64b21976f49917e3fd9af/execute?api-version=2.0&details=true");

                    HttpResponseMessage response = await client.PostAsJsonAsync("", scoreRequest);

                    if (response.IsSuccessStatusCode)
                    {
                        string[] resultArray;
                        string result = await response.Content.ReadAsStringAsync();
                        resultArray = result.Split(':'); 
                        resultArray[7] = resultArray[7].Replace("}", "");
                        resultArray[7] = resultArray[7].Replace("]", "");
                        resultArray[7] = resultArray[7].Replace("\"", "");
                        resultArray[7] = resultArray[7].Replace("\"", "");
                        resultArray[7] = resultArray[7].Replace(",", " ");
                        resultArray[7] = resultArray[7].Replace("null", " ");
                        resultArray[7] = resultArray[7].Replace(age, "");
                        resultArray[7] = resultArray[7].Replace(day, "");
                        resultArray[7] = resultArray[7].Replace(gender, "");
                        resultArray[7] = resultArray[7].Replace("[", "");
                        resultArray[7] = resultArray[7].Replace(diabetes, "");
                        resultArray[7] = resultArray[7].Replace(alcohol, "");
                        resultArray[7] = resultArray[7].Replace(hiper, "");
                        resultArray[7] = resultArray[7].Replace(handicap, "");
                        resultArray[7] = resultArray[7].Replace(smokes, "");
                        resultArray[7] = resultArray[7].Replace(school, "");
                        resultArray[7] = resultArray[7].Replace(tbc, "");
                        resultArray[7] = resultArray[7].Replace(sms, "");
                        resultArray[7] = resultArray[7].Replace(awaitnum, "");

                        MessageBox.Show(resultArray[7]);
           
                    }
                    else
                    {
                        
                        MessageBox.Show(string.Format("The request failed with status code: {0}", response.StatusCode));

                        // Print the headers - they include the requert ID and the timestamp, which are useful for debugging the failure
                        MessageBox.Show(response.Headers.ToString());

                        string responseContent = await response.Content.ReadAsStringAsync();
                        MessageBox.Show(responseContent);
                    }
                }

            }
        }
    }
}
