using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Web.Http;
using Microsoft.Ajax.Utilities;

namespace AssignmentTwo_N01458977.Controllers
{
    //Class which calculates the border size.
    public class coordinate
    {
        //Variables which hold spots of paint and the border limits.
        public int[] placeX = new int[100];
        public int[] placeY = new int[100];

        public int[] borderTop    = new int[2];
        public int[] borderBottom = new int[2];

        //Offset to add to the border size.
        public int borderOffset = 1;

        //Take input and find border based on number of spots of paint.
        public coordinate(int n)
        {
            //Min and Max sizes for the border.
            int maxX = 0;
            int minX = 100;
            int maxY = 0;
            int minY = 100;

            //Set spots of paint based on sample inputs. 
            //n = 5;

            //Variable to make random points.
            Random rnd = new Random();

            //Make random points based on number of points.
            for (int i = 1; i < (n + 1); i++)
            {
                placeX[i] = rnd.Next(1, 100);
                placeY[i] = rnd.Next(1, 100);
            }

            //Sample input coordinates.
            //placeX[1] = 44;
            //placeY[1] = 62;

            //placeX[2] = 34;
            //placeY[2] = 69;

            //placeX[3] = 24;
            //placeY[3] = 78;

            //placeX[4] = 42;
            //placeY[4] = 44;

            //placeX[5] = 64;
            //placeY[5] = 10;

            //Find border min and max based on spots of paint.
            for (int i = 1; i < (n + 1); i++)
            {
                if(placeX[i] > maxX)
                {
                    maxX = placeX[i] + borderOffset;
                }

                if (placeX[i] < minX)
                {
                    minX = placeX[i] - borderOffset;
                }

                if (placeY[i] > maxY)
                {
                    maxY = placeY[i] + borderOffset;
                }

                if (placeY[i] < minY)
                {
                    minY = placeY[i] - borderOffset;
                }
            }

            //Set min and max border coordinates.
            borderTop[0] = maxX;
            borderTop[1] = maxY;

            borderBottom[0] = minX;
            borderBottom[1] = minY;
        }
    }

    /// <summary>
    /// Returns border size based on number of points on the canvas.
    /// <example>GET api/J3/Art/5 -> 23,9 65,79</example>
    /// </summary>
    /// <param name="n">The input number</param>
    /// <return>Retunr the border coordinates needed to surround the paint</return>
    public class J3Controller : ApiController
    {
        [Route("api/J3/Art/{n}")]
        public string Get(int n)
        {
            //Generate spots of paint, find border limits and save border limit coordinates.
            var borderSize = new coordinate(n);

            //Output min and max border coordinates 
            return borderSize.borderBottom[0] + "," + borderSize.borderBottom[1] + " " + borderSize.borderTop[0] + "," + borderSize.borderTop[1];
        }
    }
}