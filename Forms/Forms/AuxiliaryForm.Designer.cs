
namespace Forms
{
    partial class AuxiliaryForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.questionButton = new System.Windows.Forms.Button();
            this.openButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.Location = new System.Drawing.Point(220, 338);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(157, 58);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // questionButton
            // 
            this.questionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionButton.Location = new System.Drawing.Point(220, 234);
            this.questionButton.Name = "questionButton";
            this.questionButton.Size = new System.Drawing.Size(157, 54);
            this.questionButton.TabIndex = 1;
            this.questionButton.Text = "Вопрос";
            this.questionButton.UseVisualStyleBackColor = true;
            this.questionButton.Click += new System.EventHandler(this.questionButton_Click);
            // 
            // openButon
            // 
            this.openButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openButon.Location = new System.Drawing.Point(220, 64);
            this.openButon.Name = "openButon";
            this.openButon.Size = new System.Drawing.Size(157, 105);
            this.openButon.TabIndex = 2;
            this.openButon.Text = "Открыть подчиненную форму";
            this.openButon.UseVisualStyleBackColor = true;
            this.openButon.Click += new System.EventHandler(this.openButon_Click);
            // 
            // AuxiliaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 450);
            this.Controls.Add(this.openButon);
            this.Controls.Add(this.questionButton);
            this.Controls.Add(this.closeButton);
            this.Name = "AuxiliaryForm";
            this.Text = "Впомогательное окно";
            this.Click += new System.EventHandler(this.questionButton_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button questionButton;
        private System.Windows.Forms.Button openButon;
    }
}