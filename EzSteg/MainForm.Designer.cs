namespace EzSteg {
    partial class EzSteg {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EzSteg));
            label1 = new Label();
            tbMessagePath = new TextBox();
            btnMessageSelect = new Button();
            label2 = new Label();
            rtbMessage = new RichTextBox();
            btnCoverSelect = new Button();
            tbCoverPath = new TextBox();
            label3 = new Label();
            btnOutputSelect = new Button();
            tbOutputPath = new TextBox();
            label4 = new Label();
            tabEncrypt = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabEncrypt.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(145, 23);
            label1.TabIndex = 0;
            label1.Text = "Message File (.txt)";
            // 
            // tbMessagePath
            // 
            tbMessagePath.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbMessagePath.Location = new Point(6, 54);
            tbMessagePath.Name = "tbMessagePath";
            tbMessagePath.ReadOnly = true;
            tbMessagePath.Size = new Size(696, 30);
            tbMessagePath.TabIndex = 1;
            // 
            // btnMessageSelect
            // 
            btnMessageSelect.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMessageSelect.Location = new Point(708, 54);
            btnMessageSelect.Name = "btnMessageSelect";
            btnMessageSelect.Size = new Size(57, 30);
            btnMessageSelect.TabIndex = 2;
            btnMessageSelect.Text = ". . .";
            btnMessageSelect.UseVisualStyleBackColor = true;
            btnMessageSelect.Click += btnFileSelect_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 97);
            label2.Name = "label2";
            label2.Size = new Size(113, 23);
            label2.TabIndex = 3;
            label2.Text = "Manual Input";
            // 
            // rtbMessage
            // 
            rtbMessage.Location = new Point(6, 123);
            rtbMessage.Name = "rtbMessage";
            rtbMessage.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbMessage.Size = new Size(759, 80);
            rtbMessage.TabIndex = 4;
            rtbMessage.Text = "";
            rtbMessage.TextChanged += rtbMessage_TextChanged;
            // 
            // btnCoverSelect
            // 
            btnCoverSelect.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCoverSelect.Location = new Point(708, 243);
            btnCoverSelect.Name = "btnCoverSelect";
            btnCoverSelect.Size = new Size(57, 30);
            btnCoverSelect.TabIndex = 7;
            btnCoverSelect.Text = ". . .";
            btnCoverSelect.UseVisualStyleBackColor = true;
            btnCoverSelect.Click += btnCoverSelect_Click;
            // 
            // tbCoverPath
            // 
            tbCoverPath.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCoverPath.Location = new Point(6, 243);
            tbCoverPath.Name = "tbCoverPath";
            tbCoverPath.ReadOnly = true;
            tbCoverPath.Size = new Size(696, 30);
            tbCoverPath.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 216);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 5;
            label3.Text = "Cover File";
            // 
            // btnOutputSelect
            // 
            btnOutputSelect.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOutputSelect.Location = new Point(708, 312);
            btnOutputSelect.Name = "btnOutputSelect";
            btnOutputSelect.Size = new Size(57, 30);
            btnOutputSelect.TabIndex = 10;
            btnOutputSelect.Text = ". . .";
            btnOutputSelect.UseVisualStyleBackColor = true;
            btnOutputSelect.Click += btnOutputSelect_Click;
            // 
            // tbOutputPath
            // 
            tbOutputPath.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbOutputPath.Location = new Point(6, 312);
            tbOutputPath.Name = "tbOutputPath";
            tbOutputPath.ReadOnly = true;
            tbOutputPath.Size = new Size(696, 30);
            tbOutputPath.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 286);
            label4.Name = "label4";
            label4.Size = new Size(95, 23);
            label4.TabIndex = 8;
            label4.Text = "Output File";
            // 
            // tabEncrypt
            // 
            tabEncrypt.Controls.Add(tabPage1);
            tabEncrypt.Controls.Add(tabPage2);
            tabEncrypt.Location = new Point(0, 0);
            tabEncrypt.Name = "tabEncrypt";
            tabEncrypt.SelectedIndex = 0;
            tabEncrypt.Size = new Size(779, 757);
            tabEncrypt.TabIndex = 12;
            tabEncrypt.Tag = "";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Control;
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btnOutputSelect);
            tabPage1.Controls.Add(tbMessagePath);
            tabPage1.Controls.Add(btnCoverSelect);
            tabPage1.Controls.Add(tbOutputPath);
            tabPage1.Controls.Add(btnMessageSelect);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(rtbMessage);
            tabPage1.Controls.Add(tbCoverPath);
            tabPage1.Controls.Add(label3);
            tabPage1.ForeColor = SystemColors.ControlText;
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(771, 724);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(771, 724);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // EzSteg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 757);
            Controls.Add(tabEncrypt);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EzSteg";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EzSteg";
            Load += Form1_Load;
            tabEncrypt.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox tbMessagePath;
        private Button btnMessageSelect;
        private Label label2;
        private RichTextBox rtbMessage;
        private Button btnCoverSelect;
        private TextBox tbCoverPath;
        private Label label3;
        private Button btnOutputSelect;
        private TextBox tbOutputPath;
        private Label label4;
        private TabControl tabEncrypt;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}
