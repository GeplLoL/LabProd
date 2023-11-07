namespace LabProd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            MenuStrip MainMenu = new MenuStrip();
            this.MainMenuStrip = MainMenu;
            ToolStripMenuItem itemFile = new ToolStripMenuItem("File");
            MainMenu.Items.Add(itemFile);
            ToolStripMenuItem itemEdit = new ToolStripMenuItem("Edit");
            MainMenu.Items.Add(itemEdit);
            ToolStripMenuItem itemHelp = new ToolStripMenuItem("Help");
            MainMenu.Items.Add(itemHelp);
            ToolStripMenuItem itemNew = new ToolStripMenuItem("New",null, new System.EventHandler(NewKeysKlick));
            itemNew.ShortcutKeys = Keys.Control | Keys.N;
            ToolStripMenuItem itemOpen = new ToolStripMenuItem("Open", null, new System.EventHandler(OpenKeysKlick));
            itemOpen.ShortcutKeys = Keys.F3;
            ToolStripMenuItem itemSave = new ToolStripMenuItem("Save", null, new System.EventHandler(SaveKeysKlick));
            itemSave.ShortcutKeys = Keys.F2;
            ToolStripMenuItem itemExit = new ToolStripMenuItem("Exist", null, new System.EventHandler(ExitKeysKlick));
            itemExit.ShortcutKeys = Keys.Alt | Keys.X;
            itemNew.Image = Image.FromFile("../../../img/New.png");
            itemOpen.Image = Image.FromFile("../../../img/Open.png");
            itemSave.Image = Image.FromFile("../../../img/Save.png");
            itemExit.Image = Image.FromFile("../../../img/Exist.png");
            itemFile.DropDownItems.Add(itemNew);
            itemFile.DropDownItems.Add(itemOpen);
            itemFile.DropDownItems.Add(itemSave);
            itemFile.DropDownItems.Add(itemExit);
            ToolStripMenuItem itemUndo = new ToolStripMenuItem("Undo", null, new System.EventHandler(UndoKeysKlick));
            itemUndo.ShortcutKeys = Keys.Control | Keys.Z;
            ToolStripMenuItem itemReno = new ToolStripMenuItem("Reno", null, new System.EventHandler(RenoKeysKlick));
            itemReno.ShortcutKeys = Keys.Control | Keys.Shift | Keys.Z;
            ToolStripMenuItem itemPen = new ToolStripMenuItem("Pen");
            itemUndo.Image = Image.FromFile("../../../img/Undo.png");
            itemReno.Image = Image.FromFile("../../../img/Reno.png");
            itemPen.Image = Image.FromFile("../../../img/Pen.png");
            itemEdit.DropDownItems.Add(itemUndo);
            itemEdit.DropDownItems.Add(itemReno);
            itemEdit.DropDownItems.Add(itemPen);
            ToolStripMenuItem itemStyle = new ToolStripMenuItem("Style");
            ToolStripMenuItem itemColor = new ToolStripMenuItem("Color");
            itemStyle.Image = Image.FromFile("../../../img/Style.png");
            itemPen.DropDownItems.Add(itemStyle);
            itemPen.DropDownItems.Add(itemColor);
            ToolStripMenuItem itemSolid = new ToolStripMenuItem("Solid");
            ToolStripMenuItem itemDot = new ToolStripMenuItem("Dot");
            ToolStripMenuItem itemDashDotDot = new ToolStripMenuItem("DashDotDot");
            itemStyle.DropDownItems.Add(itemSolid);
            itemStyle.DropDownItems.Add(itemDot);
            itemStyle.DropDownItems.Add(itemDashDotDot);
            ToolStripMenuItem itemAbout = new ToolStripMenuItem("About", null, new System.EventHandler(AboutKeysKlick));
            itemAbout.ShortcutKeys = Keys.F1;
            itemAbout.Image = Image.FromFile("../../../img/About.png");
            itemHelp.DropDownItems.Add(itemAbout);


            ToolStrip toolStrip = new ToolStrip();
            toolStrip.Orientation = Orientation.Vertical;
            itemNew = new ToolStripMenuItem("New");
            itemOpen = new ToolStripMenuItem("Open");
            itemSave = new ToolStripMenuItem("Save");
            itemStyle = new ToolStripMenuItem("Style");
            itemExit = new ToolStripMenuItem("Exit");

            toolStrip.Items.Add(itemNew);
            toolStrip.Items.Add(itemOpen);
            toolStrip.Items.Add(itemSave);
            toolStrip.Items.Add(itemStyle);
            toolStrip.Items.Add(itemExit);

            Controls.Add(toolStrip);








            Controls.Add(MainMenu);

            InitializeComponent();
        }

        private void AboutKeysKlick(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RenoKeysKlick(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void UndoKeysKlick(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ExitKeysKlick(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveKeysKlick(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OpenKeysKlick(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void NewKeysKlick(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}