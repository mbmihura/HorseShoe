namespace HorseshoeControls.Input
{
    partial class DateInput
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
            this.day_nud = new System.Windows.Forms.NumericUpDown();
            this.month_nud = new System.Windows.Forms.NumericUpDown();
            this.year_nud = new System.Windows.Forms.NumericUpDown();
            this.input_mcal = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.day_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.month_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.year_nud)).BeginInit();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Location = new System.Drawing.Point(3, 5);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(54, 13);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "DateInput";
            // 
            // day_nud
            // 
            this.day_nud.Location = new System.Drawing.Point(86, 3);
            this.day_nud.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.day_nud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.day_nud.Name = "day_nud";
            this.day_nud.Size = new System.Drawing.Size(39, 20);
            this.day_nud.TabIndex = 1;
            this.day_nud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.day_nud.Enter += new System.EventHandler(this.day_nud_Enter);
            this.day_nud.Leave += new System.EventHandler(this.day_nud_ValueChanged);
            // 
            // month_nud
            // 
            this.month_nud.Location = new System.Drawing.Point(131, 3);
            this.month_nud.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.month_nud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.month_nud.Name = "month_nud";
            this.month_nud.Size = new System.Drawing.Size(39, 20);
            this.month_nud.TabIndex = 2;
            this.month_nud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.month_nud.Enter += new System.EventHandler(this.month_nud_Enter);
            this.month_nud.Leave += new System.EventHandler(this.month_nud_ValueChanged);
            // 
            // year_nud
            // 
            this.year_nud.Location = new System.Drawing.Point(176, 3);
            this.year_nud.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.year_nud.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.year_nud.Name = "year_nud";
            this.year_nud.Size = new System.Drawing.Size(54, 20);
            this.year_nud.TabIndex = 3;
            this.year_nud.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.year_nud.Enter += new System.EventHandler(this.year_nud_Enter);
            this.year_nud.Leave += new System.EventHandler(this.year_nud_ValueChanged);
            // 
            // input_mcal
            // 
            this.input_mcal.Location = new System.Drawing.Point(3, 26);
            this.input_mcal.MaxDate = new System.DateTime(2500, 12, 31, 0, 0, 0, 0);
            this.input_mcal.MaxSelectionCount = 1;
            this.input_mcal.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.input_mcal.Name = "input_mcal";
            this.input_mcal.TabIndex = 4;
            this.input_mcal.TabStop = false;
            this.input_mcal.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.input_mcal_DateChanged);
            // 
            // DateInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.input_mcal);
            this.Controls.Add(this.year_nud);
            this.Controls.Add(this.month_nud);
            this.Controls.Add(this.day_nud);
            this.Controls.Add(this.title_lbl);
            this.Name = "DateInput";
            this.Size = new System.Drawing.Size(233, 191);
            ((System.ComponentModel.ISupportInitialize)(this.day_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.month_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.year_nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    

        #endregion

        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.NumericUpDown day_nud;
        private System.Windows.Forms.NumericUpDown month_nud;
        private System.Windows.Forms.NumericUpDown year_nud;
        private System.Windows.Forms.MonthCalendar input_mcal;
    }
}
