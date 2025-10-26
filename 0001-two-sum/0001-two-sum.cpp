class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        vector<int> reserved;

        for (int i = 0; i < nums.size() - 1; i++) {
            for (int j = i + 1; j < nums.size(); j++) {
                if (nums[i] + nums[j] == target) {
                    reserved.push_back(i);
                    reserved.push_back(j);
                }
            }
        }
        return reserved;
    }
};