﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectsWord
{
    class TransferInfo
    {
        public String EmployeeID;
        public String FirstName;
        public String LastName;
        public String PhoneNumber;
        public String OldComputer;
        public String CopsID;
        

       public TransferInfo(String EmployeeID, String FirstName,String LastName, String PhoneNumber,String OldComputer,String CopsID){
            this.EmployeeID=EmployeeID;
            this.FirstName=FirstName;
            this.LastName=LastName;
            this.PhoneNumber=PhoneNumber;
            this.OldComputer=OldComputer;
            this.CopsID = CopsID;
        }
       public TransferInfo(String EmployeeID, String FirstName, String LastName, String PhoneNumber, String OldComputer)
       {
           this.EmployeeID = EmployeeID;
           this.FirstName = FirstName;
           this.LastName = LastName;
           this.PhoneNumber = PhoneNumber;
           this.OldComputer = OldComputer;
           
       }

    }
}
