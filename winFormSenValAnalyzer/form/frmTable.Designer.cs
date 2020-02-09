namespace winFormSenValAnalyzer.form
{
    partial class frmTable
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
            this.grvIMU_Raw = new System.Windows.Forms.DataGridView();
            this.btnInitSenData = new System.Windows.Forms.Button();
            this.btnStopSensing = new System.Windows.Forms.Button();
            this.btnReadSensing = new System.Windows.Forms.Button();
            this.grvIMU = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grvIMU_Raw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvIMU)).BeginInit();
            this.SuspendLayout();
            // 
            // grvIMU_Raw
            // 
            this.grvIMU_Raw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvIMU_Raw.Location = new System.Drawing.Point(12, 71);
            this.grvIMU_Raw.Name = "grvIMU_Raw";
            this.grvIMU_Raw.RowTemplate.Height = 23;
            this.grvIMU_Raw.Size = new System.Drawing.Size(455, 367);
            this.grvIMU_Raw.TabIndex = 32;
            this.grvIMU_Raw.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.grvIMU_Raw_RowsAdded);
            // 
            // btnInitSenData
            // 
            this.btnInitSenData.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInitSenData.Location = new System.Drawing.Point(115, 17);
            this.btnInitSenData.Name = "btnInitSenData";
            this.btnInitSenData.Size = new System.Drawing.Size(91, 46);
            this.btnInitSenData.TabIndex = 31;
            this.btnInitSenData.Text = "데이터초기화";
            this.btnInitSenData.UseVisualStyleBackColor = true;
            // 
            // btnStopSensing
            // 
            this.btnStopSensing.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStopSensing.Location = new System.Drawing.Point(209, 17);
            this.btnStopSensing.Name = "btnStopSensing";
            this.btnStopSensing.Size = new System.Drawing.Size(91, 46);
            this.btnStopSensing.TabIndex = 30;
            this.btnStopSensing.Text = "중지";
            this.btnStopSensing.UseVisualStyleBackColor = true;
            // 
            // btnReadSensing
            // 
            this.btnReadSensing.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReadSensing.Location = new System.Drawing.Point(19, 17);
            this.btnReadSensing.Name = "btnReadSensing";
            this.btnReadSensing.Size = new System.Drawing.Size(91, 46);
            this.btnReadSensing.TabIndex = 29;
            this.btnReadSensing.Text = "데이터읽기";
            this.btnReadSensing.UseVisualStyleBackColor = true;
            // 
            // grvIMU
            // 
            this.grvIMU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvIMU.Location = new System.Drawing.Point(473, 71);
            this.grvIMU.Name = "grvIMU";
            this.grvIMU.RowTemplate.Height = 23;
            this.grvIMU.Size = new System.Drawing.Size(455, 367);
            this.grvIMU.TabIndex = 33;
            // 
            // frmTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 450);
            this.Controls.Add(this.grvIMU);
            this.Controls.Add(this.grvIMU_Raw);
            this.Controls.Add(this.btnInitSenData);
            this.Controls.Add(this.btnStopSensing);
            this.Controls.Add(this.btnReadSensing);
            this.Name = "frmTable";
            this.Text = "frmTable";
            this.Load += new System.EventHandler(this.frmTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvIMU_Raw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvIMU)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grvIMU_Raw;
        private System.Windows.Forms.Button btnInitSenData;
        private System.Windows.Forms.Button btnStopSensing;
        private System.Windows.Forms.Button btnReadSensing;
        private System.Windows.Forms.DataGridView grvIMU;
    }
}