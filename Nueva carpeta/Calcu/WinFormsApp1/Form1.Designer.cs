namespace WinFormsApp1
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
            lblResultado = new Label();
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            btnSumar = new Button();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(428, 92);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(65, 20);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "Calculo: ";
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(64, 89);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(143, 27);
            txtNumero1.TabIndex = 1;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(233, 89);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(173, 27);
            txtNumero2.TabIndex = 2;
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(537, 79);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(229, 46);
            btnSumar.TabIndex = 3;
            btnSumar.Text = "button1";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSumar);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(lblResultado);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResultado;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private Button btnSumar;
    }
}
