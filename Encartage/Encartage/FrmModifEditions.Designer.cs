namespace Encartage
{
    partial class FrmModifEditions
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
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblEdition = new System.Windows.Forms.Label();
            this.grpEditions = new System.Windows.Forms.GroupBox();
            this.cbx68 = new System.Windows.Forms.CheckBox();
            this.cbx67 = new System.Windows.Forms.CheckBox();
            this.btnResetEdit = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlTopBar.SuspendLayout();
            this.grpEditions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlTopBar.Controls.Add(this.lblEdition);
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(859, 40);
            this.pnlTopBar.TabIndex = 0;
            // 
            // lblEdition
            // 
            this.lblEdition.AutoSize = true;
            this.lblEdition.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdition.ForeColor = System.Drawing.Color.White;
            this.lblEdition.Location = new System.Drawing.Point(340, 10);
            this.lblEdition.Name = "lblEdition";
            this.lblEdition.Size = new System.Drawing.Size(179, 24);
            this.lblEdition.TabIndex = 23;
            this.lblEdition.Text = "Édition complète";
            // 
            // grpEditions
            // 
            this.grpEditions.Controls.Add(this.cbx68);
            this.grpEditions.Controls.Add(this.cbx67);
            this.grpEditions.Location = new System.Drawing.Point(31, 79);
            this.grpEditions.Name = "grpEditions";
            this.grpEditions.Size = new System.Drawing.Size(800, 270);
            this.grpEditions.TabIndex = 20;
            this.grpEditions.TabStop = false;
            this.grpEditions.Text = "Choisir les éditions concernées";
            // 
            // cbx68
            // 
            this.cbx68.AutoSize = true;
            this.cbx68.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx68.Location = new System.Drawing.Point(743, 238);
            this.cbx68.Name = "cbx68";
            this.cbx68.Size = new System.Drawing.Size(51, 26);
            this.cbx68.TabIndex = 1;
            this.cbx68.Text = "68";
            this.cbx68.UseVisualStyleBackColor = true;
            this.cbx68.Click += new System.EventHandler(this.cbx68_Click);
            // 
            // cbx67
            // 
            this.cbx67.AutoSize = true;
            this.cbx67.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx67.Location = new System.Drawing.Point(686, 238);
            this.cbx67.Name = "cbx67";
            this.cbx67.Size = new System.Drawing.Size(51, 26);
            this.cbx67.TabIndex = 0;
            this.cbx67.Text = "67";
            this.cbx67.UseVisualStyleBackColor = true;
            this.cbx67.Click += new System.EventHandler(this.cbx67_Click);
            // 
            // btnResetEdit
            // 
            this.btnResetEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetEdit.Location = new System.Drawing.Point(742, 50);
            this.btnResetEdit.Name = "btnResetEdit";
            this.btnResetEdit.Size = new System.Drawing.Size(89, 30);
            this.btnResetEdit.TabIndex = 21;
            this.btnResetEdit.Text = "Reset";
            this.btnResetEdit.UseVisualStyleBackColor = true;
            this.btnResetEdit.Click += new System.EventHandler(this.btnResetEdit_Click);
            // 
            // btnValider
            // 
            this.btnValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValider.Location = new System.Drawing.Point(742, 355);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(90, 33);
            this.btnValider.TabIndex = 22;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(31, 355);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 33);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmModifEditions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(858, 398);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.grpEditions);
            this.Controls.Add(this.btnResetEdit);
            this.Controls.Add(this.pnlTopBar);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmModifEditions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmModifEditions_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.grpEditions.ResumeLayout(false);
            this.grpEditions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.GroupBox grpEditions;
        private System.Windows.Forms.CheckBox cbx68;
        private System.Windows.Forms.CheckBox cbx67;
        private System.Windows.Forms.Button btnResetEdit;
        private System.Windows.Forms.Label lblEdition;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnCancel;
    }
}