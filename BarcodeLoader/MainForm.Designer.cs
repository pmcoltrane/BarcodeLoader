namespace BarcodeLoader
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.BarcodePage = new System.Windows.Forms.TabPage();
            this.PartProgramPanel = new System.Windows.Forms.Panel();
            this.LoadButton = new System.Windows.Forms.Button();
            this.BarcodeTextBox = new System.Windows.Forms.TextBox();
            this.NonePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MultiplePanel = new System.Windows.Forms.Panel();
            this.MultipleLabel = new System.Windows.Forms.Label();
            this.AdvancedPage = new System.Windows.Forms.TabPage();
            this.CaseSensitiveCheckBox = new System.Windows.Forms.CheckBox();
            this.AutoLoadCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AutoPlayRadio = new System.Windows.Forms.RadioButton();
            this.PromptPlayRadio = new System.Windows.Forms.RadioButton();
            this.NoPlayRadio = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.BarcodePage.SuspendLayout();
            this.NonePanel.SuspendLayout();
            this.MultiplePanel.SuspendLayout();
            this.AdvancedPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.BarcodePage);
            this.tabControl1.Controls.Add(this.AdvancedPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(624, 362);
            this.tabControl1.TabIndex = 0;
            // 
            // BarcodePage
            // 
            this.BarcodePage.Controls.Add(this.PartProgramPanel);
            this.BarcodePage.Controls.Add(this.LoadButton);
            this.BarcodePage.Controls.Add(this.BarcodeTextBox);
            this.BarcodePage.Controls.Add(this.NonePanel);
            this.BarcodePage.Controls.Add(this.MultiplePanel);
            this.BarcodePage.Location = new System.Drawing.Point(4, 22);
            this.BarcodePage.Name = "BarcodePage";
            this.BarcodePage.Padding = new System.Windows.Forms.Padding(3);
            this.BarcodePage.Size = new System.Drawing.Size(616, 336);
            this.BarcodePage.TabIndex = 0;
            this.BarcodePage.Text = "Scan Barcode";
            this.BarcodePage.UseVisualStyleBackColor = true;
            // 
            // PartProgramPanel
            // 
            this.PartProgramPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PartProgramPanel.Location = new System.Drawing.Point(8, 64);
            this.PartProgramPanel.Name = "PartProgramPanel";
            this.PartProgramPanel.Size = new System.Drawing.Size(600, 264);
            this.PartProgramPanel.TabIndex = 3;
            this.PartProgramPanel.Visible = false;
            // 
            // LoadButton
            // 
            this.LoadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadButton.Location = new System.Drawing.Point(528, 6);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(80, 52);
            this.LoadButton.TabIndex = 2;
            this.LoadButton.Text = "&Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // BarcodeTextBox
            // 
            this.BarcodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BarcodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeTextBox.Location = new System.Drawing.Point(6, 8);
            this.BarcodeTextBox.Name = "BarcodeTextBox";
            this.BarcodeTextBox.Size = new System.Drawing.Size(516, 38);
            this.BarcodeTextBox.TabIndex = 1;
            this.BarcodeTextBox.TextChanged += new System.EventHandler(this.BarcodeTextBox_TextChanged);
            this.BarcodeTextBox.GotFocus += new System.EventHandler(this.BarcodeTextBox_GotFocus);
            // 
            // NonePanel
            // 
            this.NonePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NonePanel.Controls.Add(this.label1);
            this.NonePanel.Location = new System.Drawing.Point(8, 64);
            this.NonePanel.Name = "NonePanel";
            this.NonePanel.Size = new System.Drawing.Size(600, 264);
            this.NonePanel.TabIndex = 4;
            this.NonePanel.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "No part programs found.\r\nPlease scan or type a barcode.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MultiplePanel
            // 
            this.MultiplePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MultiplePanel.Controls.Add(this.MultipleLabel);
            this.MultiplePanel.Location = new System.Drawing.Point(8, 64);
            this.MultiplePanel.Name = "MultiplePanel";
            this.MultiplePanel.Size = new System.Drawing.Size(600, 264);
            this.MultiplePanel.TabIndex = 6;
            this.MultiplePanel.Visible = false;
            // 
            // MultipleLabel
            // 
            this.MultipleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MultipleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultipleLabel.Location = new System.Drawing.Point(35, 105);
            this.MultipleLabel.Name = "MultipleLabel";
            this.MultipleLabel.Size = new System.Drawing.Size(533, 50);
            this.MultipleLabel.TabIndex = 0;
            this.MultipleLabel.Text = "Multiple matches found.\r\nPlease scan or type a barcode to narrow the selection.";
            this.MultipleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdvancedPage
            // 
            this.AdvancedPage.Controls.Add(this.groupBox1);
            this.AdvancedPage.Controls.Add(this.CaseSensitiveCheckBox);
            this.AdvancedPage.Controls.Add(this.AutoLoadCheckBox);
            this.AdvancedPage.Location = new System.Drawing.Point(4, 22);
            this.AdvancedPage.Name = "AdvancedPage";
            this.AdvancedPage.Padding = new System.Windows.Forms.Padding(3);
            this.AdvancedPage.Size = new System.Drawing.Size(616, 336);
            this.AdvancedPage.TabIndex = 1;
            this.AdvancedPage.Text = "Advanced";
            this.AdvancedPage.UseVisualStyleBackColor = true;
            // 
            // CaseSensitiveCheckBox
            // 
            this.CaseSensitiveCheckBox.AutoSize = true;
            this.CaseSensitiveCheckBox.Location = new System.Drawing.Point(8, 73);
            this.CaseSensitiveCheckBox.Name = "CaseSensitiveCheckBox";
            this.CaseSensitiveCheckBox.Size = new System.Drawing.Size(364, 17);
            this.CaseSensitiveCheckBox.TabIndex = 1;
            this.CaseSensitiveCheckBox.Text = "Require matching case on barcode (ABC, Abc, and abc are all different)";
            this.CaseSensitiveCheckBox.UseVisualStyleBackColor = true;
            this.CaseSensitiveCheckBox.CheckedChanged += new System.EventHandler(this.CaseSensitiveCheckBox_CheckedChanged);
            // 
            // AutoLoadCheckBox
            // 
            this.AutoLoadCheckBox.AutoSize = true;
            this.AutoLoadCheckBox.Location = new System.Drawing.Point(8, 20);
            this.AutoLoadCheckBox.Name = "AutoLoadCheckBox";
            this.AutoLoadCheckBox.Size = new System.Drawing.Size(406, 17);
            this.AutoLoadCheckBox.TabIndex = 0;
            this.AutoLoadCheckBox.Text = "Automatically load part program when selected (may cause undesirable behavior)";
            this.AutoLoadCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NoPlayRadio);
            this.groupBox1.Controls.Add(this.PromptPlayRadio);
            this.groupBox1.Controls.Add(this.AutoPlayRadio);
            this.groupBox1.Location = new System.Drawing.Point(8, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 148);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "If a setup video is available...";
            // 
            // AutoPlayRadio
            // 
            this.AutoPlayRadio.AutoSize = true;
            this.AutoPlayRadio.Checked = true;
            this.AutoPlayRadio.Location = new System.Drawing.Point(6, 31);
            this.AutoPlayRadio.Name = "AutoPlayRadio";
            this.AutoPlayRadio.Size = new System.Drawing.Size(271, 17);
            this.AutoPlayRadio.TabIndex = 0;
            this.AutoPlayRadio.TabStop = true;
            this.AutoPlayRadio.Text = "Play it automatically when the part program is loaded";
            this.AutoPlayRadio.UseVisualStyleBackColor = true;
            // 
            // PromptPlayRadio
            // 
            this.PromptPlayRadio.AutoSize = true;
            this.PromptPlayRadio.Location = new System.Drawing.Point(6, 73);
            this.PromptPlayRadio.Name = "PromptPlayRadio";
            this.PromptPlayRadio.Size = new System.Drawing.Size(280, 17);
            this.PromptPlayRadio.TabIndex = 1;
            this.PromptPlayRadio.Text = "Ask whether to play it when the part program is loaded";
            this.PromptPlayRadio.UseVisualStyleBackColor = true;
            // 
            // NoPlayRadio
            // 
            this.NoPlayRadio.AutoSize = true;
            this.NoPlayRadio.Location = new System.Drawing.Point(6, 115);
            this.NoPlayRadio.Name = "NoPlayRadio";
            this.NoPlayRadio.Size = new System.Drawing.Size(311, 17);
            this.NoPlayRadio.TabIndex = 2;
            this.NoPlayRadio.Text = "Do not play any setup video when the part program is loaded";
            this.NoPlayRadio.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AcceptButton = this.LoadButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 362);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Barcode Loader";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.tabControl1.ResumeLayout(false);
            this.BarcodePage.ResumeLayout(false);
            this.BarcodePage.PerformLayout();
            this.NonePanel.ResumeLayout(false);
            this.MultiplePanel.ResumeLayout(false);
            this.AdvancedPage.ResumeLayout(false);
            this.AdvancedPage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage BarcodePage;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.TextBox BarcodeTextBox;
        private System.Windows.Forms.TabPage AdvancedPage;
        private System.Windows.Forms.Panel PartProgramPanel;
        private System.Windows.Forms.Panel MultiplePanel;
        private System.Windows.Forms.Label MultipleLabel;
        private System.Windows.Forms.Panel NonePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CaseSensitiveCheckBox;
        private System.Windows.Forms.CheckBox AutoLoadCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton NoPlayRadio;
        private System.Windows.Forms.RadioButton PromptPlayRadio;
        private System.Windows.Forms.RadioButton AutoPlayRadio;
    }
}

