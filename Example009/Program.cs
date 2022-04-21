 int Max(int arg1, int arg2, int arg3)
{
    int res = arg1;
    if (arg2 > res) res = arg2;
    if (arg3 > res) res = arg3;
    return res;
}

int [] array = {12,31,3341,51,15,16,771,61,12};

int res = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[5], array[6], array[7])
);

Console.WriteLine(res); 