namespace Laboratorio12_3
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
            txtLadoA = new TextBox();
            txtLadoB = new TextBox();
            txtLadoC = new TextBox();
            btnSemiperimetro = new Button();
            btnArea = new Button();
            btnReset = new Button();
            btnSalida = new Button();
            label4 = new Label();
            label5 = new Label();
            txtSemiperimetro = new TextBox();
            txtArea = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 50);
            label1.Name = "label1";
            label1.Size = new Size(246, 25);
            label1.TabIndex = 0;
            label1.Text = "Ingresa la longitud del lado A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 92);
            label2.Name = "label2";
            label2.Size = new Size(244, 25);
            label2.TabIndex = 1;
            label2.Text = "Ingresa la longitud del lado B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 136);
            label3.Name = "label3";
            label3.Size = new Size(245, 25);
            label3.TabIndex = 2;
            label3.Text = "Ingresa la longitud del lado C";
            // 
            // txtLadoA
            // 
            txtLadoA.Location = new Point(323, 44);
            txtLadoA.Name = "txtLadoA";
            txtLadoA.Size = new Size(87, 31);
            txtLadoA.TabIndex = 3;
            // 
            // txtLadoB
            // 
            txtLadoB.Location = new Point(323, 86);
            txtLadoB.Name = "txtLadoB";
            txtLadoB.Size = new Size(87, 31);
            txtLadoB.TabIndex = 4;
            // 
            // txtLadoC
            // 
            txtLadoC.Location = new Point(323, 130);
            txtLadoC.Name = "txtLadoC";
            txtLadoC.Size = new Size(87, 31);
            txtLadoC.TabIndex = 5;
            // 
            // btnSemiperimetro
            // 
            btnSemiperimetro.Location = new Point(34, 202);
            btnSemiperimetro.Name = "btnSemiperimetro";
            btnSemiperimetro.Size = new Size(147, 34);
            btnSemiperimetro.TabIndex = 6;
            btnSemiperimetro.Text = "Semiperimetro";
            btnSemiperimetro.UseVisualStyleBackColor = true;
            btnSemiperimetro.Click += btnSemiperimetro_Click;
            // 
            // btnArea
            // 
            btnArea.Location = new Point(215, 202);
            btnArea.Name = "btnArea";
            btnArea.Size = new Size(147, 34);
            btnArea.TabIndex = 7;
            btnArea.Text = "Area";
            btnArea.UseVisualStyleBackColor = true;
            btnArea.Click += btnArea_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(403, 202);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(147, 34);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnSalida
            // 
            btnSalida.Location = new Point(594, 202);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new Size(147, 34);
            btnSalida.TabIndex = 9;
            btnSalida.Text = "Salida";
            btnSalida.UseVisualStyleBackColor = true;
            btnSalida.Click += btnSalida_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 283);
            label4.Name = "label4";
            label4.Size = new Size(195, 25);
            label4.TabIndex = 10;
            label4.Text = "Calcular Semiperimetro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 338);
            label5.Name = "label5";
            label5.Size = new Size(154, 25);
            label5.TabIndex = 11;
            label5.Text = "Area del Triangulo";
            // 
            // txtSemiperimetro
            // 
            txtSemiperimetro.Location = new Point(323, 280);
            txtSemiperimetro.Name = "txtSemiperimetro";
            txtSemiperimetro.Size = new Size(87, 31);
            txtSemiperimetro.TabIndex = 12;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(323, 332);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(87, 31);
            txtArea.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtArea);
            Controls.Add(txtSemiperimetro);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnSalida);
            Controls.Add(btnReset);
            Controls.Add(btnArea);
            Controls.Add(btnSemiperimetro);
            Controls.Add(txtLadoC);
            Controls.Add(txtLadoB);
            Controls.Add(txtLadoA);
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
        private TextBox txtLadoA;
        private TextBox txtLadoB;
        private TextBox txtLadoC;
        private Button btnSemiperimetro;
        private Button btnArea;
        private Button btnReset;
        private Button btnSalida;
        private Label label4;
        private Label label5;
        private TextBox txtSemiperimetro;
        private TextBox txtArea;
    }
}
