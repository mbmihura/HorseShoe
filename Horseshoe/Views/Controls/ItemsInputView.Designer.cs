namespace Horseshoe.Views.Controls
{
    partial class ItemsInputView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsInputView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.delete_pic = new System.Windows.Forms.PictureBox();
            this.box_pnl = new System.Windows.Forms.Panel();
            this.boxDExplanation_lbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.boxAType_cmb = new System.Windows.Forms.ComboBox();
            this.boxAHorse_cmb = new System.Windows.Forms.ComboBox();
            this.boxDConfirm_btn = new System.Windows.Forms.Button();
            this.boxDCancel_lnk = new System.Windows.Forms.LinkLabel();
            this.boxADinamicControlsContainer_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.boxACancel_btn = new System.Windows.Forms.Button();
            this.boxASave_btn = new System.Windows.Forms.Button();
            this.boxTitle_lbl = new System.Windows.Forms.Label();
            this.boxLeftTriangle_pic = new System.Windows.Forms.PictureBox();
            this.add_pic = new System.Windows.Forms.PictureBox();
            this.delete_lbl = new System.Windows.Forms.Label();
            this.add_lbl = new System.Windows.Forms.Label();
            this.ItemList_dgv = new System.Windows.Forms.DataGridView();
            this.dgvHorse_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvType_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescription_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDate_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCost_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.delete_pic)).BeginInit();
            this.box_pnl.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxLeftTriangle_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemList_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // delete_pic
            // 
            this.delete_pic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_pic.Image = ((System.Drawing.Image)(resources.GetObject("delete_pic.Image")));
            this.delete_pic.Location = new System.Drawing.Point(200, 27);
            this.delete_pic.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.delete_pic.Name = "delete_pic";
            this.delete_pic.Size = new System.Drawing.Size(14, 7);
            this.delete_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.delete_pic.TabIndex = 42;
            this.delete_pic.TabStop = false;
            this.delete_pic.Visible = false;
            // 
            // box_pnl
            // 
            this.box_pnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(221)))));
            this.box_pnl.Controls.Add(this.boxDExplanation_lbl);
            this.box_pnl.Controls.Add(this.tableLayoutPanel1);
            this.box_pnl.Controls.Add(this.boxDConfirm_btn);
            this.box_pnl.Controls.Add(this.boxDCancel_lnk);
            this.box_pnl.Controls.Add(this.boxADinamicControlsContainer_flp);
            this.box_pnl.Controls.Add(this.boxACancel_btn);
            this.box_pnl.Controls.Add(this.boxASave_btn);
            this.box_pnl.Controls.Add(this.boxTitle_lbl);
            this.box_pnl.Location = new System.Drawing.Point(11, 33);
            this.box_pnl.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.box_pnl.Name = "box_pnl";
            this.box_pnl.Size = new System.Drawing.Size(327, 421);
            this.box_pnl.TabIndex = 41;
            // 
            // boxDExplanation_lbl
            // 
            this.boxDExplanation_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxDExplanation_lbl.Location = new System.Drawing.Point(10, 47);
            this.boxDExplanation_lbl.Name = "boxDExplanation_lbl";
            this.boxDExplanation_lbl.Size = new System.Drawing.Size(304, 46);
            this.boxDExplanation_lbl.TabIndex = 36;
            this.boxDExplanation_lbl.Text = "Para eliminar cambios de estadias, seleccione \'eliminar\' en la lista de estadias " +
    "y luego presione el boton \'Confirmar\' a continuacion.";
            this.boxDExplanation_lbl.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.16883F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.83117F));
            this.tableLayoutPanel1.Controls.Add(this.boxAType_cmb, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.boxAHorse_cmb, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 47);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(400, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(311, 26);
            this.tableLayoutPanel1.TabIndex = 39;
            // 
            // boxAType_cmb
            // 
            this.boxAType_cmb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxAType_cmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.boxAType_cmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.boxAType_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxAType_cmb.FormattingEnabled = true;
            this.boxAType_cmb.Location = new System.Drawing.Point(177, 3);
            this.boxAType_cmb.Name = "boxAType_cmb";
            this.boxAType_cmb.Size = new System.Drawing.Size(131, 21);
            this.boxAType_cmb.TabIndex = 18;
            this.boxAType_cmb.SelectedIndexChanged += new System.EventHandler(this.boxAType_cmb_SelectedIndexChanged);
            // 
            // boxAHorse_cmb
            // 
            this.boxAHorse_cmb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxAHorse_cmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.boxAHorse_cmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.boxAHorse_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxAHorse_cmb.FormattingEnabled = true;
            this.boxAHorse_cmb.Location = new System.Drawing.Point(3, 3);
            this.boxAHorse_cmb.Name = "boxAHorse_cmb";
            this.boxAHorse_cmb.Size = new System.Drawing.Size(168, 21);
            this.boxAHorse_cmb.TabIndex = 17;
            // 
            // boxDConfirm_btn
            // 
            this.boxDConfirm_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.boxDConfirm_btn.Location = new System.Drawing.Point(97, 123);
            this.boxDConfirm_btn.Name = "boxDConfirm_btn";
            this.boxDConfirm_btn.Size = new System.Drawing.Size(112, 27);
            this.boxDConfirm_btn.TabIndex = 37;
            this.boxDConfirm_btn.Text = "CONFIRMAR";
            this.boxDConfirm_btn.UseVisualStyleBackColor = true;
            this.boxDConfirm_btn.Visible = false;
            this.boxDConfirm_btn.Click += new System.EventHandler(this.boxDConfirm_btn_Click);
            // 
            // boxDCancel_lnk
            // 
            this.boxDCancel_lnk.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.boxDCancel_lnk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boxDCancel_lnk.AutoSize = true;
            this.boxDCancel_lnk.LinkColor = System.Drawing.Color.Navy;
            this.boxDCancel_lnk.Location = new System.Drawing.Point(261, 23);
            this.boxDCancel_lnk.Name = "boxDCancel_lnk";
            this.boxDCancel_lnk.Size = new System.Drawing.Size(49, 13);
            this.boxDCancel_lnk.TabIndex = 38;
            this.boxDCancel_lnk.TabStop = true;
            this.boxDCancel_lnk.Text = "Cancelar";
            this.boxDCancel_lnk.Visible = false;
            this.boxDCancel_lnk.VisitedLinkColor = System.Drawing.Color.Navy;
            this.boxDCancel_lnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.boxDCancel_lnk_LinkClicked);
            // 
            // boxADinamicControlsContainer_flp
            // 
            this.boxADinamicControlsContainer_flp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxADinamicControlsContainer_flp.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.boxADinamicControlsContainer_flp.Location = new System.Drawing.Point(3, 80);
            this.boxADinamicControlsContainer_flp.Name = "boxADinamicControlsContainer_flp";
            this.boxADinamicControlsContainer_flp.Size = new System.Drawing.Size(323, 298);
            this.boxADinamicControlsContainer_flp.TabIndex = 16;
            // 
            // boxACancel_btn
            // 
            this.boxACancel_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.boxACancel_btn.Location = new System.Drawing.Point(161, 388);
            this.boxACancel_btn.Name = "boxACancel_btn";
            this.boxACancel_btn.Size = new System.Drawing.Size(75, 23);
            this.boxACancel_btn.TabIndex = 13;
            this.boxACancel_btn.Text = "Cancelar";
            this.boxACancel_btn.UseVisualStyleBackColor = true;
            this.boxACancel_btn.Click += new System.EventHandler(this.boxACancel_btn_Click);
            // 
            // boxASave_btn
            // 
            this.boxASave_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.boxASave_btn.Location = new System.Drawing.Point(242, 388);
            this.boxASave_btn.Name = "boxASave_btn";
            this.boxASave_btn.Size = new System.Drawing.Size(75, 23);
            this.boxASave_btn.TabIndex = 10;
            this.boxASave_btn.Text = "Guardar";
            this.boxASave_btn.UseVisualStyleBackColor = true;
            this.boxASave_btn.Click += new System.EventHandler(this.boxASave_btn_Click);
            // 
            // boxTitle_lbl
            // 
            this.boxTitle_lbl.AutoSize = true;
            this.boxTitle_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxTitle_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(64)))), ((int)(((byte)(26)))));
            this.boxTitle_lbl.Location = new System.Drawing.Point(7, 15);
            this.boxTitle_lbl.Name = "boxTitle_lbl";
            this.boxTitle_lbl.Size = new System.Drawing.Size(187, 24);
            this.boxTitle_lbl.TabIndex = 1;
            this.boxTitle_lbl.Text = "Agregar Tratamiento:";
            // 
            // boxLeftTriangle_pic
            // 
            this.boxLeftTriangle_pic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.boxLeftTriangle_pic.Image = global::Horseshoe.Properties.Resources.GreenTriangleLeftBig;
            this.boxLeftTriangle_pic.Location = new System.Drawing.Point(2, 50);
            this.boxLeftTriangle_pic.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.boxLeftTriangle_pic.Name = "boxLeftTriangle_pic";
            this.boxLeftTriangle_pic.Size = new System.Drawing.Size(10, 20);
            this.boxLeftTriangle_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.boxLeftTriangle_pic.TabIndex = 40;
            this.boxLeftTriangle_pic.TabStop = false;
            // 
            // add_pic
            // 
            this.add_pic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_pic.Image = ((System.Drawing.Image)(resources.GetObject("add_pic.Image")));
            this.add_pic.Location = new System.Drawing.Point(275, 27);
            this.add_pic.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.add_pic.Name = "add_pic";
            this.add_pic.Size = new System.Drawing.Size(14, 7);
            this.add_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.add_pic.TabIndex = 39;
            this.add_pic.TabStop = false;
            // 
            // delete_lbl
            // 
            this.delete_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_lbl.AutoSize = true;
            this.delete_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.delete_lbl.Location = new System.Drawing.Point(168, 8);
            this.delete_lbl.Name = "delete_lbl";
            this.delete_lbl.Size = new System.Drawing.Size(70, 15);
            this.delete_lbl.TabIndex = 38;
            this.delete_lbl.Text = "- Eliminar";
            this.delete_lbl.Click += new System.EventHandler(this.delete_lbl_Click);
            // 
            // add_lbl
            // 
            this.add_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_lbl.AutoSize = true;
            this.add_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.add_lbl.Location = new System.Drawing.Point(245, 8);
            this.add_lbl.Name = "add_lbl";
            this.add_lbl.Size = new System.Drawing.Size(69, 15);
            this.add_lbl.TabIndex = 37;
            this.add_lbl.Text = "+ Agregar";
            this.add_lbl.Click += new System.EventHandler(this.add_lbl_Click);
            // 
            // ItemList_dgv
            // 
            this.ItemList_dgv.AllowUserToAddRows = false;
            this.ItemList_dgv.AllowUserToOrderColumns = true;
            this.ItemList_dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.ItemList_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ItemList_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemList_dgv.BackgroundColor = System.Drawing.Color.White;
            this.ItemList_dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ItemList_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ItemList_dgv.ColumnHeadersHeight = 25;
            this.ItemList_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ItemList_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvHorse_clm,
            this.dgvType_clm,
            this.dgvDescription_clm,
            this.dgvDate_clm,
            this.dgvCost_clm});
            this.ItemList_dgv.GridColor = System.Drawing.Color.White;
            this.ItemList_dgv.Location = new System.Drawing.Point(1, 33);
            this.ItemList_dgv.Name = "ItemList_dgv";
            this.ItemList_dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ItemList_dgv.RowHeadersVisible = false;
            this.ItemList_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemList_dgv.Size = new System.Drawing.Size(466, 421);
            this.ItemList_dgv.TabIndex = 36;
            this.ItemList_dgv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_MouseClick);
            // 
            // dgvHorse_clm
            // 
            this.dgvHorse_clm.HeaderText = "Caballlo";
            this.dgvHorse_clm.Name = "dgvHorse_clm";
            this.dgvHorse_clm.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgvType_clm
            // 
            this.dgvType_clm.HeaderText = "Tipo";
            this.dgvType_clm.Name = "dgvType_clm";
            this.dgvType_clm.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgvDescription_clm
            // 
            this.dgvDescription_clm.HeaderText = "Description";
            this.dgvDescription_clm.Name = "dgvDescription_clm";
            this.dgvDescription_clm.Width = 200;
            // 
            // dgvDate_clm
            // 
            this.dgvDate_clm.HeaderText = "Fecha";
            this.dgvDate_clm.Name = "dgvDate_clm";
            this.dgvDate_clm.Visible = false;
            // 
            // dgvCost_clm
            // 
            this.dgvCost_clm.HeaderText = "Costo";
            this.dgvCost_clm.Name = "dgvCost_clm";
            this.dgvCost_clm.Width = 50;
            // 
            // dgvContextMenu
            // 
            this.dgvContextMenu.Name = "dgvContextMenu";
            this.dgvContextMenu.ShowCheckMargin = true;
            this.dgvContextMenu.ShowImageMargin = false;
            this.dgvContextMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ItemList_dgv);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.delete_lbl);
            this.splitContainer1.Panel2.Controls.Add(this.delete_pic);
            this.splitContainer1.Panel2.Controls.Add(this.box_pnl);
            this.splitContainer1.Panel2.Controls.Add(this.add_lbl);
            this.splitContainer1.Panel2.Controls.Add(this.add_pic);
            this.splitContainer1.Panel2.Controls.Add(this.boxLeftTriangle_pic);
            this.splitContainer1.Size = new System.Drawing.Size(807, 457);
            this.splitContainer1.SplitterDistance = 467;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 43;
            // 
            // ItemsInputView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ItemsInputView";
            this.Size = new System.Drawing.Size(803, 460);
            ((System.ComponentModel.ISupportInitialize)(this.delete_pic)).EndInit();
            this.box_pnl.ResumeLayout(false);
            this.box_pnl.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.boxLeftTriangle_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemList_dgv)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox delete_pic;
        private System.Windows.Forms.Panel box_pnl;
        private System.Windows.Forms.Label boxDExplanation_lbl;
        private System.Windows.Forms.Button boxDConfirm_btn;
        private System.Windows.Forms.LinkLabel boxDCancel_lnk;
        private System.Windows.Forms.ComboBox boxAType_cmb;
        private System.Windows.Forms.FlowLayoutPanel boxADinamicControlsContainer_flp;
        private System.Windows.Forms.Button boxACancel_btn;
        private System.Windows.Forms.Button boxASave_btn;
        private System.Windows.Forms.Label boxTitle_lbl;
        private System.Windows.Forms.PictureBox boxLeftTriangle_pic;
        private System.Windows.Forms.PictureBox add_pic;
        private System.Windows.Forms.Label delete_lbl;
        private System.Windows.Forms.Label add_lbl;
        private System.Windows.Forms.DataGridView ItemList_dgv;
        private System.Windows.Forms.ContextMenuStrip dgvContextMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHorse_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvType_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescription_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDate_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCost_clm;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox boxAHorse_cmb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
