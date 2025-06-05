namespace sifra
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            EncryptButton = new Button();
            DecryptButton = new Button();
            ABox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Bbox = new TextBox();
            toolTip1 = new ToolTip(components);
            EncryptText = new TextBox();
            label3 = new Label();
            EncryptFinishText = new Label();
            label5 = new Label();
            DecryptText = new TextBox();
            DecryptFinishText = new Label();
            Pozadi = new PictureBox();
            panel1 = new Panel();
            CopyDecrypted = new Button();
            CopyEncrypted = new Button();
            WarningLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)Pozadi).BeginInit();
            SuspendLayout();
            // 
            // EncryptButton
            // 
            EncryptButton.BackColor = Color.Black;
            EncryptButton.FlatAppearance.BorderColor = Color.Green;
            EncryptButton.FlatAppearance.MouseDownBackColor = Color.White;
            EncryptButton.FlatAppearance.MouseOverBackColor = Color.Lime;
            EncryptButton.FlatStyle = FlatStyle.Flat;
            EncryptButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            EncryptButton.ForeColor = Color.White;
            EncryptButton.Location = new Point(180, 27);
            EncryptButton.Name = "EncryptButton";
            EncryptButton.Size = new Size(75, 28);
            EncryptButton.TabIndex = 0;
            EncryptButton.Text = "Encrypt";
            EncryptButton.UseVisualStyleBackColor = false;
            EncryptButton.Click += EncryptButton_Click;
            // 
            // DecryptButton
            // 
            DecryptButton.BackColor = Color.Black;
            DecryptButton.FlatAppearance.BorderColor = Color.Green;
            DecryptButton.FlatAppearance.MouseDownBackColor = Color.White;
            DecryptButton.FlatAppearance.MouseOverBackColor = Color.Lime;
            DecryptButton.FlatStyle = FlatStyle.Flat;
            DecryptButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            DecryptButton.ForeColor = Color.White;
            DecryptButton.Location = new Point(180, 73);
            DecryptButton.Name = "DecryptButton";
            DecryptButton.Size = new Size(75, 28);
            DecryptButton.TabIndex = 1;
            DecryptButton.Text = "Decrypt";
            DecryptButton.UseVisualStyleBackColor = false;
            DecryptButton.Click += DecryptButton_Click;
            // 
            // ABox
            // 
            ABox.BackColor = Color.Black;
            ABox.BorderStyle = BorderStyle.FixedSingle;
            ABox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ABox.ForeColor = Color.White;
            ABox.Location = new Point(70, 26);
            ABox.Name = "ABox";
            ABox.Size = new Size(82, 29);
            ABox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 73);
            label1.Name = "label1";
            label1.Size = new Size(45, 28);
            label1.TabIndex = 3;
            label1.Text = "B =";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 27);
            label2.Name = "label2";
            label2.Size = new Size(46, 28);
            label2.TabIndex = 4;
            label2.Text = "A =";
            // 
            // Bbox
            // 
            Bbox.BackColor = Color.Black;
            Bbox.BorderStyle = BorderStyle.FixedSingle;
            Bbox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Bbox.ForeColor = Color.White;
            Bbox.Location = new Point(70, 73);
            Bbox.Name = "Bbox";
            Bbox.Size = new Size(82, 29);
            Bbox.TabIndex = 5;
            // 
            // EncryptText
            // 
            EncryptText.BackColor = Color.Black;
            EncryptText.BorderStyle = BorderStyle.FixedSingle;
            EncryptText.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            EncryptText.ForeColor = Color.White;
            EncryptText.Location = new Point(306, 25);
            EncryptText.Name = "EncryptText";
            EncryptText.Size = new Size(429, 27);
            EncryptText.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(306, 9);
            label3.Name = "label3";
            label3.Size = new Size(152, 15);
            label3.TabIndex = 7;
            label3.Text = "Zadejte text pro šiftování:";
            // 
            // EncryptFinishText
            // 
            EncryptFinishText.AutoSize = true;
            EncryptFinishText.BackColor = SystemColors.ActiveCaptionText;
            EncryptFinishText.BorderStyle = BorderStyle.FixedSingle;
            EncryptFinishText.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            EncryptFinishText.ForeColor = Color.White;
            EncryptFinishText.Location = new Point(12, 158);
            EncryptFinishText.Name = "EncryptFinishText";
            EncryptFinishText.Size = new Size(129, 22);
            EncryptFinishText.TabIndex = 8;
            EncryptFinishText.Text = "Zašifrovaný text:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(306, 55);
            label5.Name = "label5";
            label5.Size = new Size(166, 15);
            label5.TabIndex = 9;
            label5.Text = "Zadejte text pro dešifrování:";
            // 
            // DecryptText
            // 
            DecryptText.BackColor = Color.Black;
            DecryptText.BorderStyle = BorderStyle.FixedSingle;
            DecryptText.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            DecryptText.ForeColor = Color.White;
            DecryptText.Location = new Point(306, 73);
            DecryptText.Name = "DecryptText";
            DecryptText.Size = new Size(429, 27);
            DecryptText.TabIndex = 10;
            // 
            // DecryptFinishText
            // 
            DecryptFinishText.AutoSize = true;
            DecryptFinishText.BackColor = SystemColors.ActiveCaptionText;
            DecryptFinishText.BorderStyle = BorderStyle.FixedSingle;
            DecryptFinishText.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            DecryptFinishText.ForeColor = Color.White;
            DecryptFinishText.Location = new Point(10, 208);
            DecryptFinishText.Name = "DecryptFinishText";
            DecryptFinishText.Size = new Size(131, 22);
            DecryptFinishText.TabIndex = 11;
            DecryptFinishText.Text = "Dešifrovaný text:";
            // 
            // Pozadi
            // 
            Pozadi.Dock = DockStyle.Fill;
            Pozadi.Image = (Image)resources.GetObject("Pozadi.Image");
            Pozadi.Location = new Point(0, 0);
            Pozadi.Name = "Pozadi";
            Pozadi.Size = new Size(800, 450);
            Pozadi.SizeMode = PictureBoxSizeMode.StretchImage;
            Pozadi.TabIndex = 12;
            Pozadi.TabStop = false;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 450);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 0);
            panel1.TabIndex = 13;
            // 
            // CopyDecrypted
            // 
            CopyDecrypted.BackColor = Color.Black;
            CopyDecrypted.Cursor = Cursors.Hand;
            CopyDecrypted.FlatAppearance.BorderColor = Color.Green;
            CopyDecrypted.FlatAppearance.MouseDownBackColor = Color.White;
            CopyDecrypted.FlatAppearance.MouseOverBackColor = Color.Lime;
            CopyDecrypted.FlatStyle = FlatStyle.Flat;
            CopyDecrypted.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CopyDecrypted.ForeColor = Color.White;
            CopyDecrypted.Location = new Point(12, 284);
            CopyDecrypted.Name = "CopyDecrypted";
            CopyDecrypted.Size = new Size(143, 23);
            CopyDecrypted.TabIndex = 15;
            CopyDecrypted.Text = "Kopírovat Dešifrofaný";
            CopyDecrypted.UseVisualStyleBackColor = false;
            CopyDecrypted.Click += CopyDecrypted_Click;
            // 
            // CopyEncrypted
            // 
            CopyEncrypted.BackColor = Color.Black;
            CopyEncrypted.Cursor = Cursors.Hand;
            CopyEncrypted.FlatAppearance.BorderColor = Color.Green;
            CopyEncrypted.FlatAppearance.MouseDownBackColor = Color.White;
            CopyEncrypted.FlatAppearance.MouseOverBackColor = Color.Lime;
            CopyEncrypted.FlatStyle = FlatStyle.Flat;
            CopyEncrypted.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CopyEncrypted.ForeColor = Color.White;
            CopyEncrypted.Location = new Point(12, 255);
            CopyEncrypted.Name = "CopyEncrypted";
            CopyEncrypted.Size = new Size(143, 23);
            CopyEncrypted.TabIndex = 16;
            CopyEncrypted.Text = "Kopírovat Zašifrovaný";
            CopyEncrypted.UseVisualStyleBackColor = false;
            CopyEncrypted.Click += CopyEncrypted_Click;
            // 
            // WarningLabel
            // 
            WarningLabel.AutoSize = true;
            WarningLabel.BackColor = Color.Black;
            WarningLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            WarningLabel.ForeColor = Color.Lime;
            WarningLabel.Location = new Point(30, 401);
            WarningLabel.Name = "WarningLabel";
            WarningLabel.Size = new Size(0, 15);
            WarningLabel.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(WarningLabel);
            Controls.Add(CopyEncrypted);
            Controls.Add(CopyDecrypted);
            Controls.Add(DecryptFinishText);
            Controls.Add(panel1);
            Controls.Add(DecryptText);
            Controls.Add(label5);
            Controls.Add(EncryptFinishText);
            Controls.Add(label3);
            Controls.Add(EncryptText);
            Controls.Add(Bbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ABox);
            Controls.Add(DecryptButton);
            Controls.Add(EncryptButton);
            Controls.Add(Pozadi);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Pozadi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EncryptButton;
        private Button DecryptButton;
        private TextBox ABox;
        private Label label1;
        private Label label2;
        private TextBox Bbox;
        private ToolTip toolTip1;
        private TextBox EncryptText;
        private Label label3;
        private Label EncryptFinishText;
        private Label label5;
        private TextBox DecryptText;
        private Label DecryptFinishText;
        private PictureBox Pozadi;
        private Panel panel1;
        private Button CopyDecrypted;
        private Button CopyEncrypted;
        private Label WarningLabel;
    }
}