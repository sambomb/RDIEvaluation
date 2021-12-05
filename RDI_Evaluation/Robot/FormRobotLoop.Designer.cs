namespace RDI_Evaluation
{
    partial class FormRobotLoop
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
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.tableLayoutPanelBotoes = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxComandos = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.labelLinha = new System.Windows.Forms.Label();
            this.labelColuna = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExecutar = new System.Windows.Forms.Button();
            this.tableLayoutPanelBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUp
            // 
            this.buttonUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUp.Location = new System.Drawing.Point(136, 3);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(127, 127);
            this.buttonUp.TabIndex = 0;
            this.buttonUp.TabStop = false;
            this.buttonUp.Text = "Up";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLeft.Location = new System.Drawing.Point(3, 136);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(127, 127);
            this.buttonLeft.TabIndex = 1;
            this.buttonLeft.TabStop = false;
            this.buttonLeft.Text = "Left";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRight.Location = new System.Drawing.Point(269, 136);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(128, 127);
            this.buttonRight.TabIndex = 2;
            this.buttonRight.TabStop = false;
            this.buttonRight.Text = "Right";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDown.Location = new System.Drawing.Point(136, 269);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(127, 128);
            this.buttonDown.TabIndex = 3;
            this.buttonDown.TabStop = false;
            this.buttonDown.Text = "Down";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // tableLayoutPanelBotoes
            // 
            this.tableLayoutPanelBotoes.ColumnCount = 3;
            this.tableLayoutPanelBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBotoes.Controls.Add(this.buttonExecutar, 0, 0);
            this.tableLayoutPanelBotoes.Controls.Add(this.buttonUp, 1, 0);
            this.tableLayoutPanelBotoes.Controls.Add(this.buttonDown, 1, 2);
            this.tableLayoutPanelBotoes.Controls.Add(this.buttonLeft, 0, 1);
            this.tableLayoutPanelBotoes.Controls.Add(this.buttonRight, 2, 1);
            this.tableLayoutPanelBotoes.Location = new System.Drawing.Point(385, 8);
            this.tableLayoutPanelBotoes.Name = "tableLayoutPanelBotoes";
            this.tableLayoutPanelBotoes.RowCount = 3;
            this.tableLayoutPanelBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBotoes.Size = new System.Drawing.Size(400, 400);
            this.tableLayoutPanelBotoes.TabIndex = 4;
            // 
            // listBoxComandos
            // 
            this.listBoxComandos.FormattingEnabled = true;
            this.listBoxComandos.ItemHeight = 29;
            this.listBoxComandos.Location = new System.Drawing.Point(17, 94);
            this.listBoxComandos.Name = "listBoxComandos";
            this.listBoxComandos.ScrollAlwaysVisible = true;
            this.listBoxComandos.Size = new System.Drawing.Size(360, 207);
            this.listBoxComandos.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(216, 308);
            this.button5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(161, 64);
            this.button5.TabIndex = 6;
            this.button5.Text = "Sair";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // labelLinha
            // 
            this.labelLinha.AutoSize = true;
            this.labelLinha.Location = new System.Drawing.Point(43, 308);
            this.labelLinha.Name = "labelLinha";
            this.labelLinha.Size = new System.Drawing.Size(96, 29);
            this.labelLinha.TabIndex = 7;
            this.labelLinha.Text = "Linha: 0";
            // 
            // labelColuna
            // 
            this.labelColuna.AutoSize = true;
            this.labelColuna.Location = new System.Drawing.Point(43, 343);
            this.labelColuna.Name = "labelColuna";
            this.labelColuna.Size = new System.Drawing.Size(114, 29);
            this.labelColuna.TabIndex = 8;
            this.labelColuna.Text = "Coluna: 0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(360, 35);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "RRRRDDDLLUUUUUUURRDDDDR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Comandos:";
            // 
            // buttonExecutar
            // 
            this.buttonExecutar.Location = new System.Drawing.Point(5, 4);
            this.buttonExecutar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonExecutar.Name = "buttonExecutar";
            this.buttonExecutar.Size = new System.Drawing.Size(123, 64);
            this.buttonExecutar.TabIndex = 11;
            this.buttonExecutar.Text = "Executar";
            this.buttonExecutar.UseVisualStyleBackColor = true;
            this.buttonExecutar.Click += new System.EventHandler(this.buttonExecutar_Click);
            // 
            // FormRobotLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 411);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelColuna);
            this.Controls.Add(this.labelLinha);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.listBoxComandos);
            this.Controls.Add(this.tableLayoutPanelBotoes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormRobotLoop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robot Loop";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormRobotLoop_KeyDown);
            this.tableLayoutPanelBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBotoes;
        private System.Windows.Forms.ListBox listBoxComandos;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label labelLinha;
        private System.Windows.Forms.Label labelColuna;
        private System.Windows.Forms.Button buttonExecutar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}