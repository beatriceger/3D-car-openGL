using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System.Drawing.Imaging;


namespace _3DCar
{

    class Wheels
    {
      
        public Wheels()
        {

        }

        public void DrawWheels()
        {

          //  GL.BindTexture(TextureTarget.Texture2D, Skin.textures[nr]);
            GL.Begin(PrimitiveType.Polygon);
            GL.Color3(Color.Aqua);
            GL.TexCoord2(0, 0);
            GL.Vertex3(5, 10, 5);
            GL.TexCoord2(0, 1);
            GL.Vertex3(5, 0, 0);
            GL.TexCoord2(1, 1);
            GL.Vertex3(0, 0, 5);
            GL.End();



        }

        /************************** draw_cylinder() **************************/
        public void draw_cylinder(double radius,double height)
        {
            double PI = 3.1415927;

            double x = 0.0;
            double y = 0.0;
            double angle = 0.0;
            double angle_stepsize = 0.1;

            /** Draw the tube */
        GL.Color3(Color.Aqua);
            GL.Begin(PrimitiveType.QuadStrip);
            angle = 0.0;
            while (angle < 2 * PI)
            {
                x = radius * Math.Cos(angle);
                y = radius * Math.Sin(angle);
                GL.Vertex3(x, y, height);
                GL.Vertex3(x, y, 0.0);
                angle = angle + angle_stepsize;
            }
            GL.Vertex3(radius, 0.0, height);
            GL.Vertex3(radius, 0.0, 0.0);
            GL.End();

            /** Draw the circle on top of cylinder */
            GL.Color3(Color.Beige);
            GL.Begin(PrimitiveType.Polygon);
            angle = 0.0;
            while (angle < 2 * PI)
            {
                x = radius * Math.Cos(angle);
                y = radius * Math.Sin(angle);
                GL.Vertex3(x, y, height);
                angle = angle + angle_stepsize;
            }
            GL.Vertex3(radius, 0.0, height);
            GL.End();

            GL.Color3(Color.Black);
            GL.Begin(PrimitiveType.Lines);
            GL.Vertex3(height, 2,0);
            GL.Vertex3(height, 0.0, 2);
            GL.End();
        }



        public void draw_cylinder2(double radius, double height)
        {
            double PI = 3.1415927;

            double x = 0.0;
            double y = 0.0;
            double angle = 0.0;
            double angle_stepsize = 0.1;

            /** Draw the tube */
            GL.Color3(Color.Black);
            GL.Begin(PrimitiveType.QuadStrip);
            angle = 0.0;
            while (angle < 2 * PI)
            {
                x = radius * Math.Cos(angle);
                y = radius * Math.Sin(angle);
                GL.Vertex3(x+15, y, height);//aici se muta cu x
                GL.Vertex3(x+15, y, 0.0);
                angle = angle + angle_stepsize;
            }
            GL.Vertex3(radius+15, 0.0, height);
            GL.Vertex3(radius+15, 0.0, 0.0);
            GL.End();

            /** Draw the circle on top of cylinder */
            GL.Color3(Color.Brown);
            GL.Begin(PrimitiveType.Polygon);
            angle = 0.0;
            while (angle < 2 * PI)
            {
                x = radius * Math.Cos(angle);
                y = radius * Math.Sin(angle);
                GL.Vertex3(x+15, y ,height);
                angle = angle + angle_stepsize;
            }
            GL.Vertex3(radius, 0.0, height);
            GL.End();
        }
    }
}
