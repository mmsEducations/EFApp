namespace EFApp.FormUI
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
            this.buttonList = new System.Windows.Forms.Button();
            this.dataGridViewStudentList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonList
            // 
            this.buttonList.Location = new System.Drawing.Point(300, 22);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(204, 34);
            this.buttonList.TabIndex = 0;
            this.buttonList.Text = "Öğreencileri Listele";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // dataGridViewStudentList
            // 
            this.dataGridViewStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentList.Location = new System.Drawing.Point(62, 120);
            this.dataGridViewStudentList.Name = "dataGridViewStudentList";
            this.dataGridViewStudentList.RowHeadersWidth = 51;
            this.dataGridViewStudentList.RowTemplate.Height = 24;
            this.dataGridViewStudentList.Size = new System.Drawing.Size(793, 317);
            this.dataGridViewStudentList.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 486);
            this.Controls.Add(this.dataGridViewStudentList);
            this.Controls.Add(this.buttonList);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.DataGridView dataGridViewStudentList;
    }
}

