using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication3.BC;

namespace WebApplication3.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            Test test = new Test();
            test.Name = "名前";
            test.Address = "住所";
            TestBC bc = new TestBC();
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] answer;
            answer = GetAnswer(nums, target);
            return View(test);
        }
        
        /// <summary>
        /// lettcode1の問題
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        private int[] GetAnswer(int[] nums, int target)
        {
            int[] answer = new int[2];
            for(int outerCount = 0; outerCount < nums.Length; outerCount++)
            {
                for(int innerCount = 0; innerCount < nums.Length; innerCount++)
                {
                    if(nums[outerCount] + nums[innerCount] == target)
                    {
                        answer[0] = outerCount;
                        answer[1] = innerCount;
                        break;
                    }
                }
            }
            return answer;
        }
    }
}