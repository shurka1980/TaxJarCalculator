
namespace WinFormUI
{
    partial class TaxForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetTaxRateForLocation = new System.Windows.Forms.Button();
            this.btnCalculateTaxesForAnOrder = new System.Windows.Forms.Button();
            this.txtTaxRates = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtTotalTaxToCollect = new System.Windows.Forms.TextBox();
            this.lblFromCountry = new System.Windows.Forms.Label();
            this.lblFromZip = new System.Windows.Forms.Label();
            this.lblFromState = new System.Windows.Forms.Label();
            this.lblToCountry = new System.Windows.Forms.Label();
            this.lblToZip = new System.Windows.Forms.Label();
            this.lblToState = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblShipping = new System.Windows.Forms.Label();
            this.txtFromCountry = new System.Windows.Forms.TextBox();
            this.txtFromZip = new System.Windows.Forms.TextBox();
            this.txtFromState = new System.Windows.Forms.TextBox();
            this.txtToCountry = new System.Windows.Forms.TextBox();
            this.txtToZip = new System.Windows.Forms.TextBox();
            this.txtToState = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtShipping = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblProductTaxCode = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtProductTaxCode = new System.Windows.Forms.TextBox();
            this.lblTaxToBeCollected = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetTaxRateForLocation
            // 
            this.btnGetTaxRateForLocation.Location = new System.Drawing.Point(323, 30);
            this.btnGetTaxRateForLocation.Name = "btnGetTaxRateForLocation";
            this.btnGetTaxRateForLocation.Size = new System.Drawing.Size(256, 23);
            this.btnGetTaxRateForLocation.TabIndex = 0;
            this.btnGetTaxRateForLocation.Text = "Get tax rate for location";
            this.btnGetTaxRateForLocation.UseVisualStyleBackColor = true;
            this.btnGetTaxRateForLocation.Click += new System.EventHandler(this.GetTaxRatesForLocation_Click);
            // 
            // btnCalculateTaxesForAnOrder
            // 
            this.btnCalculateTaxesForAnOrder.Location = new System.Drawing.Point(323, 332);
            this.btnCalculateTaxesForAnOrder.Name = "btnCalculateTaxesForAnOrder";
            this.btnCalculateTaxesForAnOrder.Size = new System.Drawing.Size(256, 27);
            this.btnCalculateTaxesForAnOrder.TabIndex = 1;
            this.btnCalculateTaxesForAnOrder.Text = "Calculate taxes for an order";
            this.btnCalculateTaxesForAnOrder.UseVisualStyleBackColor = true;
            this.btnCalculateTaxesForAnOrder.Click += new System.EventHandler(this.CalculateTaxesForAnOrder_Click);
            // 
            // txtTaxRates
            // 
            this.txtTaxRates.Location = new System.Drawing.Point(323, 76);
            this.txtTaxRates.Multiline = true;
            this.txtTaxRates.Name = "txtTaxRates";
            this.txtTaxRates.Size = new System.Drawing.Size(256, 236);
            this.txtTaxRates.TabIndex = 2;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(130, 53);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(100, 23);
            this.txtZip.TabIndex = 3;
            this.txtZip.Text = "90404";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(130, 105);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 23);
            this.txtCountry.TabIndex = 4;
            this.txtCountry.Text = "US";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(130, 161);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(100, 23);
            this.txtState.TabIndex = 5;
            this.txtState.Text = "CA";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(130, 219);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 23);
            this.txtCity.TabIndex = 6;
            this.txtCity.Text = "SANTA MONICA";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(130, 266);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(100, 23);
            this.txtStreet.TabIndex = 7;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(51, 60);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(24, 15);
            this.lblZip.TabIndex = 8;
            this.lblZip.Text = "Zip";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(51, 113);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(50, 15);
            this.lblCountry.TabIndex = 9;
            this.lblCountry.Text = "Country";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(51, 169);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(33, 15);
            this.lblState.TabIndex = 10;
            this.lblState.Text = "State";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(51, 227);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(28, 15);
            this.lblCity.TabIndex = 11;
            this.lblCity.Text = "City";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(51, 274);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(37, 15);
            this.lblStreet.TabIndex = 12;
            this.lblStreet.Text = "Street";
            // 
            // txtTotalTaxToCollect
            // 
            this.txtTotalTaxToCollect.Location = new System.Drawing.Point(323, 418);
            this.txtTotalTaxToCollect.Multiline = true;
            this.txtTotalTaxToCollect.Name = "txtTotalTaxToCollect";
            this.txtTotalTaxToCollect.Size = new System.Drawing.Size(256, 85);
            this.txtTotalTaxToCollect.TabIndex = 13;
            // 
            // lblFromCountry
            // 
            this.lblFromCountry.AutoSize = true;
            this.lblFromCountry.Location = new System.Drawing.Point(51, 393);
            this.lblFromCountry.Name = "lblFromCountry";
            this.lblFromCountry.Size = new System.Drawing.Size(79, 15);
            this.lblFromCountry.TabIndex = 14;
            this.lblFromCountry.Text = "From country";
            // 
            // lblFromZip
            // 
            this.lblFromZip.AutoSize = true;
            this.lblFromZip.Location = new System.Drawing.Point(51, 444);
            this.lblFromZip.Name = "lblFromZip";
            this.lblFromZip.Size = new System.Drawing.Size(53, 15);
            this.lblFromZip.TabIndex = 15;
            this.lblFromZip.Text = "From zip";
            // 
            // lblFromState
            // 
            this.lblFromState.AutoSize = true;
            this.lblFromState.Location = new System.Drawing.Point(51, 488);
            this.lblFromState.Name = "lblFromState";
            this.lblFromState.Size = new System.Drawing.Size(63, 15);
            this.lblFromState.TabIndex = 16;
            this.lblFromState.Text = "From state";
            // 
            // lblToCountry
            // 
            this.lblToCountry.AutoSize = true;
            this.lblToCountry.Location = new System.Drawing.Point(51, 530);
            this.lblToCountry.Name = "lblToCountry";
            this.lblToCountry.Size = new System.Drawing.Size(63, 15);
            this.lblToCountry.TabIndex = 17;
            this.lblToCountry.Text = "To country";
            // 
            // lblToZip
            // 
            this.lblToZip.AutoSize = true;
            this.lblToZip.Location = new System.Drawing.Point(51, 576);
            this.lblToZip.Name = "lblToZip";
            this.lblToZip.Size = new System.Drawing.Size(37, 15);
            this.lblToZip.TabIndex = 18;
            this.lblToZip.Text = "To zip";
            // 
            // lblToState
            // 
            this.lblToState.AutoSize = true;
            this.lblToState.Location = new System.Drawing.Point(51, 626);
            this.lblToState.Name = "lblToState";
            this.lblToState.Size = new System.Drawing.Size(47, 15);
            this.lblToState.TabIndex = 19;
            this.lblToState.Text = "To state";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(51, 664);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(51, 15);
            this.lblAmount.TabIndex = 20;
            this.lblAmount.Text = "Amount";
            // 
            // lblShipping
            // 
            this.lblShipping.AutoSize = true;
            this.lblShipping.Location = new System.Drawing.Point(51, 708);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.Size = new System.Drawing.Size(54, 15);
            this.lblShipping.TabIndex = 21;
            this.lblShipping.Text = "Shipping";
            // 
            // txtFromCountry
            // 
            this.txtFromCountry.Location = new System.Drawing.Point(181, 390);
            this.txtFromCountry.Name = "txtFromCountry";
            this.txtFromCountry.Size = new System.Drawing.Size(100, 23);
            this.txtFromCountry.TabIndex = 23;
            this.txtFromCountry.Text = "US";
            // 
            // txtFromZip
            // 
            this.txtFromZip.Location = new System.Drawing.Point(181, 433);
            this.txtFromZip.Name = "txtFromZip";
            this.txtFromZip.Size = new System.Drawing.Size(100, 23);
            this.txtFromZip.TabIndex = 24;
            this.txtFromZip.Text = "07001";
            // 
            // txtFromState
            // 
            this.txtFromState.Location = new System.Drawing.Point(181, 485);
            this.txtFromState.Name = "txtFromState";
            this.txtFromState.Size = new System.Drawing.Size(100, 23);
            this.txtFromState.TabIndex = 25;
            this.txtFromState.Text = "NJ";
            // 
            // txtToCountry
            // 
            this.txtToCountry.Location = new System.Drawing.Point(181, 527);
            this.txtToCountry.Name = "txtToCountry";
            this.txtToCountry.Size = new System.Drawing.Size(100, 23);
            this.txtToCountry.TabIndex = 26;
            this.txtToCountry.Text = "US";
            // 
            // txtToZip
            // 
            this.txtToZip.Location = new System.Drawing.Point(181, 573);
            this.txtToZip.Name = "txtToZip";
            this.txtToZip.Size = new System.Drawing.Size(100, 23);
            this.txtToZip.TabIndex = 27;
            this.txtToZip.Text = "07446";
            // 
            // txtToState
            // 
            this.txtToState.Location = new System.Drawing.Point(181, 620);
            this.txtToState.Name = "txtToState";
            this.txtToState.Size = new System.Drawing.Size(100, 23);
            this.txtToState.TabIndex = 28;
            this.txtToState.Text = "NJ";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(181, 658);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 23);
            this.txtAmount.TabIndex = 29;
            this.txtAmount.Text = "16.50";
            // 
            // txtShipping
            // 
            this.txtShipping.Location = new System.Drawing.Point(181, 705);
            this.txtShipping.Name = "txtShipping";
            this.txtShipping.Size = new System.Drawing.Size(100, 23);
            this.txtShipping.TabIndex = 30;
            this.txtShipping.Text = "1.5";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(181, 745);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 23);
            this.txtQuantity.TabIndex = 31;
            this.txtQuantity.Text = "1";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(51, 756);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(53, 15);
            this.lblQuantity.TabIndex = 22;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(52, 795);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(58, 15);
            this.lblUnitPrice.TabIndex = 32;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // lblProductTaxCode
            // 
            this.lblProductTaxCode.AutoSize = true;
            this.lblProductTaxCode.Location = new System.Drawing.Point(52, 827);
            this.lblProductTaxCode.Name = "lblProductTaxCode";
            this.lblProductTaxCode.Size = new System.Drawing.Size(97, 15);
            this.lblProductTaxCode.TabIndex = 33;
            this.lblProductTaxCode.Text = "Product tax code";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(181, 784);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 23);
            this.txtUnitPrice.TabIndex = 34;
            this.txtUnitPrice.Text = "15.0";
            // 
            // txtProductTaxCode
            // 
            this.txtProductTaxCode.Location = new System.Drawing.Point(181, 824);
            this.txtProductTaxCode.Name = "txtProductTaxCode";
            this.txtProductTaxCode.Size = new System.Drawing.Size(100, 23);
            this.txtProductTaxCode.TabIndex = 35;
            this.txtProductTaxCode.Text = "31000";
            // 
            // lblTaxToBeCollected
            // 
            this.lblTaxToBeCollected.AutoSize = true;
            this.lblTaxToBeCollected.Location = new System.Drawing.Point(382, 390);
            this.lblTaxToBeCollected.Name = "lblTaxToBeCollected";
            this.lblTaxToBeCollected.Size = new System.Drawing.Size(103, 15);
            this.lblTaxToBeCollected.TabIndex = 36;
            this.lblTaxToBeCollected.Text = "Total tax to collect";
            // 
            // TaxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 875);
            this.Controls.Add(this.lblTaxToBeCollected);
            this.Controls.Add(this.txtProductTaxCode);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.lblProductTaxCode);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtShipping);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtToState);
            this.Controls.Add(this.txtToZip);
            this.Controls.Add(this.txtToCountry);
            this.Controls.Add(this.txtFromState);
            this.Controls.Add(this.txtFromZip);
            this.Controls.Add(this.txtFromCountry);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblShipping);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblToState);
            this.Controls.Add(this.lblToZip);
            this.Controls.Add(this.lblToCountry);
            this.Controls.Add(this.lblFromState);
            this.Controls.Add(this.lblFromZip);
            this.Controls.Add(this.lblFromCountry);
            this.Controls.Add(this.txtTotalTaxToCollect);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtTaxRates);
            this.Controls.Add(this.btnCalculateTaxesForAnOrder);
            this.Controls.Add(this.btnGetTaxRateForLocation);
            this.Name = "TaxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tax Calculation Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetTaxRateForLocation;
        private System.Windows.Forms.Button btnCalculateTaxesForAnOrder;
        private System.Windows.Forms.TextBox txtTaxRates;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtTotalTaxToCollect;
        private System.Windows.Forms.Label lblFromCountry;
        private System.Windows.Forms.Label lblFromZip;
        private System.Windows.Forms.Label lblFromState;
        private System.Windows.Forms.Label lblToCountry;
        private System.Windows.Forms.Label lblToZip;
        private System.Windows.Forms.Label lblToState;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblShipping;
        private System.Windows.Forms.TextBox txtFromCountry;
        private System.Windows.Forms.TextBox txtFromZip;
        private System.Windows.Forms.TextBox txtFromState;
        private System.Windows.Forms.TextBox txtToCountry;
        private System.Windows.Forms.TextBox txtToZip;
        private System.Windows.Forms.TextBox txtToState;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtShipping;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblProductTaxCode;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtProductTaxCode;
        private System.Windows.Forms.Label lblTaxToBeCollected;
    }
}

