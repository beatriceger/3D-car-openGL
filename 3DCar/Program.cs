using OpenTK;
using System;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System.Drawing;

namespace _3DCar
{
    class Program
    {
        internal class SimpleWindow3D : GameWindow
        {

            KeyboardState lastKeyPress;
            Wheels roti = new Wheels();
            private int forwardBack = 0;
            private int righteft = 0;
            private int upDown = 5;
            private int selectareForma = 0;
            bool curba=false;
           // private int texturaC = 0;

            private SimpleWindow3D() : base(800, 600, new GraphicsMode(32, 24, 0, 8))
            {
                GL.Enable(EnableCap.Texture2D);

            }

            protected override void OnLoad(EventArgs e)
            {
                base.OnLoad(e);
                //Form3D.Skin.LoadTextures();
                GL.ClearColor(Color.DarkOliveGreen);
                GL.Enable(EnableCap.Texture2D);
                GL.Enable(EnableCap.DepthTest);

            }

            protected override void OnResize(EventArgs e)
            {
                base.OnResize(e);

                GL.Viewport(0, 0, Width, Height);

                double aspect_ratio = Width / (double)Height;

                Matrix4 perspective = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, (float)aspect_ratio, 1, 128);
                GL.MatrixMode(MatrixMode.Projection);
                GL.LoadMatrix(ref perspective);

                Matrix4 lookat = Matrix4.LookAt(30, 30, 30, 0, 0, 0, 0, 1, 0);
                GL.MatrixMode(MatrixMode.Modelview);
                GL.LoadMatrix(ref lookat);


            }

            protected override void OnUpdateFrame(FrameEventArgs e)
            {
                base.OnUpdateFrame(e);

                KeyboardState keyboard = Keyboard.GetState();
                MouseState mouse = Mouse.GetState();

                //inchiderea ferestrei utilizand tasta Escape
                if (keyboard[Key.Escape])
                {
                    this.Exit();
                    return;
                }

                //schimbarea texturii
                if (keyboard[Key.T] && !keyboard.Equals(lastKeyPress))
                {
                   

                }

                //ascunde forma
                if (keyboard[Key.P] && !keyboard.Equals(lastKeyPress))
                {
                   // forma3D.ToggleVisibility();
                }
                // miscarea formelor

                if (keyboard[Key.W])
                {
                    curba = false;
                    forwardBack--;

                }
                if ((keyboard[Key.A])&& !keyboard.Equals(lastKeyPress))
                {
                    curba = true;
                    righteft=2;
                    righteft++;
                }
                if ((keyboard[Key.S])&& !keyboard.Equals(lastKeyPress))
                {
                    curba = false;
                    forwardBack++;
                }
                if (keyboard[Key.D])
                {
                    curba = true;
                    righteft--;
                }
                //mutare sus-jos
                if (keyboard[Key.Up])
                {
                    curba = false;
                    upDown++;
                }
                if (keyboard[Key.Down])
                {
                    curba = false;
                    upDown--;
                }
                //selectare forma
                if (keyboard[Key.Right] && !keyboard.Equals(lastKeyPress))
                {
                    do
                    {

                        selectareForma++;
                        if (selectareForma == 3)
                            selectareForma = 0;
                    }
                    while (selectareForma == 3);

                }
                //selectare forma
                if (keyboard[Key.Left] && !keyboard.Equals(lastKeyPress))
                {
                    do
                    {
                        selectareForma--;
                        if (selectareForma == -1)
                            selectareForma = 3;
                    }
                    while (selectareForma == 3);

                }
              //  curba = false;
                lastKeyPress = keyboard;
            }

            protected override void OnRenderFrame(FrameEventArgs e)
            {
                base.OnRenderFrame(e);
               
                GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
                GL.Enable(EnableCap.DepthTest);

                if (!curba)
                {
                    GL.PushMatrix();
                    //  GL.Translate(0.0, -0.4, -3.0);
                    GL.Rotate(-5, 0.0, righteft, 0.0);//viteza,x,y,z
                    GL.Translate(forwardBack, 0.0, 0.0);//miscare in fata-w
                    GL.Translate(0, upDown, 0);
                    roti.draw_cylinder(2, 10.0);
                    GL.PopMatrix();

                    GL.PushMatrix();
                    GL.Translate(forwardBack, 0.0, 0.0);//miscare in fata-w
                    GL.Translate(0, upDown, 0);
                    GL.Rotate(-5, 0.0, righteft, 0.0);//viteza,x,y,z
                    roti.draw_cylinder2(2, 10.0);
                    GL.PopMatrix();
                }
                else
                {
                   // GL.PushMatrix();
                    //  GL.Translate(0.0, -0.4, -3.0);
                    GL.Rotate(-1, 0.0, righteft, 0.0);//viteza,x,y,z
                    roti.draw_cylinder(2, 10.0);
                    roti.draw_cylinder2(2, 10.0);
                   // GL.PopMatrix();


                }
           

                this.SwapBuffers();
               
                // axe.DrawMe();
            }





            // [STAThread]
            static void Main(string[] args)
            {

                using (SimpleWindow3D example = new SimpleWindow3D())
                {
                    example.Run(30.0, 0.0);
                }

            }
        }
    }
}
