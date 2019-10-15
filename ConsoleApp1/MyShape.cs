using System;
using System.Collections.Generic;
using System.Text;
using Raylib;
namespace ConsoleApp1
{
    class MyShape
    {
        public Vector2 position = new Vector2();
        public List<Raylib.Vector2> MyPoints = new List<Vector2>();
        public void Draw()
        {
            Vector2 Last = new Vector2(); 
            for(int idx = 0; idx < MyPoints.Count; idx++)
            {
                if(idx>0)
                Raylib.Raylib.DrawLineEx(position+Last, position+MyPoints[idx], 2, Color.BLACK);
                Last = MyPoints[idx];
            }
        }
    }
}
