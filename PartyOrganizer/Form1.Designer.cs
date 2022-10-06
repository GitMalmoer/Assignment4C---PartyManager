namespace PartyOrganizer
{
    partial class Form1
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
            this.grpNewParty = new System.Windows.Forms.GroupBox();
            this.btnCreateList = new System.Windows.Forms.Button();
            this.txtFeePerson = new System.Windows.Forms.TextBox();
            this.txtCostPerson = new System.Windows.Forms.TextBox();
            this.txtMaxGuests = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpInviteGuest = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNumberGuests = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblSurplusDeficit = new System.Windows.Forms.Label();
            this.lstGuests = new System.Windows.Forms.ListBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.grpNewParty.SuspendLayout();
            this.grpInviteGuest.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNewParty
            // 
            this.grpNewParty.Controls.Add(this.btnCreateList);
            this.grpNewParty.Controls.Add(this.txtFeePerson);
            this.grpNewParty.Controls.Add(this.txtCostPerson);
            this.grpNewParty.Controls.Add(this.txtMaxGuests);
            this.grpNewParty.Controls.Add(this.label3);
            this.grpNewParty.Controls.Add(this.label2);
            this.grpNewParty.Controls.Add(this.label1);
            this.grpNewParty.Location = new System.Drawing.Point(33, 20);
            this.grpNewParty.Name = "grpNewParty";
            this.grpNewParty.Size = new System.Drawing.Size(317, 201);
            this.grpNewParty.TabIndex = 0;
            this.grpNewParty.TabStop = false;
            this.grpNewParty.Text = "New Party";
            // 
            // btnCreateList
            // 
            this.btnCreateList.Location = new System.Drawing.Point(107, 166);
            this.btnCreateList.Name = "btnCreateList";
            this.btnCreateList.Size = new System.Drawing.Size(94, 29);
            this.btnCreateList.TabIndex = 6;
            this.btnCreateList.Text = "Create List";
            this.btnCreateList.UseVisualStyleBackColor = true;
            this.btnCreateList.Click += new System.EventHandler(this.btnCreateList_Click);
            // 
            // txtFeePerson
            // 
            this.txtFeePerson.Location = new System.Drawing.Point(193, 116);
            this.txtFeePerson.Name = "txtFeePerson";
            this.txtFeePerson.Size = new System.Drawing.Size(101, 27);
            this.txtFeePerson.TabIndex = 5;
            // 
            // txtCostPerson
            // 
            this.txtCostPerson.Location = new System.Drawing.Point(193, 77);
            this.txtCostPerson.Name = "txtCostPerson";
            this.txtCostPerson.Size = new System.Drawing.Size(101, 27);
            this.txtCostPerson.TabIndex = 4;
            // 
            // txtMaxGuests
            // 
            this.txtMaxGuests.Location = new System.Drawing.Point(193, 36);
            this.txtMaxGuests.Name = "txtMaxGuests";
            this.txtMaxGuests.Size = new System.Drawing.Size(101, 27);
            this.txtMaxGuests.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "fee per person";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cost per person";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Max number of guests";
            // 
            // grpInviteGuest
            // 
            this.grpInviteGuest.Controls.Add(this.btnAdd);
            this.grpInviteGuest.Controls.Add(this.txtLastName);
            this.grpInviteGuest.Controls.Add(this.txtName);
            this.grpInviteGuest.Controls.Add(this.label5);
            this.grpInviteGuest.Controls.Add(this.label4);
            this.grpInviteGuest.Location = new System.Drawing.Point(38, 244);
            this.grpInviteGuest.Name = "grpInviteGuest";
            this.grpInviteGuest.Size = new System.Drawing.Size(312, 144);
            this.grpInviteGuest.TabIndex = 1;
            this.grpInviteGuest.TabStop = false;
            this.grpInviteGuest.Text = "Invite Guest";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(102, 109);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(158, 71);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(125, 27);
            this.txtLastName.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(158, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 27);
            this.txtName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Last name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "First name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Number of guests";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 447);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Total Cost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 480);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Total Fees";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 512);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Surplus/Deficit";
            // 
            // lblNumberGuests
            // 
            this.lblNumberGuests.AutoSize = true;
            this.lblNumberGuests.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumberGuests.Location = new System.Drawing.Point(226, 414);
            this.lblNumberGuests.Name = "lblNumberGuests";
            this.lblNumberGuests.Size = new System.Drawing.Size(60, 22);
            this.lblNumberGuests.TabIndex = 6;
            this.lblNumberGuests.Text = "label10";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCost.Location = new System.Drawing.Point(226, 447);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(60, 22);
            this.lblTotalCost.TabIndex = 7;
            this.lblTotalCost.Text = "label11";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalFees.Location = new System.Drawing.Point(226, 480);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(60, 22);
            this.lblTotalFees.TabIndex = 8;
            this.lblTotalFees.Text = "label12";
            // 
            // lblSurplusDeficit
            // 
            this.lblSurplusDeficit.AutoSize = true;
            this.lblSurplusDeficit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSurplusDeficit.Location = new System.Drawing.Point(226, 512);
            this.lblSurplusDeficit.Name = "lblSurplusDeficit";
            this.lblSurplusDeficit.Size = new System.Drawing.Size(60, 22);
            this.lblSurplusDeficit.TabIndex = 9;
            this.lblSurplusDeficit.Text = "label13";
            // 
            // lstGuests
            // 
            this.lstGuests.FormattingEnabled = true;
            this.lstGuests.ItemHeight = 20;
            this.lstGuests.Location = new System.Drawing.Point(375, 45);
            this.lstGuests.Name = "lstGuests";
            this.lstGuests.Size = new System.Drawing.Size(266, 424);
            this.lstGuests.TabIndex = 10;
            this.lstGuests.SelectedIndexChanged += new System.EventHandler(this.lstGuests_SelectedIndexChanged);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(375, 503);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(94, 29);
            this.btnChange.TabIndex = 11;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(517, 505);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(473, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Guest List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 608);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lstGuests);
            this.Controls.Add(this.lblSurplusDeficit);
            this.Controls.Add(this.lblTotalFees);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblNumberGuests);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grpInviteGuest);
            this.Controls.Add(this.grpNewParty);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpNewParty.ResumeLayout(false);
            this.grpNewParty.PerformLayout();
            this.grpInviteGuest.ResumeLayout(false);
            this.grpInviteGuest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grpNewParty;
        private Button btnCreateList;
        private TextBox txtFeePerson;
        private TextBox txtCostPerson;
        private TextBox txtMaxGuests;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox grpInviteGuest;
        private Button btnAdd;
        private TextBox txtLastName;
        private TextBox txtName;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lblNumberGuests;
        private Label lblTotalCost;
        private Label lblTotalFees;
        private Label lblSurplusDeficit;
        private ListBox lstGuests;
        private Button btnChange;
        private Button btnDelete;
        private Label label10;
    }
}