using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SampleWPF.BGWorker
{
    /// <summary>
    /// Interaction logic for BGWorker.xaml
    /// </summary>
    public partial class BGWorker : Window
    {
        BackgroundWorker worker = null;
        public BGWorker()
        {
            InitializeComponent();
            pbSamp.Value = 0;
            lbSamp.Items.Clear();

            worker = new BackgroundWorker();
            worker.WorkerSupportsCancellation = true;
            worker.WorkerReportsProgress = true;
            worker.DoWork += Worker_DoWork;
            worker.ProgressChanged += Worker_ProgressChanged;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        }

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            worker.RunWorkerAsync();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            worker.CancelAsync();
        }

        private void Worker_DoWork(object? sender, DoWorkEventArgs e)
        {
            // NO UI CHANGES ON DO WORK METHOD
            int max = 200;
            for (int i = 0; i < max; i++)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;
                }
                int percentComplete = Convert.ToInt32(((double)i / max) * 100);
                (sender as BackgroundWorker).ReportProgress(percentComplete, i); //VALUE insert here to update on Progress Changed
                Thread.Sleep(100);
            }
            e.Result = max; //Send end result value here, max for sample.
        }

        private void Worker_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            // UI CHANGES FOR PROGRESS METHOD
            // e.ProgressPercentage for progress
            // e.UserState > value to update on UI
            pbSamp.Value = e.ProgressPercentage;
            if(e.UserState != null)
                lbSamp.Items.Add(e.UserState);
        }

        private void Worker_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                pbSamp.Value = 0;
                lbSamp.Items.Clear();
                MessageBox.Show("Worker thread was cancelled.");
            }
            else
                MessageBox.Show("Completed! Listed numbers until [" + e.Result + "]~" );
        }
    }
}
