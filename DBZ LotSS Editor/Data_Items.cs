using HexTools;
using System;

namespace DBZ_LotSS_Editor
{
    public partial class Data_Items : HexTools.HexUserControl
    {
        public Data_Items()
        {
            InitializeComponent();
        }

        private void RefreshZenie()
        {
            Zenie.Enabled = !Priceless.Checked;
        }

        private void HexCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            RefreshZenie();
        }

        private void HexCheckBox1_EnabledChanged(object sender, EventArgs e)
        {
            RefreshZenie();
        }

        private void HexCheckBox1_PreWrite(object sender, HexTools.PreWriteArgs e)
        {
            if (Zenie.Enabled)
            {
                e.NewValue = Math.Min(Zenie.Value, 254m);
            }
        }

        private void HexListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            NamePanel.Visible = DescriptionPanel.Visible = HexPanel1.Visible
                = HexListBox1.SelectedIndex < 40;
            hexPanel5.Visible = Script.Visible = HexListBox1.SelectedIndex < 32;
        }

        private void UseEffects_ValueChanged(object sender, EventArgs e)
        {
            if (HexListBox1.SelectedIndex >= 32) return;

            Script.HexOffset = "&H" + HexConvert.IntToHexRaw(HexConvert.SnesToPC("01" + ScriptPointer.Text, true) + 2, 5);
            Script.Load();
        }
    }
}