
using HexTools;

namespace DBZ_LotSS_Editor
{
    public partial class Data_Skills : HexTools.HexUserControl
    {
        public Data_Skills()
        {
            InitializeComponent();
        }

        private void VisualEffects_ValueChanged(object sender, System.EventArgs e)
        {
            hexTextBox1.HexOffset = "&H" + HexConvert.IntToHexRaw(HexConvert.SnesToPC("1E" + ScriptEffects.Text, true), 5);
            hexTextBox1.Load();
        }
    }
}