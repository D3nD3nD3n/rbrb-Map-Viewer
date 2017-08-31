using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace RabiRibiMapViewer
{
    class RoomGraphicTabController
    {
        TableLayoutPanel TLPRoom, TLPSpritePalette;
        Bitmap spriteSheet;
        PictureBox pbSelectedSprite;
        CheckBox cbHorizontalFlip, cbVerticalFlip, cbRightClickCopy;
        ListBox lbLayer;
        Button btnFillSpritePicker;
        Point palatteCurrentCoord = new Point(0, 0);
        Map map;
        int selectedImageValue = 1;
        
        public RoomGraphicTabController(TableLayoutPanel _TLPRoom,TableLayoutPanel _TLPspritePalette, Bitmap _spriteSheet, PictureBox _pbSelectedSprited, CheckBox _cbHorizontal, CheckBox _cbVertical, CheckBox _checkBoxRightClickCopy, ListBox _lbLayer, Button _btnFillSprites, Map _map)
        {
            TLPRoom = _TLPRoom;
            TLPSpritePalette = _TLPspritePalette;
            spriteSheet = _spriteSheet;
            pbSelectedSprite = _pbSelectedSprited;
            cbHorizontalFlip = _cbHorizontal;
            cbVerticalFlip = _cbVertical;
            cbRightClickCopy = _checkBoxRightClickCopy;
            lbLayer = _lbLayer;
            btnFillSpritePicker = _btnFillSprites;
            map = _map;

            pbSelectedSprite.Image = getSpriteByID(0);
            initializeRoomSpriteTable();
            initializeSpritePalette();
        }

        private Bitmap getSpriteByID(int ID)//https://stackoverflow.com/a/13626080
        {
            Bitmap imgHolder = new Bitmap(32, 32);

            using (Graphics g = Graphics.FromImage(imgHolder))
            { 
                if (ID > 0)
                {
                    int x = 32 * ((ID) % 32);
                    int y = 32 * (ID / 32);
                    g.DrawImage(spriteSheet, new Rectangle(0, 0, 32, 32), new Rectangle(x, y, 32, 32), GraphicsUnit.Pixel);
                }
            }
            return imgHolder;
        }

        public void initializeRoomSpriteTable()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    PictureBox PB = new PictureBox();
                    PB.Size = new Size(48, 48);
                    PB.SizeMode = PictureBoxSizeMode.StretchImage;
                    PB.Margin = new Padding(0, 0, 0, 0);
                    PB.Tag = 0;
                    TLPRoom.Controls.Add(PB, i, j);
                    PB.Click += PBRoomSpriteGrid_Click;
                }
            }
        }

        public void initializeSpritePalette()
        {
            for (int i = 0; i < TLPSpritePalette.ColumnCount; i++)
            {
                for (int j = 0; j < TLPSpritePalette.RowCount; j++)
                {
                    PictureBox PB = new PictureBox();
                    PB.Size = new Size(48, 48);
                    PB.SizeMode = PictureBoxSizeMode.StretchImage;
                    PB.Margin = new Padding(0, 0, 0, 0);
                    PB.Image = getSpriteByID(0);
                    PB.BorderStyle = BorderStyle.FixedSingle;
                    
                    PB.Tag = 0;
                    
                    TLPSpritePalette.Controls.Add(PB, i, j);
                    PB.Click += PBPaletteCell_Click;
                }

            }
        }

        private void PBPaletteCell_Click(object sender, EventArgs e)
        {
            PictureBox PB = (PictureBox)sender;
            selectSprite(PB);
        }

        /// <summary>
        /// Change currently active left click sprite.
        /// </summary>
        /// <param name="PB"></param>
        public void selectSprite(PictureBox PB)
        {
                selectedImageValue = int.Parse(PB.Tag.ToString());
                Bitmap imageHolder = getSpriteByID(selectedImageValue);
                if (cbVerticalFlip.Checked)
                {
                    imageHolder.RotateFlip(RotateFlipType.Rotate180FlipX);
                }
                if (cbHorizontalFlip.Checked)
                {
                    imageHolder.RotateFlip(RotateFlipType.Rotate180FlipY);
                }
                pbSelectedSprite.Image = imageHolder;
                PB.BackColor = Color.Gray;
                PictureBox oldPB = (PictureBox)TLPSpritePalette.GetControlFromPosition(palatteCurrentCoord.X, palatteCurrentCoord.Y);
                oldPB.BackColor = Color.Transparent;

                palatteCurrentCoord = new Point(TLPSpritePalette.GetPositionFromControl(PB).Column, TLPSpritePalette.GetPositionFromControl(PB).Row);
        }

        private void PBRoomSpriteGrid_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            PictureBox PB = (PictureBox)sender;
            if (me.Button == MouseButtons.Left)
            {
                int x = TLPRoom.GetPositionFromControl(PB).Column;
                int y = TLPRoom.GetPositionFromControl(PB).Row;
                UInt16 imgValueHolder = (UInt16)selectedImageValue;
                Bitmap selectedImageBMP = getSpriteByID(selectedImageValue);
                if (cbVerticalFlip.Checked)
                {
                    imgValueHolder += 5000;
                    selectedImageBMP.RotateFlip(RotateFlipType.Rotate180FlipX);
                }
                if (cbHorizontalFlip.Checked)
                {
                    imgValueHolder = (UInt16)(65536 - imgValueHolder);
                    selectedImageBMP.RotateFlip(RotateFlipType.Rotate180FlipY);
                }

                MemoryHandler mh = new MemoryHandler();
                if (mh.version >= 0)
                {
                    mh.commitSingleRoom(imgValueHolder, lbLayer.SelectedIndex + 3, x, y, map);

                    PB.Image = selectedImageBMP;
                    PB.Tag = imgValueHolder;
                }
            }
            else if (me.Button == MouseButtons.Right)
            {
                if (cbRightClickCopy.Checked)
                {
                    int spriteIDHolder = int.Parse(PB.Tag.ToString());
                    if (spriteIDHolder > 58740)
                    {
                        spriteIDHolder = Math.Abs(65536 - spriteIDHolder);
                    }
                    if (spriteIDHolder > 5000)
                    {
                        spriteIDHolder = (spriteIDHolder - 5000);
                    }
                    updateSinglePalette(palatteCurrentCoord, spriteIDHolder);
                    selectedImageValue = spriteIDHolder;
                }
            }
        }

        /// <summary>
        /// Fill room sprite grid
        /// </summary>
        /// <param name="targetLayer"></param>
        public void fillRoom(int targetLayer)
        {
            {
                UInt16[,] roomInfo = map.getRoomLayer(targetLayer + 3);
                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < map.verticalHeights[map.currentRoomY]; j++)
                    {
                        PictureBox pb = (PictureBox)TLPRoom.GetControlFromPosition(i, j);
                        pb.Enabled = true;
                        int spriteIDHolder = roomInfo[i, j];
                        bool flipX = false, flipY = false;
                        if (spriteIDHolder > 58740)
                        {
                            flipY = true;
                            spriteIDHolder = Math.Abs(65536 - spriteIDHolder);
                        }
                        if (spriteIDHolder > 5000)
                        {
                            flipX = true;
                            spriteIDHolder = (spriteIDHolder - 5000);
                        }
                        Image imgHolder = getSpriteByID(spriteIDHolder);
                        if (flipX)
                        {
                            imgHolder.RotateFlip(RotateFlipType.Rotate180FlipX);
                        }
                        if (flipY)
                        {
                            imgHolder.RotateFlip(RotateFlipType.Rotate180FlipY);
                        }
                        pb.Image = imgHolder;
                        pb.Tag = roomInfo[i, j];


                    }
                }
                if( map.verticalHeights[map.currentRoomY] < 12)
                {
                    for(int i = 0; i < 20; i++)
                    {
                        for(int j = map.verticalHeights[map.currentRoomY]; j < 12; j++)
                        {
                            PictureBox pb = (PictureBox)TLPRoom.GetControlFromPosition(i, j);
                            pb.Enabled = false;
                            pb.Image = getSpriteByID(0);
                        }
                    }
                }
            }
        }

        
        /// <summary>
        /// Copy entire palette from SpritePickerForm
        /// </summary>
        public void updatePalette()
        {
            int[,] currentPalette = new int[3, 13];
            for(int i = 0; i < TLPSpritePalette.ColumnCount; i++)
            {
                for(int j = 0; j < TLPSpritePalette.RowCount; j++)
                {
                    currentPalette[i, j] = int.Parse(TLPSpritePalette.GetControlFromPosition(i, j).Tag.ToString());
                }
            }
            using (SpritePickerForm SPF = new SpritePickerForm(currentPalette, spriteSheet))
            {
                var result = SPF.ShowDialog();
                if(result == DialogResult.OK)
                {
                    for (int i = 0; i < TLPSpritePalette.ColumnCount; i++)
                    {
                        for (int j = 0; j < TLPSpritePalette.RowCount; j++)
                        {
                            PictureBox PB = (PictureBox)TLPSpritePalette.GetControlFromPosition(i, j);
                            PB.Image = getSpriteByID(SPF.paletteIDArray[i, j]);
                            PB.Tag = SPF.paletteIDArray[i, j];
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Copy one sprite into selected palette cell.  Used in Copy: right click.
        /// </summary>
        /// <param name="paletteCoord"></param>
        /// <param name="copiedID"></param>
        public void updateSinglePalette(Point paletteCoord, int copiedID)
        {

            PictureBox PB = (PictureBox)TLPSpritePalette.GetControlFromPosition(paletteCoord.X, paletteCoord.Y);
            

            PB.Image = getSpriteByID(copiedID);
            PB.Tag = copiedID;
            selectSprite(PB);
        }

        public void flipCurrentSpriteHorizontal()
        {
            Image img = pbSelectedSprite.Image;
            img.RotateFlip(RotateFlipType.Rotate180FlipY);
            pbSelectedSprite.Image = img;
        }
        public void flipCurrentSpriteVertical()
        {
            Image img = pbSelectedSprite.Image;
            img.RotateFlip(RotateFlipType.Rotate180FlipX);
            pbSelectedSprite.Image = img;
        }
    }
}
