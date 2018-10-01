using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ohio_Health_Kata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            int start = Convert.ToInt16(StartTime.SelectedItem);
            int end = Convert.ToInt16(EndTime.SelectedItem);
            int bedtime = Convert.ToInt16(BedTime.SelectedItem);


            int prebedtime = 12;
            int bedtime2mid = 8;
            int postmid = 14;
            int diff;
            int cost;

            if (start < 1700 )
            {
                start = start + 2400;             
            }
            if (end < 1700 )
            {

                end = end + 2400;
              
            }
            if (bedtime < 1700)
            {

                bedtime = bedtime + 2400;

            }

            diff = (start - end) / 100 * -1;
            int prebedcost = ((start - bedtime)/100 * -1) * prebedtime;
            int postbedcost = ((bedtime - 2400) / 100 * -1) * bedtime2mid;
            int postmidnight = ((2400 - end) / 100 * -1) * postmid;
            int Total = prebedcost + postbedcost + postmidnight;
            MessageBox.Show(diff.ToString() + " Total Hours " + Environment.NewLine + "Pre Bed Cost: $" + prebedcost + Environment.NewLine + "Pre Midnight Cost: $" + postbedcost + Environment.NewLine + "Post Midnight Cost: $" + postmidnight + Environment.NewLine + "Total: $" + Total);
           

            if ((diff <= 0))
            {
                MessageBox.Show("End Time Must Be After Start Time");
            }
        }
    }
}
