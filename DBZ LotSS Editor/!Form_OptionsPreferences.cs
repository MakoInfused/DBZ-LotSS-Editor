using System;
using System.Linq;
using System.Windows.Forms;
using BasicTools;
using HexTools.HexEnumerations;

namespace DBZ_LotSS_Editor
{

    public partial class Form_OptionsPreferences : HexTools.HexForm
    {
        public Form_OptionsPreferences()
        {
            InitializeComponent();
        }

        private void Form_OptionsPreferences_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            AutoLoadWindows.Checked = Properties.Settings.Default.AutoLoadWindows;
            AutoLoadRecent.Checked = Properties.Settings.Default.AutoLoadRecent;
            AutoBackup.Checked = Properties.Settings.Default.AutoBackup;
            Backups.Value = Properties.Settings.Default.Backups;
            SupressUnsafeWarnings.Checked = Properties.Settings.Default.SupressUnsafeWarnings;
            if(DataManagement.Items.Count == 0)
            {
                DataManagement.Items.AddRange(Enum.GetValues(typeof(DataManagementType))
                    .Cast<object>().ToArray());
            }
            DataManagement.SelectedItem = Properties.Settings.Default.DataManagement;
        }

        private void AutoLoadWindows_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AutoLoadWindows = AutoLoadWindows.Checked;
        }

        private void AutoLoadRecent_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AutoLoadRecent = AutoLoadRecent.Checked;
        }

        private void AutoBackup_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AutoBackup = AutoBackup.Checked;
            BackupsPanel.Enabled = AutoBackup.Checked;
        }

        private void Backups_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Backups = (byte)Math.Round(Backups.Value);
        }

        private void SupressUnsafeWarnings_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SupressUnsafeWarnings = SupressUnsafeWarnings.Checked;
        }

        private void DataManagement_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DataManagement = (DataManagementType) DataManagement.SelectedItem;
        }

        private void Form_OptionsPreferences_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Reload();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            SystemFormEvent.RaisePreferencesSaved(Properties.Settings.Default);
            Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            Close();
        }
    }
}