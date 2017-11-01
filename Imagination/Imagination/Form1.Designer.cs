namespace Imagination
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
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("ImageSets");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("SoundSets");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("MovieSets");
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.SetView = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.FolderSelect = new System.Windows.Forms.FolderBrowserDialog();
            this.ImgS = new System.Windows.Forms.SplitContainer();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgS)).BeginInit();
            this.ImgS.Panel2.SuspendLayout();
            this.ImgS.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ImgS);
            this.splitContainer1.Size = new System.Drawing.Size(832, 469);
            this.splitContainer1.SplitterDistance = 277;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.SetView);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.button1);
            this.splitContainer2.Size = new System.Drawing.Size(277, 469);
            this.splitContainer2.SplitterDistance = 243;
            this.splitContainer2.TabIndex = 0;
            // 
            // SetView
            // 
            this.SetView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetView.Location = new System.Drawing.Point(0, 0);
            this.SetView.Name = "SetView";
            treeNode7.Name = "SImage";
            treeNode7.Text = "ImageSets";
            treeNode8.Name = "SSound";
            treeNode8.Text = "SoundSets";
            treeNode9.Name = "SMovie";
            treeNode9.Text = "MovieSets";
            this.SetView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9});
            this.SetView.Size = new System.Drawing.Size(273, 239);
            this.SetView.TabIndex = 0;
            this.SetView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.SetView_AfterSelect);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load ImageSet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ImgS
            // 
            this.ImgS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ImgS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgS.Location = new System.Drawing.Point(0, 0);
            this.ImgS.Name = "ImgS";
            this.ImgS.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ImgS.Panel2
            // 
            this.ImgS.Panel2.Controls.Add(this.button3);
            this.ImgS.Panel2.Controls.Add(this.button2);
            this.ImgS.Size = new System.Drawing.Size(551, 469);
            this.ImgS.SplitterDistance = 183;
            this.ImgS.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Train Mind";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(4, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Imagine Image";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 469);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Imagination (c)VividWare ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ImgS.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgS)).EndInit();
            this.ImgS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView SetView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog FolderSelect;
        private System.Windows.Forms.SplitContainer ImgS;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

