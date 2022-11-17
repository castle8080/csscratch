namespace CSScratch.Expression
{
    public static class Expression
    {

        public static Expression<T> column<T>(string name)
        {
            return new ColumnExpression<T>(name);
        }

        public static Expression<T> literal<T>(T value)
        {
            return new LiteralExpression<T>(value);
        }

        public static Expression<bool> LT<T>(Expression<T> left, Expression<T> right)
        {
            return new BinaryExpression<T>(BinaryOperator.LT, left, right);
        }
        public static Expression<bool> LT<T>(Expression<T> left, T right)
        {
            return new BinaryExpression<T>(BinaryOperator.LT, left, literal(right));
        }

        public static Expression<bool> AND(params Expression<bool>[] operands)
        {
            return new AndExpression(operands);
        }
    }

    public abstract class Expression<T>
    {

    }

    public class LiteralExpression<T> : Expression<T>
    {
        public T Value { get; }

        public LiteralExpression(T value)
        {
            this.Value = value;
        }
    }

    public class ColumnExpression<T> : Expression<T>
    {
        public string Name { get; }

        public ColumnExpression(string name)
        {
            this.Name = name;
        }
    }

    public enum BinaryOperator
    {
        LT, LE, EQ, NE, GT, GE
    }

    public class BinaryExpression<T> : Expression<bool>
    {
        public BinaryOperator Operator { get; }
        
        public Expression<T> Left { get; }

        public Expression<T> Right { get; }

        public BinaryExpression(BinaryOperator op, Expression<T> left, Expression<T> right)
        {
            this.Operator = op;
            this.Left = left;
            this.Right = right;
        }
    }

    public class AndExpression : Expression<bool>
    {
        public Expression<bool>[] Operands { get; }

        public AndExpression(params Expression<bool>[] operands)
        {
            this.Operands = operands;
        }

    }
}
