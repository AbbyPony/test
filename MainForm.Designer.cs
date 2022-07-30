namespace _01PLC通讯模拟
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
            this.txt_PLCAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Write = new System.Windows.Forms.TextBox();
            this.Btn_Write = new System.Windows.Forms.Button();
            this.Txt_Read = new System.Windows.Forms.TextBox();
            this.Txt_PLCReadAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Read = new System.Windows.Forms.Button();
            this.Btn_Connect = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_DataParams = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DataItemRe = new System.Windows.Forms.TextBox();
            this.txt_DataItem = new System.Windows.Forms.TextBox();
            this.txt_DataResultCode = new System.Windows.Forms.TextBox();
            this.txt_DataResult = new System.Windows.Forms.TextBox();
            this.txt_JsonCode = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_PLCAddress
            // 
            this.txt_PLCAddress.Location = new System.Drawing.Point(198, 26);
            this.txt_PLCAddress.Name = "txt_PLCAddress";
            this.txt_PLCAddress.Size = new System.Drawing.Size(353, 28);
            this.txt_PLCAddress.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "PLC写入地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "写入值：";
            // 
            // Txt_Write
            // 
            this.Txt_Write.Location = new System.Drawing.Point(198, 94);
            this.Txt_Write.Name = "Txt_Write";
            this.Txt_Write.Size = new System.Drawing.Size(353, 28);
            this.Txt_Write.TabIndex = 3;
            // 
            // Btn_Write
            // 
            this.Btn_Write.Location = new System.Drawing.Point(624, 50);
            this.Btn_Write.Name = "Btn_Write";
            this.Btn_Write.Size = new System.Drawing.Size(105, 54);
            this.Btn_Write.TabIndex = 4;
            this.Btn_Write.Text = "写入";
            this.Btn_Write.UseVisualStyleBackColor = true;
            this.Btn_Write.Click += new System.EventHandler(this.Btn_Write_Click);
            // 
            // Txt_Read
            // 
            this.Txt_Read.Location = new System.Drawing.Point(198, 204);
            this.Txt_Read.Name = "Txt_Read";
            this.Txt_Read.Size = new System.Drawing.Size(353, 28);
            this.Txt_Read.TabIndex = 5;
            // 
            // Txt_PLCReadAdd
            // 
            this.Txt_PLCReadAdd.Location = new System.Drawing.Point(198, 145);
            this.Txt_PLCReadAdd.Name = "Txt_PLCReadAdd";
            this.Txt_PLCReadAdd.Size = new System.Drawing.Size(353, 28);
            this.Txt_PLCReadAdd.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "读取值：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "PLC读取地址：";
            // 
            // Btn_Read
            // 
            this.Btn_Read.Location = new System.Drawing.Point(624, 164);
            this.Btn_Read.Name = "Btn_Read";
            this.Btn_Read.Size = new System.Drawing.Size(105, 54);
            this.Btn_Read.TabIndex = 9;
            this.Btn_Read.Text = "读取";
            this.Btn_Read.UseVisualStyleBackColor = true;
            this.Btn_Read.Click += new System.EventHandler(this.Btn_Read_Click);
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.Location = new System.Drawing.Point(827, 148);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.Size = new System.Drawing.Size(105, 54);
            this.Btn_Connect.TabIndex = 10;
            this.Btn_Connect.Text = "连接PLC";
            this.Btn_Connect.UseVisualStyleBackColor = true;
            this.Btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(827, 46);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(105, 58);
            this.Btn_Exit.TabIndex = 11;
            this.Btn_Exit.Text = "退出键";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_DataParams);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_DataItemRe);
            this.groupBox1.Controls.Add(this.txt_DataItem);
            this.groupBox1.Controls.Add(this.txt_DataResultCode);
            this.groupBox1.Controls.Add(this.txt_DataResult);
            this.groupBox1.Controls.Add(this.txt_JsonCode);
            this.groupBox1.Location = new System.Drawing.Point(106, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 222);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Json字符接收";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(393, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "params:";
            // 
            // txt_DataParams
            // 
            this.txt_DataParams.Location = new System.Drawing.Point(470, 160);
            this.txt_DataParams.Name = "txt_DataParams";
            this.txt_DataParams.Size = new System.Drawing.Size(179, 28);
            this.txt_DataParams.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(339, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "itemRevision:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(411, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "item:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "resultcode:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "result:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "code:";
            // 
            // txt_DataItemRe
            // 
            this.txt_DataItemRe.Location = new System.Drawing.Point(470, 105);
            this.txt_DataItemRe.Name = "txt_DataItemRe";
            this.txt_DataItemRe.Size = new System.Drawing.Size(179, 28);
            this.txt_DataItemRe.TabIndex = 10;
            // 
            // txt_DataItem
            // 
            this.txt_DataItem.Location = new System.Drawing.Point(470, 57);
            this.txt_DataItem.Name = "txt_DataItem";
            this.txt_DataItem.Size = new System.Drawing.Size(179, 28);
            this.txt_DataItem.TabIndex = 9;
            // 
            // txt_DataResultCode
            // 
            this.txt_DataResultCode.Location = new System.Drawing.Point(131, 160);
            this.txt_DataResultCode.Name = "txt_DataResultCode";
            this.txt_DataResultCode.Size = new System.Drawing.Size(179, 28);
            this.txt_DataResultCode.TabIndex = 8;
            // 
            // txt_DataResult
            // 
            this.txt_DataResult.Location = new System.Drawing.Point(131, 105);
            this.txt_DataResult.Name = "txt_DataResult";
            this.txt_DataResult.Size = new System.Drawing.Size(179, 28);
            this.txt_DataResult.TabIndex = 7;
            // 
            // txt_JsonCode
            // 
            this.txt_JsonCode.Location = new System.Drawing.Point(131, 57);
            this.txt_JsonCode.Name = "txt_JsonCode";
            this.txt_JsonCode.Size = new System.Drawing.Size(179, 28);
            this.txt_JsonCode.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 599);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Connect);
            this.Controls.Add(this.Btn_Read);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_PLCReadAdd);
            this.Controls.Add(this.Txt_Read);
            this.Controls.Add(this.Btn_Write);
            this.Controls.Add(this.Txt_Write);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_PLCAddress);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_PLCAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Write;
        private System.Windows.Forms.Button Btn_Write;
        private System.Windows.Forms.TextBox Txt_Read;
        private System.Windows.Forms.TextBox Txt_PLCReadAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Read;
        private System.Windows.Forms.Button Btn_Connect;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_JsonCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_DataItemRe;
        private System.Windows.Forms.TextBox txt_DataItem;
        private System.Windows.Forms.TextBox txt_DataResultCode;
        private System.Windows.Forms.TextBox txt_DataResult;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_DataParams;
    }
}