namespace Accounts
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
            label1 = new Label();
            OwnerTxt = new TextBox();
            CreateAccountBtn = new Button();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            BankAccountsGrid = new DataGridView();
            DepositBtn = new Button();
            WithdrawBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 14F);
            label1.Location = new Point(22, 36);
            label1.Name = "label1";
            label1.Size = new Size(70, 22);
            label1.TabIndex = 0;
            label1.Text = "Owner:";
            // 
            // OwnerTxt
            // 
            OwnerTxt.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OwnerTxt.Location = new Point(98, 35);
            OwnerTxt.Name = "OwnerTxt";
            OwnerTxt.Size = new Size(145, 26);
            OwnerTxt.TabIndex = 1;
            // 
            // CreateAccountBtn
            // 
            CreateAccountBtn.BackColor = SystemColors.ControlLight;
            CreateAccountBtn.Font = new Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            CreateAccountBtn.Location = new Point(98, 67);
            CreateAccountBtn.Name = "CreateAccountBtn";
            CreateAccountBtn.Size = new Size(145, 38);
            CreateAccountBtn.TabIndex = 2;
            CreateAccountBtn.Text = "Create Account";
            CreateAccountBtn.UseVisualStyleBackColor = false;
            CreateAccountBtn.Click += CreateAccountBtn_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(109, 288);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(134, 26);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 14F);
            label2.Location = new Point(22, 289);
            label2.Name = "label2";
            label2.Size = new Size(81, 22);
            label2.TabIndex = 4;
            label2.Text = "Amount:";
            // 
            // BankAccountsGrid
            // 
            BankAccountsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BankAccountsGrid.Location = new Point(322, 35);
            BankAccountsGrid.Name = "BankAccountsGrid";
            BankAccountsGrid.Size = new Size(352, 189);
            BankAccountsGrid.TabIndex = 5;
            // 
            // DepositBtn
            // 
            DepositBtn.BackColor = SystemColors.ControlLight;
            DepositBtn.Font = new Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            DepositBtn.Location = new Point(348, 276);
            DepositBtn.Name = "DepositBtn";
            DepositBtn.Size = new Size(145, 38);
            DepositBtn.TabIndex = 6;
            DepositBtn.Text = "Deposit";
            DepositBtn.UseVisualStyleBackColor = false;
            DepositBtn.Click += DepositBtn_Click;
            // 
            // WithdrawBtn
            // 
            WithdrawBtn.BackColor = SystemColors.ControlLight;
            WithdrawBtn.Font = new Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            WithdrawBtn.Location = new Point(510, 276);
            WithdrawBtn.Name = "WithdrawBtn";
            WithdrawBtn.Size = new Size(145, 38);
            WithdrawBtn.TabIndex = 7;
            WithdrawBtn.Text = "Withdraw";
            WithdrawBtn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 361);
            Controls.Add(WithdrawBtn);
            Controls.Add(DepositBtn);
            Controls.Add(BankAccountsGrid);
            Controls.Add(label2);
            Controls.Add(numericUpDown1);
            Controls.Add(CreateAccountBtn);
            Controls.Add(OwnerTxt);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox OwnerTxt;
        private Button CreateAccountBtn;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private DataGridView BankAccountsGrid;
        private Button DepositBtn;
        private Button WithdrawBtn;
    }
}
