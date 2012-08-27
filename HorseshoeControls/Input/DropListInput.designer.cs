namespace HorseshoeControls.Input
{
    partial class DropListInput
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.title_lbl = new System.Windows.Forms.Label();
            this.input_cmb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Location = new System.Drawing.Point(3, 6);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(70, 13);
            this.title_lbl.TabIndex = 5;
            this.title_lbl.Text = "DropListInput";
            // 
            // input_cmb
            // 
            this.input_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.input_cmb.FormattingEnabled = true;
            this.input_cmb.Location = new System.Drawing.Point(3, 22);
            this.input_cmb.Name = "input_cmb";
            this.input_cmb.Size = new System.Drawing.Size(169, 21);
            this.input_cmb.TabIndex = 4;
            // 
            // DropListInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.input_cmb);
            this.Name = "DropListInput";
            this.Size = new System.Drawing.Size(175, 46);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.ComboBox input_cmb;
    }
}
