using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace TestProjectsWord
{
    public partial class CustomerInformation : Form
    {
        public CustomerInformation()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Ensure a connection before the summit button can go through
            if (hasInternetConnection() == true)
            {
                TransferInfo AddDataTransfer = new TransferInfo(txtNTName.Text, txtFirstName.Text, txtLastName.Text, txtPhone.Text, txtOldName.Text);
                DatabaseAccess AddDT = new DatabaseAccess();
                AddDT.Add(AddDataTransfer);
                System.IO.File.WriteAllText(@"C:\cops\Number.txt", "Someone should be remoting in on your new PC in the next hour or less. If you do not see anyone on your new PC, Please give us a call at 843-383-7050. Thanks ");
                System.Diagnostics.Process.Start(@"C:\cops\Number.txt");
                this.Close();
            }
            else
            {
                MessageBox.Show("NETWORK ERROR. Please check your network connection and Try Again");
            }

        }
        //Chekcs for Internet Connection by ping a website(sonoco.com)...http://www.sonco.com would not work.
        public bool hasInternetConnection()
        {
            string host = "sonoco.com";
            bool result = false;
            Ping p = new Ping();
            try
            {
                PingReply reply = p.Send(host, 3000);
                if (reply.Status == IPStatus.Success)
                    return true;
            }
            catch { }
            return result;
        }
    }
}
