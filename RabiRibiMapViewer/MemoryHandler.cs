using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace RabiRibiMapViewer 
{
    class MemoryHandler
    {
        Process gameProcess;
        private IntPtr baseAddress;
        private IntPtr[] Sprite1Address, StyleAddress, CacheColorAddress, CacheStyleAddress, mapIDAddress, bexAddress, cocoaAddress;
        private IntPtr[] upperLeftRoomArray, upperLeftMapArray, upperLeftMapCacheColorArray, upperLeftMapCacheStyleArray;
        public int version = -1;
        public UInt16 areaID = 0;

        public MemoryHandler()
        {
            gameProcess = getGameProcess();
            if (gameProcess != null)
            {
                fillAddresses();
            }
            if(version == -1 && gameProcess != null)
            {
                MessageBox.Show("Can't find a matching version.");
            }
            
        }

        private Process getGameProcess()
        {
            try
            {
                var processes = Process.GetProcessesByName("rabiribi");
                if (processes.Length > 0)
                {
                    return processes[0];
                }
                else
                {
                    MessageBox.Show("No Rabbits found...");
                }
            }
            catch
            {
            }
            return null;
        }

        private void fillAddresses()
        {
            baseAddress = gameProcess.MainModule.BaseAddress;

            //scan decimal byte array 66 85 78 78 89 32 69 88
            bexAddress = new IntPtr[] {IntPtr.Add(baseAddress, 0x12DF9B0),//1.80e
                                            IntPtr.Add(baseAddress, 0x12DE9B0),//1.80
                                            IntPtr.Add(baseAddress, 0xA441C8),//1.75
                                            IntPtr.Add(baseAddress, 0xA45208),//1.75lm
                                            IntPtr.Add(baseAddress, 0xA421C8),//1.71
                                            IntPtr.Add(baseAddress, 0xA3B140),//1.70
                                            IntPtr.Add(baseAddress, 0xA176E0)//1.65
            };

            //scan decimal byte array 241 3 0 0
            cocoaAddress = new IntPtr[] {   IntPtr.Add(baseAddress, 0x271489),//1.80e
                                            IntPtr.Add(baseAddress, 0x271509),//1.80 
                                            IntPtr.Add(baseAddress, 0x29DCD2),//1.75
                                            IntPtr.Add(baseAddress, 0x29ED92),//1.75lm
                                            IntPtr.Add(baseAddress, 0x29D112),//1.71
                                            IntPtr.Add(baseAddress, 0x29B512),//1.70
                                            IntPtr.Add(baseAddress, 0x27c658)//1.65


            };

            version = matchVersion();
            if(version == -1)
            {
                return;
            }
            //Scan 51118828, 4 byte in woodlands, take first value and subtract 0x970
            Sprite1Address = new IntPtr[] {IntPtr.Add(baseAddress, 0xAC3168),//1.80e
                                            IntPtr.Add(baseAddress, 0xAC2168),//1.80
                                            IntPtr.Add(baseAddress, 0xE47290),//1.75
                                            IntPtr.Add(baseAddress, 0xE48310),//1.75lm
                                            IntPtr.Add(baseAddress, 0xE45290),//1.71
                                            IntPtr.Add(baseAddress, 0xE3D1F0),//1.70
                                            IntPtr.Add(baseAddress, 0xE197C0)//1.65

            };

            //Scan 5, 2 byte in town, compare for left exit and subtract 0x138
            StyleAddress = new IntPtr[] { IntPtr.Add(baseAddress, 0xA60C58),//1.80e
                                          IntPtr.Add(baseAddress, 0xA5FC58),//1.80
                                          IntPtr.Add(baseAddress, 0xDE4D80),//1.75
                                          IntPtr.Add(baseAddress, 0xDE5E00),//1.75lm
                                          IntPtr.Add(baseAddress, 0xDE2D80),//1.71
                                          IntPtr.Add(baseAddress, 0xDDACE0),//1.70
                                          IntPtr.Add(baseAddress, 0xDB72B0)//1.65
            };

            CacheColorAddress = new IntPtr[] {IntPtr.Add(baseAddress, 0x12C9E60),//1.80e
                                               IntPtr.Add(baseAddress, 0x12C8E60),//1.80
                                               IntPtr.Add(baseAddress, 0xA5C260),//1.75
                                               IntPtr.Add(baseAddress, 0xA5D290),//1.75lm
                                               IntPtr.Add(baseAddress, 0xA5A260),//1.71
                                               IntPtr.Add(baseAddress, 0xA531D0),//1.70
                                               IntPtr.Add(baseAddress, 0xA2F6F0)//1.65

            };

            CacheStyleAddress = new IntPtr[] { IntPtr.Add(baseAddress, 0x12C6620),//1.80e
                                               IntPtr.Add(baseAddress, 0x12C5620),//1.80
                                               IntPtr.Add(baseAddress, 0xA58A20),//1.75
                                               IntPtr.Add(baseAddress, 0xA59A50),//1.75lm
                                               IntPtr.Add(baseAddress, 0xA56A20),//1.71
                                               IntPtr.Add(baseAddress, 0xA4F990),//1.70
                                               IntPtr.Add(baseAddress, 0xA2BEB0)//1.65

            };

            mapIDAddress = new IntPtr[] { IntPtr.Add(baseAddress, 0x138124C),//1.80e
                                          IntPtr.Add(baseAddress, 0x138024C),//1.80
                                          IntPtr.Add(baseAddress, 0xAB8074),//1.75
                                          IntPtr.Add(baseAddress, 0xAB90E4),//1.75lm
                                          IntPtr.Add(baseAddress, 0xAB6074),//1.71
                                          IntPtr.Add(baseAddress, 0xAAEFD4),//1.70
                                          IntPtr.Add(baseAddress, 0xA8B4CC)//1.65

            };

            upperLeftRoomArray = new IntPtr[]{ IntPtr.Subtract(Sprite1Address[version], 0xC3F90),//collision
                                                    IntPtr.Subtract(Sprite1Address[version], 0x93250),//entities
                                                    IntPtr.Subtract(Sprite1Address[version], 0x61A84),//items
                                                    IntPtr.Subtract(Sprite1Address[version], 0x30D40),//sprite 2
                                                    IntPtr.Add(Sprite1Address[version], 0),//sprite 1
                                                     IntPtr.Add(Sprite1Address[version], 0x30D40),//sprite 3
                                                     IntPtr.Add(Sprite1Address[version], 0x61A80),//sprite 4
                                                     IntPtr.Add(Sprite1Address[version], 0x927C0),//sprite 5
                                                     IntPtr.Add(Sprite1Address[version], 0xC3500),//sprite 6
                                                     IntPtr.Add(Sprite1Address[version], 0xF4240),//sprite 7
            };

            upperLeftMapArray = new IntPtr[]{ IntPtr.Add(StyleAddress[version], 0),//Style
                                                         IntPtr.Add(StyleAddress[version], 0x384),//Color
                                                         IntPtr.Add(StyleAddress[version], 0x708),//Background
            };

            upperLeftMapCacheColorArray = new IntPtr[]{IntPtr.Add(CacheColorAddress[version], 0),//area0
                                                         IntPtr.Add(CacheColorAddress[version], 0x384),//area1
                                                         IntPtr.Add(CacheColorAddress[version], 0x708),//area2
                                                         IntPtr.Add(CacheColorAddress[version], 0xA8C),//area3
                                                         IntPtr.Add(CacheColorAddress[version], 0xE10),//area4
                                                         IntPtr.Add(CacheColorAddress[version], 0x1194),//area5
                                                         IntPtr.Add(CacheColorAddress[version], 0x1518),//area6
                                                         IntPtr.Add(CacheColorAddress[version], 0x189C),//area7
                                                         IntPtr.Add(CacheColorAddress[version], 0x1C20),//area8
                                                         IntPtr.Add(CacheColorAddress[version], 0x1FA4),//area9
                                                         IntPtr.Add(CacheColorAddress[version], 0x2328),//area10
                                                         IntPtr.Add(CacheColorAddress[version], 0x26AC)//area11
            };
            upperLeftMapCacheStyleArray = new IntPtr[]{IntPtr.Add(CacheStyleAddress[version], 0),//area0
                                                         IntPtr.Add(CacheStyleAddress[version], 0x384),//area1
                                                         IntPtr.Add(CacheStyleAddress[version], 0x708),//area2
                                                         IntPtr.Add(CacheStyleAddress[version], 0xA8C),//area3
                                                         IntPtr.Add(CacheStyleAddress[version], 0xE10),//area4
                                                         IntPtr.Add(CacheStyleAddress[version], 0x1194),//area5
                                                         IntPtr.Add(CacheStyleAddress[version], 0x1518),//area6
                                                         IntPtr.Add(CacheStyleAddress[version], 0x189C),//area7
                                                         IntPtr.Add(CacheStyleAddress[version], 0x1C20),//area8
                                                         IntPtr.Add(CacheStyleAddress[version], 0x1FA4),//area9
                                                         IntPtr.Add(CacheStyleAddress[version], 0x2328),//area10
                                                         IntPtr.Add(CacheStyleAddress[version], 0x26AC)//area11
            };
            int bytesRead;
            areaID = MemoryApi.ReadMemoryPtrUShort(gameProcess, mapIDAddress[version], out bytesRead);


        }

        private int matchVersion()
        {
            int bytesRead;
            byte[] BUNNY_EX = new byte[] { 66, 85, 78, 78, 89, 32, 69, 88 };
            byte[] cocoa_byte = new byte[] { 241, 3, 0, 0 };
            for(int i = 0; i < bexAddress.Length; i++)
            {
                byte[] byteArray = MemoryApi.ReadMemoryPtr(gameProcess, bexAddress[i], 8, out bytesRead);
                
                if(byteArray.SequenceEqual(BUNNY_EX))
                {
                    byteArray = MemoryApi.ReadMemoryPtr(gameProcess, cocoaAddress[i], 4, out bytesRead);
                    if(byteArray.SequenceEqual(cocoa_byte))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        public UInt16[] getMapRoomLayer(int targetLayerIndex)
        {

            UInt16[] mapValues = new UInt16[100000];
            int bytesRead;

            if (gameProcess != null)
                mapValues = MemoryApi.ReadMemoryPtrRange(gameProcess, upperLeftRoomArray[targetLayerIndex], 2, 100000, out bytesRead);

            return mapValues;
        }
        public UInt16[] getMapInfoLayer(int targetLayerIndex)
        {
            UInt16[] mapValues = new UInt16[450];
            int bytesRead;

            if (gameProcess != null)
                mapValues = MemoryApi.ReadMemoryPtrRange(gameProcess, upperLeftMapArray[targetLayerIndex], 2, 450, out bytesRead);

            return mapValues;
        }

        public void commitSingleMap(UInt16 value, int layer, int index)
        {
            IntPtr targetAddress = IntPtr.Add(upperLeftMapArray[layer], index * 2);
            
            MemoryApi.WriteMemoryPtrUShort(gameProcess, targetAddress, value);
            if (layer == 0)
            {
                IntPtr targetCacheAddress = IntPtr.Add(upperLeftMapCacheStyleArray[areaID], index * 2);
                MemoryApi.WriteMemoryPtrUShort(gameProcess, targetCacheAddress, value);
            }
            else if (layer == 1)
            {
                IntPtr targetCacheAddress = IntPtr.Add(upperLeftMapCacheColorArray[areaID], index * 2);
                MemoryApi.WriteMemoryPtrUShort(gameProcess, targetCacheAddress, value);
            }
        }
        public void commitSingleRoom(UInt16 value, int layer, int index)
        {
            IntPtr targetAddress = IntPtr.Add(upperLeftRoomArray[layer], index * 2);
            MemoryApi.WriteMemoryPtrUShort(gameProcess, targetAddress, value);
        }

        public void commitSingleRoom(UInt16 value, int layer, int x, int y, Map map)
        {
            int finalIndex = y + x * 200;
            finalIndex += map.verticalHeights.Take<int>(map.currentRoomY).Sum();
            finalIndex += map.currentRoomX * 4000;
            map.roomLayerArray[layer][finalIndex] = value;
            IntPtr targetAddress = IntPtr.Add(upperLeftRoomArray[layer], finalIndex * 2);
            MemoryApi.WriteMemoryPtrUShort(gameProcess, targetAddress, value);
        }

        /// <summary>
        /// Save currently selected map layer to memory and map array.  Write related cache if writeCache = true.
        /// </summary>
        /// <param name="layer"></param>
        /// <param name="map"></param>
        /// <param name="writeCache"></param>
        public void commitFullMapLayer(int layer, Map map, bool writeCache)
        {
            MemoryApi.WriteMemoryPtrUShort(gameProcess, upperLeftMapArray[layer], map.mapInfoArray[layer]);

            if (writeCache)
            {
                if (layer == 0)
                {
                    MemoryApi.WriteMemoryPtrUShort(gameProcess, upperLeftMapCacheStyleArray[areaID], map.mapInfoArray[layer]);
                }
                else if (layer == 1)
                {
                    MemoryApi.WriteMemoryPtrUShort(gameProcess, upperLeftMapCacheColorArray[areaID], map.mapInfoArray[layer]);
                }
            }
        }

        public void commitFullRoomLayer(int layer, Map map)
        {
            MemoryApi.WriteMemoryPtrUShort(gameProcess, upperLeftRoomArray[layer], map.roomLayerArray[layer]);
        }
    }
}
