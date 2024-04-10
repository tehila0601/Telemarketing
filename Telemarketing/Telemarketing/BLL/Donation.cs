﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Telemarketing.BLL
{
    internal class Donation
    {
        DataRow dr;
        private int donationID;
        private int donorID;
        private int employeeID;
        private int projectID;
        private int sum;
        private string paymentOption;
        private string creditNumber;
        private DateTime validity;
        private string CVV;
        private int numberPayments;
        private string paymentStatus;
        private DateTime donationDate;


        private string cityName;

        public DataRow Dr { get => dr; set => dr = value; }
        public int DonationID { get => donationID; set => donationID = value; }
        public int DonorID { get => donorID; set => donorID = value; }
        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public int ProjectID { get => projectID; set => projectID = value; }
        public int Sum { get => sum; set => sum = value; }
        public string PaymentOption { get => paymentOption; set => paymentOption = value; }
        public string CreditNumber { get => creditNumber; set => creditNumber = value; }
        public DateTime Validity { get => validity; set => validity = value; }
        public string CVV1 { get => CVV; set => CVV = value; }
        public int NumberPayments { get => numberPayments; set => numberPayments = value; }
        public string PaymentStatus { get => paymentStatus; set => paymentStatus = value; }
        public DateTime DonationDate { get => donationDate; set => donationDate = value; }

        public Donation() { }
        public Donation(DataRow dr)
        {
            this.dr = dr;
            this.DonationID = Convert.ToInt32(dr["Donation_ID"]);
            this.DonorID = Convert.ToInt32(dr["Donor_ID"]);
            this.EmployeeID = Convert.ToInt32(dr["Employee_ID"]);
            this.ProjectID = Convert.ToInt32(dr["Project_ID"]);
            this.Sum = Convert.ToInt32(dr["Sum"]);
            this.PaymentOption = dr["Payment_Option"].ToString();
            this.CreditNumber = dr["Credit_Number"].ToString();
            this.Validity = Convert.ToDateTime(dr["Validity"]);
            this.CVV1 = dr["CVV"].ToString();
            this.NumberPayments = Convert.ToInt32(dr["Number_Payments"]);
            this.PaymentStatus = dr["Payment_Status"].ToString();
            this.DonationDate = Convert.ToDateTime(dr["Donation_Date"]);


        }

        public void PutInto()
        {
            dr["Donation_ID"] = this.DonationID;
            dr["Donor_ID"] = this.DonorID;
            dr["Employee_ID"] = this.EmployeeID;
            dr["Project_ID"] = this.ProjectID;
            dr["Sum"] = this.Sum;
            dr["Payment_Option"] = this.PaymentOption;
            dr["Credit_Number"] = this.CreditNumber;
            dr["Validity"] = this.Validity;
            dr["CVV"] = this.CVV1;
            dr["Number_Payments"] = this.NumberPayments;
            dr["Payment_Status"] = this.PaymentStatus;
            dr["Donation_Date"] = this.DonationDate;
        }

        public override string ToString()
        {
            return DonorID+" "+Sum;
        }
    }
}
