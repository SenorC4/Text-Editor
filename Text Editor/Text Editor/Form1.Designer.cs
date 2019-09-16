namespace Text_Editor
{
    partial class TextEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextPink = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextWhite = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextBullet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.space = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.space1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuColor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuColorRed = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuColorGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuColorBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBackground = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPink = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLightGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLightBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuWhite = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTextSize = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTextSmall = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTextNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTextLarge = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatAlign = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatAlignLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatAlignCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatAlignRight = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatOffset = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatOffsetNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatOffsetSubscript = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatOffsetSuperscript = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatIndent = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatIndentNone = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatIndentHanging = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatIndentLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatIndentRight = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatIndentBoth = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatBullet = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDocument = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundToolStripMenuItem,
            this.ContextBullet});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 48);
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextPink,
            this.ContextWhite,
            this.ContextBlue,
            this.ContextGreen});
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.backgroundToolStripMenuItem.Text = "Background";
            // 
            // ContextPink
            // 
            this.ContextPink.Name = "ContextPink";
            this.ContextPink.Size = new System.Drawing.Size(180, 22);
            this.ContextPink.Text = "Pink";
            this.ContextPink.Click += new System.EventHandler(this.ContextPink_Click);
            // 
            // ContextWhite
            // 
            this.ContextWhite.Name = "ContextWhite";
            this.ContextWhite.Size = new System.Drawing.Size(180, 22);
            this.ContextWhite.Text = "White";
            this.ContextWhite.Click += new System.EventHandler(this.ContextWhite_Click);
            // 
            // ContextBlue
            // 
            this.ContextBlue.Name = "ContextBlue";
            this.ContextBlue.Size = new System.Drawing.Size(180, 22);
            this.ContextBlue.Text = "Light Blue";
            this.ContextBlue.Click += new System.EventHandler(this.ContextBlue_Click);
            // 
            // ContextGreen
            // 
            this.ContextGreen.Name = "ContextGreen";
            this.ContextGreen.Size = new System.Drawing.Size(180, 22);
            this.ContextGreen.Text = "Light Green";
            this.ContextGreen.Click += new System.EventHandler(this.ContextGreen_Click);
            // 
            // ContextBullet
            // 
            this.ContextBullet.Name = "ContextBullet";
            this.ContextBullet.Size = new System.Drawing.Size(138, 22);
            this.ContextBullet.Text = "Bullet";
            this.ContextBullet.Click += new System.EventHandler(this.ContextBullet_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuEdit,
            this.MenuFormat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(960, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuNew,
            this.MenuOpen,
            this.MenuSave,
            this.MenuSaveAs,
            this.space,
            this.MenuPrintPreview,
            this.MenuPrint,
            this.space1,
            this.MenuExit});
            this.MenuFile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(44, 24);
            this.MenuFile.Text = "&File";
            this.MenuFile.Click += new System.EventHandler(this.MenuFile_Click);
            // 
            // MenuNew
            // 
            this.MenuNew.Image = ((System.Drawing.Image)(resources.GetObject("MenuNew.Image")));
            this.MenuNew.Name = "MenuNew";
            this.MenuNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MenuNew.Size = new System.Drawing.Size(167, 24);
            this.MenuNew.Text = "New";
            this.MenuNew.Click += new System.EventHandler(this.MenuNew_Click);
            // 
            // MenuOpen
            // 
            this.MenuOpen.Image = ((System.Drawing.Image)(resources.GetObject("MenuOpen.Image")));
            this.MenuOpen.Name = "MenuOpen";
            this.MenuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuOpen.Size = new System.Drawing.Size(167, 24);
            this.MenuOpen.Text = "&Open";
            this.MenuOpen.Click += new System.EventHandler(this.MenuOpen_Click);
            // 
            // MenuSave
            // 
            this.MenuSave.Image = ((System.Drawing.Image)(resources.GetObject("MenuSave.Image")));
            this.MenuSave.Name = "MenuSave";
            this.MenuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuSave.Size = new System.Drawing.Size(167, 24);
            this.MenuSave.Text = "&Save";
            this.MenuSave.Click += new System.EventHandler(this.MenuSave_Click);
            // 
            // MenuSaveAs
            // 
            this.MenuSaveAs.Name = "MenuSaveAs";
            this.MenuSaveAs.Size = new System.Drawing.Size(167, 24);
            this.MenuSaveAs.Text = "Save &As...";
            this.MenuSaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // space
            // 
            this.space.Name = "space";
            this.space.Size = new System.Drawing.Size(167, 24);
            this.space.Text = "-------------";
            // 
            // MenuPrintPreview
            // 
            this.MenuPrintPreview.Image = ((System.Drawing.Image)(resources.GetObject("MenuPrintPreview.Image")));
            this.MenuPrintPreview.Name = "MenuPrintPreview";
            this.MenuPrintPreview.Size = new System.Drawing.Size(167, 24);
            this.MenuPrintPreview.Text = "Print Pre&view";
            this.MenuPrintPreview.Click += new System.EventHandler(this.MenuPrintPreview_Click);
            // 
            // MenuPrint
            // 
            this.MenuPrint.Image = ((System.Drawing.Image)(resources.GetObject("MenuPrint.Image")));
            this.MenuPrint.Name = "MenuPrint";
            this.MenuPrint.Size = new System.Drawing.Size(167, 24);
            this.MenuPrint.Text = "&Print";
            this.MenuPrint.Click += new System.EventHandler(this.MenuPrint_Click);
            // 
            // space1
            // 
            this.space1.Name = "space1";
            this.space1.Size = new System.Drawing.Size(167, 24);
            this.space1.Text = "-------------";
            // 
            // MenuExit
            // 
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(167, 24);
            this.MenuExit.Text = "E&xit";
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // MenuEdit
            // 
            this.MenuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUndo,
            this.MenuRedo,
            this.MenuCopy,
            this.MenuPaste,
            this.MenuDelete,
            this.MenuSelectAll});
            this.MenuEdit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuEdit.Name = "MenuEdit";
            this.MenuEdit.Size = new System.Drawing.Size(47, 24);
            this.MenuEdit.Text = "&Edit";
            this.MenuEdit.Click += new System.EventHandler(this.MenuEdit_Click);
            // 
            // MenuUndo
            // 
            this.MenuUndo.Image = ((System.Drawing.Image)(resources.GetObject("MenuUndo.Image")));
            this.MenuUndo.Name = "MenuUndo";
            this.MenuUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.MenuUndo.Size = new System.Drawing.Size(192, 24);
            this.MenuUndo.Text = "&Undo";
            this.MenuUndo.Click += new System.EventHandler(this.MenuUndo_Click);
            // 
            // MenuRedo
            // 
            this.MenuRedo.Image = ((System.Drawing.Image)(resources.GetObject("MenuRedo.Image")));
            this.MenuRedo.Name = "MenuRedo";
            this.MenuRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.MenuRedo.Size = new System.Drawing.Size(192, 24);
            this.MenuRedo.Text = "&Redo";
            this.MenuRedo.Click += new System.EventHandler(this.MenuRedo_Click);
            // 
            // MenuCopy
            // 
            this.MenuCopy.Image = ((System.Drawing.Image)(resources.GetObject("MenuCopy.Image")));
            this.MenuCopy.Name = "MenuCopy";
            this.MenuCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.MenuCopy.Size = new System.Drawing.Size(192, 24);
            this.MenuCopy.Text = "&Copy";
            this.MenuCopy.Click += new System.EventHandler(this.MenuCopy_Click);
            // 
            // MenuPaste
            // 
            this.MenuPaste.Image = ((System.Drawing.Image)(resources.GetObject("MenuPaste.Image")));
            this.MenuPaste.Name = "MenuPaste";
            this.MenuPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.MenuPaste.Size = new System.Drawing.Size(192, 24);
            this.MenuPaste.Text = "&Paste";
            this.MenuPaste.Click += new System.EventHandler(this.MenuPaste_Click);
            // 
            // MenuDelete
            // 
            this.MenuDelete.Image = ((System.Drawing.Image)(resources.GetObject("MenuDelete.Image")));
            this.MenuDelete.Name = "MenuDelete";
            this.MenuDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.MenuDelete.Size = new System.Drawing.Size(192, 24);
            this.MenuDelete.Text = "&Delete";
            this.MenuDelete.Click += new System.EventHandler(this.MenuDelete_Click);
            // 
            // MenuSelectAll
            // 
            this.MenuSelectAll.Name = "MenuSelectAll";
            this.MenuSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.MenuSelectAll.Size = new System.Drawing.Size(192, 24);
            this.MenuSelectAll.Text = "Select &All";
            this.MenuSelectAll.Click += new System.EventHandler(this.MenuSelectAll_Click);
            // 
            // MenuFormat
            // 
            this.MenuFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuColor,
            this.MenuBackground,
            this.MenuTextSize,
            this.FormatAlign,
            this.FormatOffset,
            this.FormatIndent,
            this.FormatBullet});
            this.MenuFormat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuFormat.Name = "MenuFormat";
            this.MenuFormat.Size = new System.Drawing.Size(68, 24);
            this.MenuFormat.Text = "F&ormat";
            this.MenuFormat.Click += new System.EventHandler(this.MenuFormat_Click);
            // 
            // MenuColor
            // 
            this.MenuColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuColorRed,
            this.MenuColorGreen,
            this.MenuColorBlue});
            this.MenuColor.Name = "MenuColor";
            this.MenuColor.Size = new System.Drawing.Size(157, 24);
            this.MenuColor.Text = "Text &Color";
            // 
            // MenuColorRed
            // 
            this.MenuColorRed.ForeColor = System.Drawing.Color.Red;
            this.MenuColorRed.Name = "MenuColorRed";
            this.MenuColorRed.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.MenuColorRed.Size = new System.Drawing.Size(169, 24);
            this.MenuColorRed.Text = "Red";
            this.MenuColorRed.Click += new System.EventHandler(this.MenuColorRed_Click);
            // 
            // MenuColorGreen
            // 
            this.MenuColorGreen.ForeColor = System.Drawing.Color.Green;
            this.MenuColorGreen.Name = "MenuColorGreen";
            this.MenuColorGreen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.MenuColorGreen.Size = new System.Drawing.Size(169, 24);
            this.MenuColorGreen.Text = "Green";
            this.MenuColorGreen.Click += new System.EventHandler(this.MenuColorGreen_Click);
            // 
            // MenuColorBlue
            // 
            this.MenuColorBlue.ForeColor = System.Drawing.Color.Blue;
            this.MenuColorBlue.Name = "MenuColorBlue";
            this.MenuColorBlue.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.MenuColorBlue.Size = new System.Drawing.Size(169, 24);
            this.MenuColorBlue.Text = "Blue";
            this.MenuColorBlue.Click += new System.EventHandler(this.MenuColorBlue_Click);
            // 
            // MenuBackground
            // 
            this.MenuBackground.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuPink,
            this.MenuLightGreen,
            this.MenuLightBlue,
            this.MenuWhite});
            this.MenuBackground.Name = "MenuBackground";
            this.MenuBackground.Size = new System.Drawing.Size(157, 24);
            this.MenuBackground.Text = "&Background";
            // 
            // MenuPink
            // 
            this.MenuPink.BackColor = System.Drawing.Color.Pink;
            this.MenuPink.ForeColor = System.Drawing.Color.Black;
            this.MenuPink.Name = "MenuPink";
            this.MenuPink.Size = new System.Drawing.Size(154, 24);
            this.MenuPink.Text = "&Pink";
            this.MenuPink.Click += new System.EventHandler(this.MenuPink_Click);
            // 
            // MenuLightGreen
            // 
            this.MenuLightGreen.BackColor = System.Drawing.Color.LightGreen;
            this.MenuLightGreen.ForeColor = System.Drawing.Color.Black;
            this.MenuLightGreen.Name = "MenuLightGreen";
            this.MenuLightGreen.Size = new System.Drawing.Size(154, 24);
            this.MenuLightGreen.Text = "Light &Green";
            this.MenuLightGreen.Click += new System.EventHandler(this.MenuLightGreen_Click);
            // 
            // MenuLightBlue
            // 
            this.MenuLightBlue.BackColor = System.Drawing.Color.LightBlue;
            this.MenuLightBlue.ForeColor = System.Drawing.Color.Black;
            this.MenuLightBlue.Name = "MenuLightBlue";
            this.MenuLightBlue.Size = new System.Drawing.Size(154, 24);
            this.MenuLightBlue.Text = "Light &Blue";
            this.MenuLightBlue.Click += new System.EventHandler(this.MenuLightBlue_Click);
            // 
            // MenuWhite
            // 
            this.MenuWhite.Name = "MenuWhite";
            this.MenuWhite.Size = new System.Drawing.Size(154, 24);
            this.MenuWhite.Text = "White";
            this.MenuWhite.Click += new System.EventHandler(this.MenuWhite_Click);
            // 
            // MenuTextSize
            // 
            this.MenuTextSize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTextSmall,
            this.MenuTextNormal,
            this.MenuTextLarge});
            this.MenuTextSize.Name = "MenuTextSize";
            this.MenuTextSize.Size = new System.Drawing.Size(157, 24);
            this.MenuTextSize.Text = "Text &Size";
            // 
            // MenuTextSmall
            // 
            this.MenuTextSmall.Name = "MenuTextSmall";
            this.MenuTextSmall.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.MenuTextSmall.Size = new System.Drawing.Size(221, 36);
            this.MenuTextSmall.Text = "&Small";
            this.MenuTextSmall.Click += new System.EventHandler(this.MenuTextSmall_Click);
            // 
            // MenuTextNormal
            // 
            this.MenuTextNormal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuTextNormal.Name = "MenuTextNormal";
            this.MenuTextNormal.Size = new System.Drawing.Size(221, 36);
            this.MenuTextNormal.Text = "&Normal";
            this.MenuTextNormal.Click += new System.EventHandler(this.MenuTextNormal_Click);
            // 
            // MenuTextLarge
            // 
            this.MenuTextLarge.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuTextLarge.Name = "MenuTextLarge";
            this.MenuTextLarge.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.MenuTextLarge.Size = new System.Drawing.Size(221, 36);
            this.MenuTextLarge.Text = "&Large";
            this.MenuTextLarge.Click += new System.EventHandler(this.MenuTextLarge_Click);
            // 
            // FormatAlign
            // 
            this.FormatAlign.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormatAlignLeft,
            this.FormatAlignCenter,
            this.FormatAlignRight});
            this.FormatAlign.Name = "FormatAlign";
            this.FormatAlign.Size = new System.Drawing.Size(157, 24);
            this.FormatAlign.Text = "&Align";
            // 
            // FormatAlignLeft
            // 
            this.FormatAlignLeft.Image = ((System.Drawing.Image)(resources.GetObject("FormatAlignLeft.Image")));
            this.FormatAlignLeft.Name = "FormatAlignLeft";
            this.FormatAlignLeft.Size = new System.Drawing.Size(121, 24);
            this.FormatAlignLeft.Text = "&Left";
            this.FormatAlignLeft.Click += new System.EventHandler(this.FormatAlignLeft_Click);
            // 
            // FormatAlignCenter
            // 
            this.FormatAlignCenter.Image = ((System.Drawing.Image)(resources.GetObject("FormatAlignCenter.Image")));
            this.FormatAlignCenter.Name = "FormatAlignCenter";
            this.FormatAlignCenter.Size = new System.Drawing.Size(121, 24);
            this.FormatAlignCenter.Text = "&Center";
            this.FormatAlignCenter.Click += new System.EventHandler(this.FormatAlignCenter_Click);
            // 
            // FormatAlignRight
            // 
            this.FormatAlignRight.Image = ((System.Drawing.Image)(resources.GetObject("FormatAlignRight.Image")));
            this.FormatAlignRight.Name = "FormatAlignRight";
            this.FormatAlignRight.Size = new System.Drawing.Size(121, 24);
            this.FormatAlignRight.Text = "&Right";
            this.FormatAlignRight.Click += new System.EventHandler(this.FormatAlignRight_Click);
            // 
            // FormatOffset
            // 
            this.FormatOffset.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormatOffsetNormal,
            this.FormatOffsetSubscript,
            this.FormatOffsetSuperscript});
            this.FormatOffset.Name = "FormatOffset";
            this.FormatOffset.Size = new System.Drawing.Size(157, 24);
            this.FormatOffset.Text = "&Offset";
            // 
            // FormatOffsetNormal
            // 
            this.FormatOffsetNormal.Image = ((System.Drawing.Image)(resources.GetObject("FormatOffsetNormal.Image")));
            this.FormatOffsetNormal.Name = "FormatOffsetNormal";
            this.FormatOffsetNormal.Size = new System.Drawing.Size(152, 24);
            this.FormatOffsetNormal.Text = "&Normal";
            this.FormatOffsetNormal.Click += new System.EventHandler(this.FormatOffsetNormal_Click);
            // 
            // FormatOffsetSubscript
            // 
            this.FormatOffsetSubscript.Image = ((System.Drawing.Image)(resources.GetObject("FormatOffsetSubscript.Image")));
            this.FormatOffsetSubscript.Name = "FormatOffsetSubscript";
            this.FormatOffsetSubscript.Size = new System.Drawing.Size(152, 24);
            this.FormatOffsetSubscript.Text = "Su&bscript";
            this.FormatOffsetSubscript.Click += new System.EventHandler(this.FormatOffsetSubscript_Click);
            // 
            // FormatOffsetSuperscript
            // 
            this.FormatOffsetSuperscript.Image = ((System.Drawing.Image)(resources.GetObject("FormatOffsetSuperscript.Image")));
            this.FormatOffsetSuperscript.Name = "FormatOffsetSuperscript";
            this.FormatOffsetSuperscript.Size = new System.Drawing.Size(152, 24);
            this.FormatOffsetSuperscript.Text = "Su&perscript";
            this.FormatOffsetSuperscript.Click += new System.EventHandler(this.FormatOffsetSuperscript_Click);
            // 
            // FormatIndent
            // 
            this.FormatIndent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormatIndentNone,
            this.FormatIndentHanging,
            this.FormatIndentLeft,
            this.FormatIndentRight,
            this.FormatIndentBoth});
            this.FormatIndent.Name = "FormatIndent";
            this.FormatIndent.Size = new System.Drawing.Size(180, 24);
            this.FormatIndent.Text = "&Indent";
            this.FormatIndent.Click += new System.EventHandler(this.FormatIndent_Click);
            // 
            // FormatIndentNone
            // 
            this.FormatIndentNone.Image = ((System.Drawing.Image)(resources.GetObject("FormatIndentNone.Image")));
            this.FormatIndentNone.Name = "FormatIndentNone";
            this.FormatIndentNone.Size = new System.Drawing.Size(135, 24);
            this.FormatIndentNone.Text = "&None";
            this.FormatIndentNone.Click += new System.EventHandler(this.FormatIndentNone_Click);
            // 
            // FormatIndentHanging
            // 
            this.FormatIndentHanging.Image = ((System.Drawing.Image)(resources.GetObject("FormatIndentHanging.Image")));
            this.FormatIndentHanging.Name = "FormatIndentHanging";
            this.FormatIndentHanging.Size = new System.Drawing.Size(135, 24);
            this.FormatIndentHanging.Text = "&Hanging";
            this.FormatIndentHanging.Click += new System.EventHandler(this.FormatIndentHanging_Click);
            // 
            // FormatIndentLeft
            // 
            this.FormatIndentLeft.Image = ((System.Drawing.Image)(resources.GetObject("FormatIndentLeft.Image")));
            this.FormatIndentLeft.Name = "FormatIndentLeft";
            this.FormatIndentLeft.Size = new System.Drawing.Size(135, 24);
            this.FormatIndentLeft.Text = "&Left";
            this.FormatIndentLeft.Click += new System.EventHandler(this.FormatIndentLeft_Click);
            // 
            // FormatIndentRight
            // 
            this.FormatIndentRight.Image = ((System.Drawing.Image)(resources.GetObject("FormatIndentRight.Image")));
            this.FormatIndentRight.Name = "FormatIndentRight";
            this.FormatIndentRight.Size = new System.Drawing.Size(135, 24);
            this.FormatIndentRight.Text = "&Right";
            this.FormatIndentRight.Click += new System.EventHandler(this.FormatIndentRight_Click);
            // 
            // FormatIndentBoth
            // 
            this.FormatIndentBoth.Image = ((System.Drawing.Image)(resources.GetObject("FormatIndentBoth.Image")));
            this.FormatIndentBoth.Name = "FormatIndentBoth";
            this.FormatIndentBoth.Size = new System.Drawing.Size(135, 24);
            this.FormatIndentBoth.Text = "&Both";
            this.FormatIndentBoth.Click += new System.EventHandler(this.FormatIndentBoth_Click);
            // 
            // FormatBullet
            // 
            this.FormatBullet.Image = ((System.Drawing.Image)(resources.GetObject("FormatBullet.Image")));
            this.FormatBullet.Name = "FormatBullet";
            this.FormatBullet.Size = new System.Drawing.Size(157, 24);
            this.FormatBullet.Text = "B&ullet";
            this.FormatBullet.Click += new System.EventHandler(this.FormatBullet_Click);
            // 
            // txtDocument
            // 
            this.txtDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDocument.ContextMenuStrip = this.contextMenuStrip1;
            this.txtDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocument.Location = new System.Drawing.Point(0, 31);
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.Size = new System.Drawing.Size(960, 482);
            this.txtDocument.TabIndex = 6;
            this.txtDocument.Text = "\"If you have haters good, that means you stood up for something\" -Marshall Mather" +
    "s";
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 511);
            this.Controls.Add(this.txtDocument);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TextEditor";
            this.Text = "Way Cool Text Editor";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuSave;
        private System.Windows.Forms.ToolStripMenuItem MenuExit;
        private System.Windows.Forms.ToolStripMenuItem MenuFormat;
        private System.Windows.Forms.ToolStripMenuItem MenuColor;
        private System.Windows.Forms.ToolStripMenuItem MenuColorRed;
        private System.Windows.Forms.ToolStripMenuItem MenuColorGreen;
        private System.Windows.Forms.ToolStripMenuItem MenuColorBlue;
        private System.Windows.Forms.ToolStripMenuItem MenuBackground;
        private System.Windows.Forms.ToolStripMenuItem MenuPink;
        private System.Windows.Forms.ToolStripMenuItem MenuLightGreen;
        private System.Windows.Forms.ToolStripMenuItem MenuLightBlue;
        private System.Windows.Forms.ToolStripMenuItem MenuTextSize;
        private System.Windows.Forms.ToolStripMenuItem MenuTextSmall;
        private System.Windows.Forms.ToolStripMenuItem MenuTextNormal;
        private System.Windows.Forms.ToolStripMenuItem MenuTextLarge;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuNew;
        private System.Windows.Forms.ToolStripMenuItem MenuOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuEdit;
        private System.Windows.Forms.ToolStripMenuItem MenuUndo;
        private System.Windows.Forms.ToolStripMenuItem MenuRedo;
        private System.Windows.Forms.ToolStripMenuItem MenuCopy;
        private System.Windows.Forms.ToolStripMenuItem MenuPaste;
        private System.Windows.Forms.ToolStripMenuItem MenuDelete;
        private System.Windows.Forms.ToolStripMenuItem MenuSelectAll;
        private System.Windows.Forms.ToolStripMenuItem space;
        private System.Windows.Forms.ToolStripMenuItem MenuSaveAs;
        private System.Windows.Forms.ToolStripMenuItem MenuPrintPreview;
        private System.Windows.Forms.ToolStripMenuItem MenuPrint;
        private System.Windows.Forms.ToolStripMenuItem space1;
        private System.Windows.Forms.ToolStripMenuItem FormatAlign;
        private System.Windows.Forms.ToolStripMenuItem FormatAlignLeft;
        private System.Windows.Forms.ToolStripMenuItem FormatAlignCenter;
        private System.Windows.Forms.ToolStripMenuItem FormatAlignRight;
        private System.Windows.Forms.ToolStripMenuItem FormatOffset;
        private System.Windows.Forms.ToolStripMenuItem FormatOffsetNormal;
        private System.Windows.Forms.ToolStripMenuItem FormatOffsetSubscript;
        private System.Windows.Forms.ToolStripMenuItem FormatOffsetSuperscript;
        private System.Windows.Forms.ToolStripMenuItem FormatIndent;
        private System.Windows.Forms.ToolStripMenuItem FormatIndentNone;
        private System.Windows.Forms.ToolStripMenuItem FormatIndentHanging;
        private System.Windows.Forms.ToolStripMenuItem FormatIndentLeft;
        private System.Windows.Forms.ToolStripMenuItem FormatIndentRight;
        private System.Windows.Forms.ToolStripMenuItem FormatIndentBoth;
        private System.Windows.Forms.ToolStripMenuItem FormatBullet;
        private System.Windows.Forms.ToolStripMenuItem MenuWhite;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContextPink;
        private System.Windows.Forms.ToolStripMenuItem ContextWhite;
        private System.Windows.Forms.ToolStripMenuItem ContextBlue;
        private System.Windows.Forms.ToolStripMenuItem ContextGreen;
        private System.Windows.Forms.ToolStripMenuItem ContextBullet;
        private System.Windows.Forms.RichTextBox txtDocument;
    }
}

