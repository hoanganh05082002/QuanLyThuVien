
namespace QuanLyThuVien_BTL_05
{
    partial class repot
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
            this.crtReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crtReport
            // 
            this.crtReport.ActiveViewIndex = -1;
            this.crtReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crtReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.crtReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crtReport.Location = new System.Drawing.Point(0, 0);
            this.crtReport.Name = "crtReport";
            this.crtReport.Size = new System.Drawing.Size(800, 450);
            this.crtReport.TabIndex = 0;
            // 
            // repot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crtReport);
            this.Name = "repot";
            this.Text = "repot";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crtReport;
    }
}