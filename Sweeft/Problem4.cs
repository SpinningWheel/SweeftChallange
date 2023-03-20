using System.Collections;

bool IsProperly(string sequence) {
    Stack check = new Stack();
    for (int i = 0; i < sequence.Length; i++) {
        bool except = false;
        string wrap = "" + sequence[i];
        if (check.Count != 0) {
            if (wrap == ")" && (string)check.Peek() == "(") { 
                check.Pop();
                except = true;
            } 
        }
        if (wrap == "(") check.Push(wrap);
        if (except == false && wrap == ")") return false;
    }
    if (check.Count == 0) return true;
    return false;
}

Console.WriteLine(IsProperly("()"));
