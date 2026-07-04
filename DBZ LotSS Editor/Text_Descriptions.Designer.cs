using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DBZ_LotSS_Editor
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Text_Descriptions : HexTools.HexUserControl
    {
        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components != null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.BasicListBoxAssociate1 = new BasicTools.BasicControls.BasicListBoxAssociate();
            this.MessageBox = new HexTools.HexMessageBox();
            this.HexListBox1 = new HexTools.HexListBox();
            this.BasicListBoxAssociate1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BasicListBoxAssociate1
            // 
            this.BasicListBoxAssociate1.Controls.Add(this.MessageBox);
            this.BasicListBoxAssociate1.ListBox = this.HexListBox1;
            this.BasicListBoxAssociate1.Location = new System.Drawing.Point(257, 17);
            this.BasicListBoxAssociate1.Margin = new System.Windows.Forms.Padding(4);
            this.BasicListBoxAssociate1.Name = "BasicListBoxAssociate1";
            this.BasicListBoxAssociate1.Padding = new System.Windows.Forms.Padding(4);
            this.BasicListBoxAssociate1.Size = new System.Drawing.Size(497, 530);
            this.BasicListBoxAssociate1.TabIndex = 19;
            this.BasicListBoxAssociate1.TabStop = false;
            this.BasicListBoxAssociate1.Text = "HexListBox1";
            // 
            // MessageBox
            // 
            this.MessageBox.AutoSize = true;
            this.MessageBox.Location = new System.Drawing.Point(9, 3);
            this.MessageBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MessageBox.MessageDefinition = "TextEditor.Descriptions";
            this.MessageBox.MinimumSize = new System.Drawing.Size(375, 195);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(360, 217);
            this.MessageBox.TabIndex = 0;
            // 
            // HexListBox1
            // 
            this.HexListBox1.Definition = "TextEditor.Descriptions.List";
            this.HexListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.HexListBox1.FormatString = "X2";
            this.HexListBox1.FormattingEnabled = true;
            this.HexListBox1.IndexDisplay = true;
            this.HexListBox1.Location = new System.Drawing.Point(24, 27);
            this.HexListBox1.Margin = new System.Windows.Forms.Padding(6);
            this.HexListBox1.Name = "HexListBox1";
            this.HexListBox1.SelectedItem = null;
            this.HexListBox1.Size = new System.Drawing.Size(232, 480);
            this.HexListBox1.CanEditLabel = true;
            this.HexListBox1.TabIndex = 18;
            // 
            // Text_Descriptions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BasicListBoxAssociate1);
            this.Controls.Add(this.HexListBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Text_Descriptions";
            this.Size = new System.Drawing.Size(787, 603);
            this.BasicListBoxAssociate1.ResumeLayout(false);
            this.BasicListBoxAssociate1.PerformLayout();
            this.ResumeLayout(false);

        }

        internal BasicTools.BasicControls.BasicListBoxAssociate BasicListBoxAssociate1;
        internal HexTools.HexListBox HexListBox1;
        internal HexTools.HexMessageBox MessageBox;
    }
}