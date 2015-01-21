namespace PointOfSale
{
    partial class PizzaApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl = new System.Windows.Forms.Label();
            this.sizeBox = new System.Windows.Forms.GroupBox();
            this.radioLg = new System.Windows.Forms.RadioButton();
            this.radioMed = new System.Windows.Forms.RadioButton();
            this.radioSm = new System.Windows.Forms.RadioButton();
            this.ToppingsBox = new System.Windows.Forms.GroupBox();
            this.cbBeef = new System.Windows.Forms.CheckBox();
            this.cbAnchovy = new System.Windows.Forms.CheckBox();
            this.cbPork = new System.Windows.Forms.CheckBox();
            this.cbHam = new System.Windows.Forms.CheckBox();
            this.cbCheese = new System.Windows.Forms.CheckBox();
            this.cbPep = new System.Windows.Forms.CheckBox();
            this.cmbDrinks = new System.Windows.Forms.ComboBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtTaxAmt = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lstMenu = new System.Windows.Forms.ListBox();
            this.lblCpy = new System.Windows.Forms.Label();
            this.sizeBox.SuspendLayout();
            this.ToppingsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.Green;
            this.lbl.Location = new System.Drawing.Point(151, 9);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(151, 24);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Mack\'s Pizzeria";
            // 
            // sizeBox
            // 
            this.sizeBox.Controls.Add(this.radioLg);
            this.sizeBox.Controls.Add(this.radioMed);
            this.sizeBox.Controls.Add(this.radioSm);
            this.sizeBox.ForeColor = System.Drawing.Color.Green;
            this.sizeBox.Location = new System.Drawing.Point(268, 60);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(219, 52);
            this.sizeBox.TabIndex = 1;
            this.sizeBox.TabStop = false;
            this.sizeBox.Text = "Size";
            // 
            // radioLg
            // 
            this.radioLg.AutoSize = true;
            this.radioLg.Location = new System.Drawing.Point(154, 23);
            this.radioLg.Name = "radioLg";
            this.radioLg.Size = new System.Drawing.Size(52, 17);
            this.radioLg.TabIndex = 2;
            this.radioLg.TabStop = true;
            this.radioLg.Text = "Large";
            this.radioLg.UseVisualStyleBackColor = true;
            // 
            // radioMed
            // 
            this.radioMed.AutoSize = true;
            this.radioMed.Location = new System.Drawing.Point(86, 23);
            this.radioMed.Name = "radioMed";
            this.radioMed.Size = new System.Drawing.Size(62, 17);
            this.radioMed.TabIndex = 1;
            this.radioMed.TabStop = true;
            this.radioMed.Text = "Medium";
            this.radioMed.UseVisualStyleBackColor = true;
            // 
            // radioSm
            // 
            this.radioSm.AutoSize = true;
            this.radioSm.Location = new System.Drawing.Point(19, 23);
            this.radioSm.Name = "radioSm";
            this.radioSm.Size = new System.Drawing.Size(50, 17);
            this.radioSm.TabIndex = 0;
            this.radioSm.TabStop = true;
            this.radioSm.Text = "Small";
            this.radioSm.UseVisualStyleBackColor = true;
            // 
            // ToppingsBox
            // 
            this.ToppingsBox.Controls.Add(this.cbBeef);
            this.ToppingsBox.Controls.Add(this.cbAnchovy);
            this.ToppingsBox.Controls.Add(this.cbPork);
            this.ToppingsBox.Controls.Add(this.cbHam);
            this.ToppingsBox.Controls.Add(this.cbCheese);
            this.ToppingsBox.Controls.Add(this.cbPep);
            this.ToppingsBox.ForeColor = System.Drawing.Color.Green;
            this.ToppingsBox.Location = new System.Drawing.Point(268, 144);
            this.ToppingsBox.Name = "ToppingsBox";
            this.ToppingsBox.Size = new System.Drawing.Size(269, 89);
            this.ToppingsBox.TabIndex = 2;
            this.ToppingsBox.TabStop = false;
            this.ToppingsBox.Text = "Toppings";
            // 
            // cbBeef
            // 
            this.cbBeef.AutoSize = true;
            this.cbBeef.Location = new System.Drawing.Point(191, 59);
            this.cbBeef.Name = "cbBeef";
            this.cbBeef.Size = new System.Drawing.Size(48, 17);
            this.cbBeef.TabIndex = 5;
            this.cbBeef.Text = "Beef";
            this.cbBeef.UseVisualStyleBackColor = true;
            // 
            // cbAnchovy
            // 
            this.cbAnchovy.AutoSize = true;
            this.cbAnchovy.Location = new System.Drawing.Point(105, 59);
            this.cbAnchovy.Name = "cbAnchovy";
            this.cbAnchovy.Size = new System.Drawing.Size(68, 17);
            this.cbAnchovy.TabIndex = 4;
            this.cbAnchovy.Text = "Anchovy";
            this.cbAnchovy.UseVisualStyleBackColor = true;
            // 
            // cbPork
            // 
            this.cbPork.AutoSize = true;
            this.cbPork.Location = new System.Drawing.Point(19, 59);
            this.cbPork.Name = "cbPork";
            this.cbPork.Size = new System.Drawing.Size(48, 17);
            this.cbPork.TabIndex = 3;
            this.cbPork.Text = "Pork";
            this.cbPork.UseVisualStyleBackColor = true;
            // 
            // cbHam
            // 
            this.cbHam.AutoSize = true;
            this.cbHam.Location = new System.Drawing.Point(191, 25);
            this.cbHam.Name = "cbHam";
            this.cbHam.Size = new System.Drawing.Size(48, 17);
            this.cbHam.TabIndex = 2;
            this.cbHam.Text = "Ham";
            this.cbHam.UseVisualStyleBackColor = true;
            // 
            // cbCheese
            // 
            this.cbCheese.AutoSize = true;
            this.cbCheese.Location = new System.Drawing.Point(105, 25);
            this.cbCheese.Name = "cbCheese";
            this.cbCheese.Size = new System.Drawing.Size(62, 17);
            this.cbCheese.TabIndex = 1;
            this.cbCheese.Text = "Cheese";
            this.cbCheese.UseVisualStyleBackColor = true;
            // 
            // cbPep
            // 
            this.cbPep.AutoSize = true;
            this.cbPep.Location = new System.Drawing.Point(19, 25);
            this.cbPep.Name = "cbPep";
            this.cbPep.Size = new System.Drawing.Size(74, 17);
            this.cbPep.TabIndex = 0;
            this.cbPep.Text = "Pepperoni";
            this.cbPep.UseVisualStyleBackColor = true;
            // 
            // cmbDrinks
            // 
            this.cmbDrinks.ForeColor = System.Drawing.Color.Green;
            this.cmbDrinks.FormattingEnabled = true;
            this.cmbDrinks.Items.AddRange(new object[] {
            "None",
            "Sprite",
            "Coke",
            "Dr. Pepper",
            "Sierra Mist",
            "Mountain Dew"});
            this.cmbDrinks.Location = new System.Drawing.Point(72, 212);
            this.cmbDrinks.Name = "cmbDrinks";
            this.cmbDrinks.Size = new System.Drawing.Size(121, 21);
            this.cmbDrinks.TabIndex = 3;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.ForeColor = System.Drawing.Color.Green;
            this.lbl2.Location = new System.Drawing.Point(12, 212);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(35, 13);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Drink:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.ForeColor = System.Drawing.Color.Green;
            this.btnSubmit.Location = new System.Drawing.Point(72, 302);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(97, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit Order";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.ForeColor = System.Drawing.Color.Green;
            this.lbl3.Location = new System.Drawing.Point(246, 302);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(49, 13);
            this.lbl3.TabIndex = 6;
            this.lbl3.Text = "Tax Amt:";
            // 
            // txtTaxAmt
            // 
            this.txtTaxAmt.ForeColor = System.Drawing.Color.Green;
            this.txtTaxAmt.Location = new System.Drawing.Point(301, 299);
            this.txtTaxAmt.Name = "txtTaxAmt";
            this.txtTaxAmt.Size = new System.Drawing.Size(100, 20);
            this.txtTaxAmt.TabIndex = 7;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.ForeColor = System.Drawing.Color.Green;
            this.lbl4.Location = new System.Drawing.Point(246, 338);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(34, 13);
            this.lbl4.TabIndex = 8;
            this.lbl4.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.ForeColor = System.Drawing.Color.Green;
            this.txtTotal.Location = new System.Drawing.Point(301, 338);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 9;
            // 
            // lstMenu
            // 
            this.lstMenu.ForeColor = System.Drawing.Color.Green;
            this.lstMenu.FormattingEnabled = true;
            this.lstMenu.Items.AddRange(new object[] {
            "Menu",
            "",
            "Small  $4",
            "Medium  $6",
            "Large  $8",
            "1 Topping  $0.50",
            "2 Toppings  $1",
            "3 Toppings  $1.50",
            ">3 Toppings  $2.50",
            "Drinks  $1.25",
            "Tax  10%"});
            this.lstMenu.Location = new System.Drawing.Point(15, 60);
            this.lstMenu.Name = "lstMenu";
            this.lstMenu.Size = new System.Drawing.Size(178, 95);
            this.lstMenu.TabIndex = 10;
            // 
            // lblCpy
            // 
            this.lblCpy.AutoSize = true;
            this.lblCpy.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpy.ForeColor = System.Drawing.Color.Green;
            this.lblCpy.Location = new System.Drawing.Point(453, 375);
            this.lblCpy.Name = "lblCpy";
            this.lblCpy.Size = new System.Drawing.Size(84, 14);
            this.lblCpy.TabIndex = 11;
            this.lblCpy.Text = "2015 Alex Mack";
            // 
            // PizzaApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(573, 397);
            this.Controls.Add(this.lblCpy);
            this.Controls.Add(this.lstMenu);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.txtTaxAmt);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.cmbDrinks);
            this.Controls.Add(this.ToppingsBox);
            this.Controls.Add(this.sizeBox);
            this.Controls.Add(this.lbl);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "PizzaApp";
            this.Text = "Pizza Order App";
            this.sizeBox.ResumeLayout(false);
            this.sizeBox.PerformLayout();
            this.ToppingsBox.ResumeLayout(false);
            this.ToppingsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.GroupBox sizeBox;
        private System.Windows.Forms.RadioButton radioLg;
        private System.Windows.Forms.RadioButton radioMed;
        private System.Windows.Forms.RadioButton radioSm;
        private System.Windows.Forms.GroupBox ToppingsBox;
        private System.Windows.Forms.CheckBox cbBeef;
        private System.Windows.Forms.CheckBox cbAnchovy;
        private System.Windows.Forms.CheckBox cbPork;
        private System.Windows.Forms.CheckBox cbHam;
        private System.Windows.Forms.CheckBox cbCheese;
        private System.Windows.Forms.CheckBox cbPep;
        private System.Windows.Forms.ComboBox cmbDrinks;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txtTaxAmt;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ListBox lstMenu;
        private System.Windows.Forms.Label lblCpy;
    }
}

