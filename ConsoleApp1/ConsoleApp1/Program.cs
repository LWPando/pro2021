using System;
class TowerOfHanoi
{
    int m_numdiscs;
    public TowerOfHanoi()
    {
        numdiscs = 0;
    }
    public TowerOfHanoi(int newval)
    {
        numdiscs = newval;
    }
    public int numdiscs
    {
        get
        {
            return m_numdiscs;
        }
        set
        {
            if (value > 0)
                m_numdiscs = value;
        }
    }
    public void movetower(int n, int from, int to, int other)
    {
        if (n > 0)
        {
            movetower(n - 1, from, other, to);
            Console.WriteLine("Premakni {0} iz {1} na {2}",
                               n, from, to);
            movetower(n - 1, other, to, from);
        }
    }
}
class TowersOfHanoiApp
{
    public static int Main()
    {
        TowerOfHanoi T = new TowerOfHanoi();
        string cnumdiscs;
        Console.Write("Vnesi stevilo obrocev: ");
        cnumdiscs = Console.ReadLine();
        T.numdiscs = Convert.ToInt32(cnumdiscs);
        T.movetower(T.numdiscs, 1, 3, 2);
        Console.ReadLine();
        return 0;
    }
}

