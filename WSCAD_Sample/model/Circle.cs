using MapWinGIS;
using System;

namespace WSCAD_Sample.model
{
    public class Circle : ShapeBase
    {
        public override string type { get; } = "circle";
        public string center { get; set; }
        public double? radius { get; set; }
        public bool? filled { get; set; }

        public override Shapefile drawShape()
        {
            string[] centerVals = this.center.Split(';');

            Shapefile sf = new Shapefile();
            sf.CreateNew("", ShpfileType.SHP_POLYGON);

            var shp = new Shape();
            shp.Create(ShpfileType.SHP_POLYGON);
            this.AddRing(true, Int32.Parse(centerVals[0]), Int32.Parse(centerVals[1]), radius.Value, ref shp);
            int index = 0;
            sf.EditInsertShape(shp, ref index);

            this.applyDecoration(sf);

            return sf;
        }

        public override void applyDecoration(Shapefile sf)
        {
            var ct = sf.Categories.Add("Circle");
            if (filled.Value)
            {
                ct.DrawingOptions.FillColor = base.prepareColor();
            }
            else
            {
                ct.DrawingOptions.FillColor = TRANSPARENT;
            }
            sf.set_ShapeCategory(0, 0);
        }

        private void AddRing(bool clockWise, double x, double y, double radius, ref Shape shp)
        {
            int partIndex = shp.NumParts;
            if (shp.numPoints > 0)
                shp.InsertPart(shp.numPoints, ref partIndex);
            int count = 0;
            for (int j = 0; j < 37; j++)
            {
                double dx = radius * Math.Cos(j * Math.PI / 18);
                double dy = radius * Math.Sin(j * Math.PI / 18);

                //dx *= clockWise ? -1 : 1;
                dy *= clockWise ? -1 : 1;
                var pnt = new Point();
                pnt.x = x + dx;
                pnt.y = y + dy;
                count = shp.numPoints;
                shp.InsertPoint(pnt, ref count);
            }
        }
    }
}
