class program {
    static void Main(string[] args){
        Console.Write("V max : ");
        double vMax = double.Parse(Console.ReadLine());
        Console.Write("V drink : ");
        double vdrink = double.Parse(Console.ReadLine());
        Console.Write("V fill : ");
        double vfill = double.Parse(Console.ReadLine());

        Console.Write("T drink : ");
        double tdrink = double.Parse(Console.ReadLine());
        Console.Write("T fill : ");
        double tfill = double.Parse(Console.ReadLine());
        Console.Write("T day : ");
        double tday = double.Parse(Console.ReadLine());



        if(vdrink <= vMax){
            if(tday>= tdrink && tday >= tfill){
                
                double a = (double)(tday/tdrink) ;
                double b = (double)(vMax- vdrink);
                double c = (double)(vMax-((b+vfill)-vdrink));
                int fill = (int)(tday/tfill);
                if(vMax >= a && b > 0){
                    Console.WriteLine("Enough Water, {0} left" , c);
                } else if(b - vdrink < 0) {
                    Console.WriteLine("Not Enough Water");
                }
                if(c > 0){
                    Console.WriteLine("Overflow Water");
                }
            }
        }
    }
}
