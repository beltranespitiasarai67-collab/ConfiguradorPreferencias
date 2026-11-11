namespace ConfiguradorPreferencias
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
            clbActividades.Items.Add("Leer");
            clbActividades.Items.Add("Practicar deporte");
            clbActividades.Items.Add("Escuchar música");
            clbActividades.Items.Add("Programar");
            clbActividades.Items.Add("Ver películas");


            cmbTipoUsuario.Items.Add("Estudiante");
            cmbTipoUsuario.Items.Add("Docente");
            cmbTipoUsuario.Items.Add("Invitado");


            cmbTipoUsuario.SelectedIndex = 0;


            ToolStripMenuItem opcionColor = new ToolStripMenuItem("Elegir color");
            ToolStripMenuItem opcionRestablecer = new ToolStripMenuItem("Restablecer");
            ToolStripMenuItem opcionSalir = new ToolStripMenuItem("Salir");

            contextMenuStrip1.Items.Add(opcionColor);
            contextMenuStrip1.Items.Add(opcionRestablecer);
            contextMenuStrip1.Items.Add(opcionSalir);

            btnColor.Click += btnColor_Click;
            btnAplicar.Click += btnAplicar_Click;
            btnRestablecer.Click += btnRestablecer_Click;


            panelPrincipal.ContextMenuStrip = contextMenuStrip1;
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn(object sender, EventArgs e)
        {

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            // Abre el cuadro de selección de colores
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // Aplica el color elegido al panel principal
                panelPrincipal.BackColor = colorDialog1.Color;
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            string mensaje = "CONFIGURACIÓN GUARDADA\n\n";
            // Revisa el estado de los CheckBox
            mensaje += "Notificaciones: " + (chkNotificaciones.Checked ? "Sí" : "No") + "\n";
            mensaje += "Recordatorios: " + (chkRecordatorios.Checked ? "Sí" : "No") + "\n";
            // Obtiene la categoría seleccionada
            mensaje += "Tipo de usuario: " + cmbTipoUsuario.SelectedItem.ToString() + "\n";
            // Recorre las actividades marcadas
            mensaje += "Actividades seleccionadas:\n";
            if (clbActividades.CheckedItems.Count == 0)
            {
                mensaje += "- Ninguna actividad seleccionada\n";
            }
            else
            {
                foreach (object actividad in clbActividades.CheckedItems)
                {
                    mensaje += "- " + actividad.ToString() + "\n";
                }
            }
            lblResumen.Text = mensaje;
            MessageBox.Show(mensaje, "Mis preferencias", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            // Recupera la configuración inicial
            chkNotificaciones.Checked = true;
            chkRecordatorios.Checked = true;
            // Desmarca todas las actividades
            for (int i = 0; i < clbActividades.Items.Count; i++)
            {
                clbActividades.SetItemChecked(i, false);
            }
            // Selecciona la primera categoría
            cmbTipoUsuario.SelectedIndex = 0;
            // Recupera el color original del panel
            panelPrincipal.BackColor = Color.AliceBlue;
            lblResumen.Text = "Tus preferencias aparecerán aquí.";

        }
        private void opcionSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRestablecer_Click_1(object sender, EventArgs e)
        {

        }
    }
}
