namespace winFormSenValAnalyzer.form
{
    partial class frmTestSetting
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
            this.rdbtnTestMode = new System.Windows.Forms.RadioButton();
            this.rdbtnNormalMode = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbtnTestMode
            // 
            this.rdbtnTestMode.AutoSize = true;
            this.rdbtnTestMode.Location = new System.Drawing.Point(11, 46);
            this.rdbtnTestMode.Name = "rdbtnTestMode";
            this.rdbtnTestMode.Size = new System.Drawing.Size(83, 16);
            this.rdbtnTestMode.TabIndex = 0;
            this.rdbtnTestMode.TabStop = true;
            this.rdbtnTestMode.Text = "테스트모드";
            this.rdbtnTestMode.UseVisualStyleBackColor = true;
            this.rdbtnTestMode.CheckedChanged += new System.EventHandler(this.rdbtnTestMode_CheckedChanged);
            // 
            // rdbtnNormalMode
            // 
            this.rdbtnNormalMode.AutoSize = true;
            this.rdbtnNormalMode.Location = new System.Drawing.Point(11, 22);
            this.rdbtnNormalMode.Name = "rdbtnNormalMode";
            this.rdbtnNormalMode.Size = new System.Drawing.Size(71, 16);
            this.rdbtnNormalMode.TabIndex = 1;
            this.rdbtnNormalMode.Text = "일반모드";
            this.rdbtnNormalMode.UseVisualStyleBackColor = true;
            this.rdbtnNormalMode.CheckedChanged += new System.EventHandler(this.rdbtnNormalMode_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtnNormalMode);
            this.groupBox1.Controls.Add(this.rdbtnTestMode);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 80);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "모드설정";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "확인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmTestSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(156, 167);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTestSetting";
            this.Text = "frmTestSetting";
            this.Load += new System.EventHandler(this.frmTestSetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbtnTestMode;
        private System.Windows.Forms.RadioButton rdbtnNormalMode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}