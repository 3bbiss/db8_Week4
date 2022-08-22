

Polygon poly1 = new Polygon("Fred", new Edge("a", 5), new Edge("b", 4), new Edge("c", 3));
// Requirements: 
// Can add additional edges
// Can change the length of an edge. E.g. change edge "b" from 4 to 5.



Console.WriteLine(poly1);

poly1.AddEdge(new Edge("d", 6));

Console.WriteLine(poly1);

poly1.ChangeEdge("b", 5);

Console.WriteLine(poly1);

Console.WriteLine();
Console.WriteLine("Which edge would you like to change? ");
string edge = Console.ReadLine();
Console.WriteLine("What size do you want to change it to? ");
string entry = Console.ReadLine();
double length = double.Parse(entry);

poly1.ChangeEdge(edge, length);

Console.WriteLine(poly1);

class Edge
{
    public string name;
    public double length;

    public Edge(string _name, double _length)
    {
        name = _name;
        length = _length;
    }
}




class Polygon
{
    public string name;
    public List<Edge> edges;


    public Polygon(string _name, Edge edge1, Edge edge2, Edge edge3)
    {
        name = _name;
        edges = new List<Edge>();
        edges.Add(edge1);
        edges.Add(edge2);
        edges.Add(edge3);
    }



    public void AddEdge(Edge another)
    {
        edges.Add(another);
    }


    public void ChangeEdge(string which, double newLength)
    {
        foreach (Edge ed in edges)
        {
            if (ed.name == which)
            {
                ed.length = newLength;
                return;
            }
        }
    }



    public override string ToString()
    {
        string result = string.Empty;
        foreach (Edge ed in edges)
        {
            result += $"{ed.name}:{ed.length},";
        }
        return $"{name} = {result}";
    }


}