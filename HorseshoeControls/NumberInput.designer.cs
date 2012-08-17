namespace HorseshoeControls.Input
{
    partial class NumberInput
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
            this.input_nud = new System.Windows.Forms.NumericUpDown();
            this.title_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.input_nud)).BeginInit();
            this.SuspendLayout();
            // 
            // input_nud
            // 
            this.input_nud.Location = new System.Drawing.Point(3, 22);
            this.input_nud.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.input_nud.Name = "input_nud";
            this.input_nud.Size = new System.Drawing.Size(169, 20);
            this.input_nud.TabIndex = 4;
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Location = new System.Drawing.Point(3, 6);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(70, 13);
            this.title_lbl.TabIndex = 3;
            this.title_lbl.Text = "NumericInput";
            // 
            // NumberInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.input_nud);
            this.Controls.Add(this.title_lbl);
            this.Name = "NumberInput";
            this.Size = new System.Drawing.Size(175, 45);
            ((System.ComponentModel.ISupportInitialize)(this.input_nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown input_nud;
        private System.Windows.Forms.Label title_lbl;
    }
}
