using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace BrickOut
{
    public partial class Form1 : Form
    {
        private const int kNumberOfRows = 8;
        private const int kNumberOfTries = 3;

        private int NumTotalBricks = 0;

        private int NumBalls = 0;

        private Ball TheBall = new Ball();
        private Paddle ThePaddle = new Paddle();
        private Row[] Rows = new Row[kNumberOfRows];
        private Score TheScore = null;
        private Thread oTread = null;

         public Form1()
        {
             InitializeComponent();

             for(int i=0;i<kNumberOfRows;i++)
             {
                Rows[i]=new Row(i);
             }

             ThePaddle.Position.X=5;
             ThePaddle.Position.Y=this.ClientRectangle.Bottom-ThePaddle.Height;

             TheBall.Position.Y=this.ClientRectangle.Bottom-200;

             this.SetBounds(this.Left,this.Top,Rows[0].GetBounds().Width,this.Height);

             TheScore=new Score(ClientRectangle.Right-50,ClientRectangle.Bottom-180);

             //chose Level
             SpeedDialog dlg =new SpeedDialog();
             if(dlg.ShowDialog()==DialogResult.OK)
             {
                timer1.Interval=dlg.Speed;              
             }
        }


         private void DrawRows(Graphics g)
         {
             for (int i = 0; i < kNumberOfRows; i++)
             {
                 Rows[i].Draw(g);
             }
         }

         private void Form1_Paint(object sender, PaintEventArgs e)
         {
             Graphics g = e.Graphics;
             g.FillRectangle(Brushes.White, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height);
             TheScore.Draw(g);
             ThePaddle.Draw(g);
             DrawRows(g);
             TheBall.Draw(g);
         }

         [DllImport("winmm.dll")]
         public static extern long PlaySound(String lpszName, int hModule, int dwFlags);

        private string m_strCurrentSoundFile="Ballout.wav";
        public void PlayASound()
        {
            if(m_strCurrentSoundFile.Length>0)
            {
                PlaySound(Application.StartupPath + "\\" + m_strCurrentSoundFile, 0, 0);
            }
            m_strCurrentSoundFile="";
            oTread.Abort();
        }

        private void PlaySoundInThread(string wavefile)
        {
 	        m_strCurrentSoundFile=wavefile;
            oTread=new Thread(new ThreadStart(PlayASound));
            oTread.Start();
        }

        private void CheckForCollision()
        {
            //hit the left side,switch polarity
            if(TheBall.Position.X<0)
            {
                TheBall.XStep*=-1;
                TheBall.Position.X+=TheBall.XStep;
                PlaySoundInThread("WallHit.wav");
            }

            if(TheBall.Position.Y<0)
            {
                TheBall.YStep*=-1;
                TheBall.Position.Y+=TheBall.YStep;
                PlaySoundInThread("WallHit.wav");
            }

            if(TheBall.Position.X>this.ClientRectangle.Right-TheBall.Width)
            {
                TheBall.XStep*=-1;
                TheBall.Position.X+=TheBall.XStep;
                PlaySoundInThread("WallHit.wav");          
            }

            if(TheBall.Position.Y>this.ClientRectangle.Bottom-TheBall.YStep)
            {
                IncrementGamesBalls();
                Reset();
                PlaySoundInThread("BallOut.wav");
            }

            if(RowsCollide(TheBall.Position))
            {
                TheBall.YStep*=-1;
                PlaySoundInThread("BrickHit.wav");
            }

            int hp=HitPaddle(TheBall.Position);
            if(hp>-1)
            {
                PlaySoundInThread("PaddleHit.wav");
                switch(hp)// lost the ball!
                {
                    case 1:
                        TheBall.XStep=-7;
                        TheBall.YStep=-3;
                        break;
                    case 2:
                        TheBall.XStep=-5;
                        TheBall.YStep=-5;
                        break;
                    case 3:
                        TheBall .XStep=5;
                        TheBall.YStep=-5;
                        break;
                    default:
                        TheBall.XStep=7;
                        TheBall.YStep=-3;
                        break;
                }


            }
        }

        private int HitPaddle(Point p)
        {
 	        Rectangle PaddleRect=ThePaddle.GetBounds();
            if(p.Y>=this.ClientRectangle.Bottom-(PaddleRect.Height+TheBall.Height))
            {
                if((p.X>PaddleRect.Left)&&(p.X<PaddleRect.Right))
                {
                    if((p.X>PaddleRect.Left)&&(p.X<=PaddleRect.Left+PaddleRect.Width/4))
                        return 1;
                    else if((p.X<PaddleRect.Left+PaddleRect.Width/4)&&(p.X<PaddleRect.Left+PaddleRect.Width/2))
                        return 2;
                    else if((p.X<PaddleRect.Left+PaddleRect.Width/2)&&(p.X>PaddleRect.Right-PaddleRect.Width/2))
                        return 3;
                    else
                        return 4;
                }
            }

             return -1;
        }

        private void IncrementGamesBalls()
        {
 	        NumBalls++;
            if(NumBalls>=kNumberOfTries)
            {
                timer1.Stop();
                string msg="Games Over\nYou knocked out"+NumTotalBricks;
                if(NumTotalBricks==1)
                    msg+="brick.";
                else
                    msg+="bricks.";
                MessageBox.Show(msg);
                Application.Exit();
            }
        }

        private void Reset()
        {
 	        TheBall.XStep=5;
            TheBall.YStep=5;
            TheBall.Position.X=5;
            TheBall.Position.Y=this.ClientRectangle.Bottom-190;
            timer1.Stop();
            TheBall.UpdateBounds();
        }

        public int SumBricks()
        {
            int sum=0;
            for(int i=0;i<kNumberOfRows;i++)
            {
                sum+=Rows[i].BrickOut;
            }
            return sum;
        }
        
        private bool RowsCollide(Point p)
        {
 	        for(int i=0;i<kNumberOfRows;i++)
            {
                if(Rows[i].Collides(TheBall.GetBounds()))
                {
                    Rectangle rRow=Rows[i].GetBounds();
                    Invalidate(rRow);
                    return true;
                }
            }

            return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TheBall.UpdateBounds();
            Invalidate(TheBall.GetBounds());
            TheBall.Move();
            TheBall.UpdateBounds();
            Invalidate(TheBall.GetBounds());
            CheckForCollision();
            NumTotalBricks=SumBricks();
            TheScore.Count=NumTotalBricks;
            Invalidate(TheScore.GetFrame());
            if(NumTotalBricks==kNumberOfRows*Row.kNumberOfBricks)
            {
                timer1.Stop();
                MessageBox.Show("You Win! You knocked out all the bricks!");
                Application.Exit();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            string result=e.KeyData.ToString();
            Invalidate(TheBall.GetBounds());
            switch(result)
            {
                case "Left":
                    ThePaddle.MoveLeft();
                    Invalidate(ThePaddle.GetBounds());
                    if(timer1.Enabled==false)
                        timer1.Start();
                    break;
                case "Right":
                    ThePaddle.MoveRight(ClientRectangle.Right);
                    Invalidate(ThePaddle.GetBounds());
                    if(timer1.Enabled==false)
                        timer1.Start();
                    break;
                default:
                    break;

            }
        }

    }
}
