
namespace TicketAgency_Client
{
    partial class EmployeeV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeV));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnRefill = new System.Windows.Forms.Button();
            this.txtIdE = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPriceE = new System.Windows.Forms.TextBox();
            this.txtSeatsE = new System.Windows.Forms.TextBox();
            this.txtDurationE = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDestinationE = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOriginE = new System.Windows.Forms.TextBox();
            this.txtTrainE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDeleteTicket = new System.Windows.Forms.Button();
            this.btnUpdateTicket = new System.Windows.Forms.Button();
            this.btnAddTicket = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAuthentication
            // 
            this.btnAuthentication.Click += new System.EventHandler(this.btnAuthentication_Click_1);
            // 
            // cmbDestination
            // 
            this.cmbDestination.Margin = new System.Windows.Forms.Padding(2);
            // 
            // cmbOrigin
            // 
            this.cmbOrigin.Margin = new System.Windows.Forms.Padding(2);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btnSell);
            this.panel1.Controls.Add(this.btnRefill);
            this.panel1.Controls.Add(this.txtIdE);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.txtPriceE);
            this.panel1.Controls.Add(this.txtSeatsE);
            this.panel1.Controls.Add(this.txtDurationE);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txtDestinationE);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnDeleteTicket);
            this.panel1.Controls.Add(this.btnUpdateTicket);
            this.panel1.Controls.Add(this.btnAddTicket);
            this.panel1.Controls.Add(this.txtOriginE);
            this.panel1.Controls.Add(this.txtTrainE);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(1049, 54);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 343);
            this.panel1.TabIndex = 39;
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.Red;
            this.btnSell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSell.Location = new System.Drawing.Point(294, 222);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(82, 45);
            this.btnSell.TabIndex = 31;
            this.btnSell.Text = "SELL TICKET";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnRefill
            // 
            this.btnRefill.BackColor = System.Drawing.Color.Lime;
            this.btnRefill.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefill.Location = new System.Drawing.Point(294, 278);
            this.btnRefill.Name = "btnRefill";
            this.btnRefill.Size = new System.Drawing.Size(82, 42);
            this.btnRefill.TabIndex = 30;
            this.btnRefill.Text = "REFILL TICKETS";
            this.btnRefill.UseVisualStyleBackColor = false;
            this.btnRefill.Click += new System.EventHandler(this.btnRefill_Click);
            // 
            // txtIdE
            // 
            this.txtIdE.Location = new System.Drawing.Point(101, 292);
            this.txtIdE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdE.Name = "txtIdE";
            this.txtIdE.Size = new System.Drawing.Size(132, 20);
            this.txtIdE.TabIndex = 29;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 294);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "TICKET ID";
            // 
            // txtPriceE
            // 
            this.txtPriceE.Location = new System.Drawing.Point(101, 258);
            this.txtPriceE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPriceE.Name = "txtPriceE";
            this.txtPriceE.Size = new System.Drawing.Size(132, 20);
            this.txtPriceE.TabIndex = 27;
            // 
            // txtSeatsE
            // 
            this.txtSeatsE.Location = new System.Drawing.Point(101, 222);
            this.txtSeatsE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSeatsE.Name = "txtSeatsE";
            this.txtSeatsE.Size = new System.Drawing.Size(132, 20);
            this.txtSeatsE.TabIndex = 26;
            // 
            // txtDurationE
            // 
            this.txtDurationE.Location = new System.Drawing.Point(101, 187);
            this.txtDurationE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDurationE.Name = "txtDurationE";
            this.txtDurationE.Size = new System.Drawing.Size(132, 20);
            this.txtDurationE.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 260);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "PRICE";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 221);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "SEATS";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 186);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "DURATION";
            // 
            // txtDestinationE
            // 
            this.txtDestinationE.Location = new System.Drawing.Point(101, 150);
            this.txtDestinationE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDestinationE.Name = "txtDestinationE";
            this.txtDestinationE.Size = new System.Drawing.Size(132, 20);
            this.txtDestinationE.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(272, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 15);
            this.label12.TabIndex = 19;
            this.label12.Text = "UPDATE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(272, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "DELETE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(272, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "ADD";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(15, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(218, 32);
            this.label9.TabIndex = 16;
            this.label9.Text = "EMPLOYEE PANEL";
            // 
            // txtOriginE
            // 
            this.txtOriginE.Location = new System.Drawing.Point(101, 114);
            this.txtOriginE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOriginE.Name = "txtOriginE";
            this.txtOriginE.Size = new System.Drawing.Size(132, 20);
            this.txtOriginE.TabIndex = 8;
            // 
            // txtTrainE
            // 
            this.txtTrainE.Location = new System.Drawing.Point(101, 79);
            this.txtTrainE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTrainE.Name = "txtTrainE";
            this.txtTrainE.Size = new System.Drawing.Size(132, 20);
            this.txtTrainE.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "DESTINATION";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "ORIGIN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "TRAIN NO";
            // 
            // btnDeleteTicket
            // 
            this.btnDeleteTicket.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteTicket.BackgroundImage = global::TicketAgency_Client.Properties.Resources.stergere;
            this.btnDeleteTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteTicket.Location = new System.Drawing.Point(325, 115);
            this.btnDeleteTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteTicket.Name = "btnDeleteTicket";
            this.btnDeleteTicket.Size = new System.Drawing.Size(51, 42);
            this.btnDeleteTicket.TabIndex = 15;
            this.btnDeleteTicket.UseVisualStyleBackColor = false;
            this.btnDeleteTicket.Click += new System.EventHandler(this.btnDeleteTicket_Click);
            // 
            // btnUpdateTicket
            // 
            this.btnUpdateTicket.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateTicket.BackgroundImage = global::TicketAgency_Client.Properties.Resources.editare;
            this.btnUpdateTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateTicket.Location = new System.Drawing.Point(325, 161);
            this.btnUpdateTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateTicket.Name = "btnUpdateTicket";
            this.btnUpdateTicket.Size = new System.Drawing.Size(51, 40);
            this.btnUpdateTicket.TabIndex = 14;
            this.btnUpdateTicket.UseVisualStyleBackColor = false;
            this.btnUpdateTicket.Click += new System.EventHandler(this.btnUpdateTicket_Click);
            // 
            // btnAddTicket
            // 
            this.btnAddTicket.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddTicket.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddTicket.BackgroundImage")));
            this.btnAddTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddTicket.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddTicket.Location = new System.Drawing.Point(325, 70);
            this.btnAddTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddTicket.Name = "btnAddTicket";
            this.btnAddTicket.Size = new System.Drawing.Size(51, 42);
            this.btnAddTicket.TabIndex = 10;
            this.btnAddTicket.UseVisualStyleBackColor = false;
            this.btnAddTicket.Click += new System.EventHandler(this.btnAddTicket_Click);
            // 
            // EmployeeV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicketAgency_Client.Properties.Resources.backgroundFrame;
            this.ClientSize = new System.Drawing.Size(1456, 420);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EmployeeV";
            this.Text = "EmployeeV";
            this.Controls.SetChildIndex(this.cmbOrigin, 0);
            this.Controls.SetChildIndex(this.cmbDestination, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.btnListTrains, 0);
            this.Controls.SetChildIndex(this.btnAuthentication, 0);
            this.Controls.SetChildIndex(this.btnSearchTrain, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnRefill;
        private System.Windows.Forms.TextBox txtIdE;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPriceE;
        private System.Windows.Forms.TextBox txtSeatsE;
        private System.Windows.Forms.TextBox txtDurationE;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDestinationE;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDeleteTicket;
        private System.Windows.Forms.Button btnUpdateTicket;
        private System.Windows.Forms.Button btnAddTicket;
        private System.Windows.Forms.TextBox txtOriginE;
        private System.Windows.Forms.TextBox txtTrainE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}