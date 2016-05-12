using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            TransferInfo AddDataTransfer = new TransferInfo(txtNTName.Text, txtFirstName.Text, txtLastName.Text, txtPhone.Text, txtOldName.Text);
            DatabaseAccess AddDT = new DatabaseAccess();
            AddDT.Add(AddDataTransfer);
            System.IO.File.WriteAllText(@"C:\cops\Number.txt","Someone should be hoping on  your PC soon. If you do not see anyone on your new PC, Please give us a call at 843-383-7050. Thanks ");
            System.Diagnostics.Process.Start(@"C:\cops\Number.txt");

            this.Close();

        }
    }
}
