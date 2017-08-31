using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabiRibiMapViewer
{
    public class Map
    {
        public UInt16[][] roomLayerArray = new UInt16[10][];
        public UInt16[][] mapInfoArray = new UInt16[3][];
        public UInt16 currentArea;
        public int changeCounter = 0;
        public int currentRoomX = 0, currentRoomY = 0;
        public readonly int[] verticalHeights = { 12, 11, 11, 11, 12, 11, 11, 11, 12, 11, 11, 11, 12, 11, 11, 11, 12, 8 };

        public Map()
        {
            for(int i = 0; i < mapInfoArray.Length; i++)
            {
                mapInfoArray[i] = new UInt16[450];
            }
            for(int i = 0; i < roomLayerArray.Length; i++)
            {
                roomLayerArray[i] = new UInt16[100000];
            }
        }
        
        /// <summary>
        /// Return grid corresponding to selected room's selected layer.
        /// </summary>
        /// <param name="targetLayer"></param>
        /// <returns></returns>
        public UInt16[,] getRoomLayer(int targetLayer)
        {
            UInt16[,] roomLayer = new UInt16[20, verticalHeights[currentRoomY]];
            int index = verticalHeights.Take<int>(currentRoomY).Sum() + 4000 * currentRoomX;
            for (int i = 0; i < roomLayer.GetLength(0); i++)
            {
                for (int j = 0; j < roomLayer.GetLength(1); j++)
                {
                    int currentStep = index + j + i * 200;
                    roomLayer[i, j] = roomLayerArray[targetLayer][currentStep];
                }
            }
            return roomLayer;
        }
        /// <summary>
        /// Return grid corresponding to map's selected layer
        /// </summary>
        /// <param name="targetLayer"></param>
        /// <returns></returns>
        public UInt16[,] getMapLayer(int targetLayer)
        {
            UInt16[,] mapLayer = new UInt16[25, 18];
            UInt16[] targetMapLayer = mapInfoArray[targetLayer];
            for(int i = 0; i < mapLayer.GetLength(0); i++)
            {
                for(int j = 0; j < mapLayer.GetLength(1); j++)
                {
                    mapLayer[i, j] = targetMapLayer[j + i * 18];
                }
            }
            return mapLayer;
        }

        /// <summary>
        /// Load map from memory into arrays
        /// </summary>
        public void loadMap()
        {
            MemoryHandler mh = new MemoryHandler();
            if (mh.version >= 0)
            {
                for (int i = 0; i < roomLayerArray.GetLength(0); i++)
                {

                    roomLayerArray[i] = mh.getMapRoomLayer(i);
                }
                for (int i = 0; i < mapInfoArray.GetLength(0); i++)
                {
                    mapInfoArray[i] = new UInt16[450];
                    mapInfoArray[i] = mh.getMapInfoLayer(i);
                }
                currentArea = mh.areaID;
            }
        }
    }

}
