namespace PiecePay
{
    partial class frmSummary
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
            this.lblTotalPay = new System.Windows.Forms.Label();
            this.lblTotalPieces = new System.Windows.Forms.Label();
            this.lblAveragePay = new System.Windows.Forms.Label();
            this.lblWorkers = new System.Windows.Forms.Label();
            this.txtBxTotalPay = new System.Windows.Forms.TextBox();
            this.txtBxTotalPieces = new System.Windows.Forms.TextBox();
            this.txtBxAveragePay = new System.Windows.Forms.TextBox();
            this.txtBxWorkers = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTotalPay
            // 
            this.lblTotalPay.AutoSize = true;
            this.lblTotalPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPay.Location = new System.Drawing.Point(68, 47);
            this.lblTotalPay.Name = "lblTotalPay";
            this.lblTotalPay.Size = new System.Drawing.Size(72, 17);
            this.lblTotalPay.TabIndex = 0;
            this.lblTotalPay.Text = "Total Pay:";
            // 
            // lblTotalPieces
            // 
            this.lblTotalPieces.AutoSize = true;
            this.lblTotalPieces.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPieces.Location = new System.Drawing.Point(50, 92);
            this.lblTotalPieces.Name = "lblTotalPieces";
            this.lblTotalPieces.Size = new System.Drawing.Size(90, 17);
            this.lblTotalPieces.TabIndex = 1;
            this.lblTotalPieces.Text = "Total Pieces:";
            // 
            // lblAveragePay
            // 
            this.lblAveragePay.AutoSize = true;
            this.lblAveragePay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAveragePay.Location = new System.Drawing.Point(47, 131);
            this.lblAveragePay.Name = "lblAveragePay";
            this.lblAveragePay.Size = new System.Drawing.Size(93, 17);
            this.lblAveragePay.TabIndex = 2;
            this.lblAveragePay.Text = "Average Pay:";
            // 
            // lblWorkers
            // 
            this.lblWorkers.AutoSize = true;
            this.lblWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkers.Location = new System.Drawing.Point(47, 171);
            this.lblWorkers.Name = "lblWorkers";
            this.lblWorkers.Size = new System.Drawing.Size(93, 17);
            this.lblWorkers.TabIndex = 3;
            this.lblWorkers.Text = "# of Workers:";
            // 
            // txtBxTotalPay
            // 
            this.txtBxTotalPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxTotalPay.Location = new System.Drawing.Point(155, 47);
            this.txtBxTotalPay.Name = "txtBxTotalPay";
            this.txtBxTotalPay.ReadOnly = true;
            this.txtBxTotalPay.Size = new System.Drawing.Size(100, 23);
            this.txtBxTotalPay.TabIndex = 4;
            this.txtBxTotalPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBxTotalPieces
            // 
            this.txtBxTotalPieces.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxTotalPieces.Location = new System.Drawing.Point(155, 89);
            this.txtBxTotalPieces.Name = "txtBxTotalPieces";
            this.txtBxTotalPieces.ReadOnly = true;
            this.txtBxTotalPieces.Size = new System.Drawing.Size(100, 23);
            this.txtBxTotalPieces.TabIndex = 5;
            this.txtBxTotalPieces.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBxAveragePay
            // 
            this.txtBxAveragePay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxAveragePay.Location = new System.Drawing.Point(155, 128);
            this.txtBxAveragePay.Name = "txtBxAveragePay";
            this.txtBxAveragePay.ReadOnly = true;
            this.txtBxAveragePay.Size = new System.Drawing.Size(100, 23);
            this.txtBxAveragePay.TabIndex = 6;
            this.txtBxAveragePay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBxWorkers
            // 
            this.txtBxWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxWorkers.Location = new System.Drawing.Point(155, 168);
            this.txtBxWorkers.Name = "txtBxWorkers";
            this.txtBxWorkers.ReadOnly = true;
            this.txtBxWorkers.Size = new System.Drawing.Size(100, 23);
            this.txtBxWorkers.TabIndex = 7;
            this.txtBxWorkers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(213, 232);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmSummary
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 293);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtBxWorkers);
            this.Controls.Add(this.txtBxAveragePay);
            this.Controls.Add(this.txtBxTotalPieces);
            this.Controls.Add(this.txtBxTotalPay);
            this.Controls.Add(this.lblWorkers);
            this.Controls.Add(this.lblAveragePay);
            this.Controls.Add(this.lblTotalPieces);
            this.Controls.Add(this.lblTotalPay);
            this.Name = "frmSummary";
            this.Text = "Summary";
            this.Load += new System.EventHandler(this.frmSummary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalPay;
        private System.Windows.Forms.Label lblTotalPieces;
        private System.Windows.Forms.Label lblAveragePay;
        private System.Windows.Forms.Label lblWorkers;
        private System.Windows.Forms.TextBox txtBxTotalPay;
        private System.Windows.Forms.TextBox txtBxTotalPieces;
        private System.Windows.Forms.TextBox txtBxAveragePay;
        private System.Windows.Forms.TextBox txtBxWorkers;
        private System.Windows.Forms.Button btnOK;
    }
}