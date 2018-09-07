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

namespace PatientPredictionFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string gender, diabetes, alcoholism, hipertension, handicap, smoking, scholarship, sms, day, tbc;
        public class StringTable
        {
            public string[] ColumnNames { get; set; }
            public string[,] Values { get; set; }
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            
            string age = ageBox.Text.ToString();
            string awaitdays = awaitBox.Text.ToString();

            //GENDER RADIOBUTTON
            if (radioBtnMale.Checked)   {gender = "M"; }
            if (radioBtnFemale.Checked) {gender = "F"; }

            //DAY OF THE WEEK
            if (rbMon.Checked)  { day = "Monday"; }
            if (rbTue.Checked)  { day = "Tuesday"; }
            if (rbWed.Checked)  { day = "Wednesday"; }
            if (rbThur.Checked) { day = "Thursday"; }
            if (rbFri.Checked)  { day = "Friday"; }
            if (rbSat.Checked)  { day = "Saturday"; }
            if (rbSun.Checked)  { day = "Sunday"; }

            //DIABETES
            if (rbDiaNo.Checked) { diabetes = "0"; }
            if (rbDiaYes.Checked) { diabetes = "1"; }

            //ALCOHOLISM
            if (rbAlcNo.Checked) { alcoholism = "0"; }
            if (rbAlcYes.Checked) { alcoholism = "1"; }

            //HIPERTENSION
            if (rbHipNo.Checked) { hipertension = "0"; }
            if (rbHipYes.Checked) { hipertension = "1";  }

            //HANDICAP LEVEL
            if (rbHanCapZero.Checked) { handicap = "0"; }
            if (rbHanCapOne.Checked) { handicap = "1"; }
            if (rbHanCapTwo.Checked) { handicap = "2"; }
            if (rbHanCapThree.Checked) { handicap = "3"; }
            if (rbHanCapFour.Checked) { handicap = "4"; }

            //SMOKING
            if (rbSmoNo.Checked) { smoking = "0"; }
            if (rbSmoYes.Checked) { smoking = "1"; }
     
            //SCHOLARSHIP
            if (rbSchNo.Checked) { scholarship = "0"; }
            if (rbSchYes.Checked) { scholarship = "1"; }

            //TUBERCULOSIS
            if (rbTbcNo.Checked) { tbc = "0"; }
            if (rbTbcYes.Checked) { tbc = "1"; }

            //SMS REMINDER
            if (rbSmsZero.Checked) { sms = "0"; }
            if (rbSmsOne.Checked) { sms = "1"; }
            if (rbSmsTwo.Checked) { sms = "2"; }

            bool somethingEmpty = false;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text == "")
                    somethingEmpty = true;
                }
            }

            if (somethingEmpty)
            {
                MessageBox.Show("Popunite sva polja!");
            }
            else
            {
                using(var client = new HttpClient())
                {
                    var scoreRequest = new
                    {

                        Inputs = new Dictionary<string, StringTable>() {
                        {
                            "input1",
                            new StringTable()
                            {
                                ColumnNames = new string[] {"Age", "Gender", "DayOfTheWeek", "Status", "Diabetes", "Alcoolism", "HiperTension", "Handcap", "Smokes", "Scholarship", "Tuberculosis", "Sms_Reminder", "AwaitingTime"},
                                Values = new string[,] {  { age, gender, day, "", diabetes, alcoholism, hipertension, handicap, smoking, scholarship, tbc, sms,awaitdays },}
                            }
                        },
                    },
                        GlobalParameters = new Dictionary<string, string>()
                        {
                        }
                    };

                    const string apiKey = "zW2hbCctTVV/nJyEhog3S2wmK+69jaSQkcOTYc5s47DdLTQIgQXDeGVgBIgCFZY9uTJwdCmiEw9Wl9K14x5KvQ=="; // Replace this with the API key for the web service
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
                    client.BaseAddress = new Uri("https://ussouthcentral.services.azureml.net/workspaces/e1b8a1845a89432d8f71e613c63a9a00/services/bcd59111003d495599ffa8e5d0fc67a4/execute?api-version=2.0&details=true");

                    HttpResponseMessage response = await client.PostAsJsonAsync("", scoreRequest);

                    if (response.IsSuccessStatusCode)
                    {
                        string[] resultArray;
                        string result = await response.Content.ReadAsStringAsync();
                        //MessageBox.Show("Result: {0}", result);
                        resultArray = result.Split(':');

                        resultArray[7] = resultArray[7].Replace("}", "");
                        resultArray[7] = resultArray[7].Replace("]", "");
                        resultArray[7] = resultArray[7].Replace("[", "");
                        resultArray[7] = resultArray[7].Replace("\"", " ");


                        var outputString = string.Join(",", resultArray[7]);
                        
                        MessageBox.Show("Status of prediction: " + outputString ,"Results", MessageBoxButtons.OK);


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

        private void radioBtnMale_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
