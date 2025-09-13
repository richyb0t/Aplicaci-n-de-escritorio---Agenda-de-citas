namespace Proyecto
{
    partial class AgregarExpedienteAltas
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
            this.BuscarPaciente = new System.Windows.Forms.Button();
            this.Pacientes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDoctor = new System.Windows.Forms.TextBox();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BuscarPaciente
            // 
            this.BuscarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BuscarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarPaciente.Location = new System.Drawing.Point(140, 188);
            this.BuscarPaciente.Name = "BuscarPaciente";
            this.BuscarPaciente.Size = new System.Drawing.Size(96, 28);
            this.BuscarPaciente.TabIndex = 0;
            this.BuscarPaciente.Text = "Buscar";
            this.BuscarPaciente.UseVisualStyleBackColor = false;
            this.BuscarPaciente.Click += new System.EventHandler(this.BuscarPaciente_Click);
            // 
            // Pacientes
            // 
            this.Pacientes.AutoSize = true;
            this.Pacientes.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Italic);
            this.Pacientes.Location = new System.Drawing.Point(71, 131);
            this.Pacientes.Name = "Pacientes";
            this.Pacientes.Size = new System.Drawing.Size(71, 19);
            this.Pacientes.TabIndex = 1;
            this.Pacientes.Text = "Paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(81, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Doctor";
            // 
            // txtDoctor
            // 
            this.txtDoctor.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Italic);
            this.txtDoctor.Location = new System.Drawing.Point(172, 63);
            this.txtDoctor.Multiline = true;
            this.txtDoctor.Name = "txtDoctor";
            this.txtDoctor.ReadOnly = true;
            this.txtDoctor.Size = new System.Drawing.Size(143, 30);
            this.txtDoctor.TabIndex = 3;
            // 
            // txtPaciente
            // 
            this.txtPaciente.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Italic);
            this.txtPaciente.Location = new System.Drawing.Point(172, 124);
            this.txtPaciente.Multiline = true;
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(143, 32);
            this.txtPaciente.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(298, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AgregarExpedienteAltas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto.Properties.Resources.Imagen_22;
            this.ClientSize = new System.Drawing.Size(406, 281);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.txtDoctor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pacientes);
            this.Controls.Add(this.BuscarPaciente);
            this.Name = "AgregarExpedienteAltas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgreagrExedienteAltas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuscarPaciente;
        private System.Windows.Forms.Label Pacientes;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtDoctor;
        public System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Button button1;
    }
}