
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
            Script.HexOffset = "&H" + HexConvert.IntToHexRaw(HexConvert.SnesToPC("1E" + ScriptPointer.Text, true), 5);
            Script.Load();
        }
    }
}