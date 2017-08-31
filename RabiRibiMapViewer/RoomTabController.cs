using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabiRibiMapViewer
{
    public class RoomTabController
    {
        private ListBox listBoxRoomLayerMemoryOrder, listBoxRoomLayerSpriteOrder;
        private CheckBox cbAutoCommit;
        private TableLayoutPanel TLPRoom;
        private Map map;

        public RoomTabController(TableLayoutPanel TLP, Button _buttonCommit, Button _buttonReloadValues, ListBox _listBoxRoomLayerMemory, ListBox _listBoxRoomLayerSprite, CheckBox _cbAutoCommit, Map _map)
        {
            TLPRoom = TLP;
            listBoxRoomLayerMemoryOrder = _listBoxRoomLayerMemory;
            listBoxRoomLayerSpriteOrder = _listBoxRoomLayerSprite;
            cbAutoCommit = _cbAutoCommit;
            map = _map;
            

            initializeRoomGrid();
            
        }
        public void fillRoom(int targetLayer)
        {
            
            foreach (TextBox tb in TLPRoom.Controls)
            {
                tb.Enabled = true;
            }
            if (map.verticalHeights[map.currentRoomY] == 11)
            {
                for(int i = 0; i < 20; i++)
                {
                    TLPRoom.GetControlFromPosition(i, 11).Enabled = false;
                    TLPRoom.GetControlFromPosition(i, 11).Text = "0";
                    TLPRoom.GetControlFromPosition(i, 11).BackColor = Color.SlateGray;
                }
            }
             if(map.verticalHeights[map.currentRoomY] == 8)
            {
                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        TLPRoom.GetControlFromPosition(i, 9+j).Enabled = false;
                        TLPRoom.GetControlFromPosition(i, 9 + j).Text = "0";
                        TLPRoom.GetControlFromPosition(i, 9 + j).BackColor = Color.SlateGray;
                    }
                }
            }
            updateRoomGrid(targetLayer);
            
        }

        private void initializeRoomGrid()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    TextBox tb = new TextBox();
                    tb.Text = "0";
                    tb.Leave += Tb_Leave;
                    tb.Enter += Tb_Enter;

                    tb.BorderStyle = BorderStyle.FixedSingle;
                    TLPRoom.Controls.Add(tb, i, j);
                }
            }
        }

        private void Tb_Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Tag = tb.Text;
        }

        private void Tb_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            try
            {
                UInt16 newValue = UInt16.Parse(tb.Text);
                tb.Tag = tb.Text;
                if (cbAutoCommit.Checked)
                {
                    MemoryHandler mh = new MemoryHandler();
                    if (mh.version >= 0)
                    {
                        int x = TLPRoom.GetPositionFromControl(tb).Column;
                        int y = TLPRoom.GetPositionFromControl(tb).Row;

                        mh.commitSingleRoom(newValue, listBoxRoomLayerMemoryOrder.SelectedIndex, x, y, map);
                        updateRoomGrid(listBoxRoomLayerMemoryOrder.SelectedIndex);
                    }
                }
            }
            catch
            {
                tb.Text = tb.Tag.ToString();
            }
        }

        public void updateRoomGrid(int targetLayer)
        {
            UInt16[,] roomInfo = map.getRoomLayer(targetLayer);
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < map.verticalHeights[map.currentRoomY]; j++)
                {
                    TLPRoom.GetControlFromPosition(i, j).Text = roomInfo[i, j].ToString();
                    if (roomInfo[i, j] > 0)
                    {
                        TLPRoom.GetControlFromPosition(i, j).BackColor = Color.LightBlue;
                    }
                    else
                    {
                        TLPRoom.GetControlFromPosition(i, j).BackColor = Color.White;
                    }
                }
            }
        }

        public void commitRoomChanges()
        {
            MemoryHandler mh = new MemoryHandler();
            if (mh.version >= 0)
            {
                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < map.verticalHeights[map.currentRoomY]; j++)
                    {


                        int finalIndex = j + i * 200;
                        finalIndex += map.verticalHeights.Take<int>(map.currentRoomY).Sum();
                        finalIndex += map.currentRoomX * 4000;
                        UInt16 newValue = UInt16.Parse(TLPRoom.GetControlFromPosition(i, j).Text);

                        map.roomLayerArray[listBoxRoomLayerMemoryOrder.SelectedIndex][finalIndex] = newValue;

                        mh.commitSingleRoom(newValue, listBoxRoomLayerMemoryOrder.SelectedIndex, finalIndex);
                    }

                }
                updateRoomGrid(listBoxRoomLayerMemoryOrder.SelectedIndex);
            }
        }
    }
}
