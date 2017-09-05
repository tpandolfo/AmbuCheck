using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AmbuCheckPrototype
{
    public partial class MainForm : Form
    {
        SandboxEntities _db;

        Dictionary<int, int> ambulanceCache;

        Dictionary<string, string> templates;
        string templateFolder = @"..\..\Templates";

        public MainForm()
        {
            InitializeComponent();
            //InitializeTemplates();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Populate Form Values

            _db = new SandboxEntities();


            // Ambulance Numbers

            ambulanceCache = new Dictionary<int, int>();

            foreach (Ambulance a in _db.Ambulances.ToList())
            {
                if (a.ambulanceNumber != null)
                {
                    ambulanceCache[(int)a.ambulanceNumber] = a.id;
                    comboBox_RigNumber.Items.Add(a.ambulanceNumber);
                }
            }
            

            // Date and time

            textBox_Date.Text = DateTime.Now.Date.ToShortDateString();
            textBox_Time.Text = DateTime.Now.ToString("HH:mm");


            // Set up Autocomplete for crew names

            AutoCompleteStringCollection crewNames = new AutoCompleteStringCollection();
            crewNames.AddRange(_db.Reports.Select(r => r.crew1).Concat(_db.Reports.Select(r => r.crew2)).Distinct().ToArray());
            textBox_Crew1.AutoCompleteCustomSource = crewNames;
            textBox_Crew2.AutoCompleteCustomSource = crewNames;

        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            // Add new report to the database
            var r = new Report();

            // Validation

            // TODO Add validation, raise warnings if invalid fields


            // Add Report Data

            // TODO Add Report Data


            // Add the Report

            r.ambulanceId = Convert.ToInt32(_db.Ambulances.Where(a => a.ambulanceNumber == Convert.ToInt32(comboBox_RigNumber.Text)).Select(a => a.id).First());
            r.crew1 = textBox_Crew1.Text;
            r.crew2 = textBox_Crew2.Text;
            r.dateTime = DateTime.Now;

            _db.Reports.Add(r);
            _db.SaveChanges();


            // Close the program

            Close();
        }

        // FUTURE
        // Maps checklist template names to XML files.
        private void InitializeTemplates()
        {
            templates = new Dictionary<string, string>();

            foreach (string filename in Directory.GetFiles(templateFolder, "*.xml"))
            {
                using (XmlReader reader = XmlReader.Create(filename))
                {
                    while (reader.Read())
                    {
                        if (reader.IsStartElement() && reader.Name == "checklist")
                        {
                            string templateName = reader.GetAttribute("name");
                            templates[templateName] = filename;
                        }
                    }
                }
            }
        }


        // FUTURE
        // Loads a checklist template from an XML document, and constructs the checklist out of Windows Forms Controls.
        private void LoadTemplate(string templateName)
        {
            string templateFileName = templates[templateName];
            Checklist checklist = new Checklist();
            checklist.LoadTemplate(templateFileName);


            // TODO: Build checklist out of WF Controls

            //this.panel_Checklist.Controls.Add();
        }
    }
}
