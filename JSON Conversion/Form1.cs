using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JSON_Conversion
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string oldJSONstring;
        private string newJSON;



        private void importJSON()
        {
            string oldJsonPath = "";
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                oldJsonPath = folderBrowserDialog1.SelectedPath + "\\bi.json";
            }
            oldJSONstring = File.ReadAllText(oldJsonPath);
            oldJSONObject deserializedJson = JsonConvert.DeserializeObject<oldJSONObject>(oldJSONstring);

            MessageBox.Show(deserializedJson.id);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Convert_btn_Click(object sender, EventArgs e)
        {
            importJSON();
        }
    }
}
