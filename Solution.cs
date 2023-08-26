using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LeetCode
{
    public class Solution
    {
        public void init() //初始化
        {
            #region TwoSum_1
            //調用
            //int[] Input = { 2, 7, 11, 15 };
            //int Output = 9;
            //int[] Input = { 3, 2, 4 };
            //int Output = 6;
            //int[] Input = { 3, 3 };
            //int Output = 6;
            //string result = $"[{string.Join(',', TwoSum(Input, Output))}]";
            #endregion 

            #region IsValid_20
            //string Input = "()";
            //string Input = "()[]{}";
            string Input = "(]";
            var result = IsValid(Input);
            #endregion

            //共用
            Console.WriteLine(result);
            Console.ReadLine();
        }
        public int[] TwoSum(int[] nums, int target)
        {
            int[] ints = new int[2];
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i]; //7 2
                if (dic.ContainsKey(complement))
                {
                    ints[0] = dic[complement];
                    ints[1] = i;
                    return ints;
                }
                else
                {
                    dic.Add(nums[i], i); //2,0
                }
            }

            return ints;

        }

        public bool IsValid(string s)
        {
            Dictionary<string,string> dic= new Dictionary<string,string>();
            //()[]{}
            dic.Add("(",")");
            dic.Add("[","]");
            dic.Add("{","}");
            //array
           List<string> strings = new List<string>();
            for (int i = 0; i < s.Length; i++)
            {
                string target = s[i].ToString(); //"("
                if (dic.ContainsKey(target)) //()[]{}
                {
                    strings.Add(dic[target].ToString()); //")"
                }
                else
                {
                    if (target != strings[strings.Count-1])
                    {
                        return false;
                    }
                    else
                    {
                        strings.Remove(target);
                    }
                }
            }
            if (strings.Count != 0)
            {
                return false;
            }
            return true;
        }
    }
}
