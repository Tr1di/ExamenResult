
namespace Examen
{
    partial class EditPredlDialog
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
            this.client = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rieltor = new System.Windows.Forms.ComboBox();
            this.Недвижимость = new System.Windows.Forms.Label();
            this.nedvij = new System.Windows.Forms.ComboBox();
            this.price = new System.Windows.Forms.NumericUpDown();
            this.priceLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.sdelka = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
            this.SuspendLayout();
            // 
            // client
            // 
            this.client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.client.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.client.FormattingEnabled = true;
            this.client.Location = new System.Drawing.Point(10, 25);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(104, 22);
            this.client.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Клиент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Риэлтор";
            // 
            // rieltor
            // 
            this.rieltor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.rieltor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.rieltor.FormattingEnabled = true;
            this.rieltor.Location = new System.Drawing.Point(119, 25);
            this.rieltor.Name = "rieltor";
            this.rieltor.Size = new System.Drawing.Size(104, 22);
            this.rieltor.TabIndex = 2;
            // 
            // Недвижимость
            // 
            this.Недвижимость.AutoSize = true;
            this.Недвижимость.Location = new System.Drawing.Point(228, 8);
            this.Недвижимость.Name = "Недвижимость";
            this.Недвижимость.Size = new System.Drawing.Size(86, 14);
            this.Недвижимость.TabIndex = 5;
            this.Недвижимость.Text = "Недвижимость";
            // 
            // nedvij
            // 
            this.nedvij.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.nedvij.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.nedvij.FormattingEnabled = true;
            this.nedvij.Location = new System.Drawing.Point(228, 25);
            this.nedvij.Name = "nedvij";
            this.nedvij.Size = new System.Drawing.Size(104, 22);
            this.nedvij.TabIndex = 4;
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.price.Location = new System.Drawing.Point(229, 66);
            this.price.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(103, 22);
            this.price.TabIndex = 6;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(228, 49);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(35, 14);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.Text = "Цена";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.button1.Location = new System.Drawing.Point(119, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 21);
            this.button1.TabIndex = 8;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.button2.Location = new System.Drawing.Point(228, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 21);
            this.button2.TabIndex = 9;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "Сделка";
            // 
            // sdelka
            // 
            this.sdelka.FormattingEnabled = true;
            this.sdelka.Location = new System.Drawing.Point(119, 66);
            this.sdelka.Name = "sdelka";
            this.sdelka.Size = new System.Drawing.Size(104, 22);
            this.sdelka.TabIndex = 12;
            // 
            // EditPredlDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(342, 124);
            this.Controls.Add(this.sdelka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.price);
            this.Controls.Add(this.Недвижимость);
            this.Controls.Add(this.nedvij);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rieltor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.client);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.Name = "EditPredlDialog";
            this.Text = "EditPredlDialog";
            this.Load += new System.EventHandler(this.EditPredlDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox client;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox rieltor;
        private System.Windows.Forms.Label Недвижимость;
        private System.Windows.Forms.ComboBox nedvij;
        private System.Windows.Forms.NumericUpDown price;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sdelka;
    }
}