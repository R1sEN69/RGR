namespace RGR
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelBusNumber = new System.Windows.Forms.Label();
            this.txtBusNumber = new System.Windows.Forms.TextBox();
            this.labelDeparturePoint = new System.Windows.Forms.Label();
            this.txtDeparturePoint = new System.Windows.Forms.TextBox();
            this.labelDestination = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.labelDepartureTime = new System.Windows.Forms.Label();
            this.txtDepartureTime = new System.Windows.Forms.TextBox();
            this.labelTicketPrice = new System.Windows.Forms.Label();
            this.txtTicketPrice = new System.Windows.Forms.TextBox();
            this.btnAddBus = new System.Windows.Forms.Button();
            this.btnRemoveBus = new System.Windows.Forms.Button();
            this.listBoxBuses = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            // labelBusNumber
            this.labelBusNumber.AutoSize = true;
            this.labelBusNumber.Location = new System.Drawing.Point(13, 13);
            this.labelBusNumber.Name = "labelBusNumber";
            this.labelBusNumber.Size = new System.Drawing.Size(87, 13);
            this.labelBusNumber.TabIndex = 0;
            this.labelBusNumber.Text = "Номер автобуса:";

            // txtBusNumber
            this.txtBusNumber.Location = new System.Drawing.Point(13, 30);
            this.txtBusNumber.Name = "txtBusNumber";
            this.txtBusNumber.Size = new System.Drawing.Size(100, 20);
            this.txtBusNumber.TabIndex = 1;

            // labelDeparturePoint
            this.labelDeparturePoint.AutoSize = true;
            this.labelDeparturePoint.Location = new System.Drawing.Point(13, 57);
            this.labelDeparturePoint.Name = "labelDeparturePoint";
            this.labelDeparturePoint.Size = new System.Drawing.Size(100, 13);
            this.labelDeparturePoint.TabIndex = 2;
            this.labelDeparturePoint.Text = "Пункт відправлення:";

            // txtDeparturePoint
            this.txtDeparturePoint.Location = new System.Drawing.Point(13, 74);
            this.txtDeparturePoint.Name = "txtDeparturePoint";
            this.txtDeparturePoint.Size = new System.Drawing.Size(100, 20);
            this.txtDeparturePoint.TabIndex = 3;

            // labelDestination
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(13, 101);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(63, 13);
            this.labelDestination.TabIndex = 4;
            this.labelDestination.Text = "Пункт призначення:";

            // txtDestination
            this.txtDestination.Location = new System.Drawing.Point(13, 118);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(100, 20);
            this.txtDestination.TabIndex = 5;

            // labelDepartureTime
            this.labelDepartureTime.AutoSize = true;
            this.labelDepartureTime.Location = new System.Drawing.Point(13, 145);
            this.labelDepartureTime.Name = "labelDepartureTime";
            this.labelDepartureTime.Size = new System.Drawing.Size(92, 13);
            this.labelDepartureTime.TabIndex = 6;
            this.labelDepartureTime.Text = "Час відправлення:";

            // txtDepartureTime
            this.txtDepartureTime.Location = new System.Drawing.Point(13, 162);
            this.txtDepartureTime.Name = "txtDepartureTime";
            this.txtDepartureTime.Size = new System.Drawing.Size(100, 20);
            this.txtDepartureTime.TabIndex = 7;

            // labelTicketPrice
            this.labelTicketPrice.AutoSize = true;
            this.labelTicketPrice.Location = new System.Drawing.Point(13, 189);
            this.labelTicketPrice.Name = "labelTicketPrice";
            this.labelTicketPrice.Size = new System.Drawing.Size(64, 13);
            this.labelTicketPrice.TabIndex = 8;
            this.labelTicketPrice.Text = "Ціна квитка:";

            // txtTicketPrice
            this.txtTicketPrice.Location = new System.Drawing.Point(13, 206);
            this.txtTicketPrice.Name = "txtTicketPrice";
            this.txtTicketPrice.Size = new System.Drawing.Size(100, 20);
            this.txtTicketPrice.TabIndex = 9;

            // btnAddBus
            this.btnAddBus.Location = new System.Drawing.Point(13, 233);
            this.btnAddBus.Name = "btnAddBus";
            this.btnAddBus.Size = new System.Drawing.Size(75, 23);
            this.btnAddBus.TabIndex = 10;
            this.btnAddBus.Text = "Додати автобус";
            this.btnAddBus.UseVisualStyleBackColor = true;
            this.btnAddBus.Click += new System.EventHandler(this.btnAddBus_Click);

            // btnRemoveBus
            this.btnRemoveBus.Location = new System.Drawing.Point(13, 262);
            this.btnRemoveBus.Name = "btnRemoveBus";
            this.btnRemoveBus.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveBus.TabIndex = 11;
            this.btnRemoveBus.Text = "Видалити автобус";
            this.btnRemoveBus.UseVisualStyleBackColor = true;
            this.btnRemoveBus.Click += new System.EventHandler(this.btnRemoveBus_Click);

            // listBoxBuses
            this.listBoxBuses.FormattingEnabled = true;
            this.listBoxBuses.Location = new System.Drawing.Point(120, 13);
            this.listBoxBuses.Name = "listBoxBuses";
            this.listBoxBuses.Size = new System.Drawing.Size(600, 500);
            this.listBoxBuses.TabIndex = 13;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 600);
            this.Controls.Add(this.listBoxBuses);
            this.Controls.Add(this.btnRemoveBus);
            this.Controls.Add(this.btnAddBus);
            this.Controls.Add(this.txtTicketPrice);
            this.Controls.Add(this.labelTicketPrice);
            this.Controls.Add(this.txtDepartureTime);
            this.Controls.Add(this.labelDepartureTime);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.txtDeparturePoint);
            this.Controls.Add(this.labelDeparturePoint);
            this.Controls.Add(this.txtBusNumber);
            this.Controls.Add(this.labelBusNumber);
            this.Name = "Form1";
            this.Text = "Bus Station Management";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelBusNumber;
        private System.Windows.Forms.TextBox txtBusNumber;
        private System.Windows.Forms.Label labelDeparturePoint;
        private System.Windows.Forms.TextBox txtDeparturePoint;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label labelDepartureTime;
        private System.Windows.Forms.TextBox txtDepartureTime;
        private System.Windows.Forms.Label labelTicketPrice;
        private System.Windows.Forms.TextBox txtTicketPrice;
        private System.Windows.Forms.Button btnAddBus;
        private System.Windows.Forms.Button btnRemoveBus;
        private System.Windows.Forms.ListBox listBoxBuses;
    }
}