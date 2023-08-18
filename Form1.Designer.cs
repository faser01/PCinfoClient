namespace PCinfoClient
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbIpAddress = new System.Windows.Forms.TextBox();
            this.tbResponse = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.btnGetUserInfo = new System.Windows.Forms.Button();
            this.btnGetDiskInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(124, 242);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(135, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Соединение";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbIpAddress
            // 
            this.tbIpAddress.Location = new System.Drawing.Point(124, 136);
            this.tbIpAddress.Name = "tbIpAddress";
            this.tbIpAddress.Size = new System.Drawing.Size(120, 20);
            this.tbIpAddress.TabIndex = 1;
            // 
            // tbResponse
            // 
            this.tbResponse.Location = new System.Drawing.Point(309, 136);
            this.tbResponse.Multiline = true;
            this.tbResponse.Name = "tbResponse";
            this.tbResponse.Size = new System.Drawing.Size(403, 161);
            this.tbResponse.TabIndex = 4;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(124, 181);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(120, 20);
            this.tbPort.TabIndex = 5;
            // 
            // btnGetUserInfo
            // 
            this.btnGetUserInfo.Location = new System.Drawing.Point(354, 322);
            this.btnGetUserInfo.Name = "btnGetUserInfo";
            this.btnGetUserInfo.Size = new System.Drawing.Size(139, 23);
            this.btnGetUserInfo.TabIndex = 6;
            this.btnGetUserInfo.Text = "user_info";
            this.btnGetUserInfo.UseVisualStyleBackColor = true;
            this.btnGetUserInfo.Click += new System.EventHandler(this.btnGetUserInfo_Click);
            // 
            // btnGetDiskInfo
            // 
            this.btnGetDiskInfo.Location = new System.Drawing.Point(527, 322);
            this.btnGetDiskInfo.Name = "btnGetDiskInfo";
            this.btnGetDiskInfo.Size = new System.Drawing.Size(145, 23);
            this.btnGetDiskInfo.TabIndex = 7;
            this.btnGetDiskInfo.Text = "disk_info";
            this.btnGetDiskInfo.UseVisualStyleBackColor = true;
            this.btnGetDiskInfo.Click += new System.EventHandler(this.btnGetDiskInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите IP адрес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Введите порт";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetDiskInfo);
            this.Controls.Add(this.btnGetUserInfo);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbResponse);
            this.Controls.Add(this.tbIpAddress);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbIpAddress;
        private System.Windows.Forms.TextBox tbResponse;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Button btnGetUserInfo;
        private System.Windows.Forms.Button btnGetDiskInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

