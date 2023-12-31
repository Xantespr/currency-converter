using System;
using System.Net.Http;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;

namespace currency_converter
{
    public partial class Form1 : Form
    {
        private ConversionRate conversionRate;

        public Form1()
        {
            InitializeComponent();
            amountBox.TextChanged += new EventHandler(amountBox_TextChanged);
            conversionRate = new ConversionRate();
            FetchDataAsync();
            
        }

        private async void FetchDataAsync()
        {
            string apiUrl = "https://api.nbp.pl/api/exchangerates/tables/a/?format=json";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    // Check if the request was successful (status code 200)
                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();
                        conversionRate.UpdateFromJson(content);
                        foreach (var kvp in conversionRate.Rates)
                        {
                            baseCurBox.Items.Add(kvp.Key);
                            targetCurBox.Items.Add(kvp.Key);
                        }
                        baseCurBox.SelectedItem = conversionRate.Rates.First().Key;
                        targetCurBox.SelectedItem = conversionRate.Rates.First().Key;
                    }
                    else
                    {
                        MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}", "API Error");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Exception: {ex.Message}", "Exception");
                }
            }
        }

        private void changedCurrency()
        {
            string baseCurrency = baseCurBox.SelectedItem.ToString();
            string targetCurrency = targetCurBox.SelectedItem.ToString();
            double amount;
            try
            {
                amount = Convert.ToDouble(amountBox.Text);
            }
            catch
            {
                MessageBox.Show($"Your amount value is not decimal.");
                return;
            }
            textBox2.Text = (conversionRate.Rates[baseCurrency] * amount / conversionRate.Rates[targetCurrency]).ToString("0.0000");
        }

        private void switchCurBtn_Click(object sender, EventArgs e)
        {
            string temp = baseCurBox.SelectedItem.ToString();
            baseCurBox.SelectedItem = targetCurBox.SelectedItem.ToString();
            targetCurBox.SelectedItem = temp; 
        }

        private void baseCurBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (targetCurBox.SelectedIndex == -1) {
                return;
            }
            changedCurrency();
        }

        private void targetCurBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            changedCurrency();
        }

        void amountBox_TextChanged(object sender, EventArgs e)
        {
            changedCurrency();
        }
    }

    public class ConversionRate
    {
        public Dictionary<string, double> Rates { get; } = new Dictionary<string, double>();

        public ConversionRate()
        {
            Rates["PLN"] = 1.0;
        }
        public void UpdateFromJson(string jsonData)
        {
            JsonDocument jsonDocument = JsonDocument.Parse(jsonData);
            JsonElement ratesArray = jsonDocument.RootElement.EnumerateArray().First().GetProperty("rates");

            foreach (JsonElement rateElement in ratesArray.EnumerateArray())
            {
                string code = rateElement.GetProperty("code").GetString();
                double mid = rateElement.GetProperty("mid").GetDouble();
                Rates[code] = mid;
            }
        }
    }

}
