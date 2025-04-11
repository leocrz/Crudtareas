namespace WindowsFormsApp1
{
    partial class Form1
    {
       
        private System.ComponentModel.IContainer components = null;

        
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1saludar = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCarnet = new System.Windows.Forms.TextBox();
            this.textBoxcorreo = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxnota1 = new System.Windows.Forms.TextBox();
            this.textBoxnota2 = new System.Windows.Forms.TextBox();
            this.textBoxnota3 = new System.Windows.Forms.TextBox();
            this.textBoxnota4 = new System.Windows.Forms.TextBox();
            this.textBoxidtarea = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttoninsertar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxseccion = new System.Windows.Forms.ComboBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1saludar
            // 
            this.button1saludar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1saludar.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1saludar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1saludar.Location = new System.Drawing.Point(0, 0);
            this.button1saludar.Margin = new System.Windows.Forms.Padding(4);
            this.button1saludar.Name = "button1saludar";
            this.button1saludar.Size = new System.Drawing.Size(259, 28);
            this.button1saludar.TabIndex = 0;
            this.button1saludar.Text = "Hola Bienvenido!";
            this.button1saludar.UseVisualStyleBackColor = false;
            this.button1saludar.Click += new System.EventHandler(this.button1saludar_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxNombre.Location = new System.Drawing.Point(110, 113);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(203, 22);
            this.textBoxNombre.TabIndex = 3;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxCarnet
            // 
            this.textBoxCarnet.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCarnet.Location = new System.Drawing.Point(346, 55);
            this.textBoxCarnet.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCarnet.Name = "textBoxCarnet";
            this.textBoxCarnet.Size = new System.Drawing.Size(150, 22);
            this.textBoxCarnet.TabIndex = 4;
            this.textBoxCarnet.TextChanged += new System.EventHandler(this.textBoxCarnet_TextChanged);
            // 
            // textBoxcorreo
            // 
            this.textBoxcorreo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxcorreo.Location = new System.Drawing.Point(110, 177);
            this.textBoxcorreo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxcorreo.Name = "textBoxcorreo";
            this.textBoxcorreo.Size = new System.Drawing.Size(203, 22);
            this.textBoxcorreo.TabIndex = 7;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonBuscar.Font = new System.Drawing.Font("Leelawadee", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBuscar.Location = new System.Drawing.Point(447, 107);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(120, 28);
            this.buttonBuscar.TabIndex = 12;
            this.buttonBuscar.Text = "Buscar Alumno";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonCrear
            // 
            this.buttonCrear.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonCrear.Font = new System.Drawing.Font("Leelawadee", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCrear.Location = new System.Drawing.Point(575, 107);
            this.buttonCrear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(187, 28);
            this.buttonCrear.TabIndex = 13;
            this.buttonCrear.Text = "Crear nuevo Alumno";
            this.buttonCrear.UseVisualStyleBackColor = false;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonEliminar.Font = new System.Drawing.Font("Leelawadee", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEliminar.Location = new System.Drawing.Point(447, 139);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(120, 28);
            this.buttonEliminar.TabIndex = 14;
            this.buttonEliminar.Text = "Eliminar Alumno";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonActualizar.Font = new System.Drawing.Font("Leelawadee", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonActualizar.Location = new System.Drawing.Point(575, 140);
            this.buttonActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(149, 28);
            this.buttonActualizar.TabIndex = 15;
            this.buttonActualizar.Text = "Actualizar Alumno";
            this.buttonActualizar.UseVisualStyleBackColor = false;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Font = new System.Drawing.Font("Leelawadee", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(20, 237);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "ID Tarea";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Font = new System.Drawing.Font("Leelawadee", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(20, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Notas 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Font = new System.Drawing.Font("Leelawadee", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(23, 300);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Notas 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Font = new System.Drawing.Font("Leelawadee", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(23, 332);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Notas 3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label6.Font = new System.Drawing.Font("Leelawadee", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(20, 364);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Notas 4:";
            // 
            // textBoxnota1
            // 
            this.textBoxnota1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxnota1.Location = new System.Drawing.Point(110, 264);
            this.textBoxnota1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxnota1.Name = "textBoxnota1";
            this.textBoxnota1.Size = new System.Drawing.Size(132, 22);
            this.textBoxnota1.TabIndex = 29;
            // 
            // textBoxnota2
            // 
            this.textBoxnota2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxnota2.Location = new System.Drawing.Point(110, 296);
            this.textBoxnota2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxnota2.Name = "textBoxnota2";
            this.textBoxnota2.Size = new System.Drawing.Size(132, 22);
            this.textBoxnota2.TabIndex = 30;
            // 
            // textBoxnota3
            // 
            this.textBoxnota3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxnota3.Location = new System.Drawing.Point(110, 328);
            this.textBoxnota3.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxnota3.Name = "textBoxnota3";
            this.textBoxnota3.Size = new System.Drawing.Size(132, 22);
            this.textBoxnota3.TabIndex = 31;
            // 
            // textBoxnota4
            // 
            this.textBoxnota4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxnota4.Location = new System.Drawing.Point(110, 360);
            this.textBoxnota4.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxnota4.Name = "textBoxnota4";
            this.textBoxnota4.Size = new System.Drawing.Size(132, 22);
            this.textBoxnota4.TabIndex = 32;
            // 
            // textBoxidtarea
            // 
            this.textBoxidtarea.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxidtarea.Location = new System.Drawing.Point(110, 234);
            this.textBoxidtarea.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxidtarea.Name = "textBoxidtarea";
            this.textBoxidtarea.Size = new System.Drawing.Size(132, 22);
            this.textBoxidtarea.TabIndex = 33;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button2.Font = new System.Drawing.Font("Leelawadee", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(309, 229);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 37);
            this.button2.TabIndex = 34;
            this.button2.Text = "Buscar tarea";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttoninsertar
            // 
            this.buttoninsertar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttoninsertar.Font = new System.Drawing.Font("Leelawadee", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoninsertar.Location = new System.Drawing.Point(309, 274);
            this.buttoninsertar.Margin = new System.Windows.Forms.Padding(4);
            this.buttoninsertar.Name = "buttoninsertar";
            this.buttoninsertar.Size = new System.Drawing.Size(141, 37);
            this.buttoninsertar.TabIndex = 35;
            this.buttoninsertar.Text = "Crear tarea";
            this.buttoninsertar.UseVisualStyleBackColor = false;
            this.buttoninsertar.Click += new System.EventHandler(this.buttoninsertar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 27);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ingrese el carnet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Leelawadee", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nombre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Leelawadee", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 148);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Seccion:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Font = new System.Drawing.Font("Leelawadee", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 177);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "Correo:";
            // 
            // comboBoxseccion
            // 
            this.comboBoxseccion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxseccion.FormattingEnabled = true;
            this.comboBoxseccion.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.comboBoxseccion.Location = new System.Drawing.Point(110, 144);
            this.comboBoxseccion.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxseccion.Name = "comboBoxseccion";
            this.comboBoxseccion.Size = new System.Drawing.Size(160, 24);
            this.comboBoxseccion.TabIndex = 40;
            this.comboBoxseccion.SelectedIndexChanged += new System.EventHandler(this.comboBoxseccion_SelectedIndexChanged);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonLimpiar.Font = new System.Drawing.Font("Leelawadee", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.Location = new System.Drawing.Point(309, 332);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(143, 36);
            this.buttonLimpiar.TabIndex = 41;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Screenshot_2025_04_11_001118;
            this.ClientSize = new System.Drawing.Size(778, 432);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.comboBoxseccion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttoninsertar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxidtarea);
            this.Controls.Add(this.textBoxnota4);
            this.Controls.Add(this.textBoxnota3);
            this.Controls.Add(this.textBoxnota2);
            this.Controls.Add(this.textBoxnota1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxcorreo);
            this.Controls.Add(this.textBoxCarnet);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.button1saludar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "CRUDALUM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1saludar;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxCarnet;
        private System.Windows.Forms.TextBox textBoxcorreo;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxnota1;
        private System.Windows.Forms.TextBox textBoxnota2;
        private System.Windows.Forms.TextBox textBoxnota3;
        private System.Windows.Forms.TextBox textBoxnota4;
        private System.Windows.Forms.TextBox textBoxidtarea;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttoninsertar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxseccion;
        private System.Windows.Forms.Button buttonLimpiar;
    }
}

