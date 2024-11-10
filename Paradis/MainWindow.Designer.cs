
namespace Paradis
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.InformationLbl = new System.Windows.Forms.Label();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.LogBox = new System.Windows.Forms.RichTextBox();
            this.WidthFld = new System.Windows.Forms.NumericUpDown();
            this.HeightFld = new System.Windows.Forms.NumericUpDown();
            this.WidthLbl = new System.Windows.Forms.Label();
            this.HeightLbl = new System.Windows.Forms.Label();
            this.FullScreenOpt = new System.Windows.Forms.CheckBox();
            this.RenderApiSrcs = new System.Windows.Forms.BindingSource(this.components);
            this.RenderApiLbl = new System.Windows.Forms.Label();
            this.AutoPlayAfterUpdateOpt = new System.Windows.Forms.CheckBox();
            this.RenderApiBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.WidthFld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightFld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RenderApiSrcs)).BeginInit();
            this.SuspendLayout();
            // 
            // InformationLbl
            // 
            this.InformationLbl.AutoSize = true;
            this.InformationLbl.Location = new System.Drawing.Point(14, 450);
            this.InformationLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.InformationLbl.Name = "InformationLbl";
            this.InformationLbl.Size = new System.Drawing.Size(156, 42);
            this.InformationLbl.TabIndex = 103;
            this.InformationLbl.Text = "Platform: {0} {1}-bit\r\nLauncher Version: {2}";
            // 
            // PlayBtn
            // 
            this.PlayBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayBtn.Location = new System.Drawing.Point(224, 13);
            this.PlayBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(200, 50);
            this.PlayBtn.TabIndex = 1;
            this.PlayBtn.Text = "Play AoTTG";
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(14, 13);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(200, 50);
            this.UpdateBtn.TabIndex = 0;
            this.UpdateBtn.Text = "Update / Download";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // LogBox
            // 
            this.LogBox.AutoWordSelection = true;
            this.LogBox.BackColor = System.Drawing.Color.Black;
            this.LogBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogBox.ForeColor = System.Drawing.Color.Lime;
            this.LogBox.Location = new System.Drawing.Point(434, 13);
            this.LogBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.Size = new System.Drawing.Size(496, 475);
            this.LogBox.TabIndex = 104;
            this.LogBox.Text = "";
            // 
            // WidthFld
            // 
            this.WidthFld.Location = new System.Drawing.Point(224, 91);
            this.WidthFld.Margin = new System.Windows.Forms.Padding(4);
            this.WidthFld.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.WidthFld.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WidthFld.Name = "WidthFld";
            this.WidthFld.Size = new System.Drawing.Size(200, 29);
            this.WidthFld.TabIndex = 3;
            this.WidthFld.Value = new decimal(new int[] {
            1280,
            0,
            0,
            0});
            // 
            // HeightFld
            // 
            this.HeightFld.Location = new System.Drawing.Point(224, 149);
            this.HeightFld.Margin = new System.Windows.Forms.Padding(4);
            this.HeightFld.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.HeightFld.Name = "HeightFld";
            this.HeightFld.Size = new System.Drawing.Size(200, 29);
            this.HeightFld.TabIndex = 4;
            this.HeightFld.Value = new decimal(new int[] {
            720,
            0,
            0,
            0});
            // 
            // WidthLbl
            // 
            this.WidthLbl.AutoSize = true;
            this.WidthLbl.Location = new System.Drawing.Point(224, 66);
            this.WidthLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WidthLbl.Name = "WidthLbl";
            this.WidthLbl.Size = new System.Drawing.Size(52, 21);
            this.WidthLbl.TabIndex = 100;
            this.WidthLbl.Text = "Width";
            // 
            // HeightLbl
            // 
            this.HeightLbl.AutoSize = true;
            this.HeightLbl.Location = new System.Drawing.Point(224, 124);
            this.HeightLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeightLbl.Name = "HeightLbl";
            this.HeightLbl.Size = new System.Drawing.Size(56, 21);
            this.HeightLbl.TabIndex = 101;
            this.HeightLbl.Text = "Height";
            // 
            // FullScreenOpt
            // 
            this.FullScreenOpt.AutoSize = true;
            this.FullScreenOpt.Checked = true;
            this.FullScreenOpt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FullScreenOpt.Location = new System.Drawing.Point(224, 186);
            this.FullScreenOpt.Margin = new System.Windows.Forms.Padding(4);
            this.FullScreenOpt.Name = "FullScreenOpt";
            this.FullScreenOpt.Size = new System.Drawing.Size(99, 25);
            this.FullScreenOpt.TabIndex = 5;
            this.FullScreenOpt.Text = "Fullscreen";
            this.FullScreenOpt.UseVisualStyleBackColor = true;
            // 
            // RenderApiLbl
            // 
            this.RenderApiLbl.AutoSize = true;
            this.RenderApiLbl.Location = new System.Drawing.Point(224, 215);
            this.RenderApiLbl.Name = "RenderApiLbl";
            this.RenderApiLbl.Size = new System.Drawing.Size(109, 21);
            this.RenderApiLbl.TabIndex = 102;
            this.RenderApiLbl.Text = "Rendering API";
            // 
            // AutoPlayAfterUpdateOpt
            // 
            this.AutoPlayAfterUpdateOpt.AutoSize = true;
            this.AutoPlayAfterUpdateOpt.Checked = true;
            this.AutoPlayAfterUpdateOpt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoPlayAfterUpdateOpt.Location = new System.Drawing.Point(14, 66);
            this.AutoPlayAfterUpdateOpt.Name = "AutoPlayAfterUpdateOpt";
            this.AutoPlayAfterUpdateOpt.Size = new System.Drawing.Size(189, 25);
            this.AutoPlayAfterUpdateOpt.TabIndex = 2;
            this.AutoPlayAfterUpdateOpt.Text = "Auto-Play After Update";
            this.AutoPlayAfterUpdateOpt.UseVisualStyleBackColor = true;
            // 
            // RenderApiBox
            // 
            this.RenderApiBox.DataSource = this.RenderApiSrcs;
            this.RenderApiBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RenderApiBox.FormattingEnabled = true;
            this.RenderApiBox.Location = new System.Drawing.Point(224, 239);
            this.RenderApiBox.Name = "RenderApiBox";
            this.RenderApiBox.Size = new System.Drawing.Size(200, 29);
            this.RenderApiBox.TabIndex = 6;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.RenderApiBox);
            this.Controls.Add(this.AutoPlayAfterUpdateOpt);
            this.Controls.Add(this.RenderApiLbl);
            this.Controls.Add(this.FullScreenOpt);
            this.Controls.Add(this.HeightLbl);
            this.Controls.Add(this.WidthLbl);
            this.Controls.Add(this.HeightFld);
            this.Controls.Add(this.WidthFld);
            this.Controls.Add(this.InformationLbl);
            this.Controls.Add(this.PlayBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.LogBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MainWindow";
            this.Text = "Paradis Launcher";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WidthFld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightFld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RenderApiSrcs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InformationLbl;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.RichTextBox LogBox;
        private System.Windows.Forms.NumericUpDown WidthFld;
        private System.Windows.Forms.NumericUpDown HeightFld;
        private System.Windows.Forms.Label WidthLbl;
        private System.Windows.Forms.Label HeightLbl;
        private System.Windows.Forms.CheckBox FullScreenOpt;
        private System.Windows.Forms.BindingSource RenderApiSrcs;
        private System.Windows.Forms.Label RenderApiLbl;
        private System.Windows.Forms.CheckBox AutoPlayAfterUpdateOpt;
        private System.Windows.Forms.ComboBox RenderApiBox;
    }
}

