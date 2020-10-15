using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AssignmentTwo_N01458977.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// Returns calorie count based on meal selection.
        /// <example>GET api/J1/Menu/1/2/3/4 -> Your total calorie count is 691</example>
        /// </summary>
        /// <param name="burger">The burger selection</param>
        /// <param name="drink">The drink selection</param>
        /// <param name="side">The side selection</param>
        /// <param name="dessert">the dessert selection</param>
        /// <returns>The total calorie count</returns>
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string GetMenu(int burger, int drink, int side, int dessert)
        {
            int itemOne = 0;
            int itemTwo = 0;
            int itemThree = 0;
            int itemFour = 0;

            int itemTotal = 0;

            //Calories for Item One
            if (burger == 1)
            {
                itemOne = 461;
            }
            else if(burger == 2)
            {
                itemOne = 431;
            }
            else if (burger == 3)
            {
                itemOne = 420;
            }
            else
            {
                itemOne = 0;
            }

            //Calories ofr Item Two
            if (drink == 1)
            {
                itemTwo = 130;
            }
            else if (drink == 2)
            {
                itemTwo = 160;
            }
            else if (drink == 3)
            {
                itemTwo = 118;
            }
            else
            {
                itemTwo = 0;
            }

            //Calories ofr Item Three
            if (side == 1)
            {
                itemThree = 100;
            }
            else if (side == 2)
            {
                itemThree = 57;
            }
            else if (side == 3)
            {
                itemThree = 70;
            }
            else
            {
                itemThree = 0;
            }

            //Calories ofr Item Three
            if (dessert == 1)
            {
                itemFour = 167;
            }
            else if (dessert == 2)
            {
                itemFour = 266;
            }
            else if (dessert == 3)
            {
                itemFour = 75;
            }
            else
            {
                itemFour = 0;
            }

            //Calculate total calories
            itemTotal = itemOne + itemTwo + itemThree + itemFour;

            return "Your total calorie count is " + itemTotal;

        }

    }

}