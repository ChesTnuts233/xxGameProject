using UnityEngine;
using CodeMonkey.Utils;
using System;

namespace GridSystem
{
    public class GridMapXZ<TGridObject>
    {
        private int width; //地图的宽度
        private int height; //地图的高度
        public Vector3 originPosition; //网格从什么位置开始生成（左下角）
        public float cellSize; //单位格尺寸
        private MyGrid[,] gridArray; //网格的数组
        private TGridObject[,] gridTArray; //泛型的数组
        private TextMesh[,] debugTextArray;
        private static bool isDebugGrid = true;


        //public ModelValue<MyGrid> PlayerNowGrid;                                          //玩家当前所在的Grid
        public static QueueFixLength<MyGrid> GridQueue = new QueueFixLength<MyGrid>(2); //经过的Grid队列 固定为2个go

        public int Width
        {
            get => width;
            set => width = value;
        }

        public int Height
        {
            get => height;
            set => height = value;
        }

        public float CellSize
        {
            get => cellSize;
            set => cellSize = value;
        }

        public MyGrid[,] GridArray
        {
            get => gridArray;
            set => gridArray = value;
        }

        public Vector3 OriginPosition
        {
            get => originPosition;
            set => originPosition = value;
        }

        public TGridObject[,] GridTArray
        {
            get => gridTArray;
            set => gridTArray = value;
        }

        public GridMapXZ(int width, int height, float cellSize, Vector3 originPosition)
        {
            this.width = width;
            this.height = height;
            this.cellSize = cellSize;
            this.originPosition = originPosition;
            this.gridTArray = new TGridObject[width, height];
            debugTextArray = new TextMesh[width, height];
            if (isDebugGrid)
            {
                for (int x = 0; x < GridTArray.GetLength(0); x++)
                {
                    for (int z = 0; z < GridTArray.GetLength(1); z++)
                    {
                        /*debugTextArray[x, z] = UtilsClass.CreateWorldText(GridTArray[x, z]?.ToString(), null,
                            GetWorldPosition(x, z) + new Vector3(cellSize,0, cellSize) * .5f, 30, Color.white,
                            TextAnchor.MiddleCenter);*/
                        Debug.DrawLine(GetWorldPosition(x, z), GetWorldPosition(x, z + 1), Color.white, 100f);
                        Debug.DrawLine(GetWorldPosition(x, z), GetWorldPosition(x + 1, z), Color.white, 100f);
                    }
                }

                Debug.DrawLine(GetWorldPosition(0, height), GetWorldPosition(width, height), Color.white, 100f);
                Debug.DrawLine(GetWorldPosition(width, 0), GetWorldPosition(width, height), Color.white, 100f);
            }

            // 	PlayerNowGrid.OnValueChange += (grid) =>
            // {
            // 	grid.ShowGirdcoordinate();				//当值改变的时候显示
            // 	GridQueue.Enqueue(grid);				//让Grid入队
            // 	grid.IsCheckPlayer = true;				//设置入队的Grid的玩家bool
            // 	GridQueue.Peek().IsCheckPlayer = false; //让队头（上一个Grid）设置为false
            // };
        }

        public Vector3 GetWorldPosition(int x, int z)
        {
            return new Vector3(x, 0, z) * cellSize + OriginPosition;
        }

        /// <summary>
        /// 获取向下去整的XZ值
        /// </summary>
        public void GetXZ(Vector3 worldPosition, out int x, out int z)
        {
            x = Mathf.FloorToInt((worldPosition - OriginPosition).x / cellSize);
            z = Mathf.FloorToInt((worldPosition - OriginPosition).z / cellSize);
        }

        #region 设置网格内的值

        public void SetValue(int x, int z, TGridObject value)
        {
            if (x >= 0 && z >= 0 && x < Width && z < height)
            {
                GridTArray[x, z] = value;
                debugTextArray[x, z].text = GridArray[x, z].ToString();
            }
        }

        public void SetValue(Vector3 worldPosition, TGridObject value)
        {
            int x, z;
            GetXZ(worldPosition, out x, out z);
            SetValue(x, z, value);
        }

        #endregion

        #region 获取网格内物体

        public TGridObject GetGridObject(int x, int z)
        {
            if (x >= 0 && z >= 0 && x < width && z < height)
            {
                return GridTArray[x, z];
            }
            else
            {
                return default(TGridObject);
            }
        }

        public TGridObject GetGridObject(Vector3 worldPosition)
        {
            int x, z;
            GetXZ(worldPosition, out x, out z);
            return GetGridObject(x, z);
        }

        #endregion
    }
}