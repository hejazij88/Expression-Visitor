// See https://aka.ms/new-console-template for more information


using System.Linq.Expressions;

List<Person> list = new List<Person>
{
    new Person{Id = 1,Name = "Mohammad Javad"},
    new Person{Id = 2,Name = "Ali"},
    new Person{Id = 3,Name = "Mohsen"},
};


IQueryable<Person> lists = list.AsQueryable();
IQueryable<Person> query = lists.Where(p=>p.Id<=2)
    .OrderBy(p=>p.Name);


QueryVisitor visitor = new QueryVisitor();
visitor.Visit(query.Expression);



public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class QueryVisitor : ExpressionVisitor
{
    protected override Expression VisitBinary(BinaryExpression node)
    {
        return base.VisitBinary(node);
    }

    protected override Expression VisitConstant(ConstantExpression node)
    {
        return base.VisitConstant(node);
    }

    protected override Expression VisitMember(MemberExpression node)
    {
        return base.VisitMember(node);
    }
}