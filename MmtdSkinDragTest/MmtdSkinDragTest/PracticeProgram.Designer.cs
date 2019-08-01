namespace MmtdSkinDragTest
{
    partial class PracticeProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PracticeProgram));
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.labelGuide = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // buttonUp
            // 
            this.buttonUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUp.BackgroundImage")));
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonUp.FlatAppearance.BorderSize = 0;
            this.buttonUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUp.Location = new System.Drawing.Point(399, 56);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(200, 200);
            this.buttonUp.TabIndex = 1;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            this.buttonUp.MouseEnter += new System.EventHandler(this.buttonUp_MouseEnter);
            this.buttonUp.MouseLeave += new System.EventHandler(this.buttonUp_MouseLeave);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPlay.BackgroundImage")));
            this.buttonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPlay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Location = new System.Drawing.Point(399, 312);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(200, 200);
            this.buttonPlay.TabIndex = 2;
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            this.buttonPlay.MouseEnter += new System.EventHandler(this.buttonPlay_MouseEnter);
            this.buttonPlay.MouseLeave += new System.EventHandler(this.buttonPlay_MouseLeave);
            // 
            // buttonDown
            // 
            this.buttonDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDown.BackgroundImage")));
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDown.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDown.FlatAppearance.BorderSize = 0;
            this.buttonDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDown.Location = new System.Drawing.Point(399, 578);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(200, 200);
            this.buttonDown.TabIndex = 3;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            this.buttonDown.MouseEnter += new System.EventHandler(this.buttonDown_MouseEnter);
            this.buttonDown.MouseLeave += new System.EventHandler(this.buttonDown_MouseLeave);
            // 
            // labelGuide
            // 
            this.labelGuide.AutoSize = true;
            this.labelGuide.Font = new System.Drawing.Font("경기천년제목 Light", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelGuide.Location = new System.Drawing.Point(12, 384);
            this.labelGuide.Name = "labelGuide";
            this.labelGuide.Size = new System.Drawing.Size(203, 43);
            this.labelGuide.TabIndex = 4;
            this.labelGuide.Text = "Click Play";
            // 
            // PracticeProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1016, 834);
            this.Controls.Add(this.labelGuide);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonUp);
            this.Name = "PracticeProgram";
            this.Text = "PracticeProgram";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Label labelGuide;
        private System.IO.Ports.SerialPort serialPort1;
    }
}