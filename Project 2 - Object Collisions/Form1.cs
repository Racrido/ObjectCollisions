/*
Author: Ricardo Mohammed
Due Date: November 7, 2021
Prof: Steven MacNaughton
Class: MATH1223-01

Write a program that will ask for the centre and furthest vertex for two 3D objects.
Using the corresponding bounding spheres, determine whether a possible collision has been detected or not.
Report the radius of each sphere and the distance between centres rounded to 2 decimal places.
Using the corresponding bounding boxes, determine whether a possible collision has been detected or not.
Report the minimum and maximum coordinate values for both boxes.
For the boxes, assume that one of the corners of the box is at the furthest vertex.

You must create and use a distance funtion.
You must create and use a opposite vertex function.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Project_2___Object_Collisions
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //-------------------------------------------------------------------------
        // FUNCTION TO CALCULATE DISTANCE BETWEEN TWO POINTS
        //-------------------------------------------------------------------------
        private double ObjectDistanceCalc(Point3D objectCenter, Point3D objectVertex)
        {
            double totalDistance;

            // d = sqrt[(x2-x1)^2 + (y2-y1)^2 + (z2-z1)^2]
            totalDistance = Math.Sqrt(Math.Pow(objectVertex.x - objectCenter.x, 2) + Math.Pow(objectVertex.y - objectCenter.y, 2) + Math.Pow(objectVertex.z - objectCenter.z, 2));
            return totalDistance;
        }
        //-------------------------------------------------------------------------
        // FUNCTION TO CALCULATE OPPOSITE VERTEX 
        //-------------------------------------------------------------------------
        private Point3D OppositeVertexCalc(Point3D center, Point3D vertex)
        {
            Point3D oppositeVertex = new Point3D();

            oppositeVertex.x = (2 * center.x) - vertex.x;
            oppositeVertex.y = (2 * center.y) - vertex.y;
            oppositeVertex.z = (2 * center.z) - vertex.z;

            return oppositeVertex;
        }
        //-------------------------------------------------------------------------
        // SPHERE COLLISION FUNCTION
        //-------------------------------------------------------------------------
        private void SphereCollisionCalc(Point3D object1Center, Point3D object1Vertex, Point3D object2Center, Point3D object2Vertex)
        {
            //CALCULATE ALL NECESSARY VARIABLES USING CALC FUNCTIONS WRITTEN ABOVE
            double object1Radius = ObjectDistanceCalc(object1Center, object1Vertex);
            double object2Radius = ObjectDistanceCalc(object2Center, object2Vertex);
            double distanceBetweenCenters = ObjectDistanceCalc(object1Center, object2Center);
            double sumOfRadii = object1Radius + object2Radius;

            grpSpheres.Visible = true;

            //TEXT FORMATTING
            lblRadius1.Text = "The radius for object 1 is " + Math.Round(object1Radius, 2);
            lblRadius2.Text = "The radius for object 2 is " + Math.Round(object2Radius, 2);
            lblSumOfRadii.Text = "The sum of the radii is " + Math.Round(sumOfRadii, 2);
            lblDistance.Text = "The distance between the centers is " + Math.Round(distanceBetweenCenters, 2);

            //COLLISION DETECTION STATEMENT
            if(distanceBetweenCenters <= sumOfRadii)
            {
                lblSpheresCollided.Text = "There is a possible collision.";
            }
            else
            {
                lblSpheresCollided.Text = "There is no collision.";
            }
        }
        //-------------------------------------------------------------------------
        // BOX COLLISION FUNCTION
        //-------------------------------------------------------------------------
        private void BoxCollisionCalc(Point3D object1Center, Point3D object1Vertex, Point3D object2Center, Point3D object2Vertex)
        {
            Point3D obj1OppositeVertex = OppositeVertexCalc(object1Center, object1Vertex);
            Point3D obj2OppositeVertex = OppositeVertexCalc(object2Center, object2Vertex);
            Point3D obj1MaxPoint = new Point3D();
            Point3D obj1MinPoint = new Point3D();
            Point3D obj2MaxPoint = new Point3D();
            Point3D obj2MinPoint = new Point3D();

            //GET OUR MAX AND MIN POINT FOR OBJECT 1
            obj1MaxPoint.x = Math.Max(object1Vertex.x, obj1OppositeVertex.x);
            obj1MaxPoint.y = Math.Max(object1Vertex.y, obj1OppositeVertex.y);
            obj1MaxPoint.z = Math.Max(object1Vertex.z, obj1OppositeVertex.z);
            obj1MinPoint.x = Math.Min(object1Vertex.x, obj1OppositeVertex.x);
            obj1MinPoint.y = Math.Min(object1Vertex.y, obj1OppositeVertex.y);
            obj1MinPoint.z = Math.Min(object1Vertex.z, obj1OppositeVertex.z);

            //GET OUR MAX AND MIN POINT FOR OBJECT 2
            obj2MaxPoint.x = Math.Max(object2Vertex.x, obj2OppositeVertex.x);
            obj2MaxPoint.y = Math.Max(object2Vertex.y, obj2OppositeVertex.y);
            obj2MaxPoint.z = Math.Max(object2Vertex.z, obj2OppositeVertex.z);
            obj2MinPoint.x = Math.Min(object2Vertex.x, obj2OppositeVertex.x);
            obj2MinPoint.y = Math.Min(object2Vertex.y, obj2OppositeVertex.y);
            obj2MinPoint.z = Math.Min(object2Vertex.z, obj2OppositeVertex.z);

            grpBoxes.Visible = true;

            //TEXT FORMATTING
            txtMinX1.Text = Convert.ToString(obj1MinPoint.x);
            txtMinY1.Text = Convert.ToString(obj1MinPoint.y);
            txtMinZ1.Text = Convert.ToString(obj1MinPoint.z);
            txtMaxX1.Text = Convert.ToString(obj1MaxPoint.x);
            txtMaxY1.Text = Convert.ToString(obj1MaxPoint.y);
            txtMaxZ1.Text = Convert.ToString(obj1MaxPoint.z);

            txtMinX2.Text = Convert.ToString(obj2MinPoint.x);
            txtMinY2.Text = Convert.ToString(obj2MinPoint.y);
            txtMinZ2.Text = Convert.ToString(obj2MinPoint.z);
            txtMaxX2.Text = Convert.ToString(obj2MaxPoint.x);
            txtMaxY2.Text = Convert.ToString(obj2MaxPoint.y);
            txtMaxZ2.Text = Convert.ToString(obj2MaxPoint.z);

            //COLLISION DETECTION STATEMENT
            if ((obj1MinPoint.x <= obj2MaxPoint.x) && (obj2MinPoint.x <= obj1MaxPoint.x) && (obj1MinPoint.y <= obj2MaxPoint.y) && (obj2MinPoint.y <= obj1MaxPoint.y) &&
                (obj1MinPoint.z <= obj2MaxPoint.z) && (obj2MinPoint.z <= obj1MaxPoint.z))
            {
                lblBoxesCollided.Text = "There is a possible collsion.";
            }
            else
            {
                lblBoxesCollided.Text = "There is no collision.";
            }

        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            //your code here
            Point3D obj1Center = new Point3D();
            Point3D obj1Vertex = new Point3D();
            Point3D obj2Center = new Point3D();
            Point3D obj2Vertex = new Point3D();
            lblResults.Visible = true;
            ReadTextInput(txtCentreX1, ref obj1Center.x);
            ReadTextInput(txtCentreY1, ref obj1Center.y);
            ReadTextInput(txtCentreZ1, ref obj1Center.z);
            ReadTextInput(txtVertexX1, ref obj1Vertex.x);
            ReadTextInput(txtVertexY1, ref obj1Vertex.y);
            ReadTextInput(txtVertexZ1, ref obj1Vertex.z);  //Failsafe check to see if all boxes have integers in them
            ReadTextInput(txtCentreX2, ref obj2Center.x);
            ReadTextInput(txtCentreY2, ref obj2Center.y);
            ReadTextInput(txtCentreZ2, ref obj2Center.z);
            ReadTextInput(txtVertexX2, ref obj2Vertex.x);
            ReadTextInput(txtVertexY2, ref obj2Vertex.y);
            ReadTextInput(txtVertexZ2, ref obj2Vertex.z);

            //functions to determine if there is a collision, all function code is written above
            SphereCollisionCalc(obj1Center, obj1Vertex, obj2Center, obj2Vertex); 
            BoxCollisionCalc(obj1Center, obj1Vertex, obj2Center, obj2Vertex);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //-------------------------------------------------------------------------
        // FAILSAFE FUNCTION
        //-------------------------------------------------------------------------
        int ReadTextInput(TextBox tb1, ref double a)
        {
            //If no number is inputted in a textbox, this function will catch it and report it as an error to the user
            try
            {
                a = Convert.ToDouble(tb1.Text);

            }
            catch
            {
                MessageBox.Show("Please enter an integer in each textbox.");
                txtCentreX1.Focus();
                return 1;
            }

            return 0;

        }
        //-------------------------------------------------------------------------
        // CLEARS ALL INPUT AND RESULT BOXES
        //-------------------------------------------------------------------------
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCentreX1.Text = "";
            txtCentreY1.Text = "";
            txtCentreZ1.Text = "";
            txtVertexX1.Text = "";
            txtVertexY1.Text = "";
            txtVertexZ1.Text = "";
            txtCentreX2.Text = "";
            txtCentreY2.Text = "";
            txtCentreZ2.Text = "";
            txtVertexX2.Text = "";
            txtVertexY2.Text = "";
            txtVertexZ2.Text = "";

            grpBoxes.Visible = false;
            grpSpheres.Visible = false;
            lblResults.Visible = false;
            txtCentreX1.Focus();
        }
    }
}
