using System.Drawing.Configuration;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace LabProd
{
    public partial class Form1 : Form
    {
        private PictureBox pictureBox;
        bool drawing;
        int historyCounter;
        GraphicsPath currentPath;
        Point oldLocation;
        Pen currentPen;
        Color historyColor;
        Label label_XY;
        TrackBar trackBarPen;
        List<Image> History;
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
            ((ToolStripMenuItem)itemSolid).Checked = true;
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
            toolStrip.Dock = DockStyle.Left;
            toolStrip.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;

            ToolStripMenuItem itemNew1 = new ToolStripMenuItem(null,null,new System.EventHandler(NewKeysKlick));
            itemNew1.ShortcutKeys = Keys.Control | Keys.N;
            itemNew1.Image = Bitmap.FromFile("../../../img/New1.png");
            itemNew1.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripMenuItem itemOpen1 = new ToolStripMenuItem();
            itemOpen1.Image = Bitmap.FromFile("../../../img/Open1.png");
            itemOpen1.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripMenuItem itemSave1 = new ToolStripMenuItem();
            itemSave1.Image = Image.FromFile("../../../img/Save1.png");
            itemSave1.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripMenuItem itemStyle1 = new ToolStripMenuItem();
            itemStyle1.Image = Image.FromFile("../../../img/Style1.png");
            itemStyle1.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripMenuItem itemExit1 = new ToolStripMenuItem();
            itemExit1.Image = Image.FromFile("../../../img/Exist1.png");
            itemExit1.ImageScaling = ToolStripItemImageScaling.None;


            toolStrip.Items.Add(itemNew1);
            toolStrip.Items.Add(itemOpen1);
            toolStrip.Items.Add(itemSave1);
            toolStrip.Items.Add(itemStyle1);
            toolStrip.Items.Add(itemExit1);

            Controls.Add(toolStrip);

            Controls.Add(MainMenu);
            Bitmap pic = new Bitmap(750, 500);
            pictureBox = new PictureBox();

            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(600, 600);
            pictureBox.Location = new Point(150, 50);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            trackBarPen = new TrackBar();
            drawing = false;
            currentPen = new Pen(Color.Black);
            currentPen.Width = trackBarPen.Value;
            trackBarPen.Size = new Size(400, 400);
            trackBarPen.Location = new Point(150, 700);
            trackBarPen.ValueChanged += TrackBarPen_ValueChanged;
            this.Controls.Add(trackBarPen);
            History = new List<Image>();
            InitializeComponent();

        }

        private void TrackBarPen_ValueChanged(object? sender, EventArgs e)
        {
            currentPen.Width = trackBarPen.Value;
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
            Application.Exit();
        }

        private void SaveKeysKlick(object? sender, EventArgs e)
        { 
            InitializeComponent();
            drawing = false;
            currentPen = new Pen(Color.Black);
            SaveFileDialog SaveDlg = new SaveFileDialog();
            SaveDlg.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            SaveDlg.Title = "Save an Image File";
            SaveDlg.FilterIndex = 4;
            SaveDlg.ShowDialog();
            if (SaveDlg.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)SaveDlg.OpenFile();
                switch (SaveDlg.FilterIndex)
                {
                    case 1:
                        this.pictureBox.Image.Save(fs, ImageFormat.Jpeg);
                        break;
                    case 2:
                        this.pictureBox.Image.Save(fs, ImageFormat.Bmp);
                        break;
                    case 3:
                        this.pictureBox.Image.Save(fs, ImageFormat.Gif);
                        break;
                    case 4:
                        this.pictureBox.Image.Save(fs, ImageFormat.Png);
                        break;
                }
                fs.Close();
            }
            if (pictureBox.Image == null)
            {
                var result = MessageBox.Show("��������� ������� ����������� ����� ��������� ������ �������?", "��������������", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.No: break;
                    case DialogResult.Yes: SaveKeysKlick(sender, e); break;
                    case DialogResult.Cancel: return;
                }
            }
        }

        private void OpenKeysKlick(object? sender, EventArgs e)
        {
            if (pictureBox?.Image != null)
            {
                var result = MessageBox.Show("salvestama see pilt", "Dangerous", MessageBoxButtons.YesNoCancel);

                switch (result)
                {
                    case DialogResult.No: break;
                    case DialogResult.Yes: SaveKeysKlick(sender, e); break;
                    case DialogResult.Cancel: return;
                }
            }
            OpenFileDialog OP = new OpenFileDialog();
            OP.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            OP.Title = "Save an Image File";
            OP.FilterIndex = 1;
            if (OP.ShowDialog() != DialogResult.Cancel)
            {
                pictureBox.Load(OP.FileName);
                pictureBox.AutoSize = true;
            }
        }

        private void NewKeysKlick(object sender, EventArgs e)
        {
            Bitmap canvas = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (Graphics g = Graphics.FromImage(canvas))
            {
                g.Clear(Color.White);
            }
            pictureBox.Image = canvas;

            pictureBox.MouseDown += PictureBox_MouseDown;
            pictureBox.MouseMove += PictureBox_MouseMove;
            pictureBox.MouseUp += PictureBox_MouseUp;

            this.Controls.Add(pictureBox);
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (pictureBox.Image == null)
            {
                MessageBox.Show("Create fail!");
                return;
            }

            if (e.Button == MouseButtons.Left)
            {
                drawing = true;
                oldLocation = e.Location;
                currentPath = new GraphicsPath();
            }
            else if (e.Button == MouseButtons.Right)
            {
                historyColor = currentPen.Color;
                currentPen.Color = pictureBox.BackColor;
            }
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            label_XY = new Label();
            label_XY.Text = "0, 0";
            label_XY.Location = new Point(10, 10);
            Controls.Add(label_XY);
            label_XY.Text = e.X.ToString() + ", " + e.Y.ToString();
            if (drawing)
            {
                Graphics g = Graphics.FromImage(pictureBox.Image);

                if (currentPen == null)
                {
                    currentPen = new Pen(Color.Black);
                }

                if (currentPath == null)
                {
                    currentPath = new GraphicsPath();
                }

                if (e.Button == MouseButtons.Left)
                {
                    currentPath.AddLine(oldLocation, e.Location);
                    g.DrawPath(currentPen, currentPath);
                    oldLocation = e.Location;
                }

                g.Dispose();
                pictureBox.Invalidate();
            }
        }
        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;

            try
            {
                currentPath.Dispose();
            }
            catch { }

            if (e.Button == MouseButtons.Right)
            {
                currentPen.Color = historyColor;
            }
        }
    }
}