using Exam;

namespace Exam;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}


public class Q1_Add
{
    public int S1 {get;set;}
    public int S2 {get;set;}
    public Q1_Add(  int s1,  int s2)
    {
        this.S1 = s1;
        this.S2 = s2;
    }
    public static int Add(int a1,int a2)
    {
        return a1 + a2;
    }
}

public struct Type1
{
    public int Count;
}
public class Type2
{
    public int Count;
}
public class Basics
{

   
    public static  void  Q2MultiplyAndReset(ref int s1, ref int s2)
    {
        
        
        s1 = s1 *s2;
        s2 = 1;
        

    }
    // public static void Q5TryCatchFinally(bool Isthrow,List<string> x,bool y)
    // {
    //     try
    //     {
    //         int s = 0;
    //         for(int i =0;i<x.Length;i++)
    //         {
    //             s+=x[i];
    //         }
    //     }
    //     catch
    //     {

    //     }
    // }
    // public void Q5TryCatchFinally
    // {

    // }
}



public class Q4Person
{
    public int Age;
    public string Name;
    public Q4Person(string name,int age)
    {
        this.Age = age;
        this.Name = name;
    }
    public string Introduce()
    {
        return $"Hello, my name is {this.Name} and I am {this.Age} years old.";
    }
}



public interface IShape
{
    double GetArea();
    double GetPerimeter();
}

public class Q7Circle:IShape
{
    double Radius{get;set;}
    public Q7Circle(double r)
    {
        this.Radius = r;
    }
    
     public double GetArea()
    {
        return Math.PI * Radius* Radius;
        
    }
     public double GetPerimeter()
    {
        return 2 *(Radius*Math.PI);
    }
}
public class Q7Rectangle:IShape
{
    double Width {get;set;}
    double Height {get;set;}
    public Q7Rectangle(double with,double h)
    {
        this.Width = with;
        this.Height = h;

    }
    public double GetArea()
    {
        return Width * Height;
        
    }
    

     public double GetPerimeter()
    {
        return 2 *(Width + Height);
    }
}

public class ShapeUtils
{
   
   
    public static  double Q7TotalArea(IShape[]y)
    {
        double u = 0;
        for(int i=0;i<y.Length;i++)
        {
            double t = y[i].GetArea();
            u += t;
        }
        return u;
    }
}

public class Q8StringLengthComparer:IComparer<string>
{


    public Q8StringLengthComparer()
    {

    }
    public int Compare(string? x,string? y)
    {
        
        if (x == null && y != null)
        return -1;
        if (x == null && y == null)
        {
            return 0;
        }
        if (x != null && y ==null)
         return 1;

        else if (x!=null && y!= null)
        {
            if (x.Length != y.Length)
            {
                return x.Length.CompareTo(y.Length);
            }
            else 
            {
                return x.CompareTo(y);
            }
        }
        return 10;


    }

   

}


// public Q8ComparableString:IComparer
// {
//     public static bool operator==(Q8StringLengthComparer a,Q8StringLengthComparer b)
//     {
//         return a.Compare(a,b) == 0
//     }
//     public static bool operator != (Q8StringLengthComparer a,Q8StringLengthComparer b)
//     {
//         return a.Compare(a,b)!=0;
//     }

//     public static bool operator > (Q8StringLengthComparer a,Q8StringLengthComparer b)
//     {
//         return a.Compare(a,b)>0;
//     }

//     public static bool operator < (Q8StringLengthComparer a,Q8StringLengthComparer b)
//     {
//         return a.Compare(a,b)<0;
//     }



// }