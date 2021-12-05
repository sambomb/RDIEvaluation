namespace RDI_Evaluation
{
    partial class FormCurrencyConverter
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelValor = new System.Windows.Forms.Label();
            this.labelDecimals = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.textBoxDecimals = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(39, 24);
            this.labelValor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(69, 29);
            this.labelValor.TabIndex = 0;
            this.labelValor.Text = "Valor";
            // 
            // labelDecimals
            // 
            this.labelDecimals.AutoSize = true;
            this.labelDecimals.Location = new System.Drawing.Point(237, 24);
            this.labelDecimals.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDecimals.Name = "labelDecimals";
            this.labelDecimals.Size = new System.Drawing.Size(113, 29);
            this.labelDecimals.TabIndex = 2;
            this.labelDecimals.Text = "Decimais";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(39, 107);
            this.labelResult.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(122, 29);
            this.labelResult.TabIndex = 5;
            this.labelResult.Text = "Resultado";
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(39, 57);
            this.textBoxValue.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxValue.MaxLength = 9;
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(153, 35);
            this.textBoxValue.TabIndex = 1;
            this.textBoxValue.Text = "000000000";
            this.textBoxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxValue.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBoxValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // textBoxDecimals
            // 
            this.textBoxDecimals.Location = new System.Drawing.Point(242, 57);
            this.textBoxDecimals.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxDecimals.MaxLength = 2;
            this.textBoxDecimals.Name = "textBoxDecimals";
            this.textBoxDecimals.Size = new System.Drawing.Size(108, 35);
            this.textBoxDecimals.TabIndex = 3;
            this.textBoxDecimals.Text = "00";
            this.textBoxDecimals.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxDecimals.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBoxDecimals.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(39, 140);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(467, 205);
            this.textBoxResult.TabIndex = 6;
            this.textBoxResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // buttonConvert
            // 
            this.buttonConvert.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonConvert.Location = new System.Drawing.Point(372, 38);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(134, 54);
            this.buttonConvert.TabIndex = 4;
            this.buttonConvert.Text = "Converter";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(372, 374);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(134, 54);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Sair";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormCurrencyConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 444);
            this.ControlBox = false;
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxDecimals);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelDecimals);
            this.Controls.Add(this.labelValor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormCurrencyConverter";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Label labelDecimals;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.TextBox textBoxDecimals;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button buttonExit;
    }
}

