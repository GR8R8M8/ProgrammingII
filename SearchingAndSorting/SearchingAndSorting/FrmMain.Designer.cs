namespace SearchingAndSorting
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picArrow = new System.Windows.Forms.PictureBox();
            this.dragPanel = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dragArrow = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dragLabel = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.radBinary = new System.Windows.Forms.RadioButton();
            this.radLinear = new System.Windows.Forms.RadioButton();
            this.btnSort = new Bunifu.Framework.UI.BunifuFlatButton();
            this.grpSort = new System.Windows.Forms.GroupBox();
            this.radBogo = new System.Windows.Forms.RadioButton();
            this.radQuick = new System.Windows.Forms.RadioButton();
            this.radMerge = new System.Windows.Forms.RadioButton();
            this.radBubble = new System.Windows.Forms.RadioButton();
            this.radSelection = new System.Windows.Forms.RadioButton();
            this.radInsertion = new System.Windows.Forms.RadioButton();
            this.seperator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnImport = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOriginalArr = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGenerate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnOriginalFile = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).BeginInit();
            this.grpSearch.SuspendLayout();
            this.grpSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.picClose);
            this.pnlHeader.Controls.Add(this.picArrow);
            this.pnlHeader.Location = new System.Drawing.Point(-1, -1);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(578, 35);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(13, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(144, 17);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Searching and Sorting";
            // 
            // picClose
            // 
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(543, 4);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(29, 28);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 0;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picArrow
            // 
            this.picArrow.Image = global::SearchingAndSorting.Properties.Resources.Arrow;
            this.picArrow.Location = new System.Drawing.Point(-115, -1);
            this.picArrow.Name = "picArrow";
            this.picArrow.Size = new System.Drawing.Size(300, 36);
            this.picArrow.TabIndex = 1;
            this.picArrow.TabStop = false;
            // 
            // dragPanel
            // 
            this.dragPanel.Fixed = true;
            this.dragPanel.Horizontal = true;
            this.dragPanel.TargetControl = this.pnlHeader;
            this.dragPanel.Vertical = true;
            // 
            // dragArrow
            // 
            this.dragArrow.Fixed = true;
            this.dragArrow.Horizontal = true;
            this.dragArrow.TargetControl = this.picArrow;
            this.dragArrow.Vertical = true;
            // 
            // dragLabel
            // 
            this.dragLabel.Fixed = true;
            this.dragLabel.Horizontal = true;
            this.dragLabel.TargetControl = this.lblHeader;
            this.dragLabel.Vertical = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.BorderRadius = 0;
            this.btnSearch.ButtonText = "Search";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearch.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSearch.Iconimage")));
            this.btnSearch.Iconimage_right = null;
            this.btnSearch.Iconimage_right_Selected = null;
            this.btnSearch.Iconimage_Selected = null;
            this.btnSearch.IconMarginLeft = 0;
            this.btnSearch.IconMarginRight = 0;
            this.btnSearch.IconRightVisible = false;
            this.btnSearch.IconRightZoom = 0D;
            this.btnSearch.IconVisible = false;
            this.btnSearch.IconZoom = 90D;
            this.btnSearch.IsTab = false;
            this.btnSearch.Location = new System.Drawing.Point(55, 114);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(92, 29);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Textcolor = System.Drawing.Color.White;
            this.btnSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.radBinary);
            this.grpSearch.Controls.Add(this.radLinear);
            this.grpSearch.Location = new System.Drawing.Point(47, 161);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(111, 77);
            this.grpSearch.TabIndex = 3;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Method";
            // 
            // radBinary
            // 
            this.radBinary.AutoSize = true;
            this.radBinary.Location = new System.Drawing.Point(7, 46);
            this.radBinary.Name = "radBinary";
            this.radBinary.Size = new System.Drawing.Size(54, 17);
            this.radBinary.TabIndex = 1;
            this.radBinary.TabStop = true;
            this.radBinary.Text = "Binary";
            this.radBinary.UseVisualStyleBackColor = true;
            // 
            // radLinear
            // 
            this.radLinear.AutoSize = true;
            this.radLinear.Location = new System.Drawing.Point(8, 23);
            this.radLinear.Name = "radLinear";
            this.radLinear.Size = new System.Drawing.Size(54, 17);
            this.radLinear.TabIndex = 0;
            this.radLinear.TabStop = true;
            this.radLinear.Text = "Linear";
            this.radLinear.UseVisualStyleBackColor = true;
            // 
            // btnSort
            // 
            this.btnSort.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSort.BorderRadius = 0;
            this.btnSort.ButtonText = "Sort Array";
            this.btnSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSort.DisabledColor = System.Drawing.Color.Gray;
            this.btnSort.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSort.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSort.Iconimage")));
            this.btnSort.Iconimage_right = null;
            this.btnSort.Iconimage_right_Selected = null;
            this.btnSort.Iconimage_Selected = null;
            this.btnSort.IconMarginLeft = 0;
            this.btnSort.IconMarginRight = 0;
            this.btnSort.IconRightVisible = false;
            this.btnSort.IconRightZoom = 0D;
            this.btnSort.IconVisible = false;
            this.btnSort.IconZoom = 90D;
            this.btnSort.IsTab = false;
            this.btnSort.Location = new System.Drawing.Point(237, 78);
            this.btnSort.Margin = new System.Windows.Forms.Padding(4);
            this.btnSort.Name = "btnSort";
            this.btnSort.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSort.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSort.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSort.selected = false;
            this.btnSort.Size = new System.Drawing.Size(157, 44);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Sort Array";
            this.btnSort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSort.Textcolor = System.Drawing.Color.White;
            this.btnSort.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // grpSort
            // 
            this.grpSort.Controls.Add(this.radBogo);
            this.grpSort.Controls.Add(this.radQuick);
            this.grpSort.Controls.Add(this.radMerge);
            this.grpSort.Controls.Add(this.radBubble);
            this.grpSort.Controls.Add(this.radSelection);
            this.grpSort.Controls.Add(this.radInsertion);
            this.grpSort.Location = new System.Drawing.Point(417, 96);
            this.grpSort.Name = "grpSort";
            this.grpSort.Size = new System.Drawing.Size(147, 96);
            this.grpSort.TabIndex = 5;
            this.grpSort.TabStop = false;
            this.grpSort.Text = "Sorting Method";
            // 
            // radBogo
            // 
            this.radBogo.AutoSize = true;
            this.radBogo.Location = new System.Drawing.Point(78, 66);
            this.radBogo.Name = "radBogo";
            this.radBogo.Size = new System.Drawing.Size(50, 17);
            this.radBogo.TabIndex = 5;
            this.radBogo.TabStop = true;
            this.radBogo.Text = "Bogo";
            this.radBogo.UseVisualStyleBackColor = true;
            // 
            // radQuick
            // 
            this.radQuick.AutoSize = true;
            this.radQuick.Location = new System.Drawing.Point(78, 43);
            this.radQuick.Name = "radQuick";
            this.radQuick.Size = new System.Drawing.Size(53, 17);
            this.radQuick.TabIndex = 4;
            this.radQuick.TabStop = true;
            this.radQuick.Text = "Quick";
            this.radQuick.UseVisualStyleBackColor = true;
            // 
            // radMerge
            // 
            this.radMerge.AutoSize = true;
            this.radMerge.Location = new System.Drawing.Point(78, 20);
            this.radMerge.Name = "radMerge";
            this.radMerge.Size = new System.Drawing.Size(55, 17);
            this.radMerge.TabIndex = 3;
            this.radMerge.TabStop = true;
            this.radMerge.Text = "Merge";
            this.radMerge.UseVisualStyleBackColor = true;
            // 
            // radBubble
            // 
            this.radBubble.AutoSize = true;
            this.radBubble.Location = new System.Drawing.Point(7, 66);
            this.radBubble.Name = "radBubble";
            this.radBubble.Size = new System.Drawing.Size(58, 17);
            this.radBubble.TabIndex = 2;
            this.radBubble.TabStop = true;
            this.radBubble.Text = "Bubble";
            this.radBubble.UseVisualStyleBackColor = true;
            // 
            // radSelection
            // 
            this.radSelection.AutoSize = true;
            this.radSelection.Location = new System.Drawing.Point(7, 43);
            this.radSelection.Name = "radSelection";
            this.radSelection.Size = new System.Drawing.Size(69, 17);
            this.radSelection.TabIndex = 1;
            this.radSelection.TabStop = true;
            this.radSelection.Text = "Selection";
            this.radSelection.UseVisualStyleBackColor = true;
            // 
            // radInsertion
            // 
            this.radInsertion.AutoSize = true;
            this.radInsertion.Location = new System.Drawing.Point(7, 20);
            this.radInsertion.Name = "radInsertion";
            this.radInsertion.Size = new System.Drawing.Size(65, 17);
            this.radInsertion.TabIndex = 0;
            this.radInsertion.TabStop = true;
            this.radInsertion.Text = "Insertion";
            this.radInsertion.UseVisualStyleBackColor = true;
            // 
            // seperator1
            // 
            this.seperator1.BackColor = System.Drawing.Color.Transparent;
            this.seperator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.seperator1.LineThickness = 1;
            this.seperator1.Location = new System.Drawing.Point(211, 42);
            this.seperator1.Margin = new System.Windows.Forms.Padding(4);
            this.seperator1.Name = "seperator1";
            this.seperator1.Size = new System.Drawing.Size(18, 228);
            this.seperator1.TabIndex = 6;
            this.seperator1.Transparency = 255;
            this.seperator1.Vertical = true;
            // 
            // btnImport
            // 
            this.btnImport.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnImport.BackColor = System.Drawing.Color.SeaGreen;
            this.btnImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImport.BorderRadius = 0;
            this.btnImport.ButtonText = "Sort From File";
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.DisabledColor = System.Drawing.Color.Gray;
            this.btnImport.Iconcolor = System.Drawing.Color.Transparent;
            this.btnImport.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnImport.Iconimage")));
            this.btnImport.Iconimage_right = null;
            this.btnImport.Iconimage_right_Selected = null;
            this.btnImport.Iconimage_Selected = null;
            this.btnImport.IconMarginLeft = 0;
            this.btnImport.IconMarginRight = 0;
            this.btnImport.IconRightVisible = false;
            this.btnImport.IconRightZoom = 0D;
            this.btnImport.IconVisible = false;
            this.btnImport.IconZoom = 90D;
            this.btnImport.IsTab = false;
            this.btnImport.Location = new System.Drawing.Point(237, 162);
            this.btnImport.Margin = new System.Windows.Forms.Padding(4);
            this.btnImport.Name = "btnImport";
            this.btnImport.Normalcolor = System.Drawing.Color.SeaGreen;
            this.btnImport.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnImport.OnHoverTextColor = System.Drawing.Color.White;
            this.btnImport.selected = false;
            this.btnImport.Size = new System.Drawing.Size(157, 44);
            this.btnImport.TabIndex = 8;
            this.btnImport.Text = "Sort From File";
            this.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnImport.Textcolor = System.Drawing.Color.White;
            this.btnImport.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter Search Query:";
            // 
            // btnOriginalArr
            // 
            this.btnOriginalArr.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnOriginalArr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnOriginalArr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOriginalArr.BorderRadius = 0;
            this.btnOriginalArr.ButtonText = "View Original";
            this.btnOriginalArr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOriginalArr.DisabledColor = System.Drawing.Color.Gray;
            this.btnOriginalArr.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOriginalArr.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnOriginalArr.Iconimage")));
            this.btnOriginalArr.Iconimage_right = null;
            this.btnOriginalArr.Iconimage_right_Selected = null;
            this.btnOriginalArr.Iconimage_Selected = null;
            this.btnOriginalArr.IconMarginLeft = 0;
            this.btnOriginalArr.IconMarginRight = 0;
            this.btnOriginalArr.IconRightVisible = false;
            this.btnOriginalArr.IconRightZoom = 0D;
            this.btnOriginalArr.IconVisible = false;
            this.btnOriginalArr.IconZoom = 90D;
            this.btnOriginalArr.IsTab = false;
            this.btnOriginalArr.Location = new System.Drawing.Point(237, 124);
            this.btnOriginalArr.Margin = new System.Windows.Forms.Padding(4);
            this.btnOriginalArr.Name = "btnOriginalArr";
            this.btnOriginalArr.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnOriginalArr.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnOriginalArr.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOriginalArr.selected = false;
            this.btnOriginalArr.Size = new System.Drawing.Size(157, 30);
            this.btnOriginalArr.TabIndex = 11;
            this.btnOriginalArr.Text = "View Original";
            this.btnOriginalArr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOriginalArr.Textcolor = System.Drawing.Color.White;
            this.btnOriginalArr.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOriginalArr.Click += new System.EventHandler(this.btnOriginal_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnGenerate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerate.BorderRadius = 0;
            this.btnGenerate.ButtonText = "Generate Data";
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.DisabledColor = System.Drawing.Color.Gray;
            this.btnGenerate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGenerate.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGenerate.Iconimage")));
            this.btnGenerate.Iconimage_right = null;
            this.btnGenerate.Iconimage_right_Selected = null;
            this.btnGenerate.Iconimage_Selected = null;
            this.btnGenerate.IconMarginLeft = 0;
            this.btnGenerate.IconMarginRight = 0;
            this.btnGenerate.IconRightVisible = false;
            this.btnGenerate.IconRightZoom = 0D;
            this.btnGenerate.IconVisible = false;
            this.btnGenerate.IconZoom = 90D;
            this.btnGenerate.IsTab = false;
            this.btnGenerate.Location = new System.Drawing.Point(422, 199);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnGenerate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnGenerate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGenerate.selected = false;
            this.btnGenerate.Size = new System.Drawing.Size(131, 29);
            this.btnGenerate.TabIndex = 12;
            this.btnGenerate.Text = "Generate Data";
            this.btnGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGenerate.Textcolor = System.Drawing.Color.White;
            this.btnGenerate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.txtSearch.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.txtSearch.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.txtSearch.BorderThickness = 2;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.isPassword = false;
            this.txtSearch.Location = new System.Drawing.Point(37, 78);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(133, 31);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOriginalFile
            // 
            this.btnOriginalFile.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnOriginalFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnOriginalFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOriginalFile.BorderRadius = 0;
            this.btnOriginalFile.ButtonText = "View Original";
            this.btnOriginalFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOriginalFile.DisabledColor = System.Drawing.Color.Gray;
            this.btnOriginalFile.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOriginalFile.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnOriginalFile.Iconimage")));
            this.btnOriginalFile.Iconimage_right = null;
            this.btnOriginalFile.Iconimage_right_Selected = null;
            this.btnOriginalFile.Iconimage_Selected = null;
            this.btnOriginalFile.IconMarginLeft = 0;
            this.btnOriginalFile.IconMarginRight = 0;
            this.btnOriginalFile.IconRightVisible = false;
            this.btnOriginalFile.IconRightZoom = 0D;
            this.btnOriginalFile.IconVisible = false;
            this.btnOriginalFile.IconZoom = 90D;
            this.btnOriginalFile.IsTab = false;
            this.btnOriginalFile.Location = new System.Drawing.Point(237, 209);
            this.btnOriginalFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnOriginalFile.Name = "btnOriginalFile";
            this.btnOriginalFile.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnOriginalFile.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnOriginalFile.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOriginalFile.selected = false;
            this.btnOriginalFile.Size = new System.Drawing.Size(157, 30);
            this.btnOriginalFile.TabIndex = 14;
            this.btnOriginalFile.Text = "View Original";
            this.btnOriginalFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOriginalFile.Textcolor = System.Drawing.Color.White;
            this.btnOriginalFile.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOriginalFile.Click += new System.EventHandler(this.btnOriginalFile_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(576, 283);
            this.Controls.Add(this.btnOriginalFile);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnOriginalArr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.seperator1);
            this.Controls.Add(this.grpSort);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "Searching and Sorting";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpSort.ResumeLayout(false);
            this.grpSort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picArrow;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox picClose;
        private Bunifu.Framework.UI.BunifuDragControl dragPanel;
        private Bunifu.Framework.UI.BunifuDragControl dragArrow;
        private Bunifu.Framework.UI.BunifuDragControl dragLabel;
        private Bunifu.Framework.UI.BunifuSeparator seperator1;
        private System.Windows.Forms.GroupBox grpSort;
        private System.Windows.Forms.RadioButton radBogo;
        private System.Windows.Forms.RadioButton radQuick;
        private System.Windows.Forms.RadioButton radMerge;
        private System.Windows.Forms.RadioButton radBubble;
        private System.Windows.Forms.RadioButton radSelection;
        private System.Windows.Forms.RadioButton radInsertion;
        private Bunifu.Framework.UI.BunifuFlatButton btnSort;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.RadioButton radBinary;
        private System.Windows.Forms.RadioButton radLinear;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnImport;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnOriginalArr;
        private Bunifu.Framework.UI.BunifuFlatButton btnGenerate;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnOriginalFile;
    }
}

