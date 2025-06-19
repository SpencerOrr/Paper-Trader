namespace Paper_Trader
{
    partial class Trader
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
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.btnGetPrice = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSavePortfolio = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblcurrency = new System.Windows.Forms.Label();
            this.lblPortfolioValue = new System.Windows.Forms.Label();
            this.lstPurchases = new System.Windows.Forms.ListBox();
            this.formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSymbol
            // 
            this.txtSymbol.Location = new System.Drawing.Point(35, 24);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(100, 22);
            this.txtSymbol.TabIndex = 1;
            // 
            // btnGetPrice
            // 
            this.btnGetPrice.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGetPrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGetPrice.Location = new System.Drawing.Point(189, 61);
            this.btnGetPrice.Name = "btnGetPrice";
            this.btnGetPrice.Size = new System.Drawing.Size(105, 23);
            this.btnGetPrice.TabIndex = 3;
            this.btnGetPrice.Text = "Get Price";
            this.btnGetPrice.UseVisualStyleBackColor = false;
            this.btnGetPrice.Click += new System.EventHandler(this.btnGetPrice_Click_1);
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.YellowGreen;
            this.btnBuy.ForeColor = System.Drawing.Color.Black;
            this.btnBuy.Location = new System.Drawing.Point(35, 101);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 23);
            this.btnBuy.TabIndex = 6;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click_1);
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.Firebrick;
            this.btnSell.ForeColor = System.Drawing.Color.Black;
            this.btnSell.Location = new System.Drawing.Point(35, 145);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(75, 23);
            this.btnSell.TabIndex = 17;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrice.Location = new System.Drawing.Point(204, 30);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 16);
            this.lblPrice.TabIndex = 18;
            this.lblPrice.Text = "Price";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(35, 61);
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 22);
            this.numQuantity.TabIndex = 19;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(536, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Show Graph";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnClear.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnClear.Location = new System.Drawing.Point(581, 559);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Restart";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSavePortfolio
            // 
            this.btnSavePortfolio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSavePortfolio.Location = new System.Drawing.Point(581, 450);
            this.btnSavePortfolio.Name = "btnSavePortfolio";
            this.btnSavePortfolio.Size = new System.Drawing.Size(75, 23);
            this.btnSavePortfolio.TabIndex = 22;
            this.btnSavePortfolio.Text = "Save";
            this.btnSavePortfolio.UseVisualStyleBackColor = true;
            this.btnSavePortfolio.Click += new System.EventHandler(this.btnSavePortfolio_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnRefresh.Location = new System.Drawing.Point(581, 338);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 23;
            this.btnRefresh.Text = "Refresh ";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblcurrency
            // 
            this.lblcurrency.AutoSize = true;
            this.lblcurrency.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcurrency.Location = new System.Drawing.Point(32, 399);
            this.lblcurrency.Name = "lblcurrency";
            this.lblcurrency.Size = new System.Drawing.Size(157, 16);
            this.lblcurrency.TabIndex = 24;
            this.lblcurrency.Text = "Current amount of money ";
            // 
            // lblPortfolioValue
            // 
            this.lblPortfolioValue.AutoSize = true;
            this.lblPortfolioValue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPortfolioValue.Location = new System.Drawing.Point(32, 489);
            this.lblPortfolioValue.Name = "lblPortfolioValue";
            this.lblPortfolioValue.Size = new System.Drawing.Size(133, 16);
            this.lblPortfolioValue.TabIndex = 25;
            this.lblPortfolioValue.Text = "Current cost of stocks";
            // 
            // lstPurchases
            // 
            this.lstPurchases.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPurchases.FormattingEnabled = true;
            this.lstPurchases.ItemHeight = 25;
            this.lstPurchases.Location = new System.Drawing.Point(662, 338);
            this.lstPurchases.Name = "lstPurchases";
            this.lstPurchases.Size = new System.Drawing.Size(609, 229);
            this.lstPurchases.TabIndex = 26;
            // 
            // formsPlot1
            // 
            this.formsPlot1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.formsPlot1.DisplayScale = 0F;
            this.formsPlot1.Location = new System.Drawing.Point(662, 12);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(600, 308);
            this.formsPlot1.TabIndex = 27;
            // 
            // Trader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1283, 594);
            this.Controls.Add(this.formsPlot1);
            this.Controls.Add(this.lstPurchases);
            this.Controls.Add(this.lblPortfolioValue);
            this.Controls.Add(this.lblcurrency);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSavePortfolio);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnGetPrice);
            this.Controls.Add(this.txtSymbol);
            this.Name = "Trader";
            this.Text = "Trader";
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.Button btnGetPrice;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSavePortfolio;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblcurrency;
        private System.Windows.Forms.Label lblPortfolioValue;
        private System.Windows.Forms.ListBox lstPurchases;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
    }
}