using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabiRibiMapViewer
{
    public partial class SpritePickerForm : Form
    {
        PictureBox selectedPaletteSlot;
        Point currentCoordinate = new Point(0, 0);
        public int[,] paletteIDArray = new int[3, 13];
        Bitmap SpriteSheet;
        public SpritePickerForm()
        {
            InitializeComponent();
        }
        public SpritePickerForm(int[,] mainPalette, Bitmap _spriteSheet)
        {
            InitializeComponent();
            SpriteSheet = _spriteSheet;
            pictureBoxSpritePicker.Image = SpriteSheet;
            paletteIDArray = mainPalette;
            
            initializePalette(paletteIDArray);
        }

        private void initializePalette(int[,] mainPalette)
        {
            for (int i = 0; i < tableLayoutPanelPalette.ColumnCount; i++)
            {
                for (int j = 0; j < tableLayoutPanelPalette.RowCount; j++)
                {
                    PictureBox PB = new PictureBox();
                    PB.Anchor = AnchorStyles.None;
                    PB.Size = new Size(48, 48);
                    PB.SizeMode = PictureBoxSizeMode.StretchImage;
                    PB.Image = getSpriteByID(mainPalette[i, j]);
                    PB.Margin = new Padding(0, 0, 0, 0);
                    PB.Tag = mainPalette[i, j];
                    PB.BorderStyle = BorderStyle.Fixed3D;
                    tableLayoutPanelPalette.Controls.Add(PB, i, j);
                    PB.Click += PBPalette_Click;

                }
            }
            selectPaletteSlot((PictureBox)tableLayoutPanelPalette.GetControlFromPosition(0, 0));
        }
        private void selectPaletteSlot(PictureBox pbPalette)
        {
            selectedPaletteSlot = pbPalette;
            pbPalette.BorderStyle = BorderStyle.FixedSingle;
        }

        private void PBPalette_Click(object sender, EventArgs e)
        {
            int coordX = tableLayoutPanelPalette.GetPositionFromControl((PictureBox)sender).Column;
            int coordY = tableLayoutPanelPalette.GetPositionFromControl((PictureBox)sender).Row;
            currentCoordinate = new Point(coordX, coordY);

            selectedPaletteSlot.BorderStyle = BorderStyle.Fixed3D;
            selectPaletteSlot((PictureBox)sender);


        }
        


        private Bitmap getSpriteByID(int ID)//https://stackoverflow.com/a/13626080
        {
            Bitmap imgHolder = new Bitmap(32, 32);
            Graphics g = Graphics.FromImage(imgHolder);

            if (ID > 0)
            {
                int x = 32 * ((ID) % 32);
                int y = 32 * (ID / 32);
                g.DrawImage(pictureBoxSpritePicker.Image, new Rectangle(0, 0, 32, 32), new Rectangle(x, y, 32, 32), GraphicsUnit.Pixel);
            }
            return imgHolder;
        }
        

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle r = e.CellBounds;
            Point cellCoords = new Point(e.Column, e.Row);

            if (cellCoords == currentCoordinate)
            {
                g.FillRectangle(new SolidBrush(Color.DarkGray), r);
            }
            else
            {
                g.FillRectangle(new SolidBrush(SystemColors.Control), r);
            }
        }
        
        private void buttonSavePalette_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tableLayoutPanelPalette.ColumnCount; i++)
            {
                for (int j = 0; j < tableLayoutPanelPalette.RowCount; j++)
                {
                    paletteIDArray[i, j] = int.Parse(tableLayoutPanelPalette.GetControlFromPosition(i, j).Tag.ToString());
                }
            }
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void pictureBoxSpritePicker_Click(object sender, EventArgs e)//https://stackoverflow.com/questions/18040945/read-picture-box-mouse-coordinates-on-click
        {
            Bitmap toDisplay = new Bitmap(32, 32);
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;

            Graphics g = Graphics.FromImage(toDisplay);

            int x = coordinates.X / 32;
            int y = coordinates.Y / 32;
            int ID = x + y * 32;
            selectedPaletteSlot.Image = getSpriteByID(ID);
            selectedPaletteSlot.Tag = ID;
        }
    }
}
