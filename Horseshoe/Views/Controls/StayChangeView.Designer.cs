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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StayChangeView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.add_pic = new System.Windows.Forms.PictureBox();
            this.add_lbl = new System.Windows.Forms.Label();
            this.delete_pic = new System.Windows.Forms.PictureBox();
            this.box_pnl = new System.Windows.Forms.Panel();
            this.boxDCancel_lnk = new System.Windows.Forms.LinkLabel();
            this.boxDConfirm_btn = new System.Windows.Forms.Button();
            this.boxDExplanation_lbl = new System.Windows.Forms.Label();
            this.boxAType_lbl = new System.Windows.Forms.Label();
            this.boxAHorses_lbl = new System.Windows.Forms.Label();
            this.dateInput = new HorseshoeControls.Input.DateInput();
            this.boxAType_cmb = new System.Windows.Forms.ComboBox();
            this.boxAHorse_cmb = new System.Windows.Forms.ComboBox();
            this.boxACancel_btn = new System.Windows.Forms.Button();
            this.boxASave_btn = new System.Windows.Forms.Button();
            this.boxTitle_lbl = new System.Windows.Forms.Label();
            this.boxLeftTriangle_pic = new System.Windows.Forms.PictureBox();
            this.delete_lbl = new System.Windows.Forms.Label();
            this.stayList_dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.add_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_pic)).BeginInit();
            this.box_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxLeftTriangle_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stayList_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // add_pic
            // 
            this.add_pic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_pic.Image = ((System.Drawing.Image)(resources.GetObject("add_pic.Image")));
            this.add_pic.Location = new System.Drawing.Point(383, 52);
            this.add_pic.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.add_pic.Name = "add_pic";
            this.add_pic.Size = new System.Drawing.Size(14, 7);
            this.add_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.add_pic.TabIndex = 45;
            this.add_pic.TabStop = false;
            // 
            // add_lbl
            // 
            this.add_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_lbl.AutoSize = true;
            this.add_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.add_lbl.Location = new System.Drawing.Point(350, 36);
            this.add_lbl.Name = "add_lbl";
            this.add_lbl.Size = new System.Drawing.Size(69, 15);
            this.add_lbl.TabIndex = 44;
            this.add_lbl.Text = "+ Agregar";
            // 
            // delete_pic
            // 
            this.delete_pic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_pic.Image = ((System.Drawing.Image)(resources.GetObject("delete_pic.Image")));
            this.delete_pic.Location = new System.Drawing.Point(305, 52);
            this.delete_pic.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.delete_pic.Name = "delete_pic";
            this.delete_pic.Size = new System.Drawing.Size(14, 7);
            this.delete_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.delete_pic.TabIndex = 43;
            this.delete_pic.TabStop = false;
            // 
            // box_pnl
            // 
            this.box_pnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(221)))));
            this.box_pnl.Controls.Add(this.boxDCancel_lnk);
            this.box_pnl.Controls.Add(this.boxDConfirm_btn);
            this.box_pnl.Controls.Add(this.boxDExplanation_lbl);
            this.box_pnl.Controls.Add(this.boxAType_lbl);
            this.box_pnl.Controls.Add(this.boxAHorses_lbl);
            this.box_pnl.Controls.Add(this.dateInput);
            this.box_pnl.Controls.Add(this.boxAType_cmb);
            this.box_pnl.Controls.Add(this.boxAHorse_cmb);
            this.box_pnl.Controls.Add(this.boxACancel_btn);
            this.box_pnl.Controls.Add(this.boxASave_btn);
            this.box_pnl.Controls.Add(this.boxTitle_lbl);
            this.box_pnl.Location = new System.Drawing.Point(277, 58);
            this.box_pnl.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.box_pnl.Name = "box_pnl";
            this.box_pnl.Size = new System.Drawing.Size(525, 213);
            this.box_pnl.TabIndex = 42;
            // 
            // boxDCancel_lnk
            // 
            this.boxDCancel_lnk.AutoSize = true;
            this.boxDCancel_lnk.LinkColor = System.Drawing.Color.Navy;
            this.boxDCancel_lnk.Location = new System.Drawing.Point(464, 18);
            this.boxDCancel_lnk.Name = "boxDCancel_lnk";
            this.boxDCancel_lnk.Size = new System.Drawing.Size(49, 13);
            this.boxDCancel_lnk.TabIndex = 24;
            this.boxDCancel_lnk.TabStop = true;
            this.boxDCancel_lnk.Text = "Cancelar";
            // 
            // boxDConfirm_btn
            // 
            this.boxDConfirm_btn.Location = new System.Drawing.Point(218, 100);
            this.boxDConfirm_btn.Name = "boxDConfirm_btn";
            this.boxDConfirm_btn.Size = new System.Drawing.Size(112, 27);
            this.boxDConfirm_btn.TabIndex = 23;
            this.boxDConfirm_btn.Text = "CONFIRMAR";
            this.boxDConfirm_btn.UseVisualStyleBackColor = true;
            // 
            // boxDExplanation_lbl
            // 
            this.boxDExplanation_lbl.Location = new System.Drawing.Point(12, 46);
            this.boxDExplanation_lbl.Name = "boxDExplanation_lbl";
            this.boxDExplanation_lbl.Size = new System.Drawing.Size(489, 28);
            this.boxDExplanation_lbl.TabIndex = 22;
            this.boxDExplanation_lbl.Text = "Para eliminar cambios de estadias, seleccione \'eliminar\' en la lista de estadias " +
    "y luego presione el boton \'Confirmar\' a continuacion.";
            // 
            // boxAType_lbl
            // 
            this.boxAType_lbl.AutoSize = true;
            this.boxAType_lbl.Location = new System.Drawing.Point(12, 104);
            this.boxAType_lbl.Name = "boxAType_lbl";
            this.boxAType_lbl.Size = new System.Drawing.Size(52, 13);
            this.boxAType_lbl.TabIndex = 21;
            this.boxAType_lbl.Text = "Categoria";
            // 
            // boxAHorses_lbl
            // 
            this.boxAHorses_lbl.AutoSize = true;
            this.boxAHorses_lbl.Location = new System.Drawing.Point(12, 56);
            this.boxAHorses_lbl.Name = "boxAHorses_lbl";
            this.boxAHorses_lbl.Size = new System.Drawing.Size(42, 13);
            this.boxAHorses_lbl.TabIndex = 20;
            this.boxAHorses_lbl.Text = "Caballo";
            // 
            // dateInput
            // 
            this.dateInput.Label = "Fecha:";
            this.dateInput.Location = new System.Drawing.Point(282, 13);
            this.dateInput.Name = "dateInput";
            this.dateInput.Selection = new System.DateTime(2012, 8, 18, 0, 0, 0, 0);
            this.dateInput.Size = new System.Drawing.Size(233, 191);
            this.dateInput.TabIndex = 19;
            // 
            // boxAType_cmb
            // 
            this.boxAType_cmb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boxAType_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxAType_cmb.FormattingEnabled = true;
            this.boxAType_cmb.Location = new System.Drawing.Point(70, 101);
            this.boxAType_cmb.Name = "boxAType_cmb";
            this.boxAType_cmb.Size = new System.Drawing.Size(193, 21);
            this.boxAType_cmb.TabIndex = 18;
            // 
            // boxAHorse_cmb
            // 
            this.boxAHorse_cmb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boxAHorse_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxAHorse_cmb.FormattingEnabled = true;
            this.boxAHorse_cmb.Location = new System.Drawing.Point(70, 53);
            this.boxAHorse_cmb.Name = "boxAHorse_cmb";
            this.boxAHorse_cmb.Size = new System.Drawing.Size(193, 21);
            this.boxAHorse_cmb.TabIndex = 17;
            // 
            // boxACancel_btn
            // 
            this.boxACancel_btn.Location = new System.Drawing.Point(107, 150);
            this.boxACancel_btn.Name = "boxACancel_btn";
            this.boxACancel_btn.Size = new System.Drawing.Size(75, 23);
            this.boxACancel_btn.TabIndex = 13;
            this.boxACancel_btn.Text = "Cancelar";
            this.boxACancel_btn.UseVisualStyleBackColor = true;
            // 
            // boxASave_btn
            // 
            this.boxASave_btn.Location = new System.Drawing.Point(188, 150);
            this.boxASave_btn.Name = "boxASave_btn";
            this.boxASave_btn.Size = new System.Drawing.Size(75, 23);
            this.boxASave_btn.TabIndex = 10;
            this.boxASave_btn.Text = "Guardar";
            this.boxASave_btn.UseVisualStyleBackColor = true;
            // 
            // boxTitle_lbl
            // 
            this.boxTitle_lbl.AutoSize = true;
            this.boxTitle_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxTitle_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(64)))), ((int)(((byte)(26)))));
            this.boxTitle_lbl.Location = new System.Drawing.Point(11, 10);
            this.boxTitle_lbl.Name = "boxTitle_lbl";
            this.boxTitle_lbl.Size = new System.Drawing.Size(144, 24);
            this.boxTitle_lbl.TabIndex = 1;
            this.boxTitle_lbl.Text = "Agregar Estadia";
            // 
            // boxLeftTriangle_pic
            // 
            this.boxLeftTriangle_pic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxLeftTriangle_pic.Location = new System.Drawing.Point(268, 72);
            this.boxLeftTriangle_pic.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.boxLeftTriangle_pic.Name = "boxLeftTriangle_pic";
            this.boxLeftTriangle_pic.Size = new System.Drawing.Size(10, 20);
            this.boxLeftTriangle_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.boxLeftTriangle_pic.TabIndex = 41;
            this.boxLeftTriangle_pic.TabStop = false;
            // 
            // delete_lbl
            // 
            this.delete_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_lbl.AutoSize = true;
            this.delete_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.delete_lbl.Location = new System.Drawing.Point(274, 36);
            this.delete_lbl.Name = "delete_lbl";
            this.delete_lbl.Size = new System.Drawing.Size(70, 15);
            this.delete_lbl.TabIndex = 40;
            this.delete_lbl.Text = "- Eliminar";
            // 
            // stayList_dgv
            // 
            this.stayList_dgv.AllowUserToOrderColumns = true;
            this.stayList_dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.stayList_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.stayList_dgv.BackgroundColor = System.Drawing.Color.White;
            this.stayList_dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stayList_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.stayList_dgv.ColumnHeadersHeight = 25;
            this.stayList_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.stayList_dgv.GridColor = System.Drawing.Color.White;
            this.stayList_dgv.Location = new System.Drawing.Point(3, 36);
            this.stayList_dgv.Name = "stayList_dgv";
            this.stayList_dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.stayList_dgv.RowHeadersVisible = false;
            this.stayList_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.stayList_dgv.Size = new System.Drawing.Size(261, 277);
            this.stayList_dgv.TabIndex = 39;
            // 
            // StayChangeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.add_pic);
            this.Controls.Add(this.add_lbl);
            this.Controls.Add(this.delete_pic);
            this.Controls.Add(this.box_pnl);
            this.Controls.Add(this.boxLeftTriangle_pic);
            this.Controls.Add(this.delete_lbl);
            this.Controls.Add(this.stayList_dgv);
            this.Name = "StayChangeView";
            this.Size = new System.Drawing.Size(800, 316);
            ((System.ComponentModel.ISupportInitialize)(this.add_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_pic)).EndInit();
            this.box_pnl.ResumeLayout(false);
            this.box_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxLeftTriangle_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stayList_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox add_pic;
        private System.Windows.Forms.Label add_lbl;
        private System.Windows.Forms.PictureBox delete_pic;
        private System.Windows.Forms.Panel box_pnl;
        private System.Windows.Forms.LinkLabel boxDCancel_lnk;
        private System.Windows.Forms.Button boxDConfirm_btn;
        private System.Windows.Forms.Label boxDExplanation_lbl;
        private System.Windows.Forms.Label boxAType_lbl;
        private System.Windows.Forms.Label boxAHorses_lbl;
        private HorseshoeControls.Input.DateInput dateInput;
        private System.Windows.Forms.ComboBox boxAType_cmb;
        private System.Windows.Forms.ComboBox boxAHorse_cmb;
        private System.Windows.Forms.Button boxACancel_btn;
        private System.Windows.Forms.Button boxASave_btn;
        private System.Windows.Forms.Label boxTitle_lbl;
        private System.Windows.Forms.PictureBox boxLeftTriangle_pic;
        private System.Windows.Forms.Label delete_lbl;
        private System.Windows.Forms.DataGridView stayList_dgv;
    }
}
