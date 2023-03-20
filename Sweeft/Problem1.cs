using System.Collections;

bool sPalindrome(string text) { 
    Stack characters = new Stack();
    string stringInv = "";
    for (int i = 0; i < text.Length / 2; i++) {
        characters.Push(text[i]);
    }
    while (characters.Count != 0) {
        stringInv += characters.Pop();
    }
    if (text.Length % 2 == 0 && text.Substring(text.Length / 2).Equals(stringInv)) {
        return true;
    } else if (text.Substring(text.Length / 2 + 1).Equals(stringInv)) return true;
    return false;
}
Console.WriteLine(sPalindrome("abba"));


