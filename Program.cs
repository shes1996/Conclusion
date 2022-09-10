string[] words = {"hello", "2", "world",":-)"};
int count = 0;
string[] itog = {};
for (int i = 0; i < words.Length; ++i)
    {
        if (words[i].Length <= 3) count++;
    }
Console.Write(count);