﻿namespace MyVieShowApp
{
    partial class MainWindow
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.selectNumberComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.summitButton = new System.Windows.Forms.Button();
            this.receiptRichTextBox = new System.Windows.Forms.RichTextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.nextSeatButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // selectNumberComboBox
            // 
            this.selectNumberComboBox.FormattingEnabled = true;
            this.selectNumberComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.selectNumberComboBox.Location = new System.Drawing.Point(569, 49);
            this.selectNumberComboBox.Name = "selectNumberComboBox";
            this.selectNumberComboBox.Size = new System.Drawing.Size(143, 20);
            this.selectNumberComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(565, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "請選擇購票張數:";
            // 
            // summitButton
            // 
            this.summitButton.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.summitButton.Location = new System.Drawing.Point(569, 85);
            this.summitButton.Name = "summitButton";
            this.summitButton.Size = new System.Drawing.Size(143, 30);
            this.summitButton.TabIndex = 2;
            this.summitButton.Text = "自動劃位";
            this.summitButton.UseVisualStyleBackColor = true;
            this.summitButton.Click += new System.EventHandler(this.summitButton_Click);
            // 
            // receiptRichTextBox
            // 
            this.receiptRichTextBox.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.receiptRichTextBox.Location = new System.Drawing.Point(569, 165);
            this.receiptRichTextBox.Name = "receiptRichTextBox";
            this.receiptRichTextBox.Size = new System.Drawing.Size(143, 157);
            this.receiptRichTextBox.TabIndex = 3;
            this.receiptRichTextBox.Text = "";
            // 
            // nextSeatButton
            // 
            this.nextSeatButton.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nextSeatButton.Location = new System.Drawing.Point(569, 122);
            this.nextSeatButton.Name = "nextSeatButton";
            this.nextSeatButton.Size = new System.Drawing.Size(143, 26);
            this.nextSeatButton.TabIndex = 4;
            this.nextSeatButton.Text = "下一組座位";
            this.nextSeatButton.UseVisualStyleBackColor = true;
            this.nextSeatButton.Click += new System.EventHandler(this.nextSeatButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(247, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 474);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nextSeatButton);
            this.Controls.Add(this.receiptRichTextBox);
            this.Controls.Add(this.summitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectNumberComboBox);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectNumberComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button summitButton;
        private System.Windows.Forms.RichTextBox receiptRichTextBox;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button nextSeatButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

