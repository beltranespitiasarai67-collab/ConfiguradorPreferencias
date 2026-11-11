namespace ConfiguradorPreferencias
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
            components = new System.ComponentModel.Container();
            panelPrincipal = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            elegirColorToolStripMenuItem = new ToolStripMenuItem();
            restablecerToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            lblResumen = new Label();
            btnRestablecer = new Button();
            btnAplicar = new Button();
            btnColor = new Button();
            cmbTipoUsuario = new ComboBox();
            clbActividades = new CheckedListBox();
            chkRecordatorios = new CheckBox();
            chkNotificaciones = new CheckBox();
            lblTitulo = new Label();
            colorDialog1 = new ColorDialog();
            panelPrincipal.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.AliceBlue;
            panelPrincipal.ContextMenuStrip = contextMenuStrip1;
            panelPrincipal.Controls.Add(lblResumen);
            panelPrincipal.Controls.Add(btnRestablecer);
            panelPrincipal.Controls.Add(btnAplicar);
            panelPrincipal.Controls.Add(btnColor);
            panelPrincipal.Controls.Add(cmbTipoUsuario);
            panelPrincipal.Controls.Add(clbActividades);
            panelPrincipal.Controls.Add(chkRecordatorios);
            panelPrincipal.Controls.Add(chkNotificaciones);
            panelPrincipal.Controls.Add(lblTitulo);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(732, 473);
            panelPrincipal.TabIndex = 0;
            panelPrincipal.Click += btn;
            panelPrincipal.Paint += panelPrincipal_Paint;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { elegirColorToolStripMenuItem, restablecerToolStripMenuItem, salirToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(156, 76);
            // 
            // elegirColorToolStripMenuItem
            // 
            elegirColorToolStripMenuItem.Name = "elegirColorToolStripMenuItem";
            elegirColorToolStripMenuItem.Size = new Size(155, 24);
            elegirColorToolStripMenuItem.Text = "Elegir color";
            // 
            // restablecerToolStripMenuItem
            // 
            restablecerToolStripMenuItem.Name = "restablecerToolStripMenuItem";
            restablecerToolStripMenuItem.Size = new Size(155, 24);
            restablecerToolStripMenuItem.Text = "Restablecer";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(155, 24);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // lblResumen
            // 
            lblResumen.AutoSize = true;
            lblResumen.Location = new Point(380, 232);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(227, 20);
            lblResumen.TabIndex = 8;
            lblResumen.Text = "Tus preferencias apareceran aqui";
            // 
            // btnRestablecer
            // 
            btnRestablecer.Location = new Point(566, 420);
            btnRestablecer.Name = "btnRestablecer";
            btnRestablecer.Size = new Size(145, 44);
            btnRestablecer.TabIndex = 7;
            btnRestablecer.Text = "Restablecer";
            btnRestablecer.UseVisualStyleBackColor = true;
            btnRestablecer.Click += btnRestablecer_Click_1;
            // 
            // btnAplicar
            // 
            btnAplicar.Location = new Point(12, 411);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(145, 53);
            btnAplicar.TabIndex = 6;
            btnAplicar.Text = "Aplicar preferencias";
            btnAplicar.UseVisualStyleBackColor = true;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(301, 422);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(145, 41);
            btnColor.TabIndex = 5;
            btnColor.Text = "Eleguir color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // cmbTipoUsuario
            // 
            cmbTipoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoUsuario.FormattingEnabled = true;
            cmbTipoUsuario.Location = new Point(397, 123);
            cmbTipoUsuario.Name = "cmbTipoUsuario";
            cmbTipoUsuario.Size = new Size(151, 28);
            cmbTipoUsuario.TabIndex = 4;
            // 
            // clbActividades
            // 
            clbActividades.CheckOnClick = true;
            clbActividades.FormattingEnabled = true;
            clbActividades.Location = new Point(99, 232);
            clbActividades.Name = "clbActividades";
            clbActividades.Size = new Size(228, 158);
            clbActividades.TabIndex = 3;
            // 
            // chkRecordatorios
            // 
            chkRecordatorios.AutoSize = true;
            chkRecordatorios.Checked = true;
            chkRecordatorios.CheckState = CheckState.Checked;
            chkRecordatorios.Location = new Point(112, 176);
            chkRecordatorios.Name = "chkRecordatorios";
            chkRecordatorios.Size = new Size(212, 24);
            chkRecordatorios.TabIndex = 2;
            chkRecordatorios.Text = "Deseo recibir recordatorios";
            chkRecordatorios.UseVisualStyleBackColor = true;
            // 
            // chkNotificaciones
            // 
            chkNotificaciones.AutoSize = true;
            chkNotificaciones.Checked = true;
            chkNotificaciones.CheckState = CheckState.Checked;
            chkNotificaciones.Location = new Point(112, 125);
            chkNotificaciones.Name = "chkNotificaciones";
            chkNotificaciones.Size = new Size(215, 24);
            chkNotificaciones.TabIndex = 1;
            chkNotificaciones.Text = "Deseo recibir notificaciones";
            chkNotificaciones.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(149, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(414, 64);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Mis preferencias";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 473);
            Controls.Add(panelPrincipal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configurador de preferencias";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private CheckBox chkRecordatorios;
        private CheckBox chkNotificaciones;
        private Label lblTitulo;
        private ComboBox cmbTipoUsuario;
        private CheckedListBox clbActividades;
        private Label lblResumen;
        private Button btnRestablecer;
        private Button btnAplicar;
        private Button btnColor;
        private ColorDialog colorDialog1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem elegirColorToolStripMenuItem;
        private ToolStripMenuItem restablecerToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}
