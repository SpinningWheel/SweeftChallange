using System.Collections;

int NotContains(int[] arr) {
    int len = arr.Length;
    List<int> list = arr.ToList();
    list.Sort();
    if (!list.Contains(1)) {
        return 1;
    }
    for (int i = 0; i < list.Count - 1; i++) {
        if (list[i] + 1 > 0) {
            if (list[i] + 1 < list[i + 1]) {
                return list[i] + 1;
            }
        }
    }
    if (list[list.Count - 1] > 0) {
        return list[list.Count - 1] + 1;
    }

    return 1;
}

int[] arr = { -1, -2, -5, -8, -28, -12, 0, 1, 7};
Console.WriteLine(NotContains(arr));