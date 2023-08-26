/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */

//2,0
//
//Input: nums = [2, 7, 11, 15], target = 9 
//Output: [0, 1]
//7,2,-2,-6
var twoSum = function (nums, target) {
  let map = new Map();
  for (let i = 0; i < nums.length; i++) {
    const complement = target - nums[i];
    if (map.has(complement)) {
      return [map.get(complement), i]
    } else {
      map.set(nums[i], i)
    }
  }
  return [];
};

let result = twoSum([2, 7, 11, 15], 9);
console.log(result);