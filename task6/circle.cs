
 class circle{
    private double Radius;  
    private double p;
    
    private double d;

    public double GetArea()
   {
    Radius =15;
    p = 3.14;
      return Radius*p;
      
   }
   public double GetDiameter(){
     Radius =15;
   
    return 2*Radius;
   }
   public double GetCircumference()
   {
     Radius =15;
     p = 3.14;
     return p*Radius*Radius;

   }
   public double GetRadius(){

        Radius =15;
         d = 30;
     return d/Radius;

   }
 }
