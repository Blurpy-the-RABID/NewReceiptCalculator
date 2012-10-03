namespace ReceiptCalculator {
    partial class RCForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.currentListOwner = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.currentReceiptComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.updateCurrentReceipt = new System.Windows.Forms.Button();
            this.calcFinalTotals = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.summaryTitle = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.additAmountOwed1 = new System.Windows.Forms.Label();
            this.additAmountOwed2 = new System.Windows.Forms.Label();
            this.aCommunalTotal = new System.Windows.Forms.Label();
            this.aCommunalTotalPerPerson = new System.Windows.Forms.Label();
            this.additAmountOwedTotal1 = new System.Windows.Forms.Label();
            this.additAmountOwedTotal2 = new System.Windows.Forms.Label();
            this.communalTotal = new System.Windows.Forms.NumericUpDown();
            this.aTotal = new System.Windows.Forms.NumericUpDown();
            this.vTotal = new System.Windows.Forms.NumericUpDown();
            this.mTotal = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.communalTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // currentListOwner
            // 
            this.currentListOwner.DisplayMember = "NameList";
            this.currentListOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currentListOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentListOwner.FormattingEnabled = true;
            this.currentListOwner.Location = new System.Drawing.Point(159, 8);
            this.currentListOwner.MaxDropDownItems = 3;
            this.currentListOwner.Name = "currentListOwner";
            this.currentListOwner.Size = new System.Drawing.Size(121, 24);
            this.currentListOwner.TabIndex = 1;
            this.currentListOwner.SelectedIndexChanged += new System.EventHandler(this.currentListOwner_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Receipt List Owner:";
            // 
            // currentReceiptComboBox
            // 
            this.currentReceiptComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currentReceiptComboBox.FormattingEnabled = true;
            this.currentReceiptComboBox.Location = new System.Drawing.Point(159, 40);
            this.currentReceiptComboBox.Name = "currentReceiptComboBox";
            this.currentReceiptComboBox.Size = new System.Drawing.Size(121, 21);
            this.currentReceiptComboBox.TabIndex = 4;
            this.currentReceiptComboBox.SelectedIndexChanged += new System.EventHandler(this.currentReceiptComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Communal Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Additional Amount Owed By Andy:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Additional Amount Owed By Vince:";
            // 
            // updateCurrentReceipt
            // 
            this.updateCurrentReceipt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.updateCurrentReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCurrentReceipt.Location = new System.Drawing.Point(12, 201);
            this.updateCurrentReceipt.Name = "updateCurrentReceipt";
            this.updateCurrentReceipt.Size = new System.Drawing.Size(204, 31);
            this.updateCurrentReceipt.TabIndex = 11;
            this.updateCurrentReceipt.Text = "Update Current Receipt";
            this.updateCurrentReceipt.UseVisualStyleBackColor = false;
            this.updateCurrentReceipt.Click += new System.EventHandler(this.updateCurrentReceipt_Click);
            // 
            // calcFinalTotals
            // 
            this.calcFinalTotals.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.calcFinalTotals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcFinalTotals.Location = new System.Drawing.Point(452, 165);
            this.calcFinalTotals.Name = "calcFinalTotals";
            this.calcFinalTotals.Size = new System.Drawing.Size(175, 31);
            this.calcFinalTotals.TabIndex = 14;
            this.calcFinalTotals.Text = "Calculate Final Totals";
            this.calcFinalTotals.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(260, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(260, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(260, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(260, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(239, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Additional Amount Owed By Mike:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Current Receipt #:";
            // 
            // summaryTitle
            // 
            this.summaryTitle.AutoSize = true;
            this.summaryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryTitle.Location = new System.Drawing.Point(449, 11);
            this.summaryTitle.Name = "summaryTitle";
            this.summaryTitle.Size = new System.Drawing.Size(107, 16);
            this.summaryTitle.TabIndex = 23;
            this.summaryTitle.Text = "Andy\'s Totals:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(449, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "=============";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(449, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(237, 16);
            this.label14.TabIndex = 25;
            this.label14.Text = "Communal Total of ALL Receipts:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(449, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(248, 16);
            this.label15.TabIndex = 26;
            this.label15.Text = "Communal Total Owed Per Person:";
            // 
            // additAmountOwed1
            // 
            this.additAmountOwed1.AutoSize = true;
            this.additAmountOwed1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additAmountOwed1.Location = new System.Drawing.Point(449, 103);
            this.additAmountOwed1.Name = "additAmountOwed1";
            this.additAmountOwed1.Size = new System.Drawing.Size(255, 16);
            this.additAmountOwed1.TabIndex = 27;
            this.additAmountOwed1.Text = "Addit. Total Amount Owed By Vince:";
            // 
            // additAmountOwed2
            // 
            this.additAmountOwed2.AutoSize = true;
            this.additAmountOwed2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additAmountOwed2.Location = new System.Drawing.Point(449, 129);
            this.additAmountOwed2.Name = "additAmountOwed2";
            this.additAmountOwed2.Size = new System.Drawing.Size(249, 16);
            this.additAmountOwed2.TabIndex = 28;
            this.additAmountOwed2.Text = "Addit. Total Amount Owed By Mike:";
            // 
            // aCommunalTotal
            // 
            this.aCommunalTotal.AutoSize = true;
            this.aCommunalTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aCommunalTotal.Location = new System.Drawing.Point(717, 48);
            this.aCommunalTotal.Name = "aCommunalTotal";
            this.aCommunalTotal.Size = new System.Drawing.Size(39, 16);
            this.aCommunalTotal.TabIndex = 29;
            this.aCommunalTotal.Text = "$0.00";
            // 
            // aCommunalTotalPerPerson
            // 
            this.aCommunalTotalPerPerson.AutoSize = true;
            this.aCommunalTotalPerPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aCommunalTotalPerPerson.Location = new System.Drawing.Point(717, 77);
            this.aCommunalTotalPerPerson.Name = "aCommunalTotalPerPerson";
            this.aCommunalTotalPerPerson.Size = new System.Drawing.Size(39, 16);
            this.aCommunalTotalPerPerson.TabIndex = 30;
            this.aCommunalTotalPerPerson.Text = "$0.00";
            // 
            // additAmountOwedTotal1
            // 
            this.additAmountOwedTotal1.AutoSize = true;
            this.additAmountOwedTotal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additAmountOwedTotal1.Location = new System.Drawing.Point(717, 103);
            this.additAmountOwedTotal1.Name = "additAmountOwedTotal1";
            this.additAmountOwedTotal1.Size = new System.Drawing.Size(39, 16);
            this.additAmountOwedTotal1.TabIndex = 31;
            this.additAmountOwedTotal1.Text = "$0.00";
            // 
            // additAmountOwedTotal2
            // 
            this.additAmountOwedTotal2.AutoSize = true;
            this.additAmountOwedTotal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additAmountOwedTotal2.Location = new System.Drawing.Point(717, 129);
            this.additAmountOwedTotal2.Name = "additAmountOwedTotal2";
            this.additAmountOwedTotal2.Size = new System.Drawing.Size(39, 16);
            this.additAmountOwedTotal2.TabIndex = 32;
            this.additAmountOwedTotal2.Text = "$0.00";
            // 
            // communalTotal
            // 
            this.communalTotal.DecimalPlaces = 2;
            this.communalTotal.Location = new System.Drawing.Point(284, 81);
            this.communalTotal.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.communalTotal.Name = "communalTotal";
            this.communalTotal.Size = new System.Drawing.Size(100, 20);
            this.communalTotal.TabIndex = 33;
            // 
            // aTotal
            // 
            this.aTotal.DecimalPlaces = 2;
            this.aTotal.Location = new System.Drawing.Point(284, 107);
            this.aTotal.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.aTotal.Name = "aTotal";
            this.aTotal.Size = new System.Drawing.Size(100, 20);
            this.aTotal.TabIndex = 34;
            // 
            // vTotal
            // 
            this.vTotal.DecimalPlaces = 2;
            this.vTotal.Location = new System.Drawing.Point(284, 132);
            this.vTotal.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.vTotal.Name = "vTotal";
            this.vTotal.Size = new System.Drawing.Size(100, 20);
            this.vTotal.TabIndex = 35;
            // 
            // mTotal
            // 
            this.mTotal.DecimalPlaces = 2;
            this.mTotal.Location = new System.Drawing.Point(284, 159);
            this.mTotal.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.mTotal.Name = "mTotal";
            this.mTotal.Size = new System.Drawing.Size(100, 20);
            this.mTotal.TabIndex = 36;
            // 
            // RCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 297);
            this.Controls.Add(this.mTotal);
            this.Controls.Add(this.vTotal);
            this.Controls.Add(this.aTotal);
            this.Controls.Add(this.communalTotal);
            this.Controls.Add(this.additAmountOwedTotal2);
            this.Controls.Add(this.additAmountOwedTotal1);
            this.Controls.Add(this.aCommunalTotalPerPerson);
            this.Controls.Add(this.aCommunalTotal);
            this.Controls.Add(this.additAmountOwed2);
            this.Controls.Add(this.additAmountOwed1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.summaryTitle);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.calcFinalTotals);
            this.Controls.Add(this.updateCurrentReceipt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.currentReceiptComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentListOwner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RCForm";
            this.Text = "RCForm";
            ((System.ComponentModel.ISupportInitialize)(this.communalTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox currentListOwner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox currentReceiptComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button updateCurrentReceipt;
        private System.Windows.Forms.Button calcFinalTotals;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label summaryTitle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label additAmountOwed1;
        private System.Windows.Forms.Label additAmountOwed2;
        private System.Windows.Forms.Label aCommunalTotal;
        private System.Windows.Forms.Label aCommunalTotalPerPerson;
        private System.Windows.Forms.Label additAmountOwedTotal1;
        private System.Windows.Forms.Label additAmountOwedTotal2;
        private System.Windows.Forms.NumericUpDown communalTotal;
        private System.Windows.Forms.NumericUpDown aTotal;
        private System.Windows.Forms.NumericUpDown vTotal;
        private System.Windows.Forms.NumericUpDown mTotal;
    }
}