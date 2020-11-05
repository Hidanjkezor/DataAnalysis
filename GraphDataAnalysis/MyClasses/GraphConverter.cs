using ZedGraph;

namespace GraphDataAnalysis.MyClasses
{
    public static class GraphConverter
    {
        public static PointPairList GetPointPairListFromCurve(CurveItem curve)
        {
            var list = new PointPairList();
            for (var i = 0; i < curve.Points.Count; i++)
            {
                list.Add(curve.Points[i]);
            }
            return list;
        }
    }
}
