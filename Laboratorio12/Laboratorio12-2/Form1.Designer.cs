namespace Laboratorio12_2
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            txtNota3 = new TextBox();
            btnPromedio = new Button();
            btnReset = new Button();
            btnSalir = new Button();
            label5 = new Label();
            txtPromedio = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(179, 31);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 0;
            label1.Text = "NOTA Promedio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 108);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 1;
            label2.Text = "NOTA No.1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 177);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 2;
            label3.Text = "NOTA No.2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 242);
            label4.Name = "label4";
            label4.Size = new Size(101, 25);
            label4.TabIndex = 3;
            label4.Text = "NOTA No.3";
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(263, 102);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(150, 31);
            txtNota1.TabIndex = 4;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(263, 171);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(150, 31);
            txtNota2.TabIndex = 5;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(263, 242);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(150, 31);
            txtNota3.TabIndex = 6;
            // 
            // btnPromedio
            // 
            btnPromedio.Location = new Point(47, 314);
            btnPromedio.Name = "btnPromedio";
            btnPromedio.Size = new Size(112, 34);
            btnPromedio.TabIndex = 7;
            btnPromedio.Text = "Promedio";
            btnPromedio.UseVisualStyleBackColor = true;
            btnPromedio.Click += btnPromedio_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(208, 314);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 34);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(361, 314);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 396);
            label5.Name = "label5";
            label5.Size = new Size(134, 25);
            label5.TabIndex = 10;
            label5.Text = "Nota Promedio";
            // 
            // txtPromedio
            // 
            txtPromedio.Location = new Point(263, 393);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.Size = new Size(150, 31);
            txtPromedio.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 477);
            Controls.Add(txtPromedio);
            Controls.Add(label5);
            Controls.Add(btnSalir);
            Controls.Add(btnReset);
            Controls.Add(btnPromedio);
            Controls.Add(txtNota3);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNota1;
        private TextBox txtNota2;
        private TextBox txtNota3;
        private Button btnPromedio;
        private Button btnReset;
        private Button btnSalir;
        private Label label5;
        private TextBox txtPromedio;
    }
}
