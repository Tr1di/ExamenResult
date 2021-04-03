
namespace Examen
{
    partial class PredlojenieDialog
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
            this.predlList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newPredlButton = new System.Windows.Forms.Button();
            this.editPredlButton = new System.Windows.Forms.Button();
            this.deletePredlButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // predlList
            // 
            this.predlList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.predlList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.predlList.FormattingEnabled = true;
            this.predlList.ItemHeight = 14;
            this.predlList.Location = new System.Drawing.Point(10, 25);
            this.predlList.Name = "predlList";
            this.predlList.Size = new System.Drawing.Size(204, 382);
            this.predlList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Предложения";
            // 
            // newPredlButton
            // 
            this.newPredlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.newPredlButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.newPredlButton.Location = new System.Drawing.Point(219, 25);
            this.newPredlButton.Name = "newPredlButton";
            this.newPredlButton.Size = new System.Drawing.Size(160, 21);
            this.newPredlButton.TabIndex = 2;
            this.newPredlButton.Text = "Новое предложение";
            this.newPredlButton.UseVisualStyleBackColor = false;
            this.newPredlButton.Click += new System.EventHandler(this.newPredlButton_Click);
            // 
            // editPredlButton
            // 
            this.editPredlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.editPredlButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.editPredlButton.Location = new System.Drawing.Point(219, 52);
            this.editPredlButton.Name = "editPredlButton";
            this.editPredlButton.Size = new System.Drawing.Size(160, 21);
            this.editPredlButton.TabIndex = 3;
            this.editPredlButton.Text = "Редактировать предложение";
            this.editPredlButton.UseVisualStyleBackColor = false;
            this.editPredlButton.Click += new System.EventHandler(this.editPredlButton_Click);
            // 
            // deletePredlButton
            // 
            this.deletePredlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.deletePredlButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.deletePredlButton.Location = new System.Drawing.Point(219, 79);
            this.deletePredlButton.Name = "deletePredlButton";
            this.deletePredlButton.Size = new System.Drawing.Size(160, 21);
            this.deletePredlButton.TabIndex = 4;
            this.deletePredlButton.Text = "Удалить предложение";
            this.deletePredlButton.UseVisualStyleBackColor = false;
            this.deletePredlButton.Click += new System.EventHandler(this.deletePredlButton_Click);
            // 
            // PredlojenieDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(386, 416);
            this.Controls.Add(this.deletePredlButton);
            this.Controls.Add(this.editPredlButton);
            this.Controls.Add(this.newPredlButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.predlList);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PredlojenieDialog";
            this.Text = "PredlojenieDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox predlList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newPredlButton;
        private System.Windows.Forms.Button editPredlButton;
        private System.Windows.Forms.Button deletePredlButton;
    }
}