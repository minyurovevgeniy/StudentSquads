using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Text.Json;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Reflection;
using Newtonsoft.Json.Linq;

namespace StudentSquads
{
    public partial class StudentSquadsForm : Form
    {
        HttpClient client;



        List<Squad> squads;
        public string sURL = "https://buildingsquaduspu.xn--100-5cdnry0bhchmgqi5d.xn--p1ai/php/getSquads.php";
        public StudentSquadsForm()
        {
            client = new();
            InitializeComponent();
            squads = new List<Squad>();
        }

        private void loadStudentSquads_Click(object sender, EventArgs e)
        {

            backgroundWorker1.RunWorkerAsync();



            //squads = ProcessRepositoriesAsync(client);
            //ProcessRepositoriesAsync(client);

        }
        async Task ProcessRepositoriesAsync(HttpClient client)
        {

            await using Stream stream = await client.GetStreamAsync("https://buildingsquaduspu.xn--100-5cdnry0bhchmgqi5d.xn--p1ai/php/getSquads.php");
            /*
            squads = await JsonSerializer.DeserializeAsync<List<Squad>>(stream);
            for (int i = 0; i < squads.Count; i++)
            {
                squadsList.Items.Add(squads[i].Name);
            }
            */
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            squads = new List<Squad>();
            var json = new WebClient().DownloadString(sURL);

            json = json.Substring(0, json.Length - 1).Substring(json.IndexOf(":") + 1);

            /*
            string removeString = @"squads\";
            int index = json.IndexOf(removeString);
            json = (index < 0)
                ? json
                : json.Remove(index, removeString.Length);
            */
            try
            {
                squads = JsonConvert.DeserializeObject<List<Squad>>(json);


            }
            catch (Exception ex)
            {

            }

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            for (int i = 0; i < squads.Count; i++)
            {
                squadsList.Items.Add(squads[i].Name);
            }
        }

    }
}