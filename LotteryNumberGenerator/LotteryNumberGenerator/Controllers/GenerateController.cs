using System;
using System.Collections.Generic;
using System.Web.Http;

namespace LotteryNumberGenerator.Controllers
{
    public class GenerateController : ApiController
    {
        private static readonly Random random = new Random();

        // GET api/generate
        public IEnumerable<int> GetNumbers()
        {
            var values = Generate();
            return values;
        }

        private IEnumerable<int> Generate()
        {
            List<int> numbers = new List<int>();

            while (numbers.Count < 6)
            {
                int randomValue = random.Next(1, 50);
                if (!numbers.Contains(randomValue))
                {
                    numbers.Add(randomValue);
                }
            }

            numbers.Sort();
            return numbers;
        }
    }
}
