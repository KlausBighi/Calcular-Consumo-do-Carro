namespace Calcular_Consumo_do_Carro
{
    partial class CalcularConsumo
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
            this.calcularButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.rendimentoLabel = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.consumoLabel = new System.Windows.Forms.Label();
            this.kmTextBox = new System.Windows.Forms.TextBox();
            this.litrosTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calcularButton
            // 
            this.calcularButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calcularButton.Location = new System.Drawing.Point(69, 156);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(252, 60);
            this.calcularButton.TabIndex = 0;
            this.calcularButton.Text = "Calcular";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "&Km:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "&Litros:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label3.Location = new System.Drawing.Point(200, 15);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(135, 13);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "Rendimento – Km / Litros";
            // 
            // rendimentoLabel
            // 
            this.rendimentoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rendimentoLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rendimentoLabel.Location = new System.Drawing.Point(200, 28);
            this.rendimentoLabel.Name = "rendimentoLabel";
            this.rendimentoLabel.Size = new System.Drawing.Size(121, 27);
            this.rendimentoLabel.TabIndex = 1;
            this.rendimentoLabel.Tag = "1";
            this.rendimentoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Segoe UI", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label5.Location = new System.Drawing.Point(200, 89);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(121, 13);
            this.Label5.TabIndex = 1;
            this.Label5.Text = "Consumo – Litros / Km";
            // 
            // consumoLabel
            // 
            this.consumoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.consumoLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.consumoLabel.Location = new System.Drawing.Point(200, 102);
            this.consumoLabel.Name = "consumoLabel";
            this.consumoLabel.Size = new System.Drawing.Size(121, 27);
            this.consumoLabel.TabIndex = 1;
            this.consumoLabel.Tag = "1";
            this.consumoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kmTextBox
            // 
            this.kmTextBox.Location = new System.Drawing.Point(69, 28);
            this.kmTextBox.Name = "kmTextBox";
            this.kmTextBox.Size = new System.Drawing.Size(125, 27);
            this.kmTextBox.TabIndex = 2;
            this.kmTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // litrosTextBox
            // 
            this.litrosTextBox.Location = new System.Drawing.Point(69, 102);
            this.litrosTextBox.Name = "litrosTextBox";
            this.litrosTextBox.Size = new System.Drawing.Size(125, 27);
            this.litrosTextBox.TabIndex = 2;
            this.litrosTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CalcularConsumo
            // 
            this.AcceptButton = this.calcularButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 256);
            this.Controls.Add(this.litrosTextBox);
            this.Controls.Add(this.kmTextBox);
            this.Controls.Add(this.consumoLabel);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.rendimentoLabel);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcularButton);
            this.KeyPreview = true;
            this.Name = "CalcularConsumo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular Consumo";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalcularConsumo_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label rendimentoLabel;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label consumoLabel;
        private System.Windows.Forms.TextBox kmTextBox;
        private System.Windows.Forms.TextBox litrosTextBox;
    }
}

