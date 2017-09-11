using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace RabiRibiMapViewer
{
    public class MapTabController
    {
        private int changeCounterCheck = 0;
        private Map map;
        private ListBox listBoxMapLayer;
        private CheckBox CBChangeRoom;
        private CheckBox CBAutoCommit;
        private CheckBox CBCacheCommit;
        private Button buttonCommitChanges;
        private Button buttonLoadMemory;
        private TableLayoutPanel tableFullMap;
        private int roomX, roomY;

        public Dictionary<int, Color> mapColors = new Dictionary<int, Color>
        {
            {0, Color.White },
            {1, Color.FromArgb(116, 187, 109) },
            {2, Color.FromArgb(102, 109, 167) },
            {3, Color.FromArgb(141,116,80) },
            {4, Color.FromArgb(134,174,121)},
            {5, Color.FromArgb(255, 255, 0)},
            {6, Color.FromArgb(151,114,114)},
            {7, Color.FromArgb(6, 133, 90)},
            {8, Color.FromArgb(57, 58, 58)},
            {9, Color.FromArgb(103, 141, 198)},
            {10, Color.FromArgb(203, 167, 80)},
            {11, Color.FromArgb(116, 187, 109)},
            {12, Color.FromArgb(223, 151, 131)},
            {13, Color.FromArgb(186, 116, 109)},
            {14, Color.FromArgb(116, 116, 187)},
            {15, Color.FromArgb(148, 110, 156)},
            {16, Color.FromArgb(148, 110, 240)},
            {17, Color.FromArgb(110,162,212)},
            {18, Color.FromArgb(81,103,215)},
            {19, Color.FromArgb(181,109,140)},
            {20, Color.FromArgb(212,162,111)},
            {21, Color.FromArgb(185,64,60)},
            {22, Color.FromArgb(217,82,92)},
            {23, Color.FromArgb(39,174,215)},
            {24, Color.FromArgb(123,204,172)},
            {25, Color.FromArgb(134,174,121)},
            {26, Color.FromArgb(112,201,118)},
            {27, Color.FromArgb(114,184,94)},
            {28, Color.FromArgb(192,51,48)},
            {29, Color.FromArgb(200,104,50)},
            {30, Color.FromArgb(70,105,170)},
            {31, Color.FromArgb(51,109,152)},
            {32, Color.FromArgb(238,170,246)},
            {33, Color.FromArgb(57,58,58)},
            {34, Color.FromArgb(127,61,59)},
            {50, Color.FromArgb(102,103,142)},
            {55, Color.FromArgb(48,189,126)},
            {87, Color.FromArgb(209,131,128)},
        };

        public MapTabController(TableLayoutPanel _tableFullMap, Button _buttonCommitChanges, Button _buttonLoadMemory, ListBox _listBoxMapLayer, CheckBox _leftClickChange, CheckBox _autoCommit, CheckBox _cacheCommit, Map _map)
        {
            tableFullMap = _tableFullMap;
            buttonCommitChanges = _buttonCommitChanges;
            buttonLoadMemory = _buttonLoadMemory;
            listBoxMapLayer = _listBoxMapLayer;
            CBAutoCommit = _autoCommit;
            CBChangeRoom = _leftClickChange;
            CBCacheCommit = _cacheCommit;
            map = _map;


            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 18; j++)
                {
                    TextBox tb = new TextBox();

                    tb.Text = "0";
                    tb.Click += mapTextBox_Click;
                    tb.Leave += mapTextBox_Leave;
                    tb.Anchor = AnchorStyles.None;
                    tb.BorderStyle = BorderStyle.FixedSingle;
                    tableFullMap.Controls.Add(tb, i, j);
                }
            }
            
        }

        private void mapTextBox_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            try
            {
                Int16 displayValue = Int16.Parse(tb.Text);
                UInt16 newValue = map.shortToUshort(displayValue);
                tb.Tag = tb.Text;
                if (CBAutoCommit.Checked)
                {
                    MemoryHandler mh = new MemoryHandler();
                    if (mh.version >= 0)
                    {
                        int x = tableFullMap.GetPositionFromControl(tb).Column;
                        int y = tableFullMap.GetPositionFromControl(tb).Row;

                        int finalIndex = y + x * 18;
                        map.mapInfoArray[listBoxMapLayer.SelectedIndex][finalIndex] = newValue;
                        mh.commitSingleMap(newValue, listBoxMapLayer.SelectedIndex, finalIndex);
                    }

                }
            }
            catch
            {
                tb.Text = tb.Tag.ToString();
            }
        }

        /// <summary>
        /// Change Room tab grid based on clicked Map tab textbox and set clicked Map tab textbox color.
        /// </summary>
        /// 
        private void mapTextBox_Click(object sender, EventArgs e)
        {
            if (CBChangeRoom.Checked)
            {
                TextBox tb = (TextBox)sender;
                roomX = tableFullMap.GetPositionFromControl(tb).Column;
                roomY = tableFullMap.GetPositionFromControl(tb).Row;
                map.currentRoomX = roomX;
                map.currentRoomY = roomY;
                map.changeCounter++;
                setColorActiveRoom();
            }
        }

        /// <summary>
        /// Highlight selected room on map
        /// </summary>
        public void setColorActiveRoom()
        {
            if (changeCounterCheck != map.changeCounter)
            {
                mapSetFullColor();
                Control c = tableFullMap.GetControlFromPosition(map.currentRoomX, map.currentRoomY);
                c.BackColor = Color.LightBlue;
                changeCounterCheck = map.changeCounter;
            }
        }

        /// <summary>
        /// Load selected layer into map grid
        /// </summary>
        /// <param name="layer"></param>
        public void fillMap(int layer)
        {
            mapSetTextBoxValues(layer);
            mapSetFullColor();
            tableFullMap.Refresh();
        }

        /// <summary>
        /// Paint map to look like minimap
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void paintMap(object sender, TableLayoutCellPaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle r = e.CellBounds;
            int cellX = e.Column, cellY = e.Row;
            int xMod, yMod, widthMod, heightMod, scalar = 3;

            xMod = scalar;
            yMod = scalar;
            widthMod = -scalar * 2;
            heightMod = -scalar * 2;

            if (map.getMapLayer(0)[cellX, cellY] == 2)
            {
                if (cellX > 0)
                {
                    if (map.getMapLayer(0)[cellX - 1, cellY] == 2)//left room
                    {
                        xMod -= scalar;
                        widthMod += scalar;
                    }
                }

                if (cellX < 24)
                {
                    if (map.getMapLayer(0)[cellX + 1, cellY] == 2)//right room
                    {
                        widthMod += scalar;
                    }
                }
            }
            else if (map.getMapLayer(0)[cellX, cellY] == 3)
            {
                if (cellY > 0)
                {
                    if (map.getMapLayer(0)[cellX, cellY - 1] == 3)//above room
                    {
                        yMod -= scalar;
                        heightMod += scalar;
                    }
                }

                if (cellY < 17)
                {
                    if (map.getMapLayer(0)[cellX, cellY + 1] == 3)//below room
                    {
                        heightMod += scalar;
                    }
                }
            }
            else if (map.getMapLayer(0)[cellX, cellY] == 4)
            {
                if (cellX > 0)
                {
                    if (map.getMapLayer(0)[cellX - 1, cellY] == 4)//left room
                    {
                        xMod -= scalar;
                        widthMod += scalar;
                    }
                }

                if (cellX < 24)
                {
                    if (map.getMapLayer(0)[cellX + 1, cellY] == 4)//right room
                    {
                        widthMod += scalar;
                    }
                }
                if (cellY > 0)
                {
                    if (map.getMapLayer(0)[cellX, cellY - 1] == 4)//above room
                    {
                        yMod -= scalar;
                        heightMod += scalar;
                    }
                }

                if (cellY < 17)
                {
                    if (map.getMapLayer(0)[cellX, cellY + 1] == 4)//below room
                    {
                        heightMod += scalar;
                    }
                }
            }


            r = new Rectangle(r.X + xMod, r.Y + yMod, r.Width + widthMod, r.Height + heightMod);
            { 
                if (mapColors.ContainsKey(map.getMapLayer(1)[cellX, cellY]))
                {
                    g.FillRectangle(new SolidBrush(mapColors[map.getMapLayer(1)[cellX, cellY]]), r);
                }
                else
                {
                    g.FillRectangle(new SolidBrush(Color.Turquoise), r);
                }
            }

        }

        /// <summary>
        /// Load values into map textboxes
        /// </summary>
        /// <param name="index"></param>
        public void mapSetTextBoxValues(int index)
        {
            UInt16[,] mapInfoLayer = map.getMapLayer(index);
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 18; j++)
                {
                    tableFullMap.GetControlFromPosition(i, j).Text = map.ushortToShort(mapInfoLayer[i, j]).ToString();
                    tableFullMap.GetControlFromPosition(i, j).Tag = map.ushortToShort(mapInfoLayer[i, j]).ToString();
                }
            }
        }

        /// <summary>
        /// Set map textbox color based on color ID
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void mapSetColor(int x, int y)
        {
            try
            {
                tableFullMap.GetControlFromPosition(x, y).BackColor = mapColors[map.getMapLayer(1)[x, y]];
            }
            catch
            {
                tableFullMap.GetControlFromPosition(x, y).BackColor = Color.Turquoise;
            }
        }

        /// <summary>
        /// Set all map textbox colors
        /// </summary>
        public void mapSetFullColor()
        {
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 18; j++)
                {
                    mapSetColor(i, j);
                }
            }
        }

        public void commitChanges()
        {
            UInt16[] currentLayerValueArray = new ushort[450];
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    currentLayerValueArray[j + i * 18] = map.shortToUshort(Int16.Parse(tableFullMap.GetControlFromPosition(i, j).Text));
                }
            }
            map.mapInfoArray[listBoxMapLayer.SelectedIndex] = currentLayerValueArray;
            MemoryHandler mh = new MemoryHandler();
            if (mh.version >= 0)
            {
                mh.commitFullMapLayer(listBoxMapLayer.SelectedIndex, map, CBCacheCommit.Checked);
                fillMap(listBoxMapLayer.SelectedIndex);
            }
        }
    }
}
