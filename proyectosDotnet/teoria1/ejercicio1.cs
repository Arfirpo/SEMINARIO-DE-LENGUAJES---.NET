// See https://aka.ms/new-console-template for more information
string st = "Hola Mundo";
string word = "";
for (int i = 0; i < st.Length; i++)
{

  if (st[i] != ' ')
  {
    word += st[i];
  }
  else
  {
    if (word.Length > 0)
    {
      Console.Write(word + " ");
      word = "";
      Console.ReadKey(true);
    }

  }
}
if (word.Length > 0)
{
  Console.Write(word);
  Console.ReadKey(true);
}