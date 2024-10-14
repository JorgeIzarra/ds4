namespace Laboratorio141
{
    partial class frmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            tsbBuscar = new Button();
            tsbCancelar = new Button();
            tsbEliminar = new Button();
            tsbGuardar = new Button();
            tsbNuevo = new Button();
            label1 = new Label();
            tstId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // tsbBuscar
            // 
            tsbBuscar.Image = (Image)resources.GetObject("tsbBuscar.Image");
            tsbBuscar.Location = new Point(683, 12);
            tsbBuscar.Name = "tsbBuscar";
            tsbBuscar.Size = new Size(72, 73);
            tsbBuscar.TabIndex = 0;
            tsbBuscar.UseVisualStyleBackColor = true;
            tsbBuscar.Click += tsbBuscar_Click;
            // 
            // tsbCancelar
            // 
            tsbCancelar.Image = (Image)resources.GetObject("tsbCancelar.Image");
            tsbCancelar.Location = new Point(168, 11);
            tsbCancelar.Name = "tsbCancelar";
            tsbCancelar.Size = new Size(72, 73);
            tsbCancelar.TabIndex = 1;
            tsbCancelar.UseVisualStyleBackColor = true;
            tsbCancelar.Click += tsbCancelar_Click;
            // 
            // tsbEliminar
            // 
            tsbEliminar.Image = (Image)resources.GetObject("tsbEliminar.Image");
            tsbEliminar.Location = new Point(246, 11);
            tsbEliminar.Name = "tsbEliminar";
            tsbEliminar.Size = new Size(72, 73);
            tsbEliminar.TabIndex = 2;
            tsbEliminar.UseVisualStyleBackColor = true;
            tsbEliminar.Click += tsbEliminar_Click;
            // 
            // tsbGuardar
            // 
            tsbGuardar.Image = (Image)resources.GetObject("tsbGuardar.Image");
            tsbGuardar.Location = new Point(90, 12);
            tsbGuardar.Name = "tsbGuardar";
            tsbGuardar.Size = new Size(72, 73);
            tsbGuardar.TabIndex = 3;
            tsbGuardar.UseVisualStyleBackColor = true;
            tsbGuardar.Click += tsbGuardar_Click;
            // 
            // tsbNuevo
            // 
            tsbNuevo.Image = (Image)resources.GetObject("tsbNuevo.Image");
            tsbNuevo.Location = new Point(12, 12);
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(72, 73);
            tsbNuevo.TabIndex = 4;
            tsbNuevo.UseVisualStyleBackColor = true;
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(349, 35);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 5;
            label1.Text = "Buscar por id:";
            // 
            // tstId
            // 
            tstId.Location = new Point(493, 35);
            tstId.Name = "tstId";
            tstId.Size = new Size(150, 31);
            tstId.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 153);
            label2.Name = "label2";
            label2.Size = new Size(30, 25);
            label2.TabIndex = 7;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(391, 153);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 8;
            label3.Text = "Nombre";
            // 
            // txtId
            // 
            txtId.Location = new Point(105, 194);
            txtId.Name = "txtId";
            txtId.Size = new Size(171, 31);
            txtId.TabIndex = 9;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(391, 194);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(364, 31);
            txtNombre.TabIndex = 10;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(105, 326);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(171, 31);
            txtPrecio.TabIndex = 11;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(391, 326);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(171, 31);
            txtStock.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(105, 280);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 13;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(391, 280);
            label5.Name = "label5";
            label5.Size = new Size(55, 25);
            label5.TabIndex = 14;
            label5.Text = "Stock";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(105, 422);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(171, 49);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 519);
            Controls.Add(btnSalir);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tstId);
            Controls.Add(label1);
            Controls.Add(tsbNuevo);
            Controls.Add(tsbGuardar);
            Controls.Add(tsbEliminar);
            Controls.Add(tsbCancelar);
            Controls.Add(tsbBuscar);
            Name = "frmProductos";
            Text = "Form1";
            Load += frmProductos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button tsbBuscar;
        private Button tsbCancelar;
        private Button tsbEliminar;
        private Button tsbGuardar;
        private Button tsbNuevo;
        private Label label1;
        private TextBox tstId;
        private Label label2;
        private Label label3;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private Label label4;
        private Label label5;
        private Button btnSalir;
    }
}
