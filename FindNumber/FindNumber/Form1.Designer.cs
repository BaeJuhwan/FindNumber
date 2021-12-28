namespace FindNumber
{
    partial class Form1
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
            this.buttoninput = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.buttonstart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttoninput
            // 
            this.buttoninput.Location = new System.Drawing.Point(436, 39);
            this.buttoninput.Name = "buttoninput";
            this.buttoninput.Size = new System.Drawing.Size(216, 25);
            this.buttoninput.TabIndex = 0;
            this.buttoninput.Text = "입력";
            this.buttoninput.UseVisualStyleBackColor = true;
            this.buttoninput.Click += new System.EventHandler(this.buttoninput_Click);
            // 
            // display
            // 
            this.display.Dock = System.Windows.Forms.DockStyle.Top;
            this.display.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.display.Location = new System.Drawing.Point(0, 0);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(800, 36);
            this.display.TabIndex = 1;
            this.display.Text = "게임을 시작합니다";
            this.display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(77, 39);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(183, 25);
            this.textBox.TabIndex = 2;
            // 
            // buttonstart
            // 
            this.buttonstart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonstart.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonstart.Location = new System.Drawing.Point(0, 406);
            this.buttonstart.Name = "buttonstart";
            this.buttonstart.Size = new System.Drawing.Size(800, 44);
            this.buttonstart.TabIndex = 3;
            this.buttonstart.Text = "게임 시작";
            this.buttonstart.UseVisualStyleBackColor = true;
            this.buttonstart.Click += new System.EventHandler(this.buttonstart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonstart);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.display);
            this.Controls.Add(this.buttoninput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttoninput;
        private System.Windows.Forms.Label display;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button buttonstart;
    }
}

