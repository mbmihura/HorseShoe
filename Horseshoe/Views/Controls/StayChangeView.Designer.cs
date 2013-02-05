namespace Horseshoe.Views.Controls
{
    partial class StayChangeView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.add_lbl = new System.Windows.Forms.Label();
            this.delete_lbl = new System.Windows.Forms.Label();
            this.stayList_dgv = new System.Windows.Forms.DataGridView();
            this.boxDExplanation_lbl = new System.Windows.Forms.Label();
            this.boxTitle_lbl = new System.Windows.Forms.Label();
            this.boxASave_btn = new System.Windows.Forms.Button();
            this.boxACancel_btn = new System.Windows.Forms.Button();
            this.boxAHorse_cmb = new System.Windows.Forms.ComboBox();
            this.boxAType_cmb = new System.Windows.Forms.ComboBox();
            this.boxAHorses_lbl = new System.Windows.Forms.Label();
            this.boxAType_lbl = new System.Windows.Forms.Label();
            this.boxDConfirm_btn = new System.Windows.Forms.Button();
            this.box_pnl = new System.Windows.Forms.Panel();
            this.add_pic = new System.Windows.Forms.PictureBox();
            this.delete_pic = new System.Windows.Forms.PictureBox();
            this.boxLeftTriangle_pic = new System.Windows.Forms.PictureBox();
            this.dateInput = new HorseshoeControls.Input.DateInput();
            ((System.ComponentModel.ISupportInitialize)(this.stayList_dgv)).BeginInit();
            this.box_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxLeftTriangle_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // add_lbl
            // 
            this.add_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_lbl.AutoSize = true;
            this.add_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.add_lbl.Location = new System.Drawing.Point(15, 36);
            this.add_lbl.Name = "add_lbl";
            this.add_lbl.Size = new System.Drawing.Size(69, 15);
            this.add_lbl.TabIndex = 44;
            this.add_lbl.Text = "+ Agregar";
            this.add_lbl.Click += new System.EventHandler(this.add_lbl_Click);
            // 
            // delete_lbl
            // 
            this.delete_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_lbl.AutoSize = true;
            this.delete_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.delete_lbl.Location = new System.Drawing.Point(97, 36);
            this.delete_lbl.Name = "delete_lbl";
            this.delete_lbl.Size = new System.Drawing.Size(70, 15);
            this.delete_lbl.TabIndex = 40;
            this.delete_lbl.Text = "- Eliminar";
            this.delete_lbl.Click += new System.EventHandler(this.delete_lbl_Click);
            // 
            // stayList_dgv
            // 
            this.stayList_dgv.AllowUserToOrderColumns = true;
            this.stayList_dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.stayList_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.stayList_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stayList_dgv.BackgroundColor = System.Drawing.Color.White;
            this.stayList_dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stayList_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.stayList_dgv.ColumnHeadersHeight = 25;
            this.stayList_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.stayList_dgv.GridColor = System.Drawing.Color.White;
            this.stayList_dgv.Location = new System.Drawing.Point(14, 279);
            this.stayList_dgv.Name = "stayList_dgv";
            this.stayList_dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.stayList_dgv.RowHeadersVisible = false;
            this.stayList_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.stayList_dgv.Size = new System.Drawing.Size(465, 236);
            this.stayList_dgv.TabIndex = 39;
            // 
            // boxDExplanation_lbl
            // 
            this.boxDExplanation_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxDExplanation_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.boxDExplanation_lbl.Location = new System.Drawing.Point(12, 46);
            this.boxDExplanation_lbl.Name = "boxDExplanation_lbl";
            this.boxDExplanation_lbl.Size = new System.Drawing.Size(442, 28);
            this.boxDExplanation_lbl.TabIndex = 22;
            this.boxDExplanation_lbl.Text = "Para eliminar cambios de estadias, seleccione \'eliminar\' en la lista de estadias " +
    "y luego presione el boton \'Confirmar\' o la tecla suprimir.";
            // 
            // boxTitle_lbl
            // 
            this.boxTitle_lbl.AutoSize = true;
            this.boxTitle_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxTitle_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.boxTitle_lbl.Location = new System.Drawing.Point(11, 10);
            this.boxTitle_lbl.Name = "boxTitle_lbl";
            this.boxTitle_lbl.Size = new System.Drawing.Size(144, 24);
            this.boxTitle_lbl.TabIndex = 1;
            this.boxTitle_lbl.Text = "Agregar Estadia";
            // 
            // boxASave_btn
            // 
            this.boxASave_btn.Location = new System.Drawing.Point(33, 163);
            this.boxASave_btn.Name = "boxASave_btn";
            this.boxASave_btn.Size = new System.Drawing.Size(75, 23);
            this.boxASave_btn.TabIndex = 3;
            this.boxASave_btn.Text = "Guardar";
            this.boxASave_btn.UseVisualStyleBackColor = true;
            // 
            // boxACancel_btn
            // 
            this.boxACancel_btn.Location = new System.Drawing.Point(114, 163);
            this.boxACancel_btn.Name = "boxACancel_btn";
            this.boxACancel_btn.Size = new System.Drawing.Size(75, 23);
            this.boxACancel_btn.TabIndex = 4;
            this.boxACancel_btn.Text = "Cancelar";
            this.boxACancel_btn.UseVisualStyleBackColor = true;
            // 
            // boxAHorse_cmb
            // 
            this.boxAHorse_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxAHorse_cmb.FormattingEnabled = true;
            this.boxAHorse_cmb.Location = new System.Drawing.Point(15, 62);
            this.boxAHorse_cmb.Name = "boxAHorse_cmb";
            this.boxAHorse_cmb.Size = new System.Drawing.Size(193, 21);
            this.boxAHorse_cmb.TabIndex = 0;
            // 
            // boxAType_cmb
            // 
            this.boxAType_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxAType_cmb.FormattingEnabled = true;
            this.boxAType_cmb.Location = new System.Drawing.Point(15, 110);
            this.boxAType_cmb.Name = "boxAType_cmb";
            this.boxAType_cmb.Size = new System.Drawing.Size(193, 21);
            this.boxAType_cmb.TabIndex = 1;
            // 
            // boxAHorses_lbl
            // 
            this.boxAHorses_lbl.AutoSize = true;
            this.boxAHorses_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.boxAHorses_lbl.Location = new System.Drawing.Point(12, 46);
            this.boxAHorses_lbl.Name = "boxAHorses_lbl";
            this.boxAHorses_lbl.Size = new System.Drawing.Size(42, 13);
            this.boxAHorses_lbl.TabIndex = 20;
            this.boxAHorses_lbl.Text = "Caballo";
            // 
            // boxAType_lbl
            // 
            this.boxAType_lbl.AutoSize = true;
            this.boxAType_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.boxAType_lbl.Location = new System.Drawing.Point(15, 94);
            this.boxAType_lbl.Name = "boxAType_lbl";
            this.boxAType_lbl.Size = new System.Drawing.Size(52, 13);
            this.boxAType_lbl.TabIndex = 21;
            this.boxAType_lbl.Text = "Categoria";
            // 
            // boxDConfirm_btn
            // 
            this.boxDConfirm_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.boxDConfirm_btn.Location = new System.Drawing.Point(173, 88);
            this.boxDConfirm_btn.Name = "boxDConfirm_btn";
            this.boxDConfirm_btn.Size = new System.Drawing.Size(112, 27);
            this.boxDConfirm_btn.TabIndex = 23;
            this.boxDConfirm_btn.Text = "CONFIRMAR";
            this.boxDConfirm_btn.UseVisualStyleBackColor = true;
            // 
            // box_pnl
            // 
            this.box_pnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.box_pnl.Controls.Add(this.boxDConfirm_btn);
            this.box_pnl.Controls.Add(this.boxAType_lbl);
            this.box_pnl.Controls.Add(this.boxAHorses_lbl);
            this.box_pnl.Controls.Add(this.boxAType_cmb);
            this.box_pnl.Controls.Add(this.boxAHorse_cmb);
            this.box_pnl.Controls.Add(this.boxACancel_btn);
            this.box_pnl.Controls.Add(this.boxASave_btn);
            this.box_pnl.Controls.Add(this.boxTitle_lbl);
            this.box_pnl.Controls.Add(this.boxDExplanation_lbl);
            this.box_pnl.Controls.Add(this.dateInput);
            this.box_pnl.Location = new System.Drawing.Point(14, 58);
            this.box_pnl.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.box_pnl.MaximumSize = new System.Drawing.Size(1000, 0);
            this.box_pnl.MinimumSize = new System.Drawing.Size(465, 100);
            this.box_pnl.Name = "box_pnl";
            this.box_pnl.Size = new System.Drawing.Size(465, 210);
            this.box_pnl.TabIndex = 42;
            this.box_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.box_pnl_Paint);
            // 
            // add_pic
            // 
            this.add_pic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_pic.Image = global::Horseshoe.Properties.Resources.BlueTriangleUpSmall;
            this.add_pic.Location = new System.Drawing.Point(48, 52);
            this.add_pic.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.add_pic.Name = "add_pic";
            this.add_pic.Size = new System.Drawing.Size(14, 7);
            this.add_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.add_pic.TabIndex = 45;
            this.add_pic.TabStop = false;
            // 
            // delete_pic
            // 
            this.delete_pic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_pic.Image = global::Horseshoe.Properties.Resources.BlueTriangleUpSmall;
            this.delete_pic.Location = new System.Drawing.Point(128, 52);
            this.delete_pic.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.delete_pic.Name = "delete_pic";
            this.delete_pic.Size = new System.Drawing.Size(14, 7);
            this.delete_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.delete_pic.TabIndex = 43;
            this.delete_pic.TabStop = false;
            // 
            // boxLeftTriangle_pic
            // 
            this.boxLeftTriangle_pic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boxLeftTriangle_pic.Image = global::Horseshoe.Properties.Resources.BlueTriangleDownBig;
            this.boxLeftTriangle_pic.Location = new System.Drawing.Point(433, 267);
            this.boxLeftTriangle_pic.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.boxLeftTriangle_pic.Name = "boxLeftTriangle_pic";
            this.boxLeftTriangle_pic.Size = new System.Drawing.Size(20, 10);
            this.boxLeftTriangle_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.boxLeftTriangle_pic.TabIndex = 41;
            this.boxLeftTriangle_pic.TabStop = false;
            // 
            // dateInput
            // 
            this.dateInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.dateInput.Label = "Fecha:";
            this.dateInput.Location = new System.Drawing.Point(226, 13);
            this.dateInput.Name = "dateInput";
            this.dateInput.Selection = new System.DateTime(2013, 2, 18, 0, 0, 0, 0);
            this.dateInput.Size = new System.Drawing.Size(233, 191);
            this.dateInput.TabIndex = 2;
            // 
            // StayChangeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.box_pnl);
            this.Controls.Add(this.add_pic);
            this.Controls.Add(this.add_lbl);
            this.Controls.Add(this.delete_pic);
            this.Controls.Add(this.boxLeftTriangle_pic);
            this.Controls.Add(this.delete_lbl);
            this.Controls.Add(this.stayList_dgv);
            this.Name = "StayChangeView";
            this.Size = new System.Drawing.Size(792, 528);
            ((System.ComponentModel.ISupportInitialize)(this.stayList_dgv)).EndInit();
            this.box_pnl.ResumeLayout(false);
            this.box_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxLeftTriangle_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox add_pic;
        private System.Windows.Forms.Label add_lbl;
        private System.Windows.Forms.PictureBox delete_pic;
        private System.Windows.Forms.PictureBox boxLeftTriangle_pic;
        private System.Windows.Forms.Label delete_lbl;
        private System.Windows.Forms.DataGridView stayList_dgv;
        private System.Windows.Forms.Label boxDExplanation_lbl;
        private System.Windows.Forms.Label boxTitle_lbl;
        private System.Windows.Forms.Button boxASave_btn;
        private System.Windows.Forms.Button boxACancel_btn;
        private System.Windows.Forms.ComboBox boxAHorse_cmb;
        private System.Windows.Forms.ComboBox boxAType_cmb;
        private HorseshoeControls.Input.DateInput dateInput;
        private System.Windows.Forms.Label boxAHorses_lbl;
        private System.Windows.Forms.Label boxAType_lbl;
        private System.Windows.Forms.Button boxDConfirm_btn;
        private System.Windows.Forms.Panel box_pnl;
    }
}
