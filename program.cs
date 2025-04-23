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



class Q2MultiplyAndReset
{

    public int S1 {get;set;}
    public int S2 {get;set;}


    public Q2MultiplyAndReset(ref int s1, ref int s2)
    {
        S1 = s1 *s2;
        s1 = S1;
        S2 = 1;
        s2 = 1;

    }
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









// public class Q8ComparableString:IComparer<Q8ComparableString>
// {
//     public string Reshte{get;set;}
//     public Q8ComparableString(string x)
//     {
//         this.Reshte = x;
//     }
//     public static bool  operator ==(Q8ComparableString  a , Q8ComparableString b)
//     {
//         if ((a == null) &&   (b ==null))
//         {
//             return true;
//         }
//          if ((a!=null) && (b ==null))
//         {
//             return false;
//         }
//          if ((a==null) &&( b !=null))
//         {
//             return false;
//         }
        
        
//         if (a.Reshte.CompareTo(b.Reshte)==0)
//             {
//                 return true;
//             }
 
//         return false;
//     }
//     public static bool operator !=(Q8ComparableString a,Q8ComparableString b)
//     {
//         if ((a == null) &&   (b ==null))
//         {
//             return false;
//         }
//          if ((a!=null) && (b ==null))
//         {
//             return true;
//         }
//          if ((a==null) && (b !=null))
//         {
//             return true;
//         }
//        if (a!=null && b!= null)
//        {
//         return a.Reshte.CompareTo(b.Reshte)!=0;
//        }
//         return false;
//     }
//     public static bool operator <(Q8ComparableString  a,Q8ComparableString b)
//     {

//         if (a == null )
//         {
//             return true;
//         }
//         if (a!=null && b== null)
//         {
//             return false;
//         }
//         else 
//         {
//             return a.Reshte.CompareTo(b.Reshte)>0;
//         }
//     }
//     public static bool operator >(Q8ComparableString a,Q8ComparableString b)
//     {
//         if (a == null )
//         {
//             return false;
//         }
//          if (a!=null && b== null)
//         {
//             return true;
//         }
//         else 
//         {
//             return a.Reshte.CompareTo(b.Reshte)>0;
//         }
//     }
//     public int Compare(Q8ComparableString? a,Q8ComparableString ? b)
//     {
//         if (a!=null && b!= null)
//         {
//             return a.Reshte.CompareTo(b.Reshte);
//         }
//         return -1;
//     }
// }