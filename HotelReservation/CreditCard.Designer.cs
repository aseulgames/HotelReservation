namespace HotelReservation
{
    partial class CreditCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditCard));
            this.btncardPay = new System.Windows.Forms.Button();
            this.txtboxAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxMMYY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxCardNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxCardNameHolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRoomrate = new System.Windows.Forms.Label();
            this.lblNoofchildren = new System.Windows.Forms.Label();
            this.lblNoofadults = new System.Windows.Forms.Label();
            this.lblTypeofroom = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblNoofnights = new System.Windows.Forms.Label();
            this.lblDateout = new System.Windows.Forms.Label();
            this.lblDatein = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblTotalamount = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblRefID = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncardPay
            // 
            this.btncardPay.BackColor = System.Drawing.Color.PaleGreen;
            this.btncardPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncardPay.Location = new System.Drawing.Point(85, 311);
            this.btncardPay.Name = "btncardPay";
            this.btncardPay.Size = new System.Drawing.Size(159, 30);
            this.btncardPay.TabIndex = 19;
            this.btncardPay.Text = "Pay";
            this.btncardPay.UseVisualStyleBackColor = false;
            this.btncardPay.Click += new System.EventHandler(this.btncardPay_Click);
            // 
            // txtboxAmount
            // 
            this.txtboxAmount.Location = new System.Drawing.Point(183, 234);
            this.txtboxAmount.Name = "txtboxAmount";
            this.txtboxAmount.ReadOnly = true;
            this.txtboxAmount.Size = new System.Drawing.Size(124, 20);
            this.txtboxAmount.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(179, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Amount";
            // 
            // txtboxMMYY
            // 
            this.txtboxMMYY.Location = new System.Drawing.Point(34, 234);
            this.txtboxMMYY.MaxLength = 4;
            this.txtboxMMYY.Name = "txtboxMMYY";
            this.txtboxMMYY.Size = new System.Drawing.Size(124, 20);
            this.txtboxMMYY.TabIndex = 16;
            this.txtboxMMYY.TextChanged += new System.EventHandler(this.txtboxMMYY_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "MM/YY";
            // 
            // txtboxCardNumber
            // 
            this.txtboxCardNumber.Location = new System.Drawing.Point(34, 160);
            this.txtboxCardNumber.MaxLength = 16;
            this.txtboxCardNumber.Name = "txtboxCardNumber";
            this.txtboxCardNumber.Size = new System.Drawing.Size(273, 20);
            this.txtboxCardNumber.TabIndex = 14;
            this.txtboxCardNumber.TextChanged += new System.EventHandler(this.txtboxCardNumber_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Card Number";
            // 
            // txtboxCardNameHolder
            // 
            this.txtboxCardNameHolder.Location = new System.Drawing.Point(34, 95);
            this.txtboxCardNameHolder.MaxLength = 100;
            this.txtboxCardNameHolder.Name = "txtboxCardNameHolder";
            this.txtboxCardNameHolder.Size = new System.Drawing.Size(273, 20);
            this.txtboxCardNameHolder.TabIndex = 12;
            this.txtboxCardNameHolder.TextChanged += new System.EventHandler(this.txtboxCardNameHolder_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Card Name Holder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Credit / Debit Card Payment";
            // 
            // lblRoomrate
            // 
            this.lblRoomrate.AutoSize = true;
            this.lblRoomrate.Location = new System.Drawing.Point(487, 477);
            this.lblRoomrate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomrate.Name = "lblRoomrate";
            this.lblRoomrate.Size = new System.Drawing.Size(211, 13);
            this.lblRoomrate.TabIndex = 125;
            this.lblRoomrate.Text = "                                                                    ";
            // 
            // lblNoofchildren
            // 
            this.lblNoofchildren.AutoSize = true;
            this.lblNoofchildren.Location = new System.Drawing.Point(487, 449);
            this.lblNoofchildren.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoofchildren.Name = "lblNoofchildren";
            this.lblNoofchildren.Size = new System.Drawing.Size(211, 13);
            this.lblNoofchildren.TabIndex = 124;
            this.lblNoofchildren.Text = "                                                                    ";
            // 
            // lblNoofadults
            // 
            this.lblNoofadults.AutoSize = true;
            this.lblNoofadults.Location = new System.Drawing.Point(487, 422);
            this.lblNoofadults.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoofadults.Name = "lblNoofadults";
            this.lblNoofadults.Size = new System.Drawing.Size(211, 13);
            this.lblNoofadults.TabIndex = 123;
            this.lblNoofadults.Text = "                                                                    ";
            // 
            // lblTypeofroom
            // 
            this.lblTypeofroom.AutoSize = true;
            this.lblTypeofroom.Location = new System.Drawing.Point(484, 391);
            this.lblTypeofroom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypeofroom.Name = "lblTypeofroom";
            this.lblTypeofroom.Size = new System.Drawing.Size(211, 13);
            this.lblTypeofroom.TabIndex = 122;
            this.lblTypeofroom.Text = "                                                                    ";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(484, 361);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(211, 13);
            this.lblDiscount.TabIndex = 121;
            this.lblDiscount.Text = "                                                                    ";
            // 
            // lblNoofnights
            // 
            this.lblNoofnights.AutoSize = true;
            this.lblNoofnights.Location = new System.Drawing.Point(487, 331);
            this.lblNoofnights.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoofnights.Name = "lblNoofnights";
            this.lblNoofnights.Size = new System.Drawing.Size(211, 13);
            this.lblNoofnights.TabIndex = 120;
            this.lblNoofnights.Text = "                                                                    ";
            // 
            // lblDateout
            // 
            this.lblDateout.AutoSize = true;
            this.lblDateout.Location = new System.Drawing.Point(487, 301);
            this.lblDateout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateout.Name = "lblDateout";
            this.lblDateout.Size = new System.Drawing.Size(211, 13);
            this.lblDateout.TabIndex = 119;
            this.lblDateout.Text = "                                                                    ";
            // 
            // lblDatein
            // 
            this.lblDatein.AutoSize = true;
            this.lblDatein.Location = new System.Drawing.Point(487, 274);
            this.lblDatein.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatein.Name = "lblDatein";
            this.lblDatein.Size = new System.Drawing.Size(211, 13);
            this.lblDatein.TabIndex = 118;
            this.lblDatein.Text = "                                                                    ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(332, 620);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(109, 16);
            this.label20.TabIndex = 112;
            this.label20.Text = "Accommodation:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(332, 591);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(120, 16);
            this.label19.TabIndex = 111;
            this.label19.Text = "Cleaning Supplies:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(332, 566);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 16);
            this.label18.TabIndex = 110;
            this.label18.Text = "Utilities:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(331, 534);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 20);
            this.label15.TabIndex = 109;
            this.label15.Text = "Other Charges:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(333, 240);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(145, 20);
            this.label17.TabIndex = 108;
            this.label17.Text = "Rate Information";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(334, 475);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 16);
            this.label14.TabIndex = 106;
            this.label14.Text = "Room Rate:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(335, 448);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 16);
            this.label13.TabIndex = 105;
            this.label13.Text = "No. of Children:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(335, 421);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 16);
            this.label12.TabIndex = 104;
            this.label12.Text = "No. of Adults:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(333, 390);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 16);
            this.label11.TabIndex = 103;
            this.label11.Text = "Type of Room:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(333, 359);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 16);
            this.label10.TabIndex = 102;
            this.label10.Text = "Discount:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(334, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 101;
            this.label9.Text = "No. of Nights";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(334, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 100;
            this.label8.Text = "Date Out:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(334, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 99;
            this.label7.Text = "Date In:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(329, 26);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(237, 24);
            this.label27.TabIndex = 93;
            this.label27.Text = "Payment Summary Receipt";
            // 
            // lblTotalamount
            // 
            this.lblTotalamount.AutoSize = true;
            this.lblTotalamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalamount.Location = new System.Drawing.Point(486, 657);
            this.lblTotalamount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalamount.Name = "lblTotalamount";
            this.lblTotalamount.Size = new System.Drawing.Size(185, 20);
            this.lblTotalamount.TabIndex = 130;
            this.lblTotalamount.Text = "                                            ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(329, 657);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(121, 20);
            this.label21.TabIndex = 129;
            this.label21.Text = "Total Amount:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label6.Location = new System.Drawing.Point(487, 620);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 13);
            this.label6.TabIndex = 133;
            this.label6.Text = "308.00                                                ";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label28.Location = new System.Drawing.Point(487, 592);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(184, 13);
            this.label28.TabIndex = 132;
            this.label28.Text = "508.00                                                ";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label29.Location = new System.Drawing.Point(488, 566);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(193, 13);
            this.label29.TabIndex = 131;
            this.label29.Text = "203.00                                                   ";
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.Location = new System.Drawing.Point(487, 503);
            this.lblRoomNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(211, 13);
            this.lblRoomNo.TabIndex = 135;
            this.lblRoomNo.Text = "                                                                    ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(334, 501);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(99, 16);
            this.label22.TabIndex = 134;
            this.label22.Text = "Room Number:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(470, 216);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(211, 13);
            this.lblAddress.TabIndex = 146;
            this.lblAddress.Text = "                                                                    ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(470, 186);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(211, 13);
            this.lblEmail.TabIndex = 145;
            this.lblEmail.Text = "                                                                    ";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(473, 156);
            this.lblContact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(211, 13);
            this.lblContact.TabIndex = 144;
            this.lblContact.Text = "                                                                    ";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(473, 126);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(211, 13);
            this.lblFullName.TabIndex = 143;
            this.lblFullName.Text = "                                                                    ";
            // 
            // lblRefID
            // 
            this.lblRefID.AutoSize = true;
            this.lblRefID.Location = new System.Drawing.Point(473, 99);
            this.lblRefID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRefID.Name = "lblRefID";
            this.lblRefID.Size = new System.Drawing.Size(211, 13);
            this.lblRefID.TabIndex = 142;
            this.lblRefID.Text = "                                                                    ";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(333, 61);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(155, 20);
            this.label32.TabIndex = 141;
            this.label32.Text = "Guest Information";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(333, 211);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(62, 16);
            this.label33.TabIndex = 140;
            this.label33.Text = "Address:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(333, 180);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(45, 16);
            this.label34.TabIndex = 139;
            this.label34.Text = "Email:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(334, 151);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(56, 16);
            this.label35.TabIndex = 138;
            this.label35.Text = "Contact:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(334, 121);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(48, 16);
            this.label36.TabIndex = 137;
            this.label36.Text = "Name:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(334, 93);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(90, 16);
            this.label37.TabIndex = 136;
            this.label37.Text = "Reference ID:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Salmon;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(85, 344);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(159, 31);
            this.btnCancel.TabIndex = 147;
            this.btnCancel.Text = "Cancel Reservation";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 696);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblRefID);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.lblRoomNo);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.lblTotalamount);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lblRoomrate);
            this.Controls.Add(this.lblNoofchildren);
            this.Controls.Add(this.lblNoofadults);
            this.Controls.Add(this.lblTypeofroom);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblNoofnights);
            this.Controls.Add(this.lblDateout);
            this.Controls.Add(this.lblDatein);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.btncardPay);
            this.Controls.Add(this.txtboxAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtboxMMYY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtboxCardNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxCardNameHolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreditCard";
            this.Text = "Credit Card";
            this.Load += new System.EventHandler(this.CreditCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncardPay;
        private System.Windows.Forms.TextBox txtboxAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtboxMMYY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxCardNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxCardNameHolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRoomrate;
        private System.Windows.Forms.Label lblNoofchildren;
        private System.Windows.Forms.Label lblNoofadults;
        private System.Windows.Forms.Label lblTypeofroom;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblNoofnights;
        private System.Windows.Forms.Label lblDateout;
        private System.Windows.Forms.Label lblDatein;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblTotalamount;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblRefID;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Button btnCancel;
    }
}