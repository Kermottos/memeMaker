namespace memeMaker
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.openButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bottomText = new System.Windows.Forms.TextBox();
            this.topText = new System.Windows.Forms.TextBox();
            this.bottomLabel = new System.Windows.Forms.Label();
            this.topLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.topMemeLabel = new System.Windows.Forms.Label();
            this.bottomMemeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(183, 386);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(528, 386);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bottomText);
            this.groupBox1.Controls.Add(this.topText);
            this.groupBox1.Controls.Add(this.bottomLabel);
            this.groupBox1.Controls.Add(this.topLabel);
            this.groupBox1.Location = new System.Drawing.Point(183, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 341);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit";
            // 
            // bottomText
            // 
            this.bottomText.Location = new System.Drawing.Point(6, 216);
            this.bottomText.Multiline = true;
            this.bottomText.Name = "bottomText";
            this.bottomText.Size = new System.Drawing.Size(247, 119);
            this.bottomText.TabIndex = 3;
            // 
            // topText
            // 
            this.topText.Location = new System.Drawing.Point(13, 45);
            this.topText.Multiline = true;
            this.topText.Name = "topText";
            this.topText.Size = new System.Drawing.Size(240, 122);
            this.topText.TabIndex = 2;
            // 
            // bottomLabel
            // 
            this.bottomLabel.AutoSize = true;
            this.bottomLabel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bottomLabel.Location = new System.Drawing.Point(10, 187);
            this.bottomLabel.Name = "bottomLabel";
            this.bottomLabel.Size = new System.Drawing.Size(112, 26);
            this.bottomLabel.TabIndex = 1;
            this.bottomLabel.Text = "Bottom Text";
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.topLabel.Location = new System.Drawing.Point(10, 16);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(83, 26);
            this.topLabel.TabIndex = 0;
            this.topLabel.Text = "Top Text";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(493, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 341);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // topMemeLabel
            // 
            this.topMemeLabel.AutoSize = true;
            this.topMemeLabel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.topMemeLabel.ForeColor = System.Drawing.Color.White;
            this.topMemeLabel.Location = new System.Drawing.Point(490, 55);
            this.topMemeLabel.Name = "topMemeLabel";
            this.topMemeLabel.Size = new System.Drawing.Size(63, 26);
            this.topMemeLabel.TabIndex = 4;
            this.topMemeLabel.Text = "label1";
            this.topMemeLabel.TextChanged += new System.EventHandler(this.topMemeLabel_TextChanged);
            // 
            // bottomMemeLabel
            // 
            this.bottomMemeLabel.AutoSize = true;
            this.bottomMemeLabel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bottomMemeLabel.ForeColor = System.Drawing.Color.White;
            this.bottomMemeLabel.Location = new System.Drawing.Point(490, 237);
            this.bottomMemeLabel.Name = "bottomMemeLabel";
            this.bottomMemeLabel.Size = new System.Drawing.Size(66, 26);
            this.bottomMemeLabel.TabIndex = 5;
            this.bottomMemeLabel.Text = "label2";
            this.bottomMemeLabel.TextChanged += new System.EventHandler(this.bottomMemeLabel_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bottomMemeLabel);
            this.Controls.Add(this.topMemeLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox bottomText;
        private System.Windows.Forms.TextBox topText;
        private System.Windows.Forms.Label bottomLabel;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label topMemeLabel;
        private System.Windows.Forms.Label bottomMemeLabel;
    }
}

