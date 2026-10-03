namespace MasFuncional3
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
            btnfunc = new Button();
            btnAct = new Button();
            btnPred = new Button();
            SuspendLayout();
            // 
            // btnfunc
            // 
            btnfunc.Location = new Point(48, 38);
            btnfunc.Name = "btnfunc";
            btnfunc.Size = new Size(144, 100);
            btnfunc.TabIndex = 0;
            btnfunc.Text = "Func";
            btnfunc.UseVisualStyleBackColor = true;
            btnfunc.Click += btnfunc_Click;
            // 
            // btnAct
            // 
            btnAct.Location = new Point(48, 188);
            btnAct.Name = "btnAct";
            btnAct.Size = new Size(144, 107);
            btnAct.TabIndex = 1;
            btnAct.Text = "Action";
            btnAct.UseVisualStyleBackColor = true;
            btnAct.Click += btnAct_Click;
            // 
            // btnPred
            // 
            btnPred.Location = new Point(48, 331);
            btnPred.Name = "btnPred";
            btnPred.Size = new Size(144, 107);
            btnPred.TabIndex = 2;
            btnPred.Text = "Predicate";
            btnPred.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPred);
            Controls.Add(btnAct);
            Controls.Add(btnfunc);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnfunc;
        private Button btnAct;
        private Button btnPred;
    }
}
