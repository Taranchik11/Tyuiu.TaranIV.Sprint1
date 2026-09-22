using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TaranIV.Sprint1.Task6.V8.Lib
{
    public class DataService : ISprint1Task6V8
    {
        public string MoveLetterToEnd(string value)
        {
            string[] words = value.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var resultWords = new List<string>();

            foreach (var item in words)
            {
                string newWord = item.Substring(1) + item[0];

                resultWords.Add(newWord);
            }
            return string.Join(" ", resultWords);
        }
    }
}
