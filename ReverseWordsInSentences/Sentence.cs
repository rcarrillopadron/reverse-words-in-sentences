namespace ReverseWordsInSentences
{
    internal class Sentence
    {
        private readonly char[] _input;

        public Sentence(char[] input)
        {
            _input = input;
        }

        public void ReverseWords()
        {
            // 1. Reverse all characters
            ReversePhrase(0, _input.Length);

            // 2. Reverse word by word
            int start = 0;

            for (int i = 0; i < _input.Length; i++)
            {
                if (_input[i] == ' ')
                {
                    ReverseWord(start, i - 1);
                    start = i + 1;
                }

                if (_input.Length == i + 1)
                {
                    ReverseWord(start, i);
                }
            }
        }

        private void ReversePhrase(int start, int end)
        {
            int counter = end - 1;
            for (int i = start; i < end/2; i++)
            {
                Swap(i, counter);
                counter--;
            }
        }

        private void ReverseWord(int start, int end)
        {
            int counter = end + 1;
            for (int i = start; i <= end; i++)
            {
                Swap(i, counter - 1);
                counter--;

                if (counter - 1 == i)
                    break;

                if (i == counter)
                    break;
            }
        }

        private void Swap(int positionA, int positionB)
        {
            char temp = _input[positionA];
            _input[positionA] = _input[positionB];
            _input[positionB] = temp;
        }
    }
}