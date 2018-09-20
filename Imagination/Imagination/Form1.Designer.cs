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
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("In");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Out");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("MovieSets");
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.SetView = new System.Windows.Forms.TreeView();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ImgS = new System.Windows.Forms.SplitContainer();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.FolderSelect = new System.Windows.Forms.FolderBrowserDialog();
            this.fromImg = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
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
            this.splitContainer2.Panel2.Controls.Add(this.button4);
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
            treeNode4.Name = "SImage";
            treeNode4.Text = "In";
            treeNode5.Name = "SSound";
            treeNode5.Text = "Out";
            treeNode6.Name = "SMovie";
            treeNode6.Text = "MovieSets";
            this.SetView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            this.SetView.Size = new System.Drawing.Size(273, 239);
            this.SetView.TabIndex = 0;
            this.SetView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.SetView_AfterSelect);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 37);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(213, 29);
            this.button4.TabIndex = 1;
            this.button4.Text = "Load Out Set";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load IN Set";
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
            this.ImgS.Panel2.Controls.Add(this.button5);
            this.ImgS.Panel2.Controls.Add(this.fromImg);
            this.ImgS.Panel2.Controls.Add(this.button3);
            this.ImgS.Panel2.Controls.Add(this.button2);
            this.ImgS.Size = new System.Drawing.Size(551, 469);
            this.ImgS.SplitterDistance = 183;
            this.ImgS.TabIndex = 0;
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
            // fromImg
            // 
            this.fromImg.Location = new System.Drawing.Point(14, 70);
            this.fromImg.Name = "fromImg";
            this.fromImg.Size = new System.Drawing.Size(245, 20);
            this.fromImg.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(276, 66);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Select From Img";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.ImgS.Panel2.PerformLayout();
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox fromImg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

