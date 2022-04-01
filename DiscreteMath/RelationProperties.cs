namespace DiscreteMath.BinaryRelations
{
    public struct RelationProperties
    {
        public bool Reflexive { private set; get; } = false;
        public bool Symmetric { private set; get; } = false;
        public bool Asymmetric { private set; get; } = false;
        public bool Antisymmetric { get { return Asymmetric && Reflexive; } }
        public bool Transitive { private set; get; } = false;

        public RelationProperties(BinaryRelation relation)
        {
            this.Reflexive = CheckReflexivity(relation.relationMatrix, relation.size);
            this.Symmetric = CheckSymmetry(relation.relationMatrix, relation.size);
            this.Asymmetric = CheckAsymmetry(relation.relationMatrix, relation.size);
            this.Transitive = CheckTransitivity(relation.relationMatrix, relation.size);
        }

        private bool CheckReflexivity(bool[,] matrix, int size)
        {
            for (int i = 0; i < size; i++)
                if (!matrix[i, i])
                    return false;
            return true;
        }

        private bool CheckSymmetry(bool[,] matrix, int size)
        {
            for (int i = 1; i < size; i++)
                for (int j = i + 1; j < size; j++)
                    if (matrix[i, j] != matrix[j, i])
                        return false;
            return true;
        }

        private bool CheckAsymmetry(bool[,] matrix, int size)
        {
            for (int i = 1; i < size; i++)
                for (int j = i + 1; j < size; j++)
                    if (matrix[i, j] && matrix[i, j] == matrix[j, i])
                        return false;
            return true;
        }

        private bool CheckTransitivity(bool[,] matrix, int size)
        {
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    for (int k = 0; k < size; k++)
                        if (matrix[i, j] && matrix[j, k] && !matrix[i, k])
                            return false;
            return true;
        }

        public override string ToString()
        {
            return String.Format("Relation properites:\nReflexive: {0}\nSymmetric: {1}\nAsymmetric: {2}\nAntisymmetric: {3}\nTransitive: {4}", Reflexive, Symmetric, Asymmetric, Antisymmetric, Transitive);
        }
    }
}