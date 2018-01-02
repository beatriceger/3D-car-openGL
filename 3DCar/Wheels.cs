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




            /** Draw the tube --ROTI FATA*/
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
            GL.Vertex3(height, 2, 0);
            GL.Vertex3(height, 0.0, 2);
            GL.End();



            /** Draw the tube--ROTI SPATE */
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
            //corp inferior masina
            GL.Begin(PrimitiveType.Quads);//fata
            GL.Color3(Color.Aqua);
            GL.Vertex3(-2, 5, 10);
            GL.Vertex3(20, 5, 10);
            GL.Vertex3(20, 2, 10);
            GL.Vertex3(-2, 2, 10);
            GL.End();


            GL.Begin(PrimitiveType.Quads);//spate
            GL.Color3(Color.Aqua);

            GL.Vertex3(-2, 0, 0);
            GL.Vertex3(20, 0, 0);
            GL.Vertex3(20, 5, 0);
            GL.Vertex3(-2, 5, 0);
            GL.End();


            GL.Begin(PrimitiveType.Quads);//stanga
            GL.Color3(Color.Red);
            GL.Vertex3(-2, 5, 10);//s
            GL.Vertex3(-2, 5, 0);
            GL.Vertex3(-2, 0, 0);
            GL.Vertex3(-2, 2, 10);//j
            GL.End();



            GL.Begin(PrimitiveType.Quads);//dreapta
            GL.Color3(Color.RosyBrown);
            GL.Vertex3(20, 5, 0);
            GL.Vertex3(20, 5, 10);//
            GL.Vertex3(20, 2, 10);//
            GL.Vertex3(20, 0, 0);
            GL.End();


            GL.Begin(PrimitiveType.Quads);//capac
            GL.Color3(Color.Aqua);
            GL.Vertex3(-2, 5, 10);
            GL.Vertex3(20, 5, 10);//sus
            GL.Vertex3(20, 5, 0);
            GL.Vertex3(-2, 5, 0);
            GL.End();

            //triunghi stanga'fata
            GL.Begin(PrimitiveType.Triangles);//stanga
            GL.Color3(Color.Red);
            GL.Vertex3(5,10, 10);
            GL.Vertex3(5, 5, 10);
             GL.Vertex3(2, 5, 10);
            GL.End();

            //triunghi stanga'geam
            GL.Begin(PrimitiveType.QuadStrip);//stanga
            GL.Color3(Color.Red);
            GL.Vertex3(5, 10, 10);//
            GL.Vertex3(5, 10, 0);
            GL.Vertex3(2, 5, 10);//
            GL.Vertex3(2, 5, 0);
            GL.End();

            //triunghi stanga'acoperis
            GL.Begin(PrimitiveType.QuadStrip);//stanga
            GL.Color3(Color.Red);
            GL.Vertex3(5, 10, 10);//
            GL.Vertex3(5, 10, 0);
            GL.Vertex3(10, 10, 10);//
            GL.Vertex3(10, 10, 0);//
            GL.End();

            //patrat stanga'geam mare
            GL.Begin(PrimitiveType.QuadStrip);//stanga
            GL.Color3(Color.Red);
            GL.Vertex3(5, 5, 10);//
            GL.Vertex3(5, 10, 10);
            GL.Vertex3(10, 5, 10);//
            GL.Vertex3(10, 10,10);//
            GL.End();

            //patrat dreapta'geam mare
            GL.Begin(PrimitiveType.QuadStrip);
            GL.Color3(Color.Red);
            GL.Vertex3(5, 5, 0);//
            GL.Vertex3(5, 10, 0);
            GL.Vertex3(10, 5, 0);//
            GL.Vertex3(10, 10, 0);//
            GL.End();

            //patrat 'geam mare spate
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(Color.Red);
            GL.Vertex3(15, 5, 10);//
            GL.Vertex3(15, 5, 0);
            GL.Vertex3(10, 10, 0);//
            GL.Vertex3(10, 10, 10);//
            GL.End();

            //triunghi stanga'spate
            GL.Begin(PrimitiveType.Triangles);//stanga
            GL.Color3(Color.Red);
            GL.Vertex3(5, 10, 0);
            GL.Vertex3(5, 5, 0);
            GL.Vertex3(2, 5, 0);
            GL.End();


            //triunghi dreapa-fata
            GL.Begin(PrimitiveType.Triangles);//stanga
            GL.Color3(Color.Red);
            GL.Vertex3(10, 10, 10);
            GL.Vertex3(15, 5, 10);
            GL.Vertex3(10, 5, 10);
            GL.End();
            //triunghi dreapa-spate
            GL.Begin(PrimitiveType.Triangles);//stanga
            GL.Color3(Color.Red);
            GL.Vertex3(10, 10, 0);
            GL.Vertex3(15, 5, 0);
            GL.Vertex3(10, 5, 0);
            GL.End();

        }
    }
}
