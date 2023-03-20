void minWrap(int amount, ref int count, ref bool exit) {
    if (exit == true) return;
    if (amount < 0) {
        return;
    }
    if (amount == 0) {
        exit = true;
        return;
    }
    count++;
    minWrap(amount - 50, ref count, ref exit);
    minWrap(amount - 20, ref count, ref exit);
    minWrap(amount - 10, ref count, ref exit);
    minWrap(amount - 5, ref count, ref exit);
    minWrap(amount - 1, ref count, ref exit);
}


int MinSplit(int amount) {
    int count = 0;
    bool exit = false;
    minWrap(amount, ref count, ref exit);
    return count;
}

Console.WriteLine(MinSplit(3));