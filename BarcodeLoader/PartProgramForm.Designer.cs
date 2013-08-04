namespace BarcodeLoader
{
    partial class PartProgramForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.BarcodeTextBox = new System.Windows.Forms.TextBox();
            this.ProgramFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ProgramLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NevermindButton = new System.Windows.Forms.Button();
            this.ProgramButton = new System.Windows.Forms.Button();
            this.ThumbnailButton = new System.Windows.Forms.Button();
            this.SetupButton = new System.Windows.Forms.Button();
            this.ThumbnailLabel = new System.Windows.Forms.Label();
            this.SetupLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.ScheduleProgramCheckBox = new System.Windows.Forms.CheckBox();
            this.ThumbnailFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SetupFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Barcode (hint: select this box and scan the barcode):";
            // 
            // BarcodeTextBox
            // 
            this.BarcodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BarcodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeTextBox.Location = new System.Drawing.Point(15, 25);
            this.BarcodeTextBox.Name = "BarcodeTextBox";
            this.BarcodeTextBox.Size = new System.Drawing.Size(511, 38);
            this.BarcodeTextBox.TabIndex = 2;
            this.BarcodeTextBox.Validating += BarcodeTextBox_Validating;
            // 
            // ProgramFileDialog
            // 
            this.ProgramFileDialog.DefaultExt = "MIN";
            this.ProgramFileDialog.Filter = "MIN Files (*.MIN)|*.MIN|All Files (*)|*";
            this.ProgramFileDialog.Title = "Choose a Part Program";
            // 
            // ProgramLabel
            // 
            this.ProgramLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgramLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProgramLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramLabel.Location = new System.Drawing.Point(178, 69);
            this.ProgramLabel.Name = "ProgramLabel";
            this.ProgramLabel.Size = new System.Drawing.Size(348, 52);
            this.ProgramLabel.TabIndex = 4;
            this.ProgramLabel.Text = "ABC.MIN";
            this.ProgramLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(532, 12);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(80, 52);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "&Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NevermindButton
            // 
            this.NevermindButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NevermindButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.NevermindButton.Location = new System.Drawing.Point(532, 70);
            this.NevermindButton.Name = "NevermindButton";
            this.NevermindButton.Size = new System.Drawing.Size(80, 52);
            this.NevermindButton.TabIndex = 6;
            this.NevermindButton.Text = "&Cancel";
            this.NevermindButton.UseVisualStyleBackColor = true;
            this.NevermindButton.Click += new System.EventHandler(this.NevermindButton_Click);
            // 
            // ProgramButton
            // 
            this.ProgramButton.Location = new System.Drawing.Point(12, 69);
            this.ProgramButton.Name = "ProgramButton";
            this.ProgramButton.Size = new System.Drawing.Size(160, 52);
            this.ProgramButton.TabIndex = 7;
            this.ProgramButton.Text = "Choose &Program...";
            this.ProgramButton.UseVisualStyleBackColor = true;
            this.ProgramButton.Click += new System.EventHandler(this.ProgramButton_Click);
            // 
            // ThumbnailButton
            // 
            this.ThumbnailButton.Location = new System.Drawing.Point(12, 127);
            this.ThumbnailButton.Name = "ThumbnailButton";
            this.ThumbnailButton.Size = new System.Drawing.Size(160, 52);
            this.ThumbnailButton.TabIndex = 8;
            this.ThumbnailButton.Text = "&Thumbnail Image...";
            this.ThumbnailButton.UseVisualStyleBackColor = true;
            this.ThumbnailButton.Click += new System.EventHandler(this.ThumbnailButton_Click);
            // 
            // SetupButton
            // 
            this.SetupButton.Location = new System.Drawing.Point(12, 185);
            this.SetupButton.Name = "SetupButton";
            this.SetupButton.Size = new System.Drawing.Size(160, 52);
            this.SetupButton.TabIndex = 9;
            this.SetupButton.Text = "Setup &File...";
            this.SetupButton.UseVisualStyleBackColor = true;
            this.SetupButton.Click += new System.EventHandler(this.SetupButton_Click);
            // 
            // ThumbnailLabel
            // 
            this.ThumbnailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ThumbnailLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThumbnailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThumbnailLabel.Location = new System.Drawing.Point(178, 127);
            this.ThumbnailLabel.Name = "ThumbnailLabel";
            this.ThumbnailLabel.Size = new System.Drawing.Size(348, 52);
            this.ThumbnailLabel.TabIndex = 10;
            this.ThumbnailLabel.Text = "ABC.MIN.PNG";
            this.ThumbnailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SetupLabel
            // 
            this.SetupLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SetupLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SetupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetupLabel.Location = new System.Drawing.Point(178, 185);
            this.SetupLabel.Name = "SetupLabel";
            this.SetupLabel.Size = new System.Drawing.Size(348, 52);
            this.SetupLabel.TabIndex = 11;
            this.SetupLabel.Text = "ABC.MIN.MPG";
            this.SetupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "&Description:";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(12, 266);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DescriptionTextBox.Size = new System.Drawing.Size(514, 83);
            this.DescriptionTextBox.TabIndex = 13;
            this.DescriptionTextBox.Validating += this.DescriptionTextBox_Validating;
            // 
            // ScheduleProgramCheckBox
            // 
            this.ScheduleProgramCheckBox.AutoSize = true;
            this.ScheduleProgramCheckBox.Location = new System.Drawing.Point(178, 246);
            this.ScheduleProgramCheckBox.Name = "ScheduleProgramCheckBox";
            this.ScheduleProgramCheckBox.Size = new System.Drawing.Size(152, 17);
            this.ScheduleProgramCheckBox.TabIndex = 14;
            this.ScheduleProgramCheckBox.Text = "This is a schedule program";
            this.ScheduleProgramCheckBox.UseVisualStyleBackColor = true;
            this.ScheduleProgramCheckBox.CheckedChanged += this.ScheduleProgramCheckBox_CheckedChanged;
            // 
            // ThumbnailFileDialog
            // 
            this.ThumbnailFileDialog.DefaultExt = "PNG";
            this.ThumbnailFileDialog.Filter = "PNG Files (*.PNG)|*.PNG|JPEG Files (*.JPG)|*.JPG|Bitmap Files (*.BMP)|*.BMP|All F" +
                "iles (*)|*";
            this.ThumbnailFileDialog.Title = "Choose a Thumbnail Image";
            // 
            // SetupFileDialog
            // 
            this.SetupFileDialog.Title = "Choose a Setup Video or File";
            // 
            // PartProgramForm
            // 
            this.AcceptButton = this.SaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.NevermindButton;
            this.ClientSize = new System.Drawing.Size(624, 361);
            this.Controls.Add(this.ScheduleProgramCheckBox);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SetupLabel);
            this.Controls.Add(this.ThumbnailLabel);
            this.Controls.Add(this.SetupButton);
            this.Controls.Add(this.ThumbnailButton);
            this.Controls.Add(this.ProgramButton);
            this.Controls.Add(this.NevermindButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ProgramLabel);
            this.Controls.Add(this.BarcodeTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PartProgramForm";
            this.Text = "Edit Part Program";
            this.Load += new System.EventHandler(this.PartProgramForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BarcodeTextBox;
        private System.Windows.Forms.OpenFileDialog ProgramFileDialog;
        private System.Windows.Forms.Label ProgramLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button NevermindButton;
        private System.Windows.Forms.Button ProgramButton;
        private System.Windows.Forms.Button ThumbnailButton;
        private System.Windows.Forms.Button SetupButton;
        private System.Windows.Forms.Label ThumbnailLabel;
        private System.Windows.Forms.Label SetupLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.CheckBox ScheduleProgramCheckBox;
        private System.Windows.Forms.OpenFileDialog ThumbnailFileDialog;
        private System.Windows.Forms.OpenFileDialog SetupFileDialog;
    }
}