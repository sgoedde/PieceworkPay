namespace PiecePay
{
    partial class frmPieceworkPay
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblPiecesMade = new System.Windows.Forms.Label();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.txtBxPieces = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSummary = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtBxOutput = new System.Windows.Forms.TextBox();
            this.lblAmountEarned = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatePayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.chkBxSenior = new System.Windows.Forms.CheckBox();
            this.lblSeniors = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(134, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "&Name:";
            // 
            // lblPiecesMade
            // 
            this.lblPiecesMade.AutoSize = true;
            this.lblPiecesMade.Location = new System.Drawing.Point(101, 74);
            this.lblPiecesMade.Name = "lblPiecesMade";
            this.lblPiecesMade.Size = new System.Drawing.Size(82, 17);
            this.lblPiecesMade.TabIndex = 2;
            this.lblPiecesMade.Text = "# of &Pieces:";
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(189, 30);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(100, 23);
            this.txtBxName.TabIndex = 1;
            // 
            // txtBxPieces
            // 
            this.txtBxPieces.Location = new System.Drawing.Point(189, 68);
            this.txtBxPieces.Name = "txtBxPieces";
            this.txtBxPieces.Size = new System.Drawing.Size(100, 23);
            this.txtBxPieces.TabIndex = 3;
            this.txtBxPieces.TextChanged += new System.EventHandler(this.txtBxPieces_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(55, 198);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(105, 32);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "&Calculate Pay";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(210, 198);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 32);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(137, 245);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(105, 32);
            this.btnSummary.TabIndex = 9;
            this.btnSummary.Text = "&Summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(275, 283);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 30);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtBxOutput
            // 
            this.txtBxOutput.Location = new System.Drawing.Point(189, 153);
            this.txtBxOutput.Name = "txtBxOutput";
            this.txtBxOutput.ReadOnly = true;
            this.txtBxOutput.Size = new System.Drawing.Size(100, 23);
            this.txtBxOutput.TabIndex = 6;
            this.txtBxOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAmountEarned
            // 
            this.lblAmountEarned.AutoSize = true;
            this.lblAmountEarned.Location = new System.Drawing.Point(73, 156);
            this.lblAmountEarned.Name = "lblAmountEarned";
            this.lblAmountEarned.Size = new System.Drawing.Size(110, 17);
            this.lblAmountEarned.TabIndex = 5;
            this.lblAmountEarned.Text = "Amount Earned:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(379, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatePayToolStripMenuItem,
            this.summaryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // calculatePayToolStripMenuItem
            // 
            this.calculatePayToolStripMenuItem.Name = "calculatePayToolStripMenuItem";
            this.calculatePayToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.calculatePayToolStripMenuItem.Text = "&Calculate Pay";
            this.calculatePayToolStripMenuItem.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.summaryToolStripMenuItem.Text = "&Summary";
            this.summaryToolStripMenuItem.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.clearAllToolStripMenuItem,
            this.toolStripSeparator1,
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.clearToolStripMenuItem.Text = "C&lear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.clearAllToolStripMenuItem.Text = "Clear &All";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(115, 6);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.fontToolStripMenuItem.Text = "&Font...";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.colorToolStripMenuItem.Text = "&Color...";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // chkBxSenior
            // 
            this.chkBxSenior.AutoSize = true;
            this.chkBxSenior.Location = new System.Drawing.Point(194, 116);
            this.chkBxSenior.Name = "chkBxSenior";
            this.chkBxSenior.Size = new System.Drawing.Size(15, 14);
            this.chkBxSenior.TabIndex = 4;
            this.chkBxSenior.UseVisualStyleBackColor = true;
            this.chkBxSenior.CheckedChanged += new System.EventHandler(this.txtBxPieces_TextChanged);
            // 
            // lblSeniors
            // 
            this.lblSeniors.AutoSize = true;
            this.lblSeniors.Location = new System.Drawing.Point(123, 113);
            this.lblSeniors.Name = "lblSeniors";
            this.lblSeniors.Size = new System.Drawing.Size(60, 17);
            this.lblSeniors.TabIndex = 13;
            this.lblSeniors.Text = "S&eniors:";
            // 
            // frmPieceworkPay
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(379, 325);
            this.Controls.Add(this.lblSeniors);
            this.Controls.Add(this.chkBxSenior);
            this.Controls.Add(this.lblAmountEarned);
            this.Controls.Add(this.txtBxOutput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtBxPieces);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.lblPiecesMade);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPieceworkPay";
            this.Text = "Piecework Pay";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPiecesMade;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.TextBox txtBxPieces;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtBxOutput;
        private System.Windows.Forms.Label lblAmountEarned;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatePayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.CheckBox chkBxSenior;
        private System.Windows.Forms.Label lblSeniors;
    }
}

