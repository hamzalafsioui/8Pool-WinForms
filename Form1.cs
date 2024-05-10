using System.Windows.Forms;

namespace _8Pool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void poolTable_OnTableComplete(object sender, PoolTable.TableCompletedEventArgs e)
        {
            string TableResults = "";

            TableResults = "Time Consumed " + e.TimeText;
            TableResults = TableResults + ", Total Seconds = " + e.TimeInSeconds;
            TableResults = TableResults + ", HourlyRate = " + e.RatePerHour.ToString();
            TableResults = TableResults + ", Total Fees = " + e.TotalFees.ToString();

            MessageBox.Show(TableResults);
        }
    }
}
