namespace LastTraining
{
    partial class Form2
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
            this.azukiButton = new System.Windows.Forms.RadioButton();
            this.custardButton = new System.Windows.Forms.RadioButton();
            this.kuriButton = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.foodGroup = new System.Windows.Forms.GroupBox();
            this.sizeGroup = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.ankoGroup = new System.Windows.Forms.GroupBox();
            this.koshiButton = new System.Windows.Forms.RadioButton();
            this.tsubuButton = new System.Windows.Forms.RadioButton();
            this.foodGroup.SuspendLayout();
            this.sizeGroup.SuspendLayout();
            this.ankoGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // azukiButton
            // 
            this.azukiButton.AutoSize = true;
            this.azukiButton.Location = new System.Drawing.Point(49, 33);
            this.azukiButton.Name = "azukiButton";
            this.azukiButton.Size = new System.Drawing.Size(52, 16);
            this.azukiButton.TabIndex = 0;
            this.azukiButton.TabStop = true;
            this.azukiButton.Text = "あずき";
            this.azukiButton.UseVisualStyleBackColor = true;
            this.azukiButton.CheckedChanged += new System.EventHandler(this.azukiButton_CheckedChanged);
            // 
            // custardButton
            // 
            this.custardButton.AutoSize = true;
            this.custardButton.Location = new System.Drawing.Point(49, 93);
            this.custardButton.Name = "custardButton";
            this.custardButton.Size = new System.Drawing.Size(68, 16);
            this.custardButton.TabIndex = 1;
            this.custardButton.TabStop = true;
            this.custardButton.Text = "カスタード";
            this.custardButton.UseVisualStyleBackColor = true;
            this.custardButton.CheckedChanged += new System.EventHandler(this.custardButton_CheckedChanged);
            // 
            // kuriButton
            // 
            this.kuriButton.AutoSize = true;
            this.kuriButton.Location = new System.Drawing.Point(49, 171);
            this.kuriButton.Name = "kuriButton";
            this.kuriButton.Size = new System.Drawing.Size(35, 16);
            this.kuriButton.TabIndex = 2;
            this.kuriButton.TabStop = true;
            this.kuriButton.Text = "栗";
            this.kuriButton.UseVisualStyleBackColor = true;
            this.kuriButton.CheckedChanged += new System.EventHandler(this.kuriButton_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(51, 33);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(47, 16);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "通常";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(51, 93);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(35, 16);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "大";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(51, 170);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(35, 16);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "小";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // foodGroup
            // 
            this.foodGroup.Controls.Add(this.kuriButton);
            this.foodGroup.Controls.Add(this.azukiButton);
            this.foodGroup.Controls.Add(this.custardButton);
            this.foodGroup.Location = new System.Drawing.Point(68, 71);
            this.foodGroup.Name = "foodGroup";
            this.foodGroup.Size = new System.Drawing.Size(200, 253);
            this.foodGroup.TabIndex = 6;
            this.foodGroup.TabStop = false;
            this.foodGroup.Text = "食べ物";
            // 
            // sizeGroup
            // 
            this.sizeGroup.Controls.Add(this.radioButton5);
            this.sizeGroup.Controls.Add(this.radioButton4);
            this.sizeGroup.Controls.Add(this.radioButton6);
            this.sizeGroup.Location = new System.Drawing.Point(336, 71);
            this.sizeGroup.Name = "sizeGroup";
            this.sizeGroup.Size = new System.Drawing.Size(200, 253);
            this.sizeGroup.TabIndex = 7;
            this.sizeGroup.TabStop = false;
            this.sizeGroup.Text = "サイズ";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(336, 389);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "キャンセル";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(440, 389);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 9;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // ankoGroup
            // 
            this.ankoGroup.Controls.Add(this.tsubuButton);
            this.ankoGroup.Controls.Add(this.koshiButton);
            this.ankoGroup.Location = new System.Drawing.Point(629, 83);
            this.ankoGroup.Name = "ankoGroup";
            this.ankoGroup.Size = new System.Drawing.Size(200, 241);
            this.ankoGroup.TabIndex = 10;
            this.ankoGroup.TabStop = false;
            this.ankoGroup.Text = "あんこ";
            // 
            // koshiButton
            // 
            this.koshiButton.AutoSize = true;
            this.koshiButton.Location = new System.Drawing.Point(45, 81);
            this.koshiButton.Name = "koshiButton";
            this.koshiButton.Size = new System.Drawing.Size(60, 16);
            this.koshiButton.TabIndex = 0;
            this.koshiButton.TabStop = true;
            this.koshiButton.Text = "こしあん";
            this.koshiButton.UseVisualStyleBackColor = true;
            // 
            // tsubuButton
            // 
            this.tsubuButton.AutoSize = true;
            this.tsubuButton.Location = new System.Drawing.Point(45, 131);
            this.tsubuButton.Name = "tsubuButton";
            this.tsubuButton.Size = new System.Drawing.Size(62, 16);
            this.tsubuButton.TabIndex = 1;
            this.tsubuButton.TabStop = true;
            this.tsubuButton.Text = "つぶあん";
            this.tsubuButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 448);
            this.Controls.Add(this.ankoGroup);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.sizeGroup);
            this.Controls.Add(this.foodGroup);
            this.Name = "Form2";
            this.Text = "Form2";
            this.foodGroup.ResumeLayout(false);
            this.foodGroup.PerformLayout();
            this.sizeGroup.ResumeLayout(false);
            this.sizeGroup.PerformLayout();
            this.ankoGroup.ResumeLayout(false);
            this.ankoGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton azukiButton;
        private System.Windows.Forms.RadioButton custardButton;
        private System.Windows.Forms.RadioButton kuriButton;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.GroupBox foodGroup;
        private System.Windows.Forms.GroupBox sizeGroup;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.GroupBox ankoGroup;
        private System.Windows.Forms.RadioButton tsubuButton;
        private System.Windows.Forms.RadioButton koshiButton;
    }
}