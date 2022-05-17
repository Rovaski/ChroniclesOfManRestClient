using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChroniclesOfManRestClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitRest_Click(object sender, EventArgs e)
        {
            RestClient restClient = new RestClient();
            restClient.endPoint = txtRestUrl.Text;

            string strResponse = string.Empty;

            strResponse = restClient.makeRequest();

            responseOutput(PrettyJson(strResponse));

        }

        private void responseOutput(string strResponse)
        {
            try
            {
                System.Diagnostics.Debug.Write(strResponse + Environment.NewLine);
                txtResponse.Text = txtResponse.Text +strResponse + Environment.NewLine;
                txtResponse.SelectionStart = txtResponse.TextLength;
                txtResponse.ScrollToCaret();
            }
            catch (Exception e)
            {

                System.Diagnostics.Debug.Write(e.Message, ToString() + Environment.NewLine);
            }
        }

        private void searchRest_Click(object sender, EventArgs e)
        {
            RestClient restClient = new RestClient();
            restClient.endPoint = txtRestUrl.Text + "?filter[title:contains]=" + searchBoxInput.Text;

            
            string strResponse = string.Empty;

            strResponse = restClient.makeRequest();
            txtResponse.Clear();
            responseOutput(PrettyJson(strResponse));
        }

        public string PrettyJson(string garbage)
        {
            var options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            var jsonElement = JsonSerializer.Deserialize<JsonElement>(garbage);
            return JsonSerializer.Serialize(jsonElement, options);
        }
    }
}
