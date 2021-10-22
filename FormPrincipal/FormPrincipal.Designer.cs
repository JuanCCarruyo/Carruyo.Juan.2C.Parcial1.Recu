
namespace FormPrincipal
{
    partial class FormPrincipal
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
            this.btnDesafiar = new System.Windows.Forms.Button();
            this.cmbEquipoUno = new System.Windows.Forms.ComboBox();
            this.cmbEquipoDos = new System.Windows.Forms.ComboBox();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.rchDatosTorneo = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDesafiar
            // 
            this.btnDesafiar.Location = new System.Drawing.Point(196, 67);
            this.btnDesafiar.Name = "btnDesafiar";
            this.btnDesafiar.Size = new System.Drawing.Size(199, 23);
            this.btnDesafiar.TabIndex = 0;
            this.btnDesafiar.Text = "Jugar Partido";
            this.btnDesafiar.UseVisualStyleBackColor = true;
            this.btnDesafiar.Click += new System.EventHandler(this.btnDesafiar_Click);
            // 
            // cmbEquipoUno
            // 
            this.cmbEquipoUno.FormattingEnabled = true;
            this.cmbEquipoUno.Location = new System.Drawing.Point(22, 24);
            this.cmbEquipoUno.Name = "cmbEquipoUno";
            this.cmbEquipoUno.Size = new System.Drawing.Size(265, 23);
            this.cmbEquipoUno.TabIndex = 1;
            this.cmbEquipoUno.SelectedIndexChanged += new System.EventHandler(this.cmbEquipoUno_SelectedIndexChanged);
            // 
            // cmbEquipoDos
            // 
            this.cmbEquipoDos.FormattingEnabled = true;
            this.cmbEquipoDos.Location = new System.Drawing.Point(317, 24);
            this.cmbEquipoDos.Name = "cmbEquipoDos";
            this.cmbEquipoDos.Size = new System.Drawing.Size(270, 23);
            this.cmbEquipoDos.TabIndex = 2;
            // 
            // dgvResultados
            // 
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(26, 137);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.RowTemplate.Height = 25;
            this.dgvResultados.Size = new System.Drawing.Size(561, 195);
            this.dgvResultados.TabIndex = 3;
            // 
            // rchDatosTorneo
            // 
            this.rchDatosTorneo.Location = new System.Drawing.Point(22, 349);
            this.rchDatosTorneo.Name = "rchDatosTorneo";
            this.rchDatosTorneo.Size = new System.Drawing.Size(564, 110);
            this.rchDatosTorneo.TabIndex = 4;
            this.rchDatosTorneo.Text = "";
            this.rchDatosTorneo.TextChanged += new System.EventHandler(this.rchDatosTorneo_TextChanged);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 484);
            this.Controls.Add(this.rchDatosTorneo);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.cmbEquipoDos);
            this.Controls.Add(this.cmbEquipoUno);
            this.Controls.Add(this.btnDesafiar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Competencias";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDesafiar;
        private System.Windows.Forms.ComboBox cmbEquipoUno;
        private System.Windows.Forms.ComboBox cmbEquipoDos;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.RichTextBox rchDatosTorneo;
    }
}

