string[] words = {"hello", "2", "world",":-)"};
int count = 0;
for (int i = 0; i < words.Length; ++i)
    {
        if (words[i].Length <= 3) count++;
    }
string[] itog = new string[words.Length];
for (int i = 0; i < words.Length; ++i)
    {               
        if (words[i].Length <= 3) itog[i] = words[i];
    }
for (int j = 0; j < words.Length; j++)
     {
        if (itog[j] != null) Console.Write(itog[j] + ' ');
     }
