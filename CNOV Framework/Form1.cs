using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Security.Cryptography;
using System.IO;
using System.Diagnostics;
using Microsoft.VisualBasic.Devices;

namespace CNOV_Framework
{
    public partial class Form1 : Form
    {
        //ANTIVIRUS START

        string fileName = "";
        private FileStream f;
        private StreamReader s;
        private FolderBrowserDialog folderBrowserDialog1;
        string currentFileHash = "";

        string currentFileName = "";

        int lineCountList;
        int currentLine = 0;
        int maxToRead = 0;

        private string _path;
        string[] allfiles;

        DateTime m_operationStart;

        private BackgroundWorker bw, bw2;
        float percentaje;

        TextWriter tw = new StreamWriter("InfectedFiles.txt");

        List<string> listInfected = new List<string>();
        bool infectados = false;

        //ANTIVIRUS END

        //PERFORMANCE START

        PerformanceCounter cpuCounter;
        PerformanceCounter ramCounter, ramTotalCounter;

        private BackgroundWorker bwCpuRamUpdater;

        //PERFORMANCE END

        //OPTIMIZATION START
        private BackgroundWorker processChecker;

        bool inProcess = false;

        System.Diagnostics.Process pr1, pr2, pr3;

        int nOfP;
        //OPTIMIZATION END

        public Form1()
        {
            InitializeComponent();

            //ANTIVIRUS START

            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();

            lineCountList = File.ReadLines("list.txt.txt").Count();

            this.bw = new BackgroundWorker();
            this.bw.WorkerReportsProgress = true;
            this.bw.WorkerSupportsCancellation = true;
            this.bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            this.bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);

            this.bw2 = new BackgroundWorker();
            this.bw2.WorkerReportsProgress = true;
            this.bw2.WorkerSupportsCancellation = true;
            this.bw2.DoWork += new DoWorkEventHandler(bw2_DoWork);
            this.bw2.ProgressChanged += new ProgressChangedEventHandler(bw2_ProgressChanged);

            //ANTIVIRUS END

            //PERFORMANCE START

            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            //ramTotalCounter = new PerformanceCounter("Memory", "Confirmed Bytes");

            this.bwCpuRamUpdater = new BackgroundWorker();
            this.bwCpuRamUpdater.WorkerReportsProgress = true;
            this.bwCpuRamUpdater.WorkerSupportsCancellation = true;
            this.bwCpuRamUpdater.DoWork += new DoWorkEventHandler(bwCpuRamUpdater_DoWork);
            this.bwCpuRamUpdater.ProgressChanged += new ProgressChangedEventHandler(bwCpuRamUpdater_ProgressChanged);

            if (!this.bwCpuRamUpdater.IsBusy)
            {
                this.bwCpuRamUpdater.RunWorkerAsync();
            }


            lbltotalram.Text = (new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory / 1e+6).ToString("N0") + " MB";

            //PERFORMANCE END

            //OPTIMIZATION START

            this.processChecker = new BackgroundWorker();
            this.processChecker.WorkerReportsProgress = true;
            this.processChecker.WorkerSupportsCancellation = true;
            this.processChecker.DoWork += new DoWorkEventHandler(processChecker_DoWork);
            this.processChecker.ProgressChanged += new ProgressChangedEventHandler(processChecker_ProgressChanged);

            if (!this.processChecker.IsBusy)
            {
                this.processChecker.RunWorkerAsync();
            }

            //OPTIMIZATION END
        }


        //ANTIVIRUS START

        static string CalculateMD5(string filename)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        private async void btnBrowse_ClickAsync(object sender, EventArgs e)
        {
            using (FileDialog fileDialog = new OpenFileDialog())
            {
                if (folderbox.Checked)
                {
                    DialogResult result2 = folderBrowserDialog1.ShowDialog();
                    if (result2 == DialogResult.OK)
                    {
                        _path = folderBrowserDialog1.SelectedPath;
                        txtFilePath.Text = _path;

                        allfiles = Directory.GetFiles(_path, "*.*", SearchOption.AllDirectories);

                        filesqty.Text = allfiles.Length.ToString();

                        lblResult.Text = "Escaneando...";
                        lblResult.ForeColor = Color.Cyan;
                        btnCancel.Enabled = true;

                        m_operationStart = DateTime.Now;

                        maxToRead = getTopLine();

                        if (!this.bw.IsBusy)
                        {
                            this.bw.RunWorkerAsync();
                            this.btnBrowse.Enabled = false;
                        }
                    }
                }
                else if (DialogResult.OK == fileDialog.ShowDialog())
                {
                    lblResult.Text = "Escaneando...";
                    lblResult.ForeColor = Color.Cyan;

                    UseWaitCursor = true;

                    fileName = fileDialog.FileName;
                    txtFilePath.Text = fileName;

                    currentFileHash = CalculateMD5(txtFilePath.Text);
                    txtHash.Text = currentFileHash;

                    currentFileName = Path.GetFileName(fileName);
                    lblfilename.Text = currentFileName;

                    f = System.IO.File.OpenRead("list.txt.txt");
                    s = new System.IO.StreamReader(f);

                    m_operationStart = DateTime.Now;

                    maxToRead = getTopLine();

                    if (!this.bw2.IsBusy)
                    {
                        this.bw2.RunWorkerAsync();
                        this.btnBrowse.Enabled = false;
                    }
                }
            }
        }

        private void bw2_DoWork(object sender, DoWorkEventArgs e)
        {
            infectados = false;
            int currentLine = 0;

            while (!s.EndOfStream && currentLine <= maxToRead)
            {
                if (bw2.CancellationPending)
                {
                    currentFileName = "";
                    bw2.ReportProgress(100);
                    e.Cancel = true;
                }
                else
                {
                    string line = s.ReadLine();
                    bw2.ReportProgress(s.Read() / s.ReadToEnd().Length);
                    if (line == currentFileHash)
                    {
                        infectados = true;
                        bw2.ReportProgress(100);
                        e.Result = infectados;

                        this.bw2.RunWorkerCompleted += bw2_RunWorkerCompleted;
                    }
                    else
                    {
                        infectados = false;
                        bw2.ReportProgress(100);
                        e.Result = infectados;

                        this.bw2.RunWorkerCompleted += bw2_RunWorkerCompleted;
                    }
                }
            }
        }

        void bw2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void bw2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnCancel.Enabled = false;
            btnBrowse.Enabled = true;
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled)
            {
                lblResult.Text = "Cancelado";
                lblResult.ForeColor = Color.Yellow;
            }
            else
            {
                if (infectados)
                {
                    lblResult.Text = "Infectado";
                    lblResult.ForeColor = Color.Red;
                    UseWaitCursor = false;
                }
                else
                {
                    lblResult.Text = "Libre de virus";
                    lblResult.ForeColor = Color.Green;
                    UseWaitCursor = false;
                }
            }
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            infectados = false;
            BackgroundWorker worker = (BackgroundWorker)sender;

            int total = allfiles.Length;
            int y = 0;
            foreach (var singleFile in allfiles)
            {
                if (bw.CancellationPending)
                {
                    currentFileName = "";
                    bw.ReportProgress(100);
                    e.Cancel = true;
                }
                else
                {
                    y++;
                    bw.ReportProgress((int)(y * 100.0 / total));

                    currentFileName = Path.GetFileName(singleFile);

                    f = System.IO.File.OpenRead("list.txt.txt");
                    s = new System.IO.StreamReader(f);

                    if (!IsFileLocked(singleFile))
                        currentFileHash = CalculateMD5(singleFile);
                    else
                        continue;

                    int currentLine = 0;

                    while (!s.EndOfStream && currentLine <= maxToRead)
                    {
                        string line = s.ReadLine();
                        currentLine++;
                        if (line == currentFileHash)
                        {
                            listInfected.Add(singleFile);
                            infectados = true;
                        }
                    }
                }
            }

            e.Result = infectados;
            this.bw.RunWorkerCompleted += bw_RunWorkerCompleted;
        }

        void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            lblfilename.Text = currentFileName;
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnCancel.Enabled = false;
            btnBrowse.Enabled = true;
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled)
            {
                lblResult.Text = "Cancelado";
                lblResult.ForeColor = Color.Yellow;
            }
            else
            {
                if (infectados)
                {
                    lblResult.Text = "Hubo infectados, revisar lista";
                    lblResult.ForeColor = Color.Red;
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(String.Join(Environment.NewLine, listInfected), "Estos son los archivos infectados, ¿desea eliminarlos?", buttons);

                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        foreach (string path in listInfected)
                        {
                            File.Delete(path);
                        }
                        this.btnBrowse.Enabled = true;
                        infectados = false;
                        listInfected.Clear();
                    }
                    else if (result == System.Windows.Forms.DialogResult.No)
                    {
                        this.btnBrowse.Enabled = true;
                        listInfected.Clear();
                    }
                }
                else
                {
                    lblResult.Text = "No hubo infectados";
                    lblResult.ForeColor = Color.Green;
                }
            }
        }

        protected virtual bool IsFileLocked(string filename)
        {
            try
            {

                using (Stream stream = new FileStream(filename, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                {
                    // Here you can copy your file
                    // then rename the copied file
                    return false;
                }
            }
            catch (Exception ex)
            {
                return true;
            }
        }

        private void folderbox_CheckedChanged(object sender, EventArgs e)
        {
            if (folderbox.Checked)
            {
                label2.Enabled = false;
                txtHash.Enabled = false;
                lblcant.Visible = true;
                filesqty.Visible = true;
            }
            else
            {
                label2.Enabled = true;
                txtHash.Enabled = true;
                lblcant.Visible = false;
                filesqty.Visible = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void antivirusgroup_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(bw2.IsBusy)
                this.bw2.CancelAsync();
            else if(bw.IsBusy)
                this.bw.CancelAsync();
        }

        private int getTopLine()
        {
            double calc;

            if (radlvl1.Checked)
                calc = lineCountList / 3;
            else if (radlvl2.Checked)
                calc = lineCountList / 2;
            else
                calc = lineCountList;

            return (int) Math.Round(calc);
        }

        //ANTIVIRUS END

        //PERFORMANCE START

        private void bwCpuRamUpdater_DoWork(object sender, DoWorkEventArgs e)
        {
            bool x = true;
            if (bwCpuRamUpdater.CancellationPending)
            {
                x = false;
                e.Cancel = true;
            }
            while (x)
            {
                System.Threading.Thread.Sleep(1000);
                bwCpuRamUpdater.ReportProgress(1);
            }
                
        }

        void bwCpuRamUpdater_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            getCurrentCpuUsage();
            getAvailableRAM();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public void getCurrentCpuUsage()
        {
            float x = cpuCounter.NextValue();
            cpupercentaje.Text = x.ToString("N2") + "%";
            progresscpu.Value = (int) x;
        }

        private void performancegroup_Enter(object sender, EventArgs e)
        {

        }

        public void getAvailableRAM()
        {
            lblavaram.Text = ramCounter.NextValue() + " MB";
        }

        //PERFORMANCE END

        //OPTIMIZATION START

        private void btnopt1_Click(object sender, EventArgs e)
        {
            if (!processChecker.IsBusy && !inProcess)
            {
                nOfP = 1;
                processChecker.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Espere a que termine el anterior proceso", caption: "Error");
            }
        }

        private void btnopt2_Click(object sender, EventArgs e)
        {
            if (!processChecker.IsBusy && !inProcess)
            {
                nOfP = 2;
                processChecker.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Espere a que termine el anterior proceso", caption: "Error");
            }
        }

        private void btnopt3_Click(object sender, EventArgs e)
        {
            if (!processChecker.IsBusy && !inProcess)
            {
                nOfP = 3;
                processChecker.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Espere a que termine el anterior proceso", caption: "Error");
            }
        }

        private void processChecker_DoWork(object sender, DoWorkEventArgs e)
        {
            switch (nOfP)
            {
                case 1:
                    pr1 = System.Diagnostics.Process.Start(@"bats\DeshabilitarServicios1.bat");
                    pr1.StartInfo.CreateNoWindow = true;
                    pr1.StartInfo.Verb = "runas";

                    processChecker.ReportProgress(1);
                    pr1.WaitForExit();
                    break;
                case 2:
                    pr2 = System.Diagnostics.Process.Start(@"bats\DeshabilitarServicios2.bat");
                    pr2.StartInfo.CreateNoWindow = true;
                    pr2.StartInfo.Verb = "runas";

                    processChecker.ReportProgress(2);
                    pr2.WaitForExit();
                    break;
                case 3:
                    pr3 = System.Diagnostics.Process.Start(@"bats\EliminarTEMP.bat");
                    pr3.StartInfo.CreateNoWindow = true;
                    pr3.StartInfo.Verb = "runas";

                    processChecker.ReportProgress(3);
                    pr3.WaitForExit();
                    break;
            }

            this.processChecker.RunWorkerCompleted += processChecker_RunWorkerCompleted;
        }

        void processChecker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if(e.ProgressPercentage == 1)
                lblinprocess.Text = "Optimizando... (1)";
            else if(e.ProgressPercentage == 2)
                lblinprocess.Text = "Optimizando... (2)";
            else
                lblinprocess.Text = "Optimizando... (3)";

            lblinprocess.ForeColor = Color.Red;

        }

        void processChecker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblinprocess.Text = "Listo para optimizar";
            lblinprocess.ForeColor = Color.Green;
        }

            //OPTIMIZATION END
    }
}
