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
    class CarBody
    {
      
        public CarBody()
        {

        }

        public void drawBody()
        {
            GL.Begin(PrimitiveType.Quads);//fata
            GL.Color3(Color.Aqua);
            GL.Vertex3(0,5,10);
            GL.Vertex3(20, 5, 10);
            GL.Vertex3(20,2, 10);
            GL.Vertex3(0, 2, 10);
            GL.End();


            GL.Begin(PrimitiveType.Quads);//spate
            GL.Color3(Color.Aqua);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(20, 0, 0);
            GL.Vertex3(20, 5, 0);
            GL.Vertex3(0, 5, 0);
            GL.End();


            GL.Begin(PrimitiveType.Quads);//stanga
            GL.Color3(Color.Red);
            GL.Vertex3(-2, 5, 10);//s
            GL.Vertex3(-2, 5, 0);
            GL.Vertex3(-2, 5, 0);
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
            GL.Vertex3(0, 5, 10);
            GL.Vertex3(20, 5, 10);//sus
            GL.Vertex3(20,5, 0);
            GL.Vertex3(0,5, 0);
            GL.End();
        }
     

    }
}
