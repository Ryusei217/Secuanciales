namespace ListasXML
{
    partial class Form1
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
            this.EstudiantesGridView = new System.Windows.Forms.DataGridView();
            this.gbEstudiantes = new System.Windows.Forms.GroupBox();
            this.CarneTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ActualizarButton = new System.Windows.Forms.Button();
            this.AbrirButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.BinarioRadioButton = new System.Windows.Forms.RadioButton();
            this.XmlRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.EstudiantesGridView)).BeginInit();
            this.gbEstudiantes.SuspendLayout();
            this.SuspendLayout();
            // 
            // EstudiantesGridView
            // 
            this.EstudiantesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EstudiantesGridView.Location = new System.Drawing.Point(12, 199);
            this.EstudiantesGridView.Name = "EstudiantesGridView";
            this.EstudiantesGridView.Size = new System.Drawing.Size(680, 290);
            this.EstudiantesGridView.TabIndex = 0;
            // 
            // gbEstudiantes
            // 
            this.gbEstudiantes.Controls.Add(this.ActualizarButton);
            this.gbEstudiantes.Controls.Add(this.label2);
            this.gbEstudiantes.Controls.Add(this.NombreTextBox);
            this.gbEstudiantes.Controls.Add(this.label1);
            this.gbEstudiantes.Controls.Add(this.CarneTextBox);
            this.gbEstudiantes.Location = new System.Drawing.Point(12, 75);
            this.gbEstudiantes.Name = "gbEstudiantes";
            this.gbEstudiantes.Size = new System.Drawing.Size(680, 118);
            this.gbEstudiantes.TabIndex = 1;
            this.gbEstudiantes.TabStop = false;
            this.gbEstudiantes.Text = "Estudiante";
            // 
            // CarneTextBox
            // 
            this.CarneTextBox.Location = new System.Drawing.Point(56, 34);
            this.CarneTextBox.Name = "CarneTextBox";
            this.CarneTextBox.Size = new System.Drawing.Size(618, 20);
            this.CarneTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Carne";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(56, 60);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(618, 20);
            this.NombreTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // ActualizarButton
            // 
            this.ActualizarButton.Location = new System.Drawing.Point(599, 86);
            this.ActualizarButton.Name = "ActualizarButton";
            this.ActualizarButton.Size = new System.Drawing.Size(75, 23);
            this.ActualizarButton.TabIndex = 2;
            this.ActualizarButton.Text = "Actualizar";
            this.ActualizarButton.UseVisualStyleBackColor = true;
            this.ActualizarButton.Click += new System.EventHandler(this.ActualizarButton_Click);
            // 
            // AbrirButton
            // 
            this.AbrirButton.Location = new System.Drawing.Point(12, 12);
            this.AbrirButton.Name = "AbrirButton";
            this.AbrirButton.Size = new System.Drawing.Size(75, 23);
            this.AbrirButton.TabIndex = 2;
            this.AbrirButton.Text = "Abrir";
            this.AbrirButton.UseVisualStyleBackColor = true;
            this.AbrirButton.Click += new System.EventHandler(this.AbrirButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(93, 12);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 3;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // BinarioRadioButton
            // 
            this.BinarioRadioButton.AutoSize = true;
            this.BinarioRadioButton.Checked = true;
            this.BinarioRadioButton.Location = new System.Drawing.Point(196, 15);
            this.BinarioRadioButton.Name = "BinarioRadioButton";
            this.BinarioRadioButton.Size = new System.Drawing.Size(57, 17);
            this.BinarioRadioButton.TabIndex = 4;
            this.BinarioRadioButton.TabStop = true;
            this.BinarioRadioButton.Text = "Binario";
            this.BinarioRadioButton.UseVisualStyleBackColor = true;
            // 
            // XmlRadioButton
            // 
            this.XmlRadioButton.AutoSize = true;
            this.XmlRadioButton.Location = new System.Drawing.Point(259, 15);
            this.XmlRadioButton.Name = "XmlRadioButton";
            this.XmlRadioButton.Size = new System.Drawing.Size(47, 17);
            this.XmlRadioButton.TabIndex = 5;
            this.XmlRadioButton.Text = "XML";
            this.XmlRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 501);
            this.Controls.Add(this.XmlRadioButton);
            this.Controls.Add(this.BinarioRadioButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.AbrirButton);
            this.Controls.Add(this.gbEstudiantes);
            this.Controls.Add(this.EstudiantesGridView);
            this.Name = "Form1";
            this.Text = "Archivos Secuenciales";
            ((System.ComponentModel.ISupportInitialize)(this.EstudiantesGridView)).EndInit();
            this.gbEstudiantes.ResumeLayout(false);
            this.gbEstudiantes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EstudiantesGridView;
        private System.Windows.Forms.GroupBox gbEstudiantes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CarneTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Button ActualizarButton;
        private System.Windows.Forms.Button AbrirButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.RadioButton BinarioRadioButton;
        private System.Windows.Forms.RadioButton XmlRadioButton;
    }
}

