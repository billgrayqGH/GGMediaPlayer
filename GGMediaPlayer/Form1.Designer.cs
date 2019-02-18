namespace GGMediaPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.listBox_files = new System.Windows.Forms.ListBox();
            this.button_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.AllowDrop = true;
            this.axWindowsMediaPlayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(784, 396);
            this.axWindowsMediaPlayer.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.ShowReadOnly = true;
            // 
            // listBox_files
            // 
            this.listBox_files.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listBox_files.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_files.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listBox_files.FormattingEnabled = true;
            this.listBox_files.HorizontalScrollbar = true;
            this.listBox_files.ItemHeight = 16;
            this.listBox_files.Location = new System.Drawing.Point(0, 396);
            this.listBox_files.Name = "listBox_files";
            this.listBox_files.ScrollAlwaysVisible = true;
            this.listBox_files.Size = new System.Drawing.Size(784, 116);
            this.listBox_files.Sorted = true;
            this.listBox_files.TabIndex = 1;
            this.listBox_files.SelectedIndexChanged += new System.EventHandler(this.listBox_files_SelectedIndexChanged);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.Black;
            this.button_add.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_add.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_add.Location = new System.Drawing.Point(0, 518);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(784, 43);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "ADD FILES TO PLAYLIST";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.listBox_files);
            this.Controls.Add(this.axWindowsMediaPlayer);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GG Media Player";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ListBox listBox_files;
        private System.Windows.Forms.Button button_add;
    }
}

