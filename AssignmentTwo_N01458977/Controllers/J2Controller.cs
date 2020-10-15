using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AssignmentTwo_N01458977.Controllers
{
    /// <summary>
    /// Retunrs the number of dice rolls that add to 10.
    /// <example>GET api/J2/DiceGame/12/4 -> There are 4 ways to get the sum 10</example>
    /// </summary>
    /// <param name="m">Number of sides on the first die</param>
    /// <param name="n">Number of sides on the second die</param>
    /// <returns>The number of ways to get the sum 10</returns>
    public class J2Controller : ApiController
    {
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string GetDiceGame(int m, int n)
        {
            int sum = 0;

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if( (i + j) == 10 )
                    {
                        sum += 1;
                    }
                }
            }
            return "Game " + sum;
        }
    }
}