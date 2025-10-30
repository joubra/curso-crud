namespace capaPresentacion
{
    partial class frClientes
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtId = new NumericUpDown();
            linkFoto = new LinkLabel();
            picFoto = new PictureBox();
            ofdFoto = new OpenFileDialog();
            btnNuevo = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)txtId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 28);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 79);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 157);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 231);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 3;
            label4.Text = "Foto";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(153, 79);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(153, 151);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(150, 31);
            txtApellido.TabIndex = 5;
            // 
            // txtId
            // 
            txtId.Location = new Point(153, 28);
            txtId.Name = "txtId";
            txtId.Size = new Size(180, 31);
            txtId.TabIndex = 6;
            // 
            // linkFoto
            // 
            linkFoto.AutoSize = true;
            linkFoto.Location = new Point(31, 274);
            linkFoto.Name = "linkFoto";
            linkFoto.Size = new Size(92, 25);
            linkFoto.TabIndex = 7;
            linkFoto.TabStop = true;
            linkFoto.Text = "Selecionar";
            linkFoto.LinkClicked += linkFoto_LinkClicked;
            // 
            // picFoto
            // 
            picFoto.BackColor = SystemColors.ControlDark;
            picFoto.Location = new Point(153, 231);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(150, 163);
            picFoto.TabIndex = 8;
            picFoto.TabStop = false;
            // 
            // ofdFoto
            // 
            ofdFoto.FileName = "openFileDialog1";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(11, 404);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(112, 34);
            btnNuevo.TabIndex = 9;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(191, 404);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(373, 404);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // frClientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Controls.Add(picFoto);
            Controls.Add(linkFoto);
            Controls.Add(txtId);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frClientes";
            Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)txtId).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private NumericUpDown txtId;
        private LinkLabel linkFoto;
        private PictureBox picFoto;
        private OpenFileDialog ofdFoto;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnGuardar;
    }
}
