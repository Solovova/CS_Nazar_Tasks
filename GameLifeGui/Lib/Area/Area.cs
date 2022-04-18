using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Serialization;

namespace GameLifeGui.Lib.Area{
    public class Area{
        public int X1{ get; }
        public int Y1{ get; }
        public int X2{ get; }
        public int Y2{ get; }

        [IgnoreDataMember] public int Height => this.Y2 - this.Y1 + 1;
        [IgnoreDataMember] public int Width => this.X2 - this.X1 + 1;

        public Area(int x1, int y1, int x2, int y2){
            if (x1 > x2)
                (this.X1, this.X2) = (x2, x1);
            else
                (this.X1, this.X2) = (x1, x2);
            if (y1 > y2)
                (this.Y1, this.Y2) = (y2, y1);
            else
                (this.Y1, this.Y2) = (y1, y2);
        }

        public Area(Area area) : this(area.X1, area.Y1, area.X2, area.Y2){
        }

        public Area Clone(){
            return new Area(this);
        }

        public override bool Equals(object? obj){
            if (obj is not Area item) return false;
            return this.X1 == item.X1 && this.X2 == item.X2 && this.Y1 == item.Y1 && this.Y2 == item.Y2;
        }

        public bool Equals(Area other){
            return this.Equals(other as object);
        }

        public override int GetHashCode(){
            unchecked{
                int hashCode = this.X1;
                hashCode = (hashCode * 397) ^ this.Y1;
                hashCode = (hashCode * 397) ^ this.X2;
                hashCode = (hashCode * 397) ^ this.Y2;
                return hashCode;
            }
        }
        
        public Area[] SplitXAxis(int cols){
            if (cols < 1) throw new ArgumentOutOfRangeException($"Cols must be uder 0 but is {cols}");
            if (cols > this.Width)
                throw new ArgumentOutOfRangeException(
                    $"Cols can't be bigger then Width Cols:{cols} Width: {this.Width}");

            Area[] result = new Area[cols];
            int widthCol = this.Width / cols;
            int actualX1 = this.X1;
            for (int i = 0; i < cols; i++){
                int actualX2 = i == cols - 1 ? this.X2 : actualX1 + widthCol - 1;
                result[i] = new Area(actualX1, this.Y1, actualX2, this.Y2);
                actualX1 += widthCol;
            }
            return result;
        }

        public Area[] SplitYAxis(int rows){
            if (rows < 1) throw new ArgumentOutOfRangeException($"Rows must be uder 0 but is {rows}");
            if (rows > this.Height)
                throw new ArgumentOutOfRangeException(
                    $"Rows can't be bigger then Height Cols:{rows} Width: {this.Height}");

            Area[] result = new Area[rows];
            int heightRow = this.Height / rows;
            int actualY1 = this.Y1;
            for (int i = 0; i < rows; i++){
                int actualY2 = i == rows - 1 ? this.Y2 : actualY1 + heightRow - 1;
                result[i] = new Area(this.X1, actualY1, this.X2, actualY2);
                actualY1 += heightRow;
            }
            return result;
        }

        public Area[][] SplitXyAxis(int rows, int cols){
            if (cols < 1) throw new ArgumentOutOfRangeException($"Cols must be uder 0 but is {cols}");
            if (cols > this.Width)
                throw new ArgumentOutOfRangeException(
                    $"Cols can't be bigger then Width Cols:{cols} Width: {this.Width}");
            if (rows < 1) throw new ArgumentOutOfRangeException($"Rows must be uder 0 but is {rows}");
            if (rows > this.Height)
                throw new ArgumentOutOfRangeException(
                    $"Rows can't be bigger then Height Cols:{rows} Width: {this.Height}");

            Area[][] result = new Area[rows][];
            Area[] rowsArea = this.SplitYAxis(rows);

            for (int i = 0; i < rows; i++) result[i] = rowsArea[i].SplitXAxis(cols);

            return result;
        }
        
    }
}