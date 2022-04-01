namespace DiscreteMath.BinaryRelations
{
    public class BinaryRelation
    {
        public bool[,] relationMatrix { private set; get; }
        public int size { private set; get; }

        public BinaryRelation(int size)
        {   
            relationMatrix = new bool[size, size];
            this.size = size;
        }

        public void AddRelation(int a, int b)
        {
            relationMatrix[a, b] = true;
        }

        public RelationProperties GetProperties()
        {
            return new RelationProperties(this);
        }
    }
}