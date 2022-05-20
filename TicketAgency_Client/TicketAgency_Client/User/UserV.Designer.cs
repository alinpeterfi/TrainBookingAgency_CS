
namespace TicketAgency_Client
{
    partial class UserV
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
            this.btnSearchTrain = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTrainNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAuthentication = new System.Windows.Forms.Button();
            this.btnListTrains = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbDestination = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TrainNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DestinationStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbOrigin = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Seats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchTrain
            // 
            this.btnSearchTrain.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSearchTrain.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSearchTrain.Location = new System.Drawing.Point(897, 297);
            this.btnSearchTrain.Name = "btnSearchTrain";
            this.btnSearchTrain.Size = new System.Drawing.Size(138, 33);
            this.btnSearchTrain.TabIndex = 38;
            this.btnSearchTrain.Text = "SEARCH TRAIN";
            this.btnSearchTrain.UseVisualStyleBackColor = false;
            this.btnSearchTrain.Click += new System.EventHandler(this.btnSearchTrain_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label5.Location = new System.Drawing.Point(899, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "ENTER TRAIN NUMBER";
            // 
            // txtTrainNo
            // 
            this.txtTrainNo.BackColor = System.Drawing.SystemColors.Control;
            this.txtTrainNo.Location = new System.Drawing.Point(900, 271);
            this.txtTrainNo.Name = "txtTrainNo";
            this.txtTrainNo.Size = new System.Drawing.Size(134, 20);
            this.txtTrainNo.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(897, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "SEARCH TRAIN";
            // 
            // btnAuthentication
            // 
            this.btnAuthentication.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAuthentication.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAuthentication.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAuthentication.Location = new System.Drawing.Point(897, 353);
            this.btnAuthentication.Name = "btnAuthentication";
            this.btnAuthentication.Size = new System.Drawing.Size(136, 44);
            this.btnAuthentication.TabIndex = 34;
            this.btnAuthentication.Text = "AUTHENTICATION";
            this.btnAuthentication.UseVisualStyleBackColor = false;
            this.btnAuthentication.Click += new System.EventHandler(this.btnAuthentication_Click);
            // 
            // btnListTrains
            // 
            this.btnListTrains.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnListTrains.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnListTrains.Location = new System.Drawing.Point(897, 51);
            this.btnListTrains.Name = "btnListTrains";
            this.btnListTrains.Size = new System.Drawing.Size(138, 29);
            this.btnListTrains.TabIndex = 33;
            this.btnListTrains.Text = "VIEW ALL TRAINS";
            this.btnListTrains.UseVisualStyleBackColor = false;
            this.btnListTrains.Click += new System.EventHandler(this.btnListTrains_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(897, 196);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(138, 28);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbDestination
            // 
            this.cmbDestination.BackColor = System.Drawing.SystemColors.Control;
            this.cmbDestination.FormattingEnabled = true;
            this.cmbDestination.Items.AddRange(new object[] {
            "Bistrita",
            "Brasov",
            "Bucuresti"});
            this.cmbDestination.Location = new System.Drawing.Point(898, 169);
            this.cmbDestination.Name = "cmbDestination";
            this.cmbDestination.Size = new System.Drawing.Size(136, 21);
            this.cmbDestination.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(897, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "TO";
            // 
            // TrainNo
            // 
            this.TrainNo.HeaderText = "TRAIN NUMBER";
            this.TrainNo.MinimumWidth = 6;
            this.TrainNo.Name = "TrainNo";
            this.TrainNo.Width = 125;
            // 
            // OriginStation
            // 
            this.OriginStation.HeaderText = "ORIGIN STATION";
            this.OriginStation.MinimumWidth = 6;
            this.OriginStation.Name = "OriginStation";
            this.OriginStation.Width = 125;
            // 
            // DestinationStation
            // 
            this.DestinationStation.HeaderText = "DESTINATION STATION";
            this.DestinationStation.MinimumWidth = 6;
            this.DestinationStation.Name = "DestinationStation";
            this.DestinationStation.Width = 125;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "DURATION";
            this.Duration.MinimumWidth = 6;
            this.Duration.Name = "Duration";
            this.Duration.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(897, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "FROM";
            // 
            // Price
            // 
            this.Price.HeaderText = "PRICE";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // TicketId
            // 
            this.TicketId.HeaderText = "TICKET ID";
            this.TicketId.MinimumWidth = 6;
            this.TicketId.Name = "TicketId";
            this.TicketId.Width = 125;
            // 
            // cmbOrigin
            // 
            this.cmbOrigin.BackColor = System.Drawing.SystemColors.Control;
            this.cmbOrigin.FormattingEnabled = true;
            this.cmbOrigin.Items.AddRange(new object[] {
            "Cluj-Napoca",
            "Bucuresti"});
            this.cmbOrigin.Location = new System.Drawing.Point(899, 111);
            this.cmbOrigin.Name = "cmbOrigin";
            this.cmbOrigin.Size = new System.Drawing.Size(136, 21);
            this.cmbOrigin.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(483, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "TRAINS LIST";
            // 
            // Seats
            // 
            this.Seats.HeaderText = "SEATS";
            this.Seats.MinimumWidth = 6;
            this.Seats.Name = "Seats";
            this.Seats.Width = 125;
            // 
            // dgvUser
            // 
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TrainNo,
            this.OriginStation,
            this.DestinationStation,
            this.Duration,
            this.Seats,
            this.Price,
            this.TicketId});
            this.dgvUser.Location = new System.Drawing.Point(12, 51);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.RowTemplate.Height = 25;
            this.dgvUser.Size = new System.Drawing.Size(879, 346);
            this.dgvUser.TabIndex = 26;
            this.dgvUser.SelectionChanged += new System.EventHandler(this.dgvUser_SelectionChanged);
            // 
            // UserV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicketAgency_Client.Properties.Resources.backgroundFrame;
            this.ClientSize = new System.Drawing.Size(1051, 429);
            this.Controls.Add(this.btnSearchTrain);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTrainNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAuthentication);
            this.Controls.Add(this.btnListTrains);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbDestination);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbOrigin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUser);
            this.Name = "UserV";
            this.Text = "UserV";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button btnSearchTrain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTrainNo;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Button btnAuthentication;
        protected System.Windows.Forms.Button btnListTrains;
        protected System.Windows.Forms.Button btnSearch;
        protected System.Windows.Forms.ComboBox cmbDestination;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestinationStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketId;
        protected System.Windows.Forms.ComboBox cmbOrigin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seats;
        protected System.Windows.Forms.DataGridView dgvUser;
    }
}

