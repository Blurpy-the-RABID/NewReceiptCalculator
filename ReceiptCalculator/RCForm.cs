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

        private List[] listOwnerArray = new List[] { new List(), new List(), new List() };

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
            // TODO: Make all these text box controls numeric up/down controls instead and remove text box documentation
            communalTotal.Value = (decimal)CurrentReceipt.returnCommunalTotal();
            WriteNumberToTextBox(aTotal, CurrentReceipt.returnATotal());
            WriteNumberToTextBox(vTotal, CurrentReceipt.returnVTotal());
            WriteNumberToTextBox(mTotal, CurrentReceipt.returnMTotal());
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
            CurrentReceipt.changeATotal(Convert.ToDouble(aTotal.Text));
            CurrentReceipt.changeVTotal(Convert.ToDouble(vTotal.Text));
            CurrentReceipt.changeMTotal(Convert.ToDouble(mTotal.Text));

            if (currentReceiptComboBox.SelectedIndex == NextReceiptNumber - 2) {
                NewReceipt();
            } else {
                WriteTotals();
            }

            CurrentList.calculateTotals();
            WriteNumberToLabel(aCommunalTotal, CurrentList.returnCommunalTotal());
        }

        private void currentListOwner_SelectedIndexChanged(object sender, EventArgs e) {
            // Update the summary title to include the newly selected users name
            summaryTitle.Text = String.Format("{0}'s Totals:", currentListOwner.SelectedItem);

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

    }

}
