using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReceiptCalculator {
    public partial class FinalTotals : Form {
        public FinalTotals() {
            InitializeComponent();
        }

        // This List will contain the final output that'll be written to a .TXT file when the "Write Results To File" button is pressed on the FinalTotals form.
        List<string> finalOutputList = new List<string>();
        // The following variables will be used in calculating the final totals owed by/to each person.
        double aCommunalTotalPerPerson = 0.00;
        double vCommunalTotalPerPerson = 0.00;
        double mCommunalTotalPerPerson = 0.00;
        // Here are the amounts owed to Andy by Vince and Mike.
        double amountVOwesA = 0.00;
        double amountMOwesA = 0.00;
        // Here are the amounts owed to Vince by Andy and Mike.
        double amountAOwesV = 0.00;
        double amountMOwesV = 0.00;
        // Here are the amounts owed to Mike by Andy and Vince.
        double amountAOwesM = 0.00;
        double amountVOwesM = 0.00;

        private static void WriteNumberToLabel(Label label, double value) {
            label.Text = String.Format("{0:N2}", value);
        }

        private void closeButton_Click(object sender, EventArgs e) {
            this.Dispose();
        }

        private void writeToFile_Click(object sender, EventArgs e) {
            Console.WriteLine("\n\nCreating output for 'ReceiptTotals.txt'...");            
            System.IO.File.WriteAllLines(@"C:\TestFolder\ReceiptTotals.txt", finalOutputList);
        }

        internal void outputReceipts(List userList) {
            finalOutputList.AddRange(userList.writeAllReceiptsToFile());
        }

        internal void outputListTotals(List userList) {            
            finalOutputList.Add(Environment.NewLine);
            finalOutputList.Add(String.Format("Final Totals For All Receipts On {0} List:", userList.returnListOwner()));
            finalOutputList.Add("----------------------------------");
            finalOutputList.Add(String.Format("Communal Total Of ALL Receipts On {0} List = {1}", userList.returnListOwner(), userList.returnCommunalTotal()));
            finalOutputList.Add(String.Format("Communal Total Owed Per Person Of ALL Receipts On {0} List = {1}", userList.returnListOwner(), userList.returnCommunalTotalPerPerson()));
            finalOutputList.Add(String.Format("Additional Total Amount Owed By Andy On {0} List = {1}", userList.returnListOwner(), userList.returnAListTotal()));
            finalOutputList.Add(String.Format("Additional Total Amount Owed By Vince On {0} List = {1}", userList.returnListOwner(), userList.returnVListTotal()));
            finalOutputList.Add(String.Format("Additional Total Amount Owed By Mike On {0} List = {1}", userList.returnListOwner(), userList.returnMListTotal()));
        }

        internal void outputFinalTotals() {
            finalOutputList.Add(Environment.NewLine);
            finalOutputList.Add("FINAL TOTALS:");
            finalOutputList.Add("=============");
            finalOutputList.Add(String.Format("Andy Owes Vince: ${0}", amountAOwesV));
            finalOutputList.Add(String.Format("Andy Owes Mike: ${0}", amountAOwesM));
            finalOutputList.Add(Environment.NewLine);
            finalOutputList.Add(String.Format("Vince Owes Andy: ${0}", amountVOwesA));
            finalOutputList.Add(String.Format("Vince Owes Mike: ${0}", amountVOwesM));
            finalOutputList.Add(Environment.NewLine);
            finalOutputList.Add(String.Format("Mike Owes Andy: ${0}", amountMOwesA));
            finalOutputList.Add(String.Format("Mike Owes Vince: ${0}", amountMOwesV));
        }

        internal void calcFinalTotals(List aList, List vList, List mList) {
            aCommunalTotalPerPerson = aList.returnCommunalTotal() / 3;
            vCommunalTotalPerPerson = vList.returnCommunalTotal() / 3;
            mCommunalTotalPerPerson = mList.returnCommunalTotal() / 3;
            amountVOwesA = aList.returnVListTotal() + aCommunalTotalPerPerson;
            amountMOwesA = aList.returnMListTotal() + aCommunalTotalPerPerson;
            amountAOwesV = vList.returnAListTotal() + vCommunalTotalPerPerson;
            amountMOwesV = vList.returnMListTotal() + vCommunalTotalPerPerson;
            amountAOwesM = mList.returnAListTotal() + mCommunalTotalPerPerson;
            amountVOwesM = mList.returnVListTotal() + mCommunalTotalPerPerson;

            // Now to compare each person's dues to the other person's dues.
            Console.WriteLine("\nComparing amounts owed to amounts due for each person...");
            if (amountVOwesA >= amountAOwesV) {
                amountVOwesA -= amountAOwesV;
                amountAOwesV = 0;
            }
            else if (amountVOwesA < amountAOwesV) {
                amountAOwesV -= amountVOwesA;
                amountVOwesA = 0;
            }
            else {
                Console.WriteLine("ERROR:  Invalid input for amounts that Andy owes Vince & vice versa.");
            }

            if (amountMOwesA >= amountAOwesM) {
                amountMOwesA -= amountAOwesM;
                amountAOwesM = 0;
            }
            else if (amountMOwesA < amountAOwesM) {
                amountAOwesM -= amountMOwesA;
                amountMOwesA = 0;
            }
            else {
                Console.WriteLine("ERROR:  Invalid input for amounts that Andy owes Mike & vice versa.");
            }

            if (amountMOwesV >= amountVOwesM) {
                amountMOwesV -= amountVOwesM;
                amountVOwesM = 0;
            }
            else if (amountMOwesV < amountVOwesM) {
                amountVOwesM -= amountMOwesV;
                amountMOwesV = 0;
            }
            else {
                Console.WriteLine("ERROR:  Invalid input for amounts that Vince owes Mike & vice versa.");
            }

            WriteNumberToLabel(vOwesA, amountVOwesA);
            WriteNumberToLabel(mOwesA, amountMOwesA);
            WriteNumberToLabel(aOwesV, amountAOwesV);
            WriteNumberToLabel(mOwesV, amountMOwesV);
            WriteNumberToLabel(aOwesM, amountAOwesM);
            WriteNumberToLabel(vOwesM, amountVOwesM);
        }
    }
}
