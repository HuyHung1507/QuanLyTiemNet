namespace QLMayTram
{
    partial class FrmGiaoTiep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiaoTiep));
            this.txtGui = new System.Windows.Forms.TextBox();
            this.btnGui = new System.Windows.Forms.Button();
            this.listvtn = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txtGui
            // 
            this.txtGui.Location = new System.Drawing.Point(3, 257);
            this.txtGui.Margin = new System.Windows.Forms.Padding(4);
            this.txtGui.Multiline = true;
            this.txtGui.Name = "txtGui";
            this.txtGui.Size = new System.Drawing.Size(405, 58);
            this.txtGui.TabIndex = 0;
            // 
            // btnGui
            // 
            this.btnGui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGui.Location = new System.Drawing.Point(419, 257);
            this.btnGui.Margin = new System.Windows.Forms.Padding(4);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(85, 59);
            this.btnGui.TabIndex = 2;
            this.btnGui.Text = "Send";
            this.btnGui.UseVisualStyleBackColor = true;
 //           this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // listvtn
            // 
            this.listvtn.Location = new System.Drawing.Point(3, 3);
            this.listvtn.Name = "listvtn";
            this.listvtn.Size = new System.Drawing.Size(501, 247);
            this.listvtn.TabIndex = 3;
            this.listvtn.UseCompatibleStateImageBehavior = false;
            this.listvtn.View = System.Windows.Forms.View.List;
            // 
            // FrmGiaoTiep
            // 
            this.AcceptButton = this.btnGui;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 319);
            this.Controls.Add(this.listvtn);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.txtGui);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGiaoTiep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat";
   //         this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmGiaoTiep_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtGui;
        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.ListView listvtn;
    }
}