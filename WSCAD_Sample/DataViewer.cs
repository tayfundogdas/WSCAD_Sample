using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using MapWinGIS;
using Newtonsoft.Json;
using WSCAD_Sample.model;

namespace WSCAD_Sample
{
    public partial class DataViewer : Form
    {
        public DataViewer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            drawBackground();
        }

        public void drawBackground()
        {
            mapControl.Projection = tkMapProjection.PROJECTION_NONE;

            mapControl.AddLayer(this.createAxis(), true);
            mapControl.AddLayer(this.createAxisPoints(), true);
        }

        private Shapefile createAxis()
        {
            Shapefile sf = new Shapefile();
            sf.CreateNew("", ShpfileType.SHP_POLYLINE);

            //y-axis
            Shape shp = new Shape();
            shp.Create(ShpfileType.SHP_POLYLINE);
            shp.ImportFromWKT("LINESTRING (0 -100, 0 100)");
            int index = 0;
            sf.EditInsertShape(shp, ref index);

            //x-axis
            shp = new Shape();
            shp.Create(ShpfileType.SHP_POLYLINE);
            shp.ImportFromWKT("LINESTRING (-100 0, 100 0)");
            sf.EditInsertShape(shp, ref index);

            return sf;
        }

        private Shapefile createAxisPoints()
        {
            Shapefile sf = new Shapefile();
            sf.CreateNew("", ShpfileType.SHP_POINT);

            //y-axis
            for (int i = -100; i <= 100; i = i + 10)
            {
                Shape shp = new Shape();
                shp.Create(ShpfileType.SHP_POINT);
                string wkt = "POINT (0 " + i + ")";
                shp.ImportFromWKT(wkt);
                int k = 0;
                sf.EditInsertShape(shp, ref k);
            }

            //x-axis
            for (int i = -100; i <= 100; i = i + 10)
            {
                Shape shp = new Shape();
                shp.Create(ShpfileType.SHP_POINT);
                string wkt = "POINT (" + i + " 0)";
                shp.ImportFromWKT(wkt);
                int k = 0;
                sf.EditInsertShape(shp, ref k);
            }

            return sf;
        }

        private void toolCursor_Click(object sender, EventArgs e)
        {
            mapControl.CursorMode = MapWinGIS.tkCursorMode.cmNone;
        }

        private void toolZoomExtent_Click(object sender, EventArgs e)
        {
            mapControl.ZoomToMaxExtents();
        }

        private void toolZoomIn_Click(object sender, EventArgs e)
        {
            mapControl.CursorMode = MapWinGIS.tkCursorMode.cmZoomIn;
        }

        private void toolZoomOut_Click(object sender, EventArgs e)
        {
            mapControl.CursorMode = MapWinGIS.tkCursorMode.cmZoomOut;
        }

        private void toolPan_Click(object sender, EventArgs e)
        {
            mapControl.CursorMode = MapWinGIS.tkCursorMode.cmPan;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "json files (*.json)|*.json";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        var fileContent = reader.ReadToEnd();
                        var shapes = JsonConvert.DeserializeObject<List<ShapeBase>>(fileContent);
                        drawShapes(shapes);
                    }
                }
            }
        }

        private void drawShapes(List<ShapeBase> shapes)
        {
            //refresh map
            mapControl.Clear();
            drawBackground();

            foreach (var shape in shapes)
            {
                mapControl.AddLayer(shape.drawShape(), true);
            }
        }
    }
}
