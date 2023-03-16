namespace EducacionCorporal
{
    partial class FormularioPaciente
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
            components = new System.ComponentModel.Container();
            btnGuardar = new Button();
            btnCancelar = new Button();
            lblFechaNacimiento = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            lblPrimerNombre = new Label();
            txtPrimerNombre = new TextBox();
            txtSegundoNombre = new TextBox();
            lblSegundoNombre = new Label();
            txtPrimerApellido = new TextBox();
            lblPrimerApellido = new Label();
            txtSegundoApellido = new TextBox();
            lblSegundoApellido = new Label();
            chkTitular = new CheckBox();
            lblTitular = new Label();
            rdbFemenino = new RadioButton();
            lblSexo = new Label();
            rdbMasculino = new RadioButton();
            lblTipoDocumento = new Label();
            cboTipoDocumento = new ComboBox();
            erpMensaje = new ErrorProvider(components);
            ttpMensaje = new ToolTip(components);
            txtIngresoBase = new TextBox();
            lblIngresoBase = new Label();
            lblCelular = new Label();
            txtCelular = new MaskedTextBox();
            txtNumeroDocumento = new TextBox();
            lblNumeroDocumento = new Label();
            ((System.ComponentModel.ISupportInitialize)erpMensaje).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Dock = DockStyle.Bottom;
            btnGuardar.Location = new Point(0, 704);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(996, 55);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Dock = DockStyle.Bottom;
            btnCancelar.Location = new Point(0, 649);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(996, 55);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(32, 392);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(149, 20);
            lblFechaNacimiento.TabIndex = 8;
            lblFechaNacimiento.Text = "&Fecha de Nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(264, 402);
            dtpFechaNacimiento.Margin = new Padding(3, 4, 3, 4);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(701, 27);
            dtpFechaNacimiento.TabIndex = 9;
            // 
            // lblPrimerNombre
            // 
            lblPrimerNombre.AutoSize = true;
            lblPrimerNombre.Location = new Point(30, 69);
            lblPrimerNombre.Name = "lblPrimerNombre";
            lblPrimerNombre.Size = new Size(111, 20);
            lblPrimerNombre.TabIndex = 0;
            lblPrimerNombre.Text = "&Primer Nombre";
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.Location = new Point(264, 69);
            txtPrimerNombre.Margin = new Padding(3, 4, 3, 4);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(698, 27);
            txtPrimerNombre.TabIndex = 1;
            ttpMensaje.SetToolTip(txtPrimerNombre, "Ingrese el primer nombre del paciente");
            // 
            // txtSegundoNombre
            // 
            txtSegundoNombre.Location = new Point(264, 126);
            txtSegundoNombre.Margin = new Padding(3, 4, 3, 4);
            txtSegundoNombre.Name = "txtSegundoNombre";
            txtSegundoNombre.Size = new Size(698, 27);
            txtSegundoNombre.TabIndex = 3;
            // 
            // lblSegundoNombre
            // 
            lblSegundoNombre.AutoSize = true;
            lblSegundoNombre.Location = new Point(30, 124);
            lblSegundoNombre.Name = "lblSegundoNombre";
            lblSegundoNombre.Size = new Size(127, 20);
            lblSegundoNombre.TabIndex = 2;
            lblSegundoNombre.Text = "&Segundo Nombre";
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(264, 183);
            txtPrimerApellido.Margin = new Padding(3, 4, 3, 4);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(698, 27);
            txtPrimerApellido.TabIndex = 5;
            // 
            // lblPrimerApellido
            // 
            lblPrimerApellido.AutoSize = true;
            lblPrimerApellido.Location = new Point(30, 179);
            lblPrimerApellido.Name = "lblPrimerApellido";
            lblPrimerApellido.Size = new Size(113, 20);
            lblPrimerApellido.TabIndex = 4;
            lblPrimerApellido.Text = "Primer &Apellido";
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(264, 240);
            txtSegundoApellido.Margin = new Padding(3, 4, 3, 4);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(698, 27);
            txtSegundoApellido.TabIndex = 7;
            // 
            // lblSegundoApellido
            // 
            lblSegundoApellido.AutoSize = true;
            lblSegundoApellido.Location = new Point(30, 234);
            lblSegundoApellido.Name = "lblSegundoApellido";
            lblSegundoApellido.Size = new Size(129, 20);
            lblSegundoApellido.TabIndex = 6;
            lblSegundoApellido.Text = "S&egundo Apellido";
            // 
            // chkTitular
            // 
            chkTitular.AutoSize = true;
            chkTitular.Location = new Point(264, 445);
            chkTitular.Margin = new Padding(3, 4, 3, 4);
            chkTitular.Name = "chkTitular";
            chkTitular.Size = new Size(18, 17);
            chkTitular.TabIndex = 12;
            chkTitular.UseVisualStyleBackColor = true;
            // 
            // lblTitular
            // 
            lblTitular.AutoSize = true;
            lblTitular.Location = new Point(34, 442);
            lblTitular.Name = "lblTitular";
            lblTitular.Size = new Size(51, 20);
            lblTitular.TabIndex = 13;
            lblTitular.Text = "Titular";
            // 
            // rdbFemenino
            // 
            rdbFemenino.AutoSize = true;
            rdbFemenino.Location = new Point(264, 489);
            rdbFemenino.Margin = new Padding(3, 4, 3, 4);
            rdbFemenino.Name = "rdbFemenino";
            rdbFemenino.Size = new Size(95, 24);
            rdbFemenino.TabIndex = 14;
            rdbFemenino.TabStop = true;
            rdbFemenino.Text = "Femenino";
            rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(34, 491);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(41, 20);
            lblSexo.TabIndex = 15;
            lblSexo.Text = "Sexo";
            // 
            // rdbMasculino
            // 
            rdbMasculino.AutoSize = true;
            rdbMasculino.Location = new Point(389, 491);
            rdbMasculino.Margin = new Padding(3, 4, 3, 4);
            rdbMasculino.Name = "rdbMasculino";
            rdbMasculino.Size = new Size(97, 24);
            rdbMasculino.TabIndex = 16;
            rdbMasculino.TabStop = true;
            rdbMasculino.Text = "Masculino";
            rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // lblTipoDocumento
            // 
            lblTipoDocumento.AutoSize = true;
            lblTipoDocumento.Location = new Point(30, 289);
            lblTipoDocumento.Name = "lblTipoDocumento";
            lblTipoDocumento.Size = new Size(142, 20);
            lblTipoDocumento.TabIndex = 17;
            lblTipoDocumento.Text = "Tipo de Documento";
            // 
            // cboTipoDocumento
            // 
            cboTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoDocumento.FormattingEnabled = true;
            cboTipoDocumento.Location = new Point(264, 297);
            cboTipoDocumento.Margin = new Padding(3, 4, 3, 4);
            cboTipoDocumento.Name = "cboTipoDocumento";
            cboTipoDocumento.Size = new Size(698, 28);
            cboTipoDocumento.TabIndex = 18;
            // 
            // erpMensaje
            // 
            erpMensaje.ContainerControl = this;
            // 
            // txtIngresoBase
            // 
            txtIngresoBase.Location = new Point(264, 533);
            txtIngresoBase.Margin = new Padding(3, 4, 3, 4);
            txtIngresoBase.MaxLength = 20;
            txtIngresoBase.Name = "txtIngresoBase";
            txtIngresoBase.Size = new Size(698, 27);
            txtIngresoBase.TabIndex = 20;
            txtIngresoBase.KeyPress += txtIngresoBase_KeyPress;
            txtIngresoBase.Validating += txtIngresoBase_Validating;
            // 
            // lblIngresoBase
            // 
            lblIngresoBase.AutoSize = true;
            lblIngresoBase.Location = new Point(34, 536);
            lblIngresoBase.Name = "lblIngresoBase";
            lblIngresoBase.Size = new Size(93, 20);
            lblIngresoBase.TabIndex = 19;
            lblIngresoBase.Text = "Ingreso Base";
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(34, 586);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(55, 20);
            lblCelular.TabIndex = 21;
            lblCelular.Text = "Celular";
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(264, 586);
            txtCelular.Margin = new Padding(3, 4, 3, 4);
            txtCelular.Mask = "000-000-0000";
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(695, 27);
            txtCelular.TabIndex = 22;
            // 
            // txtNumeroDocumento
            // 
            txtNumeroDocumento.Location = new Point(264, 355);
            txtNumeroDocumento.Margin = new Padding(3, 4, 3, 4);
            txtNumeroDocumento.MaxLength = 20;
            txtNumeroDocumento.Name = "txtNumeroDocumento";
            txtNumeroDocumento.Size = new Size(698, 27);
            txtNumeroDocumento.TabIndex = 24;
            // 
            // lblNumeroDocumento
            // 
            lblNumeroDocumento.AutoSize = true;
            lblNumeroDocumento.Location = new Point(32, 344);
            lblNumeroDocumento.Name = "lblNumeroDocumento";
            lblNumeroDocumento.Size = new Size(166, 20);
            lblNumeroDocumento.TabIndex = 23;
            lblNumeroDocumento.Text = "Número de Documento";
            // 
            // FormularioPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 759);
            Controls.Add(txtNumeroDocumento);
            Controls.Add(lblNumeroDocumento);
            Controls.Add(txtCelular);
            Controls.Add(lblCelular);
            Controls.Add(txtIngresoBase);
            Controls.Add(lblIngresoBase);
            Controls.Add(cboTipoDocumento);
            Controls.Add(lblTipoDocumento);
            Controls.Add(rdbMasculino);
            Controls.Add(lblSexo);
            Controls.Add(rdbFemenino);
            Controls.Add(lblTitular);
            Controls.Add(chkTitular);
            Controls.Add(txtSegundoApellido);
            Controls.Add(lblSegundoApellido);
            Controls.Add(txtPrimerApellido);
            Controls.Add(lblPrimerApellido);
            Controls.Add(txtSegundoNombre);
            Controls.Add(lblSegundoNombre);
            Controls.Add(txtPrimerNombre);
            Controls.Add(lblPrimerNombre);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormularioPaciente";
            Text = "Paciente";
            Load += FormularioPaciente_Load;
            ((System.ComponentModel.ISupportInitialize)erpMensaje).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnCancelar;
        private Label lblFechaNacimiento;
        private DateTimePicker dtpFechaNacimiento;
        private Label lblPrimerNombre;
        private TextBox txtPrimerNombre;
        private TextBox txtSegundoNombre;
        private Label lblSegundoNombre;
        private TextBox txtPrimerApellido;
        private Label lblPrimerApellido;
        private TextBox txtSegundoApellido;
        private Label lblSegundoApellido;
        private CheckBox chkTitular;
        private Label lblTitular;
        private RadioButton rdbFemenino;
        private Label lblSexo;
        private RadioButton rdbMasculino;
        private Label lblTipoDocumento;
        private ComboBox cboTipoDocumento;
        private ErrorProvider erpMensaje;
        private ToolTip ttpMensaje;
        private TextBox txtIngresoBase;
        private Label lblIngresoBase;
        private Label lblCelular;
        private MaskedTextBox txtCelular;
        private TextBox txtNumeroDocumento;
        private Label lblNumeroDocumento;
    }
}