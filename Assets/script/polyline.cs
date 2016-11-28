using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class polyline  {

    public List<float[]> points;

    public polyline()
    {
        points = new List<float[]>();
    }

    public void addPoint(float[] point)
    {
        points.Add(point);
    }

    
}
