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
    public partial class MapViewerForm : Form
    {
        Map map = new Map();
        MapTabController MTC;
        RoomTabController RTC;
        SaveTabController STC;
        RoomGraphicTabController RGTC;
        RoomCollisionTabController RCTC;
        Bitmap SpriteSheet;
        Bitmap collisionSheet;
        
        public MapViewerForm()
        {

            InitializeComponent();
            loadSheets();

            RTC = new RoomTabController(tableLayoutPanelRoom, buttonRoomCommitChanges, buttonRoomReload, listBoxRoomLayerMemoryOrder, listBoxRoomLayerSpriteOrder, checkBoxRoomAutoCommit, map);
            MTC = new MapTabController(tableLayoutFullMap, buttonMapCommitChanges, buttonMapLoadMemory, listBoxMapLayers, checkBoxMapLeftClickChange, checkBoxMapAutoCommit, checkBoxCacheCommit, map);
            RGTC = new RoomGraphicTabController(tableLayoutPanelRoomGraphic, tableLayoutRoomGraphicPanelPalette, SpriteSheet, pictureBoxRoomGraphicSprite, checkBoxRoomGraphicHorizontal, checkBoxRoomGraphicVertical, checkBoxRightClickCopy, listBoxRoomGraphicLayerMemoryOrder, buttonRoomGraphicSelectPalette, map);
            RCTC = new RoomCollisionTabController(tableLayoutPanelRoomCollision, tableLayoutPanelRoomCollisionCollisions, collisionSheet, map);
            STC = new SaveTabController();
        }

        private void loadSheets()
        {
            SpriteSheet = Properties.Resources.TILE1_A;
            collisionSheet = Properties.Resources.COLLISION_TILES;
            /*bool sheetFound = false;
            if (File.Exists(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\TILE1_A.PNG"))
            {
                SpriteSheet = (Bitmap)Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\TILE1_A.PNG");
                sheetFound = true;
            }
            else if (File.Exists(Directory.GetCurrentDirectory() + "\\TILE1_A.PNG"))
            {
                SpriteSheet = (Bitmap)Image.FromFile(Directory.GetCurrentDirectory() + "\\TILE1_A.PNG");
                sheetFound = true;
            }
            else
            {
                SpriteSheet = Properties.Resources.noImage;
                MessageBox.Show("Put TILE1_A.PNG into executable's folder.", "Missing Sprite Sheet.", MessageBoxButtons.OK);
            }

            if (SpriteSheet == null && sheetFound == true)
            {
                SpriteSheet = Properties.Resources.noImage;
                MessageBox.Show("Sprite sheet was found, but it failed to load.", "", MessageBoxButtons.OK);
            }

            sheetFound = false;
            if (File.Exists(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\COLLISION_TILES.PNG"))
            {
                collisionSheet = (Bitmap)Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\COLLISION_TILES.PNG");
                sheetFound = true;
            }
            else if (File.Exists(Directory.GetCurrentDirectory() + "\\COLLISION_TILES.PNG"))
            {
                collisionSheet = (Bitmap)Image.FromFile(Directory.GetCurrentDirectory() + "\\COLLISION_TILES.PNG");
                sheetFound = true;
            }
            else
            {
                collisionSheet = Properties.Resources.noImage;
                MessageBox.Show("Put COLLISION_TILES.PNG into executable's folder.", "Missing Sprite Sheet.", MessageBoxButtons.OK);
            }

            if(collisionSheet == null && sheetFound == true)
            {
                collisionSheet = Properties.Resources.noImage;
                MessageBox.Show("Collision sheet was found, but it failed to load.", "", MessageBoxButtons.OK);
            }*/
        }
        private void buttonMapLoadMemory_Click(object sender, EventArgs e)
        {
            map.loadMap();
            if(listBoxMapLayers.SelectedIndex < 0)
            {
                listBoxMapLayers.SelectedIndex = 0;
            }
            MTC.fillMap(listBoxMapLayers.SelectedIndex);
        }
        private void listBoxRoomLayerMemoryOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxRoomLayerSpriteOrder.SelectedItem = listBoxRoomLayerMemoryOrder.SelectedItem;
            RTC.fillRoom(listBoxRoomLayerMemoryOrder.SelectedIndex);
        }

        private void listBoxMapLayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            MTC.fillMap(lb.SelectedIndex);
        }

        private void tableLayoutFullMap_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            MTC.paintMap(sender, e);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab == tabPageMap)
            {
                MTC.setColorActiveRoom();
            }
            if(tabControl1.SelectedTab == tabPageRoom)
            {
                if (listBoxRoomLayerMemoryOrder.SelectedIndex < 0)
                    listBoxRoomLayerMemoryOrder.SelectedIndex = 0;
                RTC.fillRoom(listBoxRoomLayerMemoryOrder.SelectedIndex);
            }
            if(tabControl1.SelectedTab == tabPageRoomGraphic)
            {
                if (listBoxRoomGraphicLayerMemoryOrder.SelectedIndex < 0)
                    listBoxRoomGraphicLayerMemoryOrder.SelectedIndex = 0;
                RGTC.fillRoom(listBoxRoomGraphicLayerMemoryOrder.SelectedIndex);

            }
            if(tabControl1.SelectedTab == tabPageRoomCollision)
            {
                RCTC.fillRoom();
            }
        }

        private void listBoxRoomLayerSpriteOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxRoomLayerMemoryOrder.SelectedItem = listBoxRoomLayerSpriteOrder.SelectedItem;
        }

        private void buttonMapCommitChanges_Click(object sender, EventArgs e)
        {
            MTC.commitChanges();

        }

        private void buttonRoomCommitChanges_Click(object sender, EventArgs e)
        {
            RTC.commitRoomChanges();
        }

        private void buttonPickMap_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBoxFilePath.Text = openFileDialog1.FileName;
        }

        private void buttonSaveMap_Click(object sender, EventArgs e)
        {
            STC.newMapSave(textBoxFilePath.Text, map);
        }

        private void buttonRoomGraphicFill_Click(object sender, EventArgs e)
        {
            RGTC.updatePalette();
        }

        private void listBoxRoomGraphicLayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            RGTC.fillRoom(listBoxRoomGraphicLayerMemoryOrder.SelectedIndex);
            listBoxRoomGraphicLayerSpriteOrder.SelectedItem = listBoxRoomGraphicLayerMemoryOrder.SelectedItem;
        }

        private void checkBoxRoomGraphicHorizontal_CheckedChanged(object sender, EventArgs e)
        {
            RGTC.flipCurrentSpriteHorizontal();
        }

        private void checkBoxRoomGraphicVertical_CheckedChanged(object sender, EventArgs e)
        {
            RGTC.flipCurrentSpriteVertical();
        }

        private void tableLayoutPanelRoomCollisionCollisions_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            RCTC.paintCollisionPicker(sender, e);
        }

        private void listBoxRoomGraphicLayerSpriteOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxRoomGraphicLayerMemoryOrder.SelectedItem = listBoxRoomGraphicLayerSpriteOrder.SelectedItem;
        }
        
        private void buttonMoveLeft_Click(object sender, EventArgs e)
        {
            if(map.currentRoomX > 0)
            {
                map.currentRoomX = map.currentRoomX - 1;
                if(tabControl1.SelectedTab == tabPageRoom)
                {
                    RTC.fillRoom(listBoxRoomLayerMemoryOrder.SelectedIndex);
                }
                else if (tabControl1.SelectedTab == tabPageRoomGraphic)
                {
                    RGTC.fillRoom(listBoxRoomGraphicLayerMemoryOrder.SelectedIndex);
                }
                else if (tabControl1.SelectedTab == tabPageRoomCollision)
                {
                    RCTC.fillRoom();
                }
                map.changeCounter++;
            }
        }

        private void buttonMoveUp_Click(object sender, EventArgs e)
        {
            if (map.currentRoomY > 0)
            {
                map.currentRoomY = map.currentRoomY - 1;
                if (tabControl1.SelectedTab == tabPageRoom)
                {
                    RTC.fillRoom(listBoxRoomLayerMemoryOrder.SelectedIndex);
                }
                else if (tabControl1.SelectedTab == tabPageRoomGraphic)
                {
                    RGTC.fillRoom(listBoxRoomGraphicLayerMemoryOrder.SelectedIndex);
                }
                else if (tabControl1.SelectedTab == tabPageRoomCollision)
                {
                    RCTC.fillRoom();
                }
                map.changeCounter++;
            }
        }

        private void buttonMoveRight_Click(object sender, EventArgs e)
        {
            if(map.currentRoomX < 24)
            {
                map.currentRoomX = map.currentRoomX + 1;
                if (tabControl1.SelectedTab == tabPageRoom)
                {
                    RTC.fillRoom(listBoxRoomLayerMemoryOrder.SelectedIndex);
                }
                else if (tabControl1.SelectedTab == tabPageRoomGraphic)
                {
                    RGTC.fillRoom(listBoxRoomGraphicLayerMemoryOrder.SelectedIndex);
                }
                else if (tabControl1.SelectedTab == tabPageRoomCollision)
                {
                    RCTC.fillRoom();
                }
                map.changeCounter++;
            }
        }

        private void buttonMoveDown_Click(object sender, EventArgs e)
        {
            if (map.currentRoomY < 17)
            {
                map.currentRoomY = map.currentRoomY + 1;
                if (tabControl1.SelectedTab == tabPageRoom)
                {
                    RTC.fillRoom(listBoxRoomLayerMemoryOrder.SelectedIndex);
                }
                else if (tabControl1.SelectedTab == tabPageRoomGraphic)
                {
                    RGTC.fillRoom(listBoxRoomGraphicLayerMemoryOrder.SelectedIndex);
                }
                else if (tabControl1.SelectedTab == tabPageRoomCollision)
                {
                    RCTC.fillRoom();
                }
                map.changeCounter++;
            }
        }

        private void buttonRoomReload_Click(object sender, EventArgs e)
        {
            RTC.fillRoom(listBoxRoomLayerMemoryOrder.SelectedIndex);
        }
    }
}
