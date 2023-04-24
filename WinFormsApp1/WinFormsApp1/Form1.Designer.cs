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
            btnApagar = new Button();
            btnEncender = new Button();
            SuspendLayout();
            // 
            // btnApagar
            // 
            btnApagar.Location = new Point(78, 122);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(75, 23);
            btnApagar.TabIndex = 0;
            btnApagar.Text = "APAGAR";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // btnEncender
            // 
            btnEncender.Location = new Point(231, 122);
            btnEncender.Name = "btnEncender";
            btnEncender.Size = new Size(75, 23);
            btnEncender.TabIndex = 1;
            btnEncender.Text = "ENCENDER";
            btnEncender.UseVisualStyleBackColor = true;
            btnEncender.Click += btnEncender_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 328);
            Controls.Add(btnEncender);
            Controls.Add(btnApagar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnApagar;
        private Button btnEncender;
    }
}