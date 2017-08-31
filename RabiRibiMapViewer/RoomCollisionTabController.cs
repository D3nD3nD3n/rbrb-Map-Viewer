using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabiRibiMapViewer
{
    class RoomCollisionTabController
    {
        Map map;
        TableLayoutPanel TLPRoom, TLPCollisions;
        Bitmap collisionSheet;
        Point currentCoord = new Point(0, 0);
        ushort selectedCollisionValue = 0;
        
        public RoomCollisionTabController(TableLayoutPanel _tlpRoom, TableLayoutPanel _tlpCollisions, Bitmap _collisionSheet, Map _map)
        {
            map = _map;
            TLPRoom = _tlpRoom;
            TLPCollisions = _tlpCollisions;
            collisionSheet = _collisionSheet;

            initializeCollisionTable();
            initializeCollisionPalette();
        }

        /// <summary>
        /// Load Collision IDs into Grid
        /// </summary>
        public void fillRoom()
        {
            UInt16[,] roomInfo = map.getRoomLayer(0);
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < map.verticalHeights[map.currentRoomY]; j++)
                {
                    PictureBox pb = (PictureBox)TLPRoom.GetControlFromPosition(i, j);
                    pb.Enabled = true;
                    int collisionIDHolder = roomInfo[i, j];
                    Image imgHolder = getCollisionByID(collisionIDHolder);
                    pb.Image = imgHolder;
                }
            }
            if (map.verticalHeights[map.currentRoomY] < 12)
            {
                for (int i = 0; i < 20; i++)
                {
                    for (int j = map.verticalHeights[map.currentRoomY]; j < 12; j++)
                    {
                        PictureBox pb = (PictureBox)TLPRoom.GetControlFromPosition(i, j);
                        pb.Enabled = false;
                        pb.Image = getCollisionByID(0);
                    }
                }
            }
        }

        public void initializeCollisionTable()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    PictureBox PB = new PictureBox();
                    PB.Size = new Size(48, 48);
                    PB.Enabled = true;
                    PB.SizeMode = PictureBoxSizeMode.StretchImage;
                    PB.Margin = new Padding(0, 0, 0, 0);
                    TLPRoom.Controls.Add(PB, i, j);
                    PB.Click += PBGridClick_Click;
                }
            }
        }

        public void initializeCollisionPalette()
        {
            for (int i = 0; i < TLPCollisions.ColumnCount; i++)
            {
                for (int j = 0; j < TLPCollisions.RowCount; j++)
                {
                    PictureBox PB = new PictureBox();
                    PB.Size = new Size(48, 48);
                    PB.SizeMode = PictureBoxSizeMode.StretchImage;
                    PB.Margin = new Padding(0, 0, 0, 0);
                    PB.Tag = i + j * 2;
                    PB.Image = getCollisionByID(i + j * 2);

                    TLPCollisions.Controls.Add(PB, i, j);
                    PB.Click += PB_selectCollision;
                }
            }
        }

        /// <summary>
        /// Change currently selected Collision type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PB_selectCollision(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            currentCoord = new Point(TLPCollisions.GetPositionFromControl(pb).Column, TLPCollisions.GetPositionFromControl(pb).Row);
            selectedCollisionValue = UInt16.Parse(pb.Tag.ToString());
            TLPCollisions.Invalidate();
        }

        /// <summary>
        /// Highlight currently selected sprite.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void paintCollisionPicker(object sender, TableLayoutCellPaintEventArgs e)
        {
            Rectangle r = e.CellBounds;
            Point cellCoords = new Point(e.Column, e.Row);
            Graphics g = e.Graphics;
            if (cellCoords == currentCoord)
            {
                g.FillRectangle(new SolidBrush(Color.DarkGray), r);
            }
            else
            {
                g.FillRectangle(new SolidBrush(SystemColors.Control), r);
            }
        }

        private void PBGridClick_Click(object sender, EventArgs e)
        {
            PictureBox PB = (PictureBox)sender;
            int x = TLPRoom.GetPositionFromControl(PB).Column;
            int y = TLPRoom.GetPositionFromControl(PB).Row;
            Bitmap selectedImageBMP = getCollisionByID(selectedCollisionValue);
            

            MemoryHandler mh = new MemoryHandler();
            if (mh.version >= 0)
            {
                mh.commitSingleRoom(selectedCollisionValue, 0, x, y, map);

                PB.Image = selectedImageBMP;
            }
        }

        private Bitmap getCollisionByID(int ID)//https://stackoverflow.com/a/13626080
        {
            Bitmap imgHolder = new Bitmap(32, 32);

            using (Graphics g = Graphics.FromImage(imgHolder))
            { 
                if (ID > 0)
                {
                    int x = 32 * ((ID) % 32);
                    g.DrawImage(collisionSheet, new Rectangle(0, 0, 32, 32), new Rectangle(x, 0, 32, 32), GraphicsUnit.Pixel);
                }
            }
            return imgHolder;
        }
    }
}
