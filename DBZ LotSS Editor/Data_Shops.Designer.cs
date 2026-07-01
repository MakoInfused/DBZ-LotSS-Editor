namespace DBZ_LotSS_Editor
{
    partial class Data_Shops
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            HexTools.HexListBoxItem hexListBoxItem1 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem2 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem3 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem4 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem5 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem6 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem7 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem8 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem9 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem10 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem11 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem12 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem13 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem14 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem15 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem16 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem17 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem18 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem19 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem20 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem21 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem22 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem23 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem24 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem25 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem26 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem27 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem28 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem29 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem30 = new HexTools.HexListBoxItem();
            this.editableListViewItem1 = new BasicTools.BasicControls.EditableListViewItem();
            this.BasicListBoxAssociate1 = new BasicTools.BasicControls.BasicListBoxAssociate();
            this.HexPanel1 = new HexTools.HexPanel();
            this.Wares = new HexTools.HexTableView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hexComboBoxItemControl1 = new HexTools.HexComboBoxItemControl();
            this.HexListBox1 = new HexTools.HexListBox();
            this.BasicListBoxAssociate1.SuspendLayout();
            this.HexPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // editableListViewItem1
            // 
            this.editableListViewItem1.Name = "Item_01";
            // 
            // BasicListBoxAssociate1
            // 
            this.BasicListBoxAssociate1.Controls.Add(this.HexPanel1);
            this.BasicListBoxAssociate1.ListBox = this.HexListBox1;
            this.BasicListBoxAssociate1.Location = new System.Drawing.Point(406, 27);
            this.BasicListBoxAssociate1.Margin = new System.Windows.Forms.Padding(6);
            this.BasicListBoxAssociate1.Name = "BasicListBoxAssociate1";
            this.BasicListBoxAssociate1.Padding = new System.Windows.Forms.Padding(6);
            this.BasicListBoxAssociate1.Size = new System.Drawing.Size(736, 859);
            this.BasicListBoxAssociate1.TabIndex = 18;
            this.BasicListBoxAssociate1.TabStop = false;
            this.BasicListBoxAssociate1.Text = "HexListBox1";
            // 
            // HexPanel1
            // 
            this.HexPanel1.Controls.Add(this.Wares);
            this.HexPanel1.HexOffset = "&H010000";
            this.HexPanel1.IndexOffset = "&H000002";
            this.HexPanel1.Location = new System.Drawing.Point(9, 33);
            this.HexPanel1.Name = "HexPanel1";
            this.HexPanel1.Pointer = "&H019851";
            this.HexPanel1.PointerAddressFormat = HexTools.HexEnumerations.HexAddressFormatType.SNES_LoROM;
            this.HexPanel1.PointerLength = 2;
            this.HexPanel1.Size = new System.Drawing.Size(678, 630);
            this.HexPanel1.TabIndex = 0;
            // 
            // Wares
            // 
            this.Wares.ColumnActivity = BasicTools.BasicControls.BasicTableView.TableViewColumnActivity.NonClickable;
            this.Wares.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2});
            this.Wares.DoubleClickActivation = true;
            this.Wares.Editors.AddRange(new BasicTools.BasicControls.EditableListViewItem[] {
            this.editableListViewItem1,
            this.hexComboBoxItemControl1});
            this.Wares.Enabled = false;
            this.Wares.FullRowSelect = true;
            this.Wares.HexOffsetCountPointer = 1;
            this.Wares.HexOffsetCountType = HexTools.HexEnumerations.OffsetType.Terminated;
            this.Wares.HexOffsetLength = "&H000001";
            this.Wares.HideSelection = false;
            this.Wares.Location = new System.Drawing.Point(3, 6);
            this.Wares.Margin = new System.Windows.Forms.Padding(6);
            this.Wares.Name = "Wares";
            this.Wares.OwnerDraw = true;
            this.Wares.Size = new System.Drawing.Size(666, 595);
            this.Wares.Style = BasicTools.BasicControls.BasicTableView.TableViewStyles.Columns;
            this.Wares.TabIndex = 53;
            this.Wares.UseCompatibleStateImageBehavior = false;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Index";
            this.ColumnHeader1.Width = 49;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Item";
            this.ColumnHeader2.Width = 280;
            // 
            // hexComboBoxItemControl1
            // 
            // 
            // 
            // 
            this.hexComboBoxItemControl1.Control.Display = HexTools.HexEnumerations.DisplayType.Hex;
            this.hexComboBoxItemControl1.Control.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.hexComboBoxItemControl1.Control.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hexComboBoxItemControl1.Control.Endian = HexTools.HexEnumerations.EndianType.Little_Endian;
            this.hexComboBoxItemControl1.Control.FormatString = "X2";
            this.hexComboBoxItemControl1.Control.FormattingEnabled = true;
            this.hexComboBoxItemControl1.Control.ItemCollection = "Data_Items.HexListBox1";
            this.hexComboBoxItemControl1.Control.Location = new System.Drawing.Point(0, 0);
            this.hexComboBoxItemControl1.Control.MaxLength = 1;
            this.hexComboBoxItemControl1.Control.Name = "Skill";
            this.hexComboBoxItemControl1.Control.Size = new System.Drawing.Size(121, 33);
            this.hexComboBoxItemControl1.Control.TabIndex = 0;
            this.hexComboBoxItemControl1.Control.ValueDisplay = true;
            // 
            // HexListBox1
            // 
            this.HexListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.HexListBox1.FormatString = "X2";
            this.HexListBox1.FormattingEnabled = true;
            this.HexListBox1.IndexDisplay = true;
            hexListBoxItem1.HexOffset = null;
            hexListBoxItem1.Text = "Earth 01 - A";
            hexListBoxItem2.HexOffset = null;
            hexListBoxItem2.Text = "Earth 01 - B (Unused)";
            hexListBoxItem3.HexOffset = null;
            hexListBoxItem3.Text = "Earth 02 - A";
            hexListBoxItem4.HexOffset = null;
            hexListBoxItem4.Text = "Earth 02 - B";
            hexListBoxItem5.HexOffset = null;
            hexListBoxItem5.Text = "Namek 01 - A";
            hexListBoxItem6.HexOffset = null;
            hexListBoxItem6.Text = "Namek 01 - B";
            hexListBoxItem7.HexOffset = null;
            hexListBoxItem7.Text = "Namek 01 - C";
            hexListBoxItem8.HexOffset = null;
            hexListBoxItem8.Text = "Namek 02 - A";
            hexListBoxItem9.HexOffset = null;
            hexListBoxItem9.Text = "Namek 02 - B";
            hexListBoxItem10.HexOffset = null;
            hexListBoxItem10.Text = "Namek 02 - C";
            hexListBoxItem11.HexOffset = null;
            hexListBoxItem11.Text = "Namek 02 - D";
            hexListBoxItem12.HexOffset = null;
            hexListBoxItem12.Text = "Namek 02 - E";
            hexListBoxItem13.HexOffset = null;
            hexListBoxItem13.Text = "Namek 04 - A";
            hexListBoxItem14.HexOffset = null;
            hexListBoxItem14.Text = "Namek 04 - B";
            hexListBoxItem15.HexOffset = null;
            hexListBoxItem15.Text = "Namek 04 - C";
            hexListBoxItem16.HexOffset = null;
            hexListBoxItem16.Text = "Namek 04 - D";
            hexListBoxItem17.HexOffset = null;
            hexListBoxItem17.Text = "Namek 04 - E";
            hexListBoxItem18.HexOffset = null;
            hexListBoxItem18.Text = "?";
            hexListBoxItem19.HexOffset = null;
            hexListBoxItem19.Text = "?";
            hexListBoxItem20.HexOffset = null;
            hexListBoxItem20.Text = "?";
            hexListBoxItem21.HexOffset = null;
            hexListBoxItem21.Text = "?";
            hexListBoxItem22.HexOffset = null;
            hexListBoxItem22.Text = "?";
            hexListBoxItem23.HexOffset = null;
            hexListBoxItem23.Text = "Namek 03 - A";
            hexListBoxItem24.HexOffset = null;
            hexListBoxItem24.Text = "Namek 03 - B";
            hexListBoxItem25.HexOffset = null;
            hexListBoxItem25.Text = "Namek 03 - C";
            hexListBoxItem26.HexOffset = null;
            hexListBoxItem26.Text = "Namek 03 - D";
            hexListBoxItem27.HexOffset = null;
            hexListBoxItem27.Text = "Namek 05 - A";
            hexListBoxItem28.HexOffset = null;
            hexListBoxItem28.Text = "Namek 05 - B";
            hexListBoxItem29.HexOffset = null;
            hexListBoxItem29.Text = "Namek 05 - C";
            hexListBoxItem30.HexOffset = null;
            hexListBoxItem30.Text = "Namek 05 - D";
            this.HexListBox1.Items.Add(hexListBoxItem1);
            this.HexListBox1.Items.Add(hexListBoxItem2);
            this.HexListBox1.Items.Add(hexListBoxItem3);
            this.HexListBox1.Items.Add(hexListBoxItem4);
            this.HexListBox1.Items.Add(hexListBoxItem5);
            this.HexListBox1.Items.Add(hexListBoxItem6);
            this.HexListBox1.Items.Add(hexListBoxItem7);
            this.HexListBox1.Items.Add(hexListBoxItem8);
            this.HexListBox1.Items.Add(hexListBoxItem9);
            this.HexListBox1.Items.Add(hexListBoxItem10);
            this.HexListBox1.Items.Add(hexListBoxItem11);
            this.HexListBox1.Items.Add(hexListBoxItem12);
            this.HexListBox1.Items.Add(hexListBoxItem13);
            this.HexListBox1.Items.Add(hexListBoxItem14);
            this.HexListBox1.Items.Add(hexListBoxItem15);
            this.HexListBox1.Items.Add(hexListBoxItem16);
            this.HexListBox1.Items.Add(hexListBoxItem17);
            this.HexListBox1.Items.Add(hexListBoxItem18);
            this.HexListBox1.Items.Add(hexListBoxItem19);
            this.HexListBox1.Items.Add(hexListBoxItem20);
            this.HexListBox1.Items.Add(hexListBoxItem21);
            this.HexListBox1.Items.Add(hexListBoxItem22);
            this.HexListBox1.Items.Add(hexListBoxItem23);
            this.HexListBox1.Items.Add(hexListBoxItem24);
            this.HexListBox1.Items.Add(hexListBoxItem25);
            this.HexListBox1.Items.Add(hexListBoxItem26);
            this.HexListBox1.Items.Add(hexListBoxItem27);
            this.HexListBox1.Items.Add(hexListBoxItem28);
            this.HexListBox1.Items.Add(hexListBoxItem29);
            this.HexListBox1.Items.Add(hexListBoxItem30);
            this.HexListBox1.Location = new System.Drawing.Point(24, 27);
            this.HexListBox1.Margin = new System.Windows.Forms.Padding(6);
            this.HexListBox1.Name = "HexListBox1";
            this.HexListBox1.SelectedItem = null;
            this.HexListBox1.Size = new System.Drawing.Size(346, 849);
            this.HexListBox1.TabIndex = 17;
            // 
            // Data_Shops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BasicListBoxAssociate1);
            this.Controls.Add(this.HexListBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Data_Shops";
            this.Size = new System.Drawing.Size(1180, 942);
            this.BasicListBoxAssociate1.ResumeLayout(false);
            this.HexPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal HexTools.HexListBox HexListBox1;
        private BasicTools.BasicControls.BasicListBoxAssociate BasicListBoxAssociate1;
        private HexTools.HexPanel HexPanel1;
        internal HexTools.HexTableView Wares;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        private BasicTools.BasicControls.EditableListViewItem editableListViewItem1;
        private HexTools.HexComboBoxItemControl hexComboBoxItemControl1;
    }
}
