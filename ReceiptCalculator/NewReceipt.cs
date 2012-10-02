using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * This namespace contains some updated classes that demonstrate more
 * advanced methods of using C# to perform some of the same capabilities
 * of the implementations that you have written.  Each of these classes
 * has many of the same capabilities along with some additional capabilites
 * that allow you the writer to use less code and still get the same results.
 */
namespace ReceiptCalculator.NicksAdditionalSource {

    /*
     * Example Usage in different places from RCForm:
     * 
        private ReceiptList[] listOwnerArray = new ReceiptList[] {
                                                    new ReceiptList("Andy"),
                                                    new ReceiptList("Vince"),
                                                    new ReceiptList("Mike"),
                                                };
     * 
        private ReceiptList CurrentList { get { return listOwnerArray[currentListOwner.SelectedIndex]; } }
     * 
        private NewReceipt CurrentReceipt { get { return CurrentList[currentReceiptComboBox.SelectedIndex]; } }
     * 
        private int NextReceiptNumber { get { return CurrentList.Count + 1; } }
     *
        public void updateCurrentReceipt_Click(object sender, EventArgs e) {
            // Update the receipt with the values from the total text box fields
            CurrentReceipt2.CommunalTotal = communalTotal.Value;
            ...
        }
     * 
     */

    #region NewReceipt Implementation

    /// <summary>
    /// NewReceipt is an updated implementation of Receipt to use more advanced features of C#
    /// </summary>
    class NewReceipt {
        /// <summary>
        /// The name of this receipt instance
        /// </summary>
        private string recieptName;

        public NewReceipt(int number) {
            recieptName = " Receipt " + number;
        }

        #region Properties

        /// <summary>
        /// Property to get the name of this receipt instance
        /// </summary>
        public string RecieptName { get { return recieptName; } }

        /// <summary>
        /// Property to get or set the communal total of this receipt
        /// </summary>
        public decimal CommunalTotal { get; set; }
        /// <summary>
        /// Property to get or set Andy's total for this receipt
        /// </summary>
        public decimal ATotal { get; set; }
        /// <summary>
        /// Property to get or set Vince's total for this receipt
        /// </summary>
        public decimal VTotal { get; set; }
        /// <summary>
        /// Property to get or set Rizzo's total for this receipt
        /// </summary>
        public decimal RTotal { get; set; }

        #endregion /* Properties */

        public override string ToString() {
            return recieptName;
        }

    }

    #endregion /* NewReceipt Implemetation */

    #region ReceiptList Implemetation

    /// <summary>
    /// ReceiptList implementation of Receipt List updated to utilize more advanced features of C#
    /// </summary>
    class ReceiptList : IEnumerable<NewReceipt> {
        private string owner;
        private List<NewReceipt> receipts;

        public ReceiptList(string owner) {
            this.owner = owner;
            receipts = new List<NewReceipt>();
        }

        #region Properties

        /// <summary>
        /// CommunalTotal property to calculate the proper communal total sum using the Sum extension of
        /// IEnumerable on the internal receipt list.
        /// </summary>
        public decimal CommunalTotal { get { return receipts.Sum<NewReceipt>(r => r.CommunalTotal); } }
        /// <summary>
        /// ATotal property to calculate the proper Andy's total sum using the Sum extension of
        /// IEnumerable on the internal receipt list.
        /// </summary>
        public decimal ATotal { get { return receipts.Sum<NewReceipt>(r => r.ATotal); } }
        /// <summary>
        /// VTotal property to calculate the proper Vince's total sum using the Sum extension of
        /// IEnumerable on the internal receipt list.
        /// </summary>
        public decimal VTotal { get { return receipts.Sum<NewReceipt>(r => r.VTotal); } }
        /// <summary>
        /// RTotal property to calculate the proper Rizzo's total sum using the Sum extension of
        /// IEnumerable on the internal receipt list.
        /// </summary>
        public decimal RTotal { get { return receipts.Sum<NewReceipt>(r => r.RTotal); } }

        /// <summary>
        /// Return the number of receipts in this receipt list instance
        /// </summary>
        public int Count { get { return receipts.Count; } }

        /// <summary>
        /// Indexer to make ReceiptList act like an array
        /// </summary>
        /// <param name="index">Index value of desired receipt</param>
        /// <returns>Desired receipt at specified index</returns>
        public NewReceipt this[int index] {
            get { return receipts[index]; }
        }

        #endregion /* Properties */

        #region IEnumerable<T> Interface

        /// <summary>
        /// Implementation of IEnumerator#GetEnumerator method required by implementing
        /// IEnumerable<typeparamref name="NewReceipt"/>
        /// </summary>
        /// <returns></returns>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
        /// <summary>
        /// Implementation of IEnumerator<typeparamref name="NewReceipt"/>#GetEnumerator
        /// method required by implementing IEnumerable<typeparamref name="NewReceipt"/>
        /// </summary>
        /// <returns></returns>
        public IEnumerator<NewReceipt> GetEnumerator() {
            return receipts.GetEnumerator();
        }

        #endregion /* IEnumerable<T> Interface

        public override string ToString() {
            return owner;
        }

    }

    #endregion /* ReceiptList Implemetation */

}
