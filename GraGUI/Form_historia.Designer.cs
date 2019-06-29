namespace GraGUI
{
    partial class Form_historia
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
            this.listView_historia = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listView_historia
            // 
            this.listView_historia.GridLines = true;
            this.listView_historia.HideSelection = false;
            this.listView_historia.LabelEdit = true;
            this.listView_historia.Location = new System.Drawing.Point(0, 0);
            this.listView_historia.Name = "listView_historia";
            this.listView_historia.Size = new System.Drawing.Size(494, 553);
            this.listView_historia.TabIndex = 0;
            this.listView_historia.UseCompatibleStateImageBehavior = false;
            this.listView_historia.View = System.Windows.Forms.View.Details;
            this.listView_historia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView_historia_KeyDown);
            // 
            // Form_historia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 550);
            this.Controls.Add(this.listView_historia);
            this.Name = "Form_historia";
            this.Text = "Historia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_historia;
    }
}