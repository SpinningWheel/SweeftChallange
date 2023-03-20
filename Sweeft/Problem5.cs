void countWrap(int stairCount, ref int count) {
    if (stairCount == 0) {
        count++;
        return;
    }
    if (stairCount < 0) return;
    countWrap(stairCount - 1, ref count);
    countWrap(stairCount - 2, ref count);
}

int CountVariants(int stairCount) {
    int count = 0;
    countWrap(stairCount, ref count);
    return count;
}
Console.WriteLine(CountVariants(5));

