namespace RabiRibiMapViewer
{
    partial class SpritePickerForm
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
            this.panelSpritePicker = new System.Windows.Forms.Panel();
            this.pictureBoxSpritePicker = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelPalette = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSavePalette = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelSpritePicker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpritePicker)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSpritePicker
            // 
            this.panelSpritePicker.AutoScroll = true;
            this.panelSpritePicker.Controls.Add(this.pictureBoxSpritePicker);
            this.panelSpritePicker.Location = new System.Drawing.Point(13, 13);
            this.panelSpritePicker.Name = "panelSpritePicker";
            this.panelSpritePicker.Size = new System.Drawing.Size(985, 769);
            this.panelSpritePicker.TabIndex = 0;
            // 
            // pictureBoxSpritePicker
            // 
            this.pictureBoxSpritePicker.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxSpritePicker.Name = "pictureBoxSpritePicker";
            this.pictureBoxSpritePicker.Size = new System.Drawing.Size(960, 1792);
            this.pictureBoxSpritePicker.TabIndex = 0;
            this.pictureBoxSpritePicker.TabStop = false;
            this.pictureBoxSpritePicker.Click += new System.EventHandler(this.pictureBoxSpritePicker_Click);
            // 
            // tableLayoutPanelPalette
            // 
            this.tableLayoutPanelPalette.ColumnCount = 3;
            this.tableLayoutPanelPalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelPalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelPalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelPalette.Location = new System.Drawing.Point(1004, 13);
            this.tableLayoutPanelPalette.Name = "tableLayoutPanelPalette";
            this.tableLayoutPanelPalette.RowCount = 13;
            this.tableLayoutPanelPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelPalette.Size = new System.Drawing.Size(150, 650);
            this.tableLayoutPanelPalette.TabIndex = 1;
            // 
            // buttonSavePalette
            // 
            this.buttonSavePalette.Location = new System.Drawing.Point(1004, 669);
            this.buttonSavePalette.Name = "buttonSavePalette";
            this.buttonSavePalette.Size = new System.Drawing.Size(111, 23);
            this.buttonSavePalette.TabIndex = 2;
            this.buttonSavePalette.Text = "Save Sprite Palette";
            this.buttonSavePalette.UseVisualStyleBackColor = true;
            this.buttonSavePalette.Click += new System.EventHandler(this.buttonSavePalette_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(1004, 698);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(110, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // SpritePickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 794);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSavePalette);
            this.Controls.Add(this.tableLayoutPanelPalette);
            this.Controls.Add(this.panelSpritePicker);
            this.Name = "SpritePickerForm";
            this.Text = "SpritePicker";
            this.panelSpritePicker.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpritePicker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSpritePicker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPalette;
        private System.Windows.Forms.Button buttonSavePalette;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.PictureBox pictureBoxSpritePicker;
    }
}