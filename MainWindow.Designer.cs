
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
            this.OutputLogBox = new System.Windows.Forms.RichTextBox();
            this.widthField = new System.Windows.Forms.NumericUpDown();
            this.heightField = new System.Windows.Forms.NumericUpDown();
            this.widthLbl = new System.Windows.Forms.Label();
            this.heightLbl = new System.Windows.Forms.Label();
            this.fullScreenTgl = new System.Windows.Forms.CheckBox();
            this.renderApiBox = new System.Windows.Forms.ListBox();
            this.renderApiSources = new System.Windows.Forms.BindingSource(this.components);
            this.renderApiLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.widthField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.renderApiSources)).BeginInit();
            this.SuspendLayout();
            // 
            // InformationLbl
            // 
            this.InformationLbl.AutoSize = true;
            this.InformationLbl.Location = new System.Drawing.Point(14, 450);
            this.InformationLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.InformationLbl.Name = "InformationLbl";
            this.InformationLbl.Size = new System.Drawing.Size(156, 42);
            this.InformationLbl.TabIndex = 104;
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
            this.PlayBtn.Text = "Play (No Download)";
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
            this.UpdateBtn.Text = "Download + Play";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // OutputLogBox
            // 
            this.OutputLogBox.AutoWordSelection = true;
            this.OutputLogBox.BackColor = System.Drawing.Color.Black;
            this.OutputLogBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLogBox.ForeColor = System.Drawing.Color.Lime;
            this.OutputLogBox.Location = new System.Drawing.Point(434, 13);
            this.OutputLogBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.OutputLogBox.Name = "OutputLogBox";
            this.OutputLogBox.ReadOnly = true;
            this.OutputLogBox.Size = new System.Drawing.Size(496, 475);
            this.OutputLogBox.TabIndex = 6;
            this.OutputLogBox.Text = "";
            // 
            // widthField
            // 
            this.widthField.Location = new System.Drawing.Point(13, 92);
            this.widthField.Margin = new System.Windows.Forms.Padding(4);
            this.widthField.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.widthField.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.widthField.Name = "widthField";
            this.widthField.Size = new System.Drawing.Size(201, 29);
            this.widthField.TabIndex = 2;
            this.widthField.Value = new decimal(new int[] {
            1280,
            0,
            0,
            0});
            // 
            // heightField
            // 
            this.heightField.Location = new System.Drawing.Point(13, 150);
            this.heightField.Margin = new System.Windows.Forms.Padding(4);
            this.heightField.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.heightField.Name = "heightField";
            this.heightField.Size = new System.Drawing.Size(201, 29);
            this.heightField.TabIndex = 3;
            this.heightField.Value = new decimal(new int[] {
            720,
            0,
            0,
            0});
            // 
            // widthLbl
            // 
            this.widthLbl.AutoSize = true;
            this.widthLbl.Location = new System.Drawing.Point(13, 67);
            this.widthLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.widthLbl.Name = "widthLbl";
            this.widthLbl.Size = new System.Drawing.Size(52, 21);
            this.widthLbl.TabIndex = 100;
            this.widthLbl.Text = "Width";
            // 
            // heightLbl
            // 
            this.heightLbl.AutoSize = true;
            this.heightLbl.Location = new System.Drawing.Point(13, 125);
            this.heightLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heightLbl.Name = "heightLbl";
            this.heightLbl.Size = new System.Drawing.Size(56, 21);
            this.heightLbl.TabIndex = 101;
            this.heightLbl.Text = "Height";
            // 
            // fullScreenTgl
            // 
            this.fullScreenTgl.AutoSize = true;
            this.fullScreenTgl.Location = new System.Drawing.Point(13, 187);
            this.fullScreenTgl.Margin = new System.Windows.Forms.Padding(4);
            this.fullScreenTgl.Name = "fullScreenTgl";
            this.fullScreenTgl.Size = new System.Drawing.Size(99, 25);
            this.fullScreenTgl.TabIndex = 4;
            this.fullScreenTgl.Text = "Fullscreen";
            this.fullScreenTgl.UseVisualStyleBackColor = true;
            // 
            // renderApiBox
            // 
            this.renderApiBox.DataSource = this.renderApiSources;
            this.renderApiBox.FormattingEnabled = true;
            this.renderApiBox.ItemHeight = 21;
            this.renderApiBox.Location = new System.Drawing.Point(12, 240);
            this.renderApiBox.Name = "renderApiBox";
            this.renderApiBox.Size = new System.Drawing.Size(202, 193);
            this.renderApiBox.TabIndex = 5;
            // 
            // renderApiLbl
            // 
            this.renderApiLbl.AutoSize = true;
            this.renderApiLbl.Location = new System.Drawing.Point(12, 216);
            this.renderApiLbl.Name = "renderApiLbl";
            this.renderApiLbl.Size = new System.Drawing.Size(109, 21);
            this.renderApiLbl.TabIndex = 103;
            this.renderApiLbl.Text = "Rendering API";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.renderApiLbl);
            this.Controls.Add(this.renderApiBox);
            this.Controls.Add(this.fullScreenTgl);
            this.Controls.Add(this.heightLbl);
            this.Controls.Add(this.widthLbl);
            this.Controls.Add(this.heightField);
            this.Controls.Add(this.widthField);
            this.Controls.Add(this.InformationLbl);
            this.Controls.Add(this.PlayBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.OutputLogBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MainWindow";
            this.Text = "Paradis Launcher";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.widthField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.renderApiSources)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InformationLbl;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.RichTextBox OutputLogBox;
        private System.Windows.Forms.NumericUpDown widthField;
        private System.Windows.Forms.NumericUpDown heightField;
        private System.Windows.Forms.Label widthLbl;
        private System.Windows.Forms.Label heightLbl;
        private System.Windows.Forms.CheckBox fullScreenTgl;
        private System.Windows.Forms.ListBox renderApiBox;
        private System.Windows.Forms.BindingSource renderApiSources;
        private System.Windows.Forms.Label renderApiLbl;
    }
}

