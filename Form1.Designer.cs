
namespace test_WinForm
{
    partial class Form1
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
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Submit2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "one",
            "two",
            "three",
            "four"});
            this.comboBox.Location = new System.Drawing.Point(409, 81);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(181, 24);
            this.comboBox.TabIndex = 0;
            this.comboBox.DropDown += new System.EventHandler(this.comboBox_DropDown);
            this.comboBox.TextChanged += new System.EventHandler(this.comboBox_TextChanged);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(351, 283);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(143, 58);
            this.btn_Submit.TabIndex = 1;
            this.btn_Submit.Text = "submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            // 
            // btn_Submit2
            // 
            this.btn_Submit2.Location = new System.Drawing.Point(530, 283);
            this.btn_Submit2.Name = "btn_Submit2";
            this.btn_Submit2.Size = new System.Drawing.Size(143, 58);
            this.btn_Submit2.TabIndex = 1;
            this.btn_Submit2.Text = "submit";
            this.btn_Submit2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1173, 659);
            this.Controls.Add(this.btn_Submit2);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.comboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Submit2;
    }
}

