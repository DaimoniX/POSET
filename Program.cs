using DiscreteMath.BinaryRelations;
using System.Text;

class Program
{
    public static void PrintRealtion(BinaryRelation relation)
    {
        StringBuilder builder = new StringBuilder(relation.size * relation.size * 3);
        for (int i = 0; i < relation.size; i++)
        {
            for (int j = 0; j < relation.size; j++)
            {
                builder.Append((relation.relationMatrix[i, j] ? "1" : "0")).Append(' ');
            }
            builder.Append('\n');
        }
        Console.WriteLine(builder.ToString());
    }

    public static void MakeReflexive(BinaryRelation relation)
    {
        for (int i = 0; i < relation.size; i++)
            relation.AddRelation(i, i);
    }

    public static void Main()
    {
        BinaryRelation relation = new BinaryRelation(7);

        PrintRealtion(relation);

        relation.AddRelation(1, 3);
        relation.AddRelation(1, 4);
        relation.AddRelation(1, 6);
        relation.AddRelation(3, 4);
        relation.AddRelation(3, 6);

        MakeReflexive(relation);
        
        PrintRealtion(relation);

        Console.WriteLine(relation.GetProperties());
    }
}