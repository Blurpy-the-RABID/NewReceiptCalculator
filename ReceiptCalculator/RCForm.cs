using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReceiptCalculator {

    public partial class RCForm : Form {
        private static readonly string[] NameList = { "Andy", "Vince", "Mike", };

        private List[] listOwnerArray = new List[] { new List("Andy"), new List("Vince"), new List("Mike") };

        public RCForm() {
            InitializeComponent();

            currentListOwner.DataSource = NameList;
            currentReceiptComboBox.Items.Clear();

            NewReceipt();
        }

        #region Static Members

        private static void WriteNumberToTextBox(TextBox label, double value) {
            label.Text = String.Format("{0:N2}", value);
        }

        private static void WriteNumberToLabel(Label label, double value) {
            label.Text = String.Format("{0:N2}", value);
        }

        #endregion /* Static Members */

        /// <summary>
        /// Property to get the current users list
        /// </summary>
        private List CurrentList { get { return listOwnerArray[currentListOwner.SelectedIndex]; } }

        /// <summary>
        /// Property to get the current working receipt
        /// </summary>
        private Receipt CurrentReceipt { get { return CurrentList.returnList()[currentReceiptComboBox.SelectedIndex] as Receipt; } }
        
        /// <summary>
        /// Property to get the next receipt number (receipt list length + 1)
        /// </summary>
        private int NextReceiptNumber { get { return CurrentList.returnListLength() + 1; } }

        /// <summary>
        /// Write the receipt totals to the appropriate numeric up/down controls and text box controls
        /// </summary>
        private void WriteTotals() {
            communalTotal.Value = (decimal)CurrentReceipt.returnCommunalTotal();
            aTotal.Value = (decimal)CurrentReceipt.returnATotal();
            vTotal.Value = (decimal)CurrentReceipt.returnVTotal();
            mTotal.Value = (decimal)CurrentReceipt.returnMTotal();
        }

        /// <summary>
        /// Create a new receipt instance and add that receipt into the appropriate owner's list
        /// </summary>
        private void NewReceipt() {
            Receipt receipt = new Receipt(currentListOwner.SelectedItem.ToString(),
                NextReceiptNumber,
                0, 0, 0, 0);

            CurrentList.addReceiptToList(receipt);

            currentReceiptComboBox.Items.Add(receipt);
            currentReceiptComboBox.SelectedIndex = currentReceiptComboBox.Items.Count - 1;

            WriteTotals();
        }

        public void updateCurrentReceipt_Click(object sender, EventArgs e) {
            // Update the receipt with the values from the total text box fields
            CurrentReceipt.changeCommunalTotal((double)communalTotal.Value);
            CurrentReceipt.changeATotal((double)aTotal.Value);
            CurrentReceipt.changeVTotal((double)vTotal.Value);
            CurrentReceipt.changeMTotal((double)mTotal.Value);

            if (currentReceiptComboBox.SelectedIndex == NextReceiptNumber - 2) {
                NewReceipt();
            } else {
                WriteTotals();
            }

            CurrentList.calculateTotals();
            // Now to update the labels on the left of the interface that are keeping the running totals for the currently viewed receipt list.
            WriteNumberToLabel(aCommunalTotal, CurrentList.returnCommunalTotal());
            WriteNumberToLabel(aCommunalTotalPerPerson, CurrentList.returnCommunalTotal() / 3);

            if (currentListOwner.SelectedItem.ToString() == "Andy") {
                WriteNumberToLabel(additAmountOwedTotal1, CurrentList.returnVListTotal());
                WriteNumberToLabel(additAmountOwedTotal2, CurrentList.returnMListTotal());
            }
            else if (currentListOwner.SelectedItem.ToString() == "Vince") {
                WriteNumberToLabel(additAmountOwedTotal1, CurrentList.returnAListTotal());
                WriteNumberToLabel(additAmountOwedTotal2, CurrentList.returnMListTotal());
            }
            else if (currentListOwner.SelectedItem.ToString() == "Mike") {
                WriteNumberToLabel(additAmountOwedTotal1, CurrentList.returnAListTotal());
                WriteNumberToLabel(additAmountOwedTotal2, CurrentList.returnVListTotal());
            }
        }

        private void currentListOwner_SelectedIndexChanged(object sender, EventArgs e) {
            // Update the summary title to include the newly selected users name
            summaryTitle.Text = String.Format("{0}'s Totals:", currentListOwner.SelectedItem);
            WriteNumberToLabel(aCommunalTotal, CurrentList.returnCommunalTotal());
            WriteNumberToLabel(aCommunalTotalPerPerson, CurrentList.returnCommunalTotal() / 3);

            if (currentListOwner.SelectedItem.ToString() == "Andy") {
                additAmountOwed1.Text = String.Format("Addit. Total Amount Owed By Vince:");
                additAmountOwed2.Text = String.Format("Addit. Total Amount Owed By Mike:");
                WriteNumberToLabel(additAmountOwedTotal1, CurrentList.returnVListTotal());
                WriteNumberToLabel(additAmountOwedTotal2, CurrentList.returnMListTotal());
            }
            else if (currentListOwner.SelectedItem.ToString() == "Vince") {
                additAmountOwed1.Text = String.Format("Addit. Total Amount Owed By Andy:");
                additAmountOwed2.Text = String.Format("Addit. Total Amount Owed By Mike:");
                WriteNumberToLabel(additAmountOwedTotal1, CurrentList.returnAListTotal());
                WriteNumberToLabel(additAmountOwedTotal2, CurrentList.returnMListTotal());
            }
            else if (currentListOwner.SelectedItem.ToString() == "Mike") {
                additAmountOwed1.Text = String.Format("Addit. Total Amount Owed By Andy:");
                additAmountOwed2.Text = String.Format("Addit. Total Amount Owed By Vince:");
                WriteNumberToLabel(additAmountOwedTotal1, CurrentList.returnAListTotal());
                WriteNumberToLabel(additAmountOwedTotal2, CurrentList.returnVListTotal());
            }

            // Update the existing receipt list to include the list of receipts for the current user
            currentReceiptComboBox.Items.Clear();
            if (CurrentList.returnListLength() == 0) {
                NewReceipt();
            } else {
                foreach (Receipt receipt in CurrentList.returnList()) {
                    currentReceiptComboBox.Items.Add(receipt);
                }
            }
            currentReceiptComboBox.SelectedIndex = currentReceiptComboBox.Items.Count - 1;
        }

        private void currentReceiptComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            WriteTotals();
        }

        private void calcFinalTotals_Click(object sender, EventArgs e) {
            // Insert code for pop-up box with calculated totals HERE.
        }
    }

}
