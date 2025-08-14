namespace TareaFormulario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TextBox txtNombre;
        private TextBox txtCarnet;
        private TextBox txtCarrera;
        private Button btnAgregar;
        private Button btnLimpiar;
        private Label lblLista;
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
            txtNombre = new TextBox();
            txtCarnet = new TextBox();
            txtCarrera = new TextBox();
            btnAgregar = new Button();
            btnLimpiar = new Button();
            lblLista = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(34, 27);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(228, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtCarnet
            // 
            txtCarnet.Location = new Point(34, 80);
            txtCarnet.Margin = new Padding(3, 4, 3, 4);
            txtCarnet.Name = "txtCarnet";
            txtCarnet.PlaceholderText = "Carnet (7 caracteres)";
            txtCarnet.Size = new Size(228, 27);
            txtCarnet.TabIndex = 1;
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(34, 133);
            txtCarrera.Margin = new Padding(3, 4, 3, 4);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.PlaceholderText = "Carrera";
            txtCarrera.Size = new Size(228, 27);
            txtCarrera.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(34, 187);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(103, 40);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(160, 187);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(103, 40);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblLista
            // 
            lblLista.AutoSize = true;
            lblLista.Location = new Point(34, 253);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(142, 20);
            lblLista.TabIndex = 5;
            lblLista.Text = "Lista de Estudiantes:";
            // 
            // Form1
            // 
            AcceptButton = btnAgregar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnLimpiar;
            ClientSize = new Size(428, 496);
            Controls.Add(lblLista);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAgregar);
            Controls.Add(txtCarrera);
            Controls.Add(txtCarnet);
            Controls.Add(txtNombre);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Registro de Estudiantes";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
    }
}