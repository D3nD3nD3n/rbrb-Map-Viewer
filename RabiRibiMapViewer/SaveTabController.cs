using System;
using System.IO;
using System.Windows.Forms;

namespace RabiRibiMapViewer
{
    class SaveTabController
    {
        public void newMapSave(string filePath, Map map)
        {

            int[,] order ={ { 0, 0 },
                            { 0, 1 },
                            { 1, 0 },
                            { 1, 1 },
                            { 1, 2 },
                            { 0, 2 },
                            { 0, 3 },
                            { 0, 4 },
                            { 0, 5 },
                            { 0, 6 },
                            { 0, 7 },
                            { 0, 8 },
                            { 0, 9 }
            };
            byte[] roomBuffer = new byte[200000];
            ushort[] ushortBufferRoom = new ushort[100000];
            byte[] mapBuffer = new byte[900];
            ushort[] ushortBufferMap = new ushort[450];
            if(!map.loaded)
            {
                MessageBox.Show("There doesn't seem to be anything loaded yet.");
                return;
            }
            if (File.Exists(filePath))
            {
                using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite))
                {
                    if (stream.Length != 2602708)
                    {
                        MessageBox.Show("Invalid file size. ");
                        return;
                    }
                    String fn = Path.GetFileName(stream.Name);
                    if (!fn.Substring(fn.Length-4, 4).ToLower().Equals(".map"))
                    {
                        MessageBox.Show("Please select a file ending in .map");
                        return;
                    }
                    if (!fn.Substring(0, 4).ToLower().Equals("area"))
                    {
                        if (MessageBox.Show("This file's name doesn't start with \"area\". Continue anyway?", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                        {
                            return;
                        }
                    }
                    else
                    {
                        if (!fn.Substring(4, fn.Length - 8).Equals(map.currentArea.ToString()))
                        {
                            String message = String.Format("The currently loaded area is area{0}, but you are saving to {1}. Continue anyway?", map.currentArea, fn);
                            if (MessageBox.Show(message, "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                            {
                                return;
                            }
                        }
                    }

                    for (int i = 0; i < order.GetLength(0); i++)
                    {
                        if (order[i, 0] == 0)
                        {


                            Buffer.BlockCopy(map.roomLayerArray[order[i, 1]], 0, roomBuffer, 0, roomBuffer.Length);
                            stream.Write(roomBuffer, 0, roomBuffer.Length);
                            if (order[i, 1] == 2)
                            {
                                stream.Position = stream.Position + 4;
                            }
                        }
                        else
                        {

                            Buffer.BlockCopy(map.mapInfoArray[order[i, 1]], 0, mapBuffer, 0, mapBuffer.Length);
                            stream.Write(mapBuffer, 0, mapBuffer.Length);
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("File Not Found!");
            }
        }
    }
}
