namespace HomeWork_PokemonsForm
{
    partial class Form1
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.numLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.numTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(14, 91);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(172, 19);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "請輸入Pokemon名稱";
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Location = new System.Drawing.Point(14, 37);
            this.numLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(172, 19);
            this.numLabel.TabIndex = 1;
            this.numLabel.Text = "請輸入Pokemon編號";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(14, 145);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(172, 19);
            this.categoryLabel.TabIndex = 2;
            this.categoryLabel.Text = "請輸入Pokemon種類";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(14, 201);
            this.heightLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(172, 19);
            this.heightLabel.TabIndex = 3;
            this.heightLabel.Text = "請輸入Pokemon高度";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(14, 256);
            this.weightLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(172, 19);
            this.weightLabel.TabIndex = 4;
            this.weightLabel.Text = "請輸入Pokemon重量";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(14, 306);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(104, 19);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.Text = "等待輸入中";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(214, 88);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(224, 30);
            this.nameTextBox.TabIndex = 6;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // numTextBox
            // 
            this.numTextBox.Location = new System.Drawing.Point(214, 34);
            this.numTextBox.Name = "numTextBox";
            this.numTextBox.Size = new System.Drawing.Size(224, 30);
            this.numTextBox.TabIndex = 7;
            this.numTextBox.TextChanged += new System.EventHandler(this.numTextBox_TextChanged);
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(214, 145);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(224, 30);
            this.categoryTextBox.TabIndex = 8;
            this.categoryTextBox.TextChanged += new System.EventHandler(this.categoryTextBox_TextChanged);
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(214, 201);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(224, 30);
            this.heightTextBox.TabIndex = 9;
            this.heightTextBox.TextChanged += new System.EventHandler(this.heightTextBox_TextChanged);
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(214, 256);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(224, 30);
            this.weightTextBox.TabIndex = 10;
            this.weightTextBox.TextChanged += new System.EventHandler(this.weightTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 383);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(this.numTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.numLabel);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("新細明體", 14F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox numTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
    }
}

