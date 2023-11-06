namespace WinFormsApp1
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
            FolderBrowserDialog = new FolderBrowserDialog();
            DirectoryTextbox = new TextBox();
            SelectButtom = new Button();
            LabelTextbox = new Label();
            SuspendLayout();
            // 
            // DirectoryTextbox
            // 
            DirectoryTextbox.Location = new Point(12, 145);
            DirectoryTextbox.Name = "DirectoryTextbox";
            DirectoryTextbox.Size = new Size(611, 47);
            DirectoryTextbox.TabIndex = 0;
            // 
            // SelectButtom
            // 
            SelectButtom.Location = new Point(629, 145);
            SelectButtom.Name = "SelectButtom";
            SelectButtom.Size = new Size(162, 64);
            SelectButtom.TabIndex = 1;
            SelectButtom.Text = "Select";
            SelectButtom.UseVisualStyleBackColor = true;
            SelectButtom.Click += SelectButtom_Click;
            // 
            // LabelTextbox
            // 
            LabelTextbox.AutoSize = true;
            LabelTextbox.Location = new Point(12, 195);
            LabelTextbox.Name = "LabelTextbox";
            LabelTextbox.Size = new Size(226, 41);
            LabelTextbox.TabIndex = 2;
            LabelTextbox.Text = "Select Directory";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LabelTextbox);
            Controls.Add(SelectButtom);
            Controls.Add(DirectoryTextbox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FolderBrowserDialog FolderBrowserDialog;
        private TextBox DirectoryTextbox;
        private Button SelectButtom;
        private Label LabelTextbox;
    }
}