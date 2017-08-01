using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestSumSearch
{
    public class LargestSumSearch
    {
        private int _maxSum, _currSum, _start, _end, _startMax, _endMax;
        private int[] _arr;
        public LargestSumSearch(int[] arr)
        {
            _maxSum = arr.Length > 0 ? arr[0] : Int32.MinValue;
            _currSum = arr.Length > 0 ? arr[0] : Int32.MinValue;
            _start = 0;
            _end = 0;
            _startMax = 0;
            _endMax = 0;
            _arr = arr;
        }

        public int[] FindLargestSum()
        {
            if (_arr.Length == 0)
            {
                return new int[0];
            }

            for (int i = 1; i < _arr.Length; i++)
            {

                if (_arr[i] > _arr[i] + _currSum)
                {
                    _currSum = _arr[i];
                    _start = _end = i;
                }
                else
                {
                    _currSum += _arr[i];
                    _end = i;
                }

                if (_currSum > _maxSum)
                {
                    _maxSum = _currSum;
                    _startMax = _start;
                    _endMax = _end;
                }
            }

            int[] subArr = new int[_endMax - _startMax + 1];

            Array.Copy(_arr, _startMax, subArr, 0, _endMax - _startMax + 1);

            return subArr;
        } 
    }
}
