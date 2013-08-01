using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BarcodeLoader
{

    /// <summary>Main application form
    /// </summary>
    /// <remarks>
    /// <para>This form displays the main user interface for the application.
    /// </para>
    /// <para>If the "auto-load" checkbox is checked, the program may load before the barcode is finished scanning. This may lead to undesirable behavior.</para>
    /// </remarks>
    public partial class MainForm : Form
    {

        /// <summary>A list of barcode-to-part-program mappings loaded from configuration
        /// </summary>
        private PartProgram[] _partPrograms;

        /// <summary>The most recently selected part program, if any.
        /// </summary>
        private PartProgram _currentPartProgram;

        /// <summary>A <see cref="StringComparer"/> to use for matching strings.
        /// </summary>
        /// <remarks>
        /// This defaults to <see cref="StringComparer.OrdinalIgnoreCase"/> for case-insensitive barcode matches.</remarks>
        private StringComparer _comparer = StringComparer.OrdinalIgnoreCase;

        /// <summary>
        /// A <see cref="StringComparison"/> to use for matching strings.
        /// </summary>
        /// <remarks>
        /// This defaults to <see cref="StringComparison.OrdinalIgnoreCase"/> for case-insensitive barcode matches.</remarks>
        private StringComparison _comparison = StringComparison.OrdinalIgnoreCase;

        /// <summary>Answers an array of part programs that match the provided text.
        /// </summary>
        /// <param name="text">The text to match.</param>
        /// <returns>An array of part programs matching the given text, or an empty array if there are no matches.</returns>
        private PartProgram[] MatchPartProgram(string text)
        {
            List<PartProgram> ret = new List<PartProgram>();

            foreach (PartProgram program in _partPrograms)
            {
                if ((_comparer.Compare(program.Barcode, text)==0) || program.Barcode.StartsWith(text, _comparison)) ret.Add(program);
            }

            return ret.ToArray();
        }

        /// <summary>Display a "no matches" screen
        /// </summary>
        private void ShowNone()
        {
            PartProgramPanel.Visible = false;
            NonePanel.Visible = true;
            MultiplePanel.Visible = false;
            LoadButton.Enabled = false;
        }

        /// <summary>Display a screen showing the matching part program.
        /// </summary>
        /// <param name="program">The part program to display.</param>
        private void ShowOne(PartProgram program)
        {
            PartProgramPanel.Visible = true;
            NonePanel.Visible = false;
            MultiplePanel.Visible = false;
            LoadButton.Enabled = true;

            _currentPartProgram = program;

            PartProgramPanel.Controls.Clear();
            PartProgramBox box = new PartProgramBox();
            
            PartProgramPanel.Controls.Add(box);
            box.Dock = DockStyle.Fill;
            box.PartProgram = program;

            if (AutoLoadCheckBox.Checked) LoadPartProgram(program);
        }

        /// <summary>Display a screen showing a "multiple matches" screen.
        /// </summary>
        /// <param name="programs">An array of matching part programs.</param>
        /// <remarks>This could be extended in the future to display a list of part programs for the user to choose from.</remarks>
        private void ShowMultiple(PartProgram[] programs)
        {
            PartProgramPanel.Visible = false;
            NonePanel.Visible = false;
            MultiplePanel.Visible = true;
            LoadButton.Enabled = false;
        }

        /// <summary>Update the part program display based on the text entered.
        /// </summary>
        /// <param name="text">The text entered to match part programs.</param>
        private void UpdatePartPrograms(string text)
        {
            PartProgram[] programs = MatchPartProgram(text);
            switch (programs.Length)
            {
                case 0:
                    ShowNone();
                    break;
                case 1:
                    ShowOne(programs[0]);
                    break;
                default:
                    ShowMultiple(programs);
                    break;
            }
        }

        /// <summary>Loads the given part program and plays setup video based on configuration.
        /// </summary>
        /// <param name="program"></param>
        private void LoadPartProgram(PartProgram program)
        {
            MessageBox.Show("Loaded part program \"" + program.ProgramFilename + "\".");
            //TODO: actual part program load

            if (program.SetupFilename != null)
            {
                string setupPath = Path.Combine(program.SetupPath ?? "", program.SetupFilename ?? "");
                if (PlaySetupCheckBox.Checked)
                {
                    if (MessageBox.Show("Do you want to play the setup video for this part program?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) PlayVideo(setupPath);
                }
                else
                {
                    PlayVideo(setupPath);
                }
            }

            BarcodeTextBox.Focus();
        }

        private void PlayVideo(string path)
        {
            MessageBox.Show("Played video \"" + path + "\".");
            //TODO: actual play of video
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _partPrograms = PartProgram.FromFile("PartPrograms.xml");
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            BarcodeTextBox.Focus();
            UpdatePartPrograms("");
        }

        private void BarcodeTextBox_GotFocus(object sender, EventArgs e)
        {
            BarcodeTextBox.SelectAll();
        }

        private void BarcodeTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdatePartPrograms(BarcodeTextBox.Text);
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            LoadPartProgram(_currentPartProgram);
        }

        private void CaseSensitiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _comparer = CaseSensitiveCheckBox.Checked ? StringComparer.Ordinal : StringComparer.OrdinalIgnoreCase;
            _comparison = CaseSensitiveCheckBox.Checked ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase;
        }
    }
}
