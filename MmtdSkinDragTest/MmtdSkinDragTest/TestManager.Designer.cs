namespace MmtdSkinDragTest
{
    partial class TestManager
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.buttonReset = new System.Windows.Forms.Button();
            this.comboBoxSerials = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxZpos = new System.Windows.Forms.TextBox();
            this.labelZpos = new System.Windows.Forms.Label();
            this.buttonCalibration = new System.Windows.Forms.Button();
            this.buttonPractice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(12, 12);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 0;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // comboBoxSerials
            // 
            this.comboBoxSerials.FormattingEnabled = true;
            this.comboBoxSerials.Location = new System.Drawing.Point(93, 13);
            this.comboBoxSerials.Name = "comboBoxSerials";
            this.comboBoxSerials.Size = new System.Drawing.Size(121, 23);
            this.comboBoxSerials.TabIndex = 1;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(220, 12);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(220, 101);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Skin drag",
            "Poke",
            "Skin stretch"});
            this.comboBoxType.Location = new System.Drawing.Point(93, 41);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 23);
            this.comboBoxType.TabIndex = 4;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(5, 44);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(82, 15);
            this.labelType.TabIndex = 5;
            this.labelType.Text = "Tactile type";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(42, 74);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(45, 15);
            this.labelId.TabIndex = 6;
            this.labelId.Text = "log ID";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(93, 70);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(121, 25);
            this.textBoxId.TabIndex = 7;
            // 
            // textBoxZpos
            // 
            this.textBoxZpos.Location = new System.Drawing.Point(93, 101);
            this.textBoxZpos.Name = "textBoxZpos";
            this.textBoxZpos.Size = new System.Drawing.Size(121, 25);
            this.textBoxZpos.TabIndex = 9;
            // 
            // labelZpos
            // 
            this.labelZpos.AutoSize = true;
            this.labelZpos.Location = new System.Drawing.Point(12, 105);
            this.labelZpos.Name = "labelZpos";
            this.labelZpos.Size = new System.Drawing.Size(75, 15);
            this.labelZpos.TabIndex = 8;
            this.labelZpos.Text = "Z Position";
            // 
            // buttonCalibration
            // 
            this.buttonCalibration.Location = new System.Drawing.Point(220, 40);
            this.buttonCalibration.Name = "buttonCalibration";
            this.buttonCalibration.Size = new System.Drawing.Size(75, 23);
            this.buttonCalibration.TabIndex = 10;
            this.buttonCalibration.Text = "Calib";
            this.buttonCalibration.UseVisualStyleBackColor = true;
            this.buttonCalibration.Click += new System.EventHandler(this.buttonCalibration_Click);
            // 
            // buttonPractice
            // 
            this.buttonPractice.Location = new System.Drawing.Point(220, 69);
            this.buttonPractice.Name = "buttonPractice";
            this.buttonPractice.Size = new System.Drawing.Size(75, 23);
            this.buttonPractice.TabIndex = 11;
            this.buttonPractice.Text = "Practice";
            this.buttonPractice.UseVisualStyleBackColor = true;
            this.buttonPractice.Click += new System.EventHandler(this.buttonPractice_Click);
            // 
            // TestManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 147);
            this.Controls.Add(this.buttonPractice);
            this.Controls.Add(this.buttonCalibration);
            this.Controls.Add(this.textBoxZpos);
            this.Controls.Add(this.labelZpos);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.comboBoxSerials);
            this.Controls.Add(this.buttonReset);
            this.Name = "TestManager";
            this.Text = "TestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ComboBox comboBoxSerials;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxZpos;
        private System.Windows.Forms.Label labelZpos;
        private System.Windows.Forms.Button buttonCalibration;
        private System.Windows.Forms.Button buttonPractice;
    }
}