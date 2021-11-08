
namespace WindowsFormsHomework
{
    partial class Loan
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
            this.downpaymentTextBox = new System.Windows.Forms.TextBox();
            this.downpaymentlabel = new System.Windows.Forms.Label();
            this.InterestTextBox = new System.Windows.Forms.TextBox();
            this.Interestlabel = new System.Windows.Forms.Label();
            this.limitTextBox = new System.Windows.Forms.TextBox();
            this.limitlabel = new System.Windows.Forms.Label();
            this.loanTextBox = new System.Windows.Forms.TextBox();
            this.loanlabel = new System.Windows.Forms.Label();
            this.TotalButton = new System.Windows.Forms.Button();
            this.monthlyPayButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // downpaymentTextBox
            // 
            this.downpaymentTextBox.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.downpaymentTextBox.Location = new System.Drawing.Point(272, 244);
            this.downpaymentTextBox.Name = "downpaymentTextBox";
            this.downpaymentTextBox.Size = new System.Drawing.Size(175, 40);
            this.downpaymentTextBox.TabIndex = 25;
            // 
            // downpaymentlabel
            // 
            this.downpaymentlabel.AutoSize = true;
            this.downpaymentlabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.downpaymentlabel.Location = new System.Drawing.Point(101, 257);
            this.downpaymentlabel.Name = "downpaymentlabel";
            this.downpaymentlabel.Size = new System.Drawing.Size(93, 27);
            this.downpaymentlabel.TabIndex = 24;
            this.downpaymentlabel.Text = "頭期款";
            // 
            // InterestTextBox
            // 
            this.InterestTextBox.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.InterestTextBox.Location = new System.Drawing.Point(272, 185);
            this.InterestTextBox.Name = "InterestTextBox";
            this.InterestTextBox.Size = new System.Drawing.Size(175, 40);
            this.InterestTextBox.TabIndex = 23;
            // 
            // Interestlabel
            // 
            this.Interestlabel.AutoSize = true;
            this.Interestlabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Interestlabel.Location = new System.Drawing.Point(101, 198);
            this.Interestlabel.Name = "Interestlabel";
            this.Interestlabel.Size = new System.Drawing.Size(103, 27);
            this.Interestlabel.TabIndex = 22;
            this.Interestlabel.Text = "利率(%)";
            // 
            // limitTextBox
            // 
            this.limitTextBox.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.limitTextBox.Location = new System.Drawing.Point(272, 126);
            this.limitTextBox.Name = "limitTextBox";
            this.limitTextBox.Size = new System.Drawing.Size(175, 40);
            this.limitTextBox.TabIndex = 21;
            // 
            // limitlabel
            // 
            this.limitlabel.AutoSize = true;
            this.limitlabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.limitlabel.Location = new System.Drawing.Point(101, 139);
            this.limitlabel.Name = "limitlabel";
            this.limitlabel.Size = new System.Drawing.Size(109, 27);
            this.limitlabel.TabIndex = 20;
            this.limitlabel.Text = "期限(年)";
            // 
            // loanTextBox
            // 
            this.loanTextBox.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.loanTextBox.Location = new System.Drawing.Point(272, 71);
            this.loanTextBox.Name = "loanTextBox";
            this.loanTextBox.Size = new System.Drawing.Size(175, 40);
            this.loanTextBox.TabIndex = 19;
            // 
            // loanlabel
            // 
            this.loanlabel.AutoSize = true;
            this.loanlabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.loanlabel.Location = new System.Drawing.Point(101, 74);
            this.loanlabel.Name = "loanlabel";
            this.loanlabel.Size = new System.Drawing.Size(120, 27);
            this.loanlabel.TabIndex = 18;
            this.loanlabel.Text = "貸款金額";
            // 
            // TotalButton
            // 
            this.TotalButton.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TotalButton.Location = new System.Drawing.Point(314, 342);
            this.TotalButton.Name = "TotalButton";
            this.TotalButton.Size = new System.Drawing.Size(165, 42);
            this.TotalButton.TabIndex = 27;
            this.TotalButton.Text = "總付款";
            this.TotalButton.UseVisualStyleBackColor = true;
            this.TotalButton.Click += new System.EventHandler(this.TotalButton_Click);
            // 
            // monthlyPayButton
            // 
            this.monthlyPayButton.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.monthlyPayButton.Location = new System.Drawing.Point(106, 342);
            this.monthlyPayButton.Name = "monthlyPayButton";
            this.monthlyPayButton.Size = new System.Drawing.Size(165, 42);
            this.monthlyPayButton.TabIndex = 26;
            this.monthlyPayButton.Text = "PMT(月付)";
            this.monthlyPayButton.UseVisualStyleBackColor = true;
            this.monthlyPayButton.Click += new System.EventHandler(this.monthlyPayButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.reportButton.Location = new System.Drawing.Point(550, 342);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(165, 42);
            this.reportButton.TabIndex = 28;
            this.reportButton.Text = "Report";
            this.reportButton.UseVisualStyleBackColor = true;
            // 
            // Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.TotalButton);
            this.Controls.Add(this.monthlyPayButton);
            this.Controls.Add(this.downpaymentTextBox);
            this.Controls.Add(this.downpaymentlabel);
            this.Controls.Add(this.InterestTextBox);
            this.Controls.Add(this.Interestlabel);
            this.Controls.Add(this.limitTextBox);
            this.Controls.Add(this.limitlabel);
            this.Controls.Add(this.loanTextBox);
            this.Controls.Add(this.loanlabel);
            this.Name = "Loan";
            this.Text = "貸款金額計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox downpaymentTextBox;
        private System.Windows.Forms.Label downpaymentlabel;
        private System.Windows.Forms.TextBox InterestTextBox;
        private System.Windows.Forms.Label Interestlabel;
        private System.Windows.Forms.TextBox limitTextBox;
        private System.Windows.Forms.Label limitlabel;
        private System.Windows.Forms.TextBox loanTextBox;
        private System.Windows.Forms.Label loanlabel;
        private System.Windows.Forms.Button TotalButton;
        private System.Windows.Forms.Button monthlyPayButton;
        private System.Windows.Forms.Button reportButton;
    }
}