namespace L5
{
    public class Titov_Pavel_05_01
    {
        public string Filepath
        {
            get; set;
        }
        public Titov_Pavel_05_01(string filepath)
        {
            Filepath = filepath;
        }
        public int Task1()
        {
            using (StreamReader sr = new StreamReader(Filepath))
            {
                int count = 0;
                string[] words = sr.ReadToEnd().Split(" .,!?:\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                foreach (string word in words)
                {
                    if (word != "" && char.ToLower(word[0]) == char.ToLower(word[word.Length - 1]))
                    {
                        count++;
                    }
                }
                return count;
            }
        }
    }
}