using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class polyline  {

    private List<float[]> points;

    public polyline()   //类的初始化
    {
        points = new List<float[]>();
    }

    public void addPoint(float[] point)
    {
        points.Add(point);
    }

   
    public float[] getPoint(int indx)
    {
        indx = indx %  points.Count;
        if (indx < 0) indx = indx + points.Count;

        return points[(int)indx];  
    } 
}
