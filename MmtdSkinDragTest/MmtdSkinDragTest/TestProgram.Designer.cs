namespace MmtdSkinDragTest
{
    partial class TestProgram
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestProgram));
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.labelGuide = new System.Windows.Forms.Label();
            this.labelOrder = new System.Windows.Forms.Label();
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
            this.buttonUp.TabIndex = 0;
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
            this.buttonPlay.TabIndex = 1;
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
            this.buttonDown.TabIndex = 2;
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
            this.labelGuide.Size = new System.Drawing.Size(209, 44);
            this.labelGuide.TabIndex = 3;
            this.labelGuide.Text = "Click Play";
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Font = new System.Drawing.Font("경기천년제목 Light", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelOrder.Location = new System.Drawing.Point(12, 781);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(140, 44);
            this.labelOrder.TabIndex = 4;
            this.labelOrder.Text = "1/100";
            // 
            // TestProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1016, 834);
            this.Controls.Add(this.labelOrder);
            this.Controls.Add(this.labelGuide);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonUp);
            this.Name = "TestProgram";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonDown;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label labelGuide;
        private System.Windows.Forms.Label labelOrder;
    }
}

