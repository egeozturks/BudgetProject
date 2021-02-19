
namespace BudgetProjectBror
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
            this.dgrwShopping = new System.Windows.Forms.DataGridView();
            this.btnTotalShopping = new System.Windows.Forms.Button();
            this.btnRemainingMoney = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrwShopping)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrwShopping
            // 
            this.dgrwShopping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrwShopping.Location = new System.Drawing.Point(12, 12);
            this.dgrwShopping.Name = "dgrwShopping";
            this.dgrwShopping.RowTemplate.Height = 25;
            this.dgrwShopping.Size = new System.Drawing.Size(776, 261);
            this.dgrwShopping.TabIndex = 0;
            // 
            // btnTotalShopping
            // 
            this.btnTotalShopping.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTotalShopping.Location = new System.Drawing.Point(12, 331);
            this.btnTotalShopping.Name = "btnTotalShopping";
            this.btnTotalShopping.Size = new System.Drawing.Size(323, 65);
            this.btnTotalShopping.TabIndex = 1;
            this.btnTotalShopping.Text = "button1";
            this.btnTotalShopping.UseVisualStyleBackColor = true;
            this.btnTotalShopping.Click += new System.EventHandler(this.btnTotalShopping_Click);
            // 
            // btnRemainingMoney
            // 
            this.btnRemainingMoney.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemainingMoney.Location = new System.Drawing.Point(465, 331);
            this.btnRemainingMoney.Name = "btnRemainingMoney";
            this.btnRemainingMoney.Size = new System.Drawing.Size(323, 65);
            this.btnRemainingMoney.TabIndex = 2;
            this.btnRemainingMoney.Text = "button2";
            this.btnRemainingMoney.UseVisualStyleBackColor = true;
            this.btnRemainingMoney.Click += new System.EventHandler(this.btnRemainingMoney_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemainingMoney);
            this.Controls.Add(this.btnTotalShopping);
            this.Controls.Add(this.dgrwShopping);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrwShopping)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrwShopping;
        private System.Windows.Forms.Button btnTotalShopping;
        private System.Windows.Forms.Button btnRemainingMoney;
    }
}

