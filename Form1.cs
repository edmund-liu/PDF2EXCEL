using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastExcel;


namespace PDF2CSV
{
    
    public partial class Form1 : Form
    {
        string sFileName = null;
        string sSelectedPath = null;
        EventLog eventLog;

        public Form1()
        {
            InitializeComponent();
            eventLog = new EventLog("Application");
            
                eventLog.Source = "Application";
                eventLog.WriteEntry("PDF2CSV Started", EventLogEntryType.Information, 101, 1);
                lblInput.Text = "";
                lblOutput.Text = "";



        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!(lblInput.Text == "" && lblOutput.Text == ""))
            {

                var templateFile = new FileInfo(@".\Template.xlsx");
                var outputFile = new FileInfo(sSelectedPath + "\\output.xlsx");

                var arlist = new ArrayList();
                var lineCount = 0;
                string fileName = sFileName;


                //Create a worksheet with some rows
                var worksheet = new Worksheet();
                var rows = new List<Row>();
                // List<Cell> cells = new List<Cell>();

                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        lineCount++;
                        if (lineCount < 89)
                        {
                            //Ignore the first 89 Lines

                        }
                        else

                        {

                            int index = line.IndexOf(@"(");
                            int index2 = line.LastIndexOf(@")");

                            try
                            {
                                if (line.Contains("re S") && line.Contains("Td"))
                                {


                                    arlist.Add(line.Substring(index + 1, (index2 - index) - 1));

                                }
                                else if (line.Contains("re S"))
                                {
                                    arlist.Add("");

                                }

                            }

                            catch (Exception a)
                            {

                                Console.WriteLine("SKIP");
                                eventLog.WriteEntry(a.ToString(), EventLogEntryType.Error, 101, 1);

                            }





                        }

                    }
                }
            
        

            Console.WriteLine("Total arraycount: "+arlist.Count);
            Console.WriteLine("Total Lines to write: " +arlist.Count / 8);

            Console.WriteLine("ARRAYLIST: "+arlist.Count);
            int Original_ArrayCount = arlist.Count;


            for (int rowNumber = 1; rowNumber < ((Original_ArrayCount / 8) + 1); rowNumber++)
            {

                List<Cell> cells = new List<Cell>();
                for (int counter = 1; counter < 9; counter++)
                {
                    
                        
                        if(arlist.Count == 0)
                        {
                        cells.Add(new Cell(counter, "END"));
                        }
                        else
                        {
                        //Add the first item into the cell of the worksheet and pop it from the list. 
                        //The next in the array will be the first [0] and so on and so fourth
                        //FILO concept.
                        cells.Add(new Cell(counter, arlist[0]));
                        arlist.RemoveAt(0);
                        }




                }

                rows.Add(new Row(rowNumber, cells));
            }

            worksheet.Rows = rows;


            // Create an instance of FastExcel
            
                if (File.Exists(sSelectedPath + "\\output.xlsx"))
                {
                    File.Delete(sSelectedPath + "\\output.xlsx");
                }

            using (FastExcel.FastExcel fastExcel = new FastExcel.FastExcel(templateFile, outputFile))
            {
                // Write the data
                fastExcel.Write(worksheet, "Template");
            }

            Console.WriteLine(arlist.Count);

            MessageBox.Show("File has been converted successfully. Please exit application.");

            }
            else
            {
                MessageBox.Show("Select input and output files.");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            sFileName = null;
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                sFileName = choofdlog.FileName;
                //string[] arrAllFiles = choofdlog.FileNames; //used when Multiselect = true         
                lblInput.Text = sFileName;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sSelectedPath = null;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Custom Description";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                sSelectedPath = fbd.SelectedPath;
                lblOutput.Text = sSelectedPath;
            }
        }
    }
}
