namespace DiscreteMath
{
    public class BinaryRelation
    {
        private bool[,] relationMatrix;

        public BinaryRelation(int size)
        {
            relationMatrix = new bool[size + 1, size + 1];
        }

        public void AddRelation(int a, int b)
        {
            relationMatrix[a, b] = true;
        }
    }
}