using static System.Console;
using static System.Convert;
using static System.Math;


int n, m;
decimal[] arr1  = new decimal[5005];
decimal[] arr2 = new decimal[5005];
decimal mn = 101;

string str1 = ReadLine();
var arr3 = str1.Split(" ");
n = ToInt32(arr3[0]);
m = ToInt32(arr3[1]);

for(int i = 0; i < n; i++)
{
    string str2 = ReadLine();
    var arr4 = str2.Split(" ");
    arr1[i] = ToDecimal(arr4[0]);
    arr2[i] = ToDecimal(arr4[1]);
    mn = Min(mn, arr1[i] / arr2[i]);
}
decimal res = m * mn;

WriteLine(res.ToString("#.########"));
