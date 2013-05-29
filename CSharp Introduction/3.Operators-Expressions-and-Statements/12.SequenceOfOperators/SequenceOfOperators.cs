using System;

class SequenceOfOperators
{
    static void Main()
    {
        int n = 23;
        int p = 4;
        int mask1=1>>p;
        int mask2=0>>p;
        int mask3=~(1>>p);
        int mask4=~(0>>p);

        int nAndMask1= n&mask1;
        int nAndMask2 =n&mask2;
        int nAndMask3=n&mask3;
        int nAndMask4=n&mask4;

        int result1 = nAndMask1 << p;
        int result2 = nAndMask2 << p;
        int result3 = nAndMask3 << p;
        int result4 = nAndMask4 << p;

        Console.WriteLine("{0}\n{1}\n{2}\n{3}",result1,result2,result3,result4);

        int nOrMask1 = n | mask1;
        int nOrMask2 = n | mask2;

        int result5 = nOrMask1 << p;

 
        Console.WriteLine("{0}",result5);



        
        
       

    }
}

